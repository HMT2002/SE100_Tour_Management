using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class StaffProfile : Form
    {

        public StaffProfile()
        {
            InitializeComponent();
        }

        private void StaffProfile_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.CurUserId != string.Empty)
            {
                NHANVIEN nv = DataProvider.Ins.DB.NHANVIENs.Where(x => x.MAIL == Properties.Settings.Default.CurUserId && x.IsDeleted == false).FirstOrDefault();
                txbGmail.Text = nv.MAIL;
                txbTen.Text = nv.TEN;
                txbSDT.Text = nv.SDT;
                txtbxID.Text=nv.ID;
                pcbxAvatar.Image = Converter.Instance.ByteArrayToImage(nv.PICBI);
            }

            //MessageBox.Show(Properties.Settings.Default.UserName + " "  )

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPickPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                Image img = image;
                byte[] img_data = Converter.Instance.ImageToByte(image);
                pcbxAvatar.Image = image;


                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();
                nhanvien.PICBI = img_data;
                DataProvider.Ins.DB.SaveChanges();
            }
        }
    }
}
