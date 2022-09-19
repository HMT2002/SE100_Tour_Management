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
using Tour.Utils;

namespace Tour
{
    public partial class NhanVien : Form
    {

        Image img;
        Byte[] img_data;
        string randomcode;
        string id;


        public NhanVien()
        {
            InitializeComponent();
            showAll();
        }

        private void showAll()
        {
            dgv_trip.DataSource = DataProvider.Ins.DB.NHANVIENs.Select(t => new
            {
                t.ID,
                t.TEN,
                t.SDT,
                t.MAIL,
                t.PICBI,
            }
    ).ToList();

        }

        private void btnExit_Click(object sender, EventArgs e)
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
                img = image;
                img_data = Converter.Instance.ImageToByte(image);
                pcbxAvatar.Image = image;

            }
        }
        private void Clear()
        {
            txtbxName.Text = "";

            pcbxAvatar.Image = null;
        }


        private bool CheckData()
        {
            if (txtbxName.Text.Trim().CompareTo(string.Empty) == 0 || img_data == null )
            {
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_trip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                id = dgv_trip.Rows[index].Cells["data_employeeid"].Value.ToString();
                NHANVIEN temp = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == id).FirstOrDefault();
                pcbxAvatar.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);

                txtbxName.Text = temp.TEN;
                txtbxMail.Text = temp.MAIL;
                txtbxSDT.Text = temp.SDT;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
