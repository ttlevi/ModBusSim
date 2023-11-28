using ModBusSim.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModBusTest.EasyModBus;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace ModBusSim
{
    // This is the main source class of all controls in the project

    [Serializable]
    public partial class Building : Form
    {
        private Log log = new Log();
        private List<Room> Rooms { get; set; } = new List<Room>();
        public ModbusServerCluster Cluster { get; set; }
        public List<int> UnitIDsInUse { get; set; } = new List<int>();
        public Building()
        {
            InitializeComponent();

            SetUpCluster();

            WindowState = FormWindowState.Maximized;
        }

        private void SetUpCluster()
        {
            // This method sets up a new server cluster (one instance in the whole program).
            // A cluster is a list of connected servers (devices) running on the same ip and port.
            // It handles the difference between devices based on the Unit ID field of a modbus message.

            Cluster = new ModbusServerCluster();
            Cluster.Port = 502;
            Cluster.Listen();
            Cluster.DebugMessage += (s, m) =>
            {

                //this.Invoke((MethodInvoker)delegate ()
                //{
                //    log.Data += m + Environment.NewLine;
                //});
            };
        }

        public void RefreshRoomDisplays(Room newroom)
        {
            // Function to create RoomDisplay instances on the Building Form.

            if (!newroom.Exists) { newroom.Exists = true; Rooms.Add(newroom); }
            int nr = 0;
            foreach (RoomDisplay disp in panel1.Controls)
            {
                disp.SetPropOfRoomDisplay(disp.Room);
                disp.Position = nr;
                nr++;
            }
        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Function to create a new Room Form instance.

            Room newroom = new Room();
            RoomDisplay disp = new RoomDisplay();
            disp.Room = newroom;
            disp.Building = this;
            panel1.Controls.Add(disp);
            RefreshRoomDisplays(disp.Room);
            newroom.Building = this;
            newroom.Show(); 
        }

        public void RemoveRoom(Room toremove)
        {
            // Function to remove every visual element related to the given room.
            // It also removes it from the "rooms" list.

            toremove.Close();
            toremove.Dispose();
            Rooms.Remove(toremove);
            foreach (RoomDisplay disp in panel1.Controls)
            {
                if (disp.Room == toremove) { panel1.Controls.Remove(disp); }
                RefreshRoomDisplays(disp.Room);
            }
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Function to show the Log Form.

            log.Show();
            log.Activate();
        }

        private void savePresetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // xml serialize here
            var output = this.ToBuildingSettings();

            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "XML Files|*.xml|All Files|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (sfd.ShowDialog() != DialogResult.OK) { return; }

            StreamWriter sw = new StreamWriter(sfd.FileName);
            string xml = string.Empty;          

            XmlSerializer serializer = new XmlSerializer(typeof(BuildingSettings));

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, output);
                xml = writer.ToString();
            }
            
            sw.Write(xml);
            sw.Close();
        }

        private void loadPresetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cluster.StopListening();
            // xml deserialize here
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "XML Files|*.xml|All Files|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (ofd.ShowDialog() != DialogResult.OK) { return; }

            StreamReader sr = new StreamReader(ofd.FileName);
            string xml = sr.ReadToEnd();

            XmlSerializer serializer = new XmlSerializer(typeof(BuildingSettings));

            using (StringReader r = new StringReader(xml))
            {
                var newBuildingSettings = (BuildingSettings)serializer.Deserialize(r);


                var newBuilding = Building.FromBuildingSettings(newBuildingSettings);
                newBuilding.Show();
            }
            sr.Close();

            

            foreach (Room room in Rooms) {
                RefreshRoomDisplays(room);
            }
        }

        public BuildingSettings ToBuildingSettings()
        {
            BuildingSettings buildingSettings = new BuildingSettings() { };

            buildingSettings.Rooms = new List<RoomSettings>();

            foreach (Room room in Rooms) { buildingSettings.Rooms.Add(room.ToRoomSettings()); }

            return buildingSettings;
        }

        public static Building FromBuildingSettings(BuildingSettings buildingSettings)
        {
            Building building = new Building();

            foreach (RoomSettings room in buildingSettings.Rooms)
            {
                building.Rooms.Add(Room.FromRoomSettings(room));
            }

            return building;
        }
    }

    public class BuildingSettings
    {
        public List<RoomSettings> Rooms { get; set; }
    }
}
