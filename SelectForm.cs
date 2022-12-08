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
    public partial class SelectForm : Form
    {
        List<Button> listBtn = new List<Button>();
        public SelectForm()
        {
            InitializeComponent();
            CustomizeDesign();
            CustomizeDesignManager();

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

        }

        private void CustomizeDesign()
        {
            panelManage.Visible = false;
            panel_Help.Visible = false;
            panel_staff.Visible = false;



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

            panelManage.Controls.Remove(btnStatistics);
            btnStatistics.Dispose();

            panelManage.Height =60*8;

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

        private void changeColorButton(Button button)
        {
            for(int i = 0; i < listBtn.Count; i++)
            {
                if(button == listBtn[i])
                {
                    listBtn[i].BackColor = Color.Silver;
                }
                else
                {
                    listBtn[i].BackColor = Color.Linen;
                }
            }
        }
        private void SelectForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                label1.Text = "WELCOME: " + Properties.Settings.Default.CurUserName;
            }

        }
        private int image =0;
        private void loadimage()
        {
            //if(image==5)
            //{
            //    image = 0;
            //}
            
            //switch(image)
            //{
            //    case 0:
            //        picBackground.Image = Properties.Resources._0;
            //        break;
            //    case 1:
            //        picBackground.Image = Properties.Resources._1;
            //        break;
            //    case 2:
            //        picBackground.Image = Properties.Resources._2;
            //        break;
            //    case 3:
            //        picBackground.Image = Properties.Resources._3;
            //        break;
            //    case 4:
            //        picBackground.Image = Properties.Resources._4;
            //        break;
            //}

            //image++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadimage();
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Manage
        private void btnTour_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            ManageBanner h = new ManageBanner() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void picBackground_Click(object sender, EventArgs e)
        {

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

        private void panel_Help_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Help);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubmenu();

            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            StaffProfile sp = new StaffProfile() { TopLevel = false, TopMost = true };
            sp.StartPosition = FormStartPosition.CenterParent;

            this.panel4.Controls.Add(sp);
            sp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            AboutUs tour = new AboutUs() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            tour.StartPosition = FormStartPosition.CenterParent;
            tour.Size = new System.Drawing.Size(panel4.Width, panel4.Height);

            this.panel4.Controls.Add(tour);
            tour.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            Tour tour = new Tour() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            tour.Size = new System.Drawing.Size(panel4.Width, panel4.Height);

            this.panel4.Controls.Add(tour);
            tour.Show();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            DangKy dk = new DangKy() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            dk.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(dk);
            dk.Show();

        }

        private void btnEmployyeDatabase_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            NhanVien h = new NhanVien() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);

            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            NhiemVuTrongDoan h = new NhiemVuTrongDoan() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            DoanDuLich h = new DoanDuLich() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            KhachHang h = new KhachHang() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnLoyalCustomer_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            LoyalCustomer h = new LoyalCustomer() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            ReportChart h = new ReportChart() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            ChangePass cp = new ChangePass(this.Nhanvien.ACCOUNT) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            this.panel4.Controls.Add(cp);
            cp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out your account?", "Nofitication", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndataCus_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            //changeColorButton(btndataCus);
            CSDLPhieuDatCho h = new CSDLPhieuDatCho() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None,StartPosition= FormStartPosition.CenterParent,WindowState=FormWindowState.Maximized };
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);

            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnVehicalDatabase_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            //changeColorButton(btnVehicalDatabase);
            PhuongTien h = new PhuongTien() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            //panel1.Visible = false;
            //picBackground.Visible = false;
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnLocationDatabase_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            //changeColorButton(btnLocationDatabase);
            Location h = new Location() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            //panel1.Visible = false;
            //picBackground.Visible = false;
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);

            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void btnHotelDatabase_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Clear();
            //changeColorButton(btnHotelDatabase);
            Hotel h = new Hotel() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, StartPosition = FormStartPosition.CenterParent, WindowState = FormWindowState.Maximized };
            //panel1.Visible = false;
            //picBackground.Visible = false;
            h.Size = new System.Drawing.Size(panel4.Width, panel4.Height);
            this.panel4.Controls.Add(h);
            h.Show();
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Log out the account?", "Nofitication", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                
            }
        }
    }
}
