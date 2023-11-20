using EasyModBus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EasyModBus.TCPHandler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ModBusSim.Controls;
using ModBusSim;

namespace ModBusTest.EasyModBus
{
    public class ModbusServerCluster
    {
        public delegate void DebugMessageEventHandler(object sender, string message);
        public event DebugMessageEventHandler DebugMessage;

        public List<ModbusServer> Servers { get; set; } = new List<ModbusServer>();

        private IPAddress ipAddressIn;
        private IPEndPoint iPEndPoint;
        private TCPHandler tcpHandler;
        Thread listenerThread;
        object lockProcessReceivedData = new object(); //Lock object

        private IPAddress localIPAddress = IPAddress.Any;

        /// <summary>
        /// When creating a TCP or UDP socket, the local IP address to attach to.
        /// </summary>
        public IPAddress LocalIPAddress
        {
            get { return localIPAddress; }
            set { if (listenerThread == null) localIPAddress = value; }
        }

        Int32 port = 502;

        public int Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }


        public ModbusServerCluster()
        {
            Servers = new List<ModbusServer>();
        }

        public ModbusServer Add(int id)
        {
            ModbusServer modbusServer = new ModbusServer();
            modbusServer.UnitIdentifier = (byte)id;
            modbusServer.directFlag = true;

            //Ellenőrizzük, hogy van-e már ilyen
            if (Servers.Where(s => s.UnitIdentifier == id).Count() > 0) {
                MessageBox.Show("This Unit ID is already in use. Values that you change will be changed on all the devices with the same ID.","Warning");
                return null;
            };

            //Betesszük a listába
            Servers.Add(modbusServer);

            //Tesztelési céllal feliratkozunk az eseményeire
            modbusServer.HoldingRegistersChanged += (register, numberOfRegisters) =>
            {
                if (DebugMessage != null)
                {
                    for (int j = 0; j < numberOfRegisters; j++)
                    {
                        DebugMessage(modbusServer, $"Unit ID #{modbusServer.UnitIdentifier} Holding register #{register + j} set to {modbusServer.holdingRegisters[register + j]}");
                    }
                }
            };

            modbusServer.CoilsChanged += (register, numberOfRegisters) =>
            {
                if (DebugMessage != null)
                {
                    for (int j = 0; j < numberOfRegisters; j++)
                    {
                        DebugMessage(modbusServer, $"Unit ID #{modbusServer.UnitIdentifier} Coil #{register + j} set to {modbusServer.coils[register + j]}");
                    }
                }
            };

            modbusServer.ModbusDirectReply += (sender, byteArray, transctionID, stream) =>
            {

                //ToDo: hanle concurrency
                stream.Write(byteArray, 0, byteArray.Length);

                if (DebugMessage != null)
                {
                    DebugMessage(this, $"<<<:{Helpers.ByteArrayToString(byteArray)} from Unit ID #{modbusServer.UnitIdentifier}");
                }
            };

            return modbusServer;
        }

        public void Remove(int id)
        {
            foreach (ModbusServer server in Servers)
            {
                if (server.UnitIdentifier == id) { Servers.Remove(server); break; }
            }
        }

        public void Listen()
        {

            listenerThread = new Thread(ListenerThread);
            listenerThread.Start();
        }

        public void StopListening()
        {

            try
            {
                tcpHandler.Disconnect();
                listenerThread.Abort();

            }
            catch (Exception) { }
            listenerThread.Join();
            try
            {

            }
            catch (Exception) { }
        }

        private void ListenerThread()
        {

            tcpHandler = new TCPHandler(LocalIPAddress, port);
            if (DebugMessage != null)
            {
                DebugMessage(this, $"EasyModbus Server listing for incomming data at Port {port}, local IP {LocalIPAddress}");
            }
            tcpHandler.dataChanged += new TCPHandler.DataChanged(ProcessReceivedData);
            //cpHandler.numberOfClientsChanged += new TCPHandler.NumberOfClientsChanged(numberOfClientsChanged);
        }

        private void ProcessReceivedData(object networkConnectionParameter)
        {
            lock (lockProcessReceivedData)
            {
                Byte[] bytes = new byte[((NetworkConnectionParameter)networkConnectionParameter).bytes.Length];
                //if (DebugMessage != null) DebugMessage(this, "Received Data: " + BitConverter.ToString(bytes));
                //NetworkStream stream = ((NetworkConnectionParameter)networkConnectionParameter).stream;
                //int portIn = ((NetworkConnectionParameter)networkConnectionParameter).portIn;
                //IPAddress ipAddressIn = ((NetworkConnectionParameter)networkConnectionParameter).ipAddressIn;


                Array.Copy(((NetworkConnectionParameter)networkConnectionParameter).bytes, 0, bytes, 0, ((NetworkConnectionParameter)networkConnectionParameter).bytes.Length);

                //Hand data over to all servers

                if (DebugMessage != null)
                {
                    DebugMessage(this, $">>>:{Helpers.ByteArrayToString(bytes)}");
                }

                foreach (var server in Servers)
                {
                    server.ProcessModbusFrame(bytes, ((NetworkConnectionParameter)networkConnectionParameter).stream);
                }
            }

        }

    }
}

