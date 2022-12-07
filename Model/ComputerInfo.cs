using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Model
{
    public class ComputerInfo
    {
        private static ComputerInfo instance;

        public static ComputerInfo Instance
        {
            get { if (instance == null) instance = new ComputerInfo(); return ComputerInfo.instance; }
            private set { ComputerInfo.instance = value; }
        }
        private ComputerInfo()
        {

        }


        IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);


        private static string comIP;
        public string ComIP
        {
            get { if (comIP == null) comIP = GetLocalIPAddress(); return ComputerInfo.comIP; }
            private set { ComputerInfo.comIP = value; }
        }

        private static string comName;
        public string ComName
        {
            get { if (comName == null) comName = GetLocalComputerName(); return ComputerInfo.comName; }
            private set { ComputerInfo.comName = value; }
        }

        private static string comPort;
        public string ComPort
        {
            get { if (comPort == null) comPort = GetLocalComputerPort(); return ComputerInfo.comPort; }
            private set { ComputerInfo.comPort = value; }
        }


        public static string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                //throw new Exception("No network adapters with an IPv4 address in the system!");
                return "No network adapters with an IPv4 address in the system!";
            }
            catch
            {
                return "No network adapters with an IPv4 address in the system!";

            }

        }

        public static string GetLocalComputerName()
        {
            string computerName= "No Computer Name found in the system!";

            try
            {
                computerName = Directory.GetCurrentDirectory();
            }
            catch(Exception ex)
            {
                computerName += " There maybe error: " + ex.Message;
            }

            return computerName;

        }

        public static string GetLocalComputerPort()
        {
            string computerPort = "No Computer Port found in the system!";

            try
            {
                computerPort = "9999";
            }
            catch (Exception ex)
            {
                computerPort += " There maybe error: " + ex.Message;
            }

            return computerPort;

        }

    }
}
