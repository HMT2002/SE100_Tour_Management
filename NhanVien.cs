using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
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
            dgv_trip.AutoGenerateColumns = false;
            showAll();
        }

        private void showAll()
        {
            dgv_trip.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t=>t.IsDeleted==false).Select(t => new
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
            txtbxName.Text = txtbxSDT.Text = txtbxMail.Text = "";
            img_data = null;
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
            if (MessageBox.Show("Are you sure to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                try
                {
                    ACCOUNT account = DataProvider.Ins.DB.ACCOUNTs.Where(x => x.ID == id).FirstOrDefault();
                    account.IsDeleted = true;

                    NHANVIEN nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == id).FirstOrDefault();
                    nhanvien.IsDeleted = true;
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                    Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == null || id.CompareTo(string.Empty) == 0)
            {
                return;
            }
            try
            {
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == id).FirstOrDefault();
                nhanvien.TEN = txtbxName.Text;
                nhanvien.MAIL = txtbxMail.Text;
                nhanvien.SDT = txtbxSDT.Text;
                nhanvien.PICBI = img_data;
                DataProvider.Ins.DB.SaveChanges();
                showAll();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string value = tb_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    if (rdIDSearch.Checked)
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0).Select(t => t).ToList();

                    }
                    else if (rdNameSearch.Checked)
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.TEN) > 0).Select(t => t).ToList();

                    }
                }
                catch
                {

                }
            }
            else { showAll(); }
        }

        private void rdNameSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void rdIDSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }
    }
}
