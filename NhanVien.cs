using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
        string doanid;
        bool searchID;

        public string seleted_nhanvien_phutrach = "";

        public NhanVien()
        {
            InitializeComponent();
            dgv_nhanvien.AutoGenerateColumns = false;
            searchID = true;
            showAll();
        }

        public NhanVien(string phutrach, string doanid)
        {
            InitializeComponent();
            dgv_nhanvien.AutoGenerateColumns = false;
            this.phutrach = phutrach;
            this.doanid = doanid;
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

        private void Clear()
        {
            txtbxName.Text = txtbxSDT.Text = txtbxMail.Text =txtbxID.Text= "";
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

        public string getID(string ID)
        {
            return ID;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string value = tb_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    //if (rdIDSearch.Checked)
                    if (searchID == true)
                    {
                        dgv_nhanvien.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0 && t.IsDeleted == false).Select(t => t).ToList();

                    }
                    //else if (rdNameSearch.Checked)
                    else if (searchID == false)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    string randomcode = Converter.Instance.RandomString2(5);
                    var nv = new NHANVIEN() { ID = randomcode, TEN = txtbxName.Text, MAIL = txtbxMail.Text, SDT = txtbxSDT.Text, IsDeleted = false, isAvailable = true };
                    DataProvider.Ins.DB.NHANVIENs.Add(nv);

                    DataProvider.Ins.DB.SaveChanges();

                    showAll();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }

                Clear();
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search.Text = "";
            if (guna2ComboBox1.SelectedIndex != -1)
            {
                try
                {
                    if (guna2ComboBox1.SelectedIndex == 0)
                    {
                        searchID = true;
                    }
                    else
                        searchID = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            //dgv_nhanvien1.Rows.Add(4);

            //dgv_nhanvien1.Rows[0].Cells[1].Value = "Vu Quang Huy";
            //dgv_nhanvien1.Rows[0].Cells[2].Value = "0854021017";
            //dgv_nhanvien1.Rows[0].Cells[3].Value = "20521419@gm.uit.edu.vn";
            //dgv_nhanvien1.Rows[0].Cells[4].Value = 0;
            //dgv_nhanvien1.Rows[0].Cells[5].Value = false;

            //dgv_nhanvien1.Rows[1].Cells[1].Value = "Vu Quang Huy 1";
            //dgv_nhanvien1.Rows[1].Cells[2].Value = "0854021017";
            //dgv_nhanvien1.Rows[1].Cells[3].Value = "20521419@gm.uit.edu.vn";
            //dgv_nhanvien1.Rows[1].Cells[4].Value = 0;
            //dgv_nhanvien1.Rows[1].Cells[5].Value = false;

            //dgv_nhanvien1.Rows[2].Cells[1].Value = "Vu Quang Huy 2";
            //dgv_nhanvien1.Rows[2].Cells[2].Value = "0854021017";
            //dgv_nhanvien1.Rows[2].Cells[3].Value = "20521419@gm.uit.edu.vn";
            //dgv_nhanvien1.Rows[2].Cells[4].Value = 0;
            //dgv_nhanvien1.Rows[2].Cells[5].Value = false;

            //dgv_nhanvien1.Rows[2].Cells[1].Value = "Vu Quang Huy 3";
            //dgv_nhanvien1.Rows[2].Cells[2].Value = "0854021017";
            //dgv_nhanvien1.Rows[2].Cells[3].Value = "20521419@gm.uit.edu.vn";
            //dgv_nhanvien1.Rows[2].Cells[4].Value = 0;
            //dgv_nhanvien1.Rows[2].Cells[5].Value = false;
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && e.ColumnIndex.ToString() != "6")
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
            {// nhấn vào isAvailable
                if (e.ColumnIndex.ToString() == "6" && dgv_nhanvien.Rows[index].Cells["isAvailable"].Value.ToString() == "True")
                {
                    id = dgv_nhanvien.Rows[index].Cells["data_employeeid"].Value.ToString();
                    NHANVIEN temp_nv = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == id).FirstOrDefault();

                    DialogResult dr = MessageBox.Show("Do you want to assign this person to that role", "Assign", MessageBoxButtons.OKCancel);
                    switch (dr)
                    {
                        case DialogResult.OK:
                            var nvu = new tb_PHUTRACH() { ID = Converter.Instance.RandomString2(5), IDDOAN = doanid, IDNHANVIEN = temp_nv.ID, PHUTRACH = phutrach, IsDeleted = false };
                            DataProvider.Ins.DB.tb_PHUTRACH.Add(nvu);
                            seleted_nhanvien_phutrach = nvu.NHANVIEN.TEN;
                            temp_nv.isAvailable = false;
                            DataProvider.Ins.DB.SaveChanges();

                            this.Close();
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

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            string value = tb_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    //if (rdIDSearch.Checked)
                    if (searchID == true)
                    {
                        dgv_nhanvien.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0 && t.IsDeleted == false).Select(t => t).ToList();

                    }
                    //else if (rdNameSearch.Checked)
                    else if (searchID == false)
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
    }

}
