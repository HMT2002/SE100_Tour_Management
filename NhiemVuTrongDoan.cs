using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;

namespace Tour
{
    public partial class NhiemVuTrongDoan : Form
    {
        private string doanID;
        //test
        private string driver;
        //
        private string tour_guide;
        private string waiter;
        private string translator;
        public NhiemVuTrongDoan()
        {
            InitializeComponent();
        }

        public NhiemVuTrongDoan(string s)
        { 
            driver = s;
            InitializeComponent();
        }

        public NhiemVuTrongDoan(string doanID, string driver, string tour_guide, string waiter, string translator)
        {
            this.doanID = doanID;
            this.driver = driver;
            this.tour_guide = tour_guide;
            this.waiter = waiter;
            this.translator = translator;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showAll()
        {
            NhiemVuTrongDoan nv= new NhiemVuTrongDoan();

        }
        public void setTextBox(string s, bool flag)
        {
            //dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t => t.IsDeleted == false).ToList();

            //lstbxLocation.DataSource = LocationList;
            //lstbxLocation.DisplayMember = "TEN";

            //DoanID = s;
            //textBox1.Text = DoanID;
            //var query = DataProvider.Ins.DB.tb_PHUTRACH
            //                .Where(t => t.ID == DoanID)
            //                .FirstOrDefault();
            //if (query == null) return;
            //textBox1.Text = query.IDDOAN;
            //txtDriver.Text = query.IDNHANVIEN;
            //if (DoanID == "" && flag == false)
            //{
            //    DoanID = s;
            //    textBox1.Text = DoanID;
            //}
            doanID = s;
            textBox1.Text = doanID;
            if (driver != null)
            {
                txtDriver.Text = driver;
                txtTourGuide.Text = tour_guide;
                txtTranslator.Text = translator;
                txtWaitor.Text = waiter;
            }
        }

        private void bttAssign_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to complete the assignment?", "Assign", MessageBoxButtons.OKCancel);
            switch(dr)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    this.Close();
                    break;
                default: break;
            }
        }
        // nhấn vô txtDriver
        private void txtDriver_MouseClick(object sender, MouseEventArgs e)
        {
            ;
            using (NhanVien nv = new NhanVien("Driver", doanID))
            {
                this.Hide();
                nv.ShowDialog();
                txtDriver.Text = nv.seleted_nhanvien_phutrach;
                this.Show();

            }
        }

    }
}
