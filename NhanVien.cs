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
        string phutrach;

        public NhanVien()
        {
            InitializeComponent();
            dgv_nhanvien.AutoGenerateColumns = false;
            showAll();
        }

        public NhanVien(string phutrach)
        {
            InitializeComponent();
            dgv_nhanvien.AutoGenerateColumns = false;
            this.phutrach = phutrach;
            showAll();
        }

        private void showAll()
        {
            dgv_nhanvien.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t=>t.IsDeleted==false).Select(t => new
            {
                t.ID,
                t.TEN,
                t.SDT,
                t.MAIL,
                t.isAvailable,
                t.PICBI,
                t.SLDI,
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

        public string getID(string ID)
        {
            return ID;
        }

        private void dgv_trip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && e.ColumnIndex.ToString() != "5")
            {
                id = dgv_nhanvien.Rows[index].Cells["data_employeeid"].Value.ToString();
                NHANVIEN temp = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == id).FirstOrDefault();
                pcbxAvatar.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);

                txtbxID.Text = temp.ID;
                txtbxName.Text = temp.TEN;
                txtbxMail.Text = temp.MAIL;
                txtbxSDT.Text = temp.SDT;
            }
            else
            {
                if (e.ColumnIndex.ToString()== "5" && dgv_nhanvien.Rows[index].Cells["isAvailable"].Value.ToString() == "1")
                {
                    DialogResult dr =  MessageBox.Show("Do you want to assign this person to that role", "Assign", MessageBoxButtons.OKCancel);
                    switch(dr)
                    {
                        case DialogResult.OK:
                            tb_PHUTRACH nv = new tb_PHUTRACH() { ID=Converter.Instance.RandomString2(5),IDDOAN=,IDNHANVIEN= dgv_nhanvien.Rows[index].Cells["data_employeeid"].Value.ToString() ,PHUTRACH=phutrach, IsDeleted=false};
                            NhiemVuTrongDoan nvd = new NhiemVuTrongDoan();
                            nvd.setTextBox(dgv_nhanvien.Rows[index].Cells["ID"].Value.ToString());
                            break;
                        case DialogResult.Cancel:
                            break;
                        default:
                            break;
                            
                    }
                }
                else
                {
                    MessageBox.Show("IsNotAvailable");
                }
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
                        dgv_nhanvien.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0 && t.IsDeleted == false).Select(t => t).ToList();

                    }
                    else if (rdNameSearch.Checked)
                    {
                        dgv_nhanvien.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.TEN) > 0 && t.IsDeleted == false).Select(t => t).ToList();

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
        // chưa tô màu được

        private void dgv_nhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                //if (this.dgv_nhanvien.Columns[e.ColumnIndex].Name == "isAvailable")
                //{
                //    if (e.Value != null)
                //    {
                //        string stringValue = e.Value.ToString();
                //        if (stringValue == '1')
                //        {
                //            e.CellStyle.BackColor = Color.Red;
                //        }
                //    }
                //}
                //foreach(DataGridViewRow row in dgv_nhanvien.Rows)
                //{
                //    if (row.Cells[5].Value.ToString() == "0")
                //    {
                //        row.DefaultCellStyle.BackColor = Color.Red;
                //    }
                //    else if (row.Cells[5].Value.ToString() == "1")
                //    {
                //        row.DefaultCellStyle.BackColor = Color.Green;
                //    }
                //}
            }
            catch(Exception s)
            {
                MessageBox.Show(s.ToString());
            }
        }
    }
}
