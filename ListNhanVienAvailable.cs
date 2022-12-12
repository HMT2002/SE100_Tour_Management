using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class ListNhanVienAvailable : Form
    {

        string phutrach;
        string doanid;
        public string seleted_nhanvien_phutrach = "";
        public string id;

        public ListNhanVienAvailable()
        {
            InitializeComponent();
        }

        public ListNhanVienAvailable(string phutrach, string doanid)
        {
            InitializeComponent();
            dgv_nhanvien.AutoGenerateColumns = false;
            this.phutrach = phutrach;
            this.doanid = doanid;
            showAll();
        }

        private void ListNhanVienAvailable_Load(object sender, EventArgs e)
        {
        }
        private void showAll()
        {
            dgv_nhanvien.DataSource = DataProvider.Ins.DB.NHANVIENs.Where(t => t.IsDeleted == false && t.isAvailable == true).Select(t => new
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

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (e.ColumnIndex == 5 && dgv_nhanvien.Rows[index].Cells["isAvailable"].Value.ToString() == "True")
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

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
