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

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.ShadowDecoration.Depth = 50;
            textBox1.ShadowDecoration.Shadow.Horizontal.Equals(8);
            textBox1.ShadowDecoration.Shadow.Vertical.Equals(8);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.ShadowDecoration.Depth = 15;
            textBox1.ShadowDecoration.Shadow.Horizontal.Equals(3);
            textBox1.ShadowDecoration.Shadow.Vertical.Equals(3);
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

        private void txtDriver_MouseHover(object sender, EventArgs e)
        {
            txtDriver.ShadowDecoration.Depth = 35;
            txtDriver.ShadowDecoration.Shadow.Horizontal.Equals(8);
            txtDriver.ShadowDecoration.Shadow.Vertical.Equals(8);
        }

        private void txtDriver_MouseLeave(object sender, EventArgs e)
        {
            txtDriver.ShadowDecoration.Depth = 15;
            txtDriver.ShadowDecoration.Shadow.Horizontal.Equals(3);
            txtDriver.ShadowDecoration.Shadow.Vertical.Equals(3);
        }

        private void txtTourGuide_MouseHover(object sender, EventArgs e)
        {
            txtTourGuide.ShadowDecoration.Depth = 35;
            txtTourGuide.ShadowDecoration.Shadow.Horizontal.Equals(8);
            txtTourGuide.ShadowDecoration.Shadow.Vertical.Equals(8);
        }

        private void txtTourGuide_MouseLeave(object sender, EventArgs e)
        {
            txtTourGuide.ShadowDecoration.Depth = 15;
            txtTourGuide.ShadowDecoration.Shadow.Horizontal.Equals(3);
            txtTourGuide.ShadowDecoration.Shadow.Vertical.Equals(3);
        }

        private void txtWaitor_MouseHover(object sender, EventArgs e)
        {
            txtWaitor.ShadowDecoration.Depth = 35;
            txtWaitor.ShadowDecoration.Shadow.Horizontal.Equals(8);
            txtWaitor.ShadowDecoration.Shadow.Vertical.Equals(8);
        }

        private void txtWaitor_MouseLeave(object sender, EventArgs e)
        {
            txtWaitor.ShadowDecoration.Depth = 15;
            txtWaitor.ShadowDecoration.Shadow.Horizontal.Equals(3);
            txtWaitor.ShadowDecoration.Shadow.Vertical.Equals(3);
        }

        private void txtTranslator_MouseHover(object sender, EventArgs e)
        {
            txtTranslator.ShadowDecoration.Depth =35;
            txtTranslator.ShadowDecoration.Shadow.Horizontal.Equals(8);
            txtTranslator.ShadowDecoration.Shadow.Vertical.Equals(8);
        }

        private void txtTranslator_MouseLeave(object sender, EventArgs e)
        {
            txtTranslator.ShadowDecoration.Depth = 15;
            txtTranslator.ShadowDecoration.Shadow.Horizontal.Equals(3);
            txtTranslator.ShadowDecoration.Shadow.Vertical.Equals(3);
        }

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

        private void bttExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You have to save your assignment. Do you really want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
