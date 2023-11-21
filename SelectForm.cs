﻿using System;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        NHANVIEN Nhanvien = new NHANVIEN();

        public SelectForm(NHANVIEN nhanvien)
        {

            InitializeComponent();
            CustomizeDesign();
            Nhanvien = nhanvien;
            if (nhanvien != null)
            {
                if (nhanvien.ACCOUNT.ACCROLE.CompareTo("Manager") == 0)
                {
                    CustomizeDesignManager();

                }
                else if (nhanvien.ACCOUNT.ACCROLE.CompareTo("Employee") == 0)
                {
                    CustomizeDesignEmployee();

                }

            }
            label1.Text = nhanvien.TEN;

        }

        private void CustomizeDesignManager()
        {



        }

        private void CustomizeDesignEmployee()
        {

            //btndataCus.Visible = false;
            //btnEmployyeDatabase.Visible = false;
            //btnMission.Visible = false;
            //btnStatistics.Visible = false;

            panelManage.Controls.Remove(btndataCus);
            btndataCus.Dispose();
            panelManage.Controls.Remove(btnEmployyeDatabase);
            btnEmployyeDatabase.Dispose();
            panelManage.Height = 60 * 8;

        }


        private void CustomizeDesign()
        {
            panelManage.Visible = false;
            panel_Help.Visible = false;
            panel_staff.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelManage.Visible == true)
                panelManage.Visible = false;
            if (panel_Help.Visible == true)
                panel_Help.Visible = false;
            if (panel_staff.Visible == true)
                panel_staff.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void btnTour_Click(object sender, EventArgs e)
        {
            Route route = new Route();
            this.Hide();
            route.StartPosition = FormStartPosition.CenterParent;
            route.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            this.Hide();
            dk.StartPosition = FormStartPosition.CenterParent;
            dk.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Tour tour = new Tour();
            this.Hide();
            tour.StartPosition = FormStartPosition.CenterParent;
            tour.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                label1.Text = "WELCOME: " + Properties.Settings.Default.UserName;
            }
        }
        private int image =0;
        private void loadimage()
        {
            if(image==5)
            {
                image = 0;
            }
            
            switch(image)
            {
                case 0:
                    picBackground.Image = Properties.Resources._0;
                    break;
                case 1:
                    picBackground.Image = Properties.Resources._1;
                    break;
                case 2:
                    picBackground.Image = Properties.Resources._2;
                    break;
                case 3:
                    picBackground.Image = Properties.Resources._3;
                    break;
                case 4:
                    picBackground.Image = Properties.Resources._4;
                    break;
            }

            image++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadimage();
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            showSubmenu(panelManage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_staff);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Help);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffProfile sp = new StaffProfile();
            this.Hide();
            sp.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            this.Hide();
            cp.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            if (MessageBox.Show("Are you sure to log out your account?", "Nofitication", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out your account?", "Nofitication", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndataCus_Click(object sender, EventArgs e)
        {
            CSDLPhieuDatCho h = new CSDLPhieuDatCho();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void btnLocationDatabase_Click(object sender, EventArgs e)
        {
            Location h = new Location();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void btnHotelDatabase_Click(object sender, EventArgs e)
        {
            Hotel h = new Hotel();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void btnVehicalDatabase_Click(object sender, EventArgs e)
        {
            PhuongTien h = new PhuongTien();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void btnEmployyeDatabase_Click(object sender, EventArgs e)
        {
            NhanVien h = new NhanVien();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NhiemVuTrongDoan h = new NhiemVuTrongDoan();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoanDuLich h = new DoanDuLich();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KhachHang h = new KhachHang();
            this.Hide();
            h.ShowDialog();
            this.Show();
            hideSubmenu();
        }
    }
}
