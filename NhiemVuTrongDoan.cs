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

        public NhiemVuTrongDoan(string ID_doan)
        {
            doanID = ID_doan;
            InitializeComponent();
            textBox1.Text = doanID;

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

        public void showAll()
        {
            NhiemVuTrongDoan nv= new NhiemVuTrongDoan();

        }
        public void setTextBox(string s, bool flag)
        {
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

        // nhấn vô txtDriver

        private void bttAssign_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to complete the assignment?", "Assign", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    this.Close();
                    break;
                default: break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTourGuide_Click(object sender, EventArgs e)
        {
            using (NhanVien nv = new NhanVien("Tour Guide", doanID))
            {
                this.Hide();
                nv.ShowDialog();
                txtTourGuide.Text = nv.seleted_nhanvien_phutrach;
                this.Show();
            }
        }

        private void txtDriver_Click(object sender, EventArgs e)
        {
            using (NhanVien nv = new NhanVien("Driver", doanID))
            {
                this.Hide();
                nv.ShowDialog();
                txtDriver.Text = nv.seleted_nhanvien_phutrach;
                this.Show();

            }
        }

        private void txtWaitor_Click(object sender, EventArgs e)
        {
            using (NhanVien nv = new NhanVien("Waitor", doanID))
            {
                this.Hide();
                nv.ShowDialog();
                txtWaitor.Text = nv.seleted_nhanvien_phutrach;
                this.Show();

            }
        }

        private void txtTranslator_Click(object sender, EventArgs e)
        {
            using (NhanVien nv = new NhanVien("Translator", doanID))
            {
                this.Hide();
                nv.ShowDialog();
                txtTranslator.Text = nv.seleted_nhanvien_phutrach;
                this.Show();
            }
        }
    }
}
