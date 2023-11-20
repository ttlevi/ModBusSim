using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBusTest
{
    internal class Helpers
    { public static string ByteArrayToString(byte[] byteArray)
        {
            var hexBuilder = new System.Text.StringBuilder(byteArray.Length * 2);
            // Iterate through each byte and append its hexadecimal representation
            foreach (byte b in byteArray)
            {
                hexBuilder.AppendFormat("{0:X2} ", b);
            }
            return hexBuilder.ToString().Trim();
        }
    }
}
