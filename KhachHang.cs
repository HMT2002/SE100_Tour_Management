using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;

namespace Tour
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void showAll()
        {
            guna2DataGridView1.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                             join kh in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals kh.ID
                                             where ve.IsDeleted == false && kh.IsDeleted == false
                                             select new
                                             {
                                                 TENKH = kh.TENKH,
                                                 ID = kh.ID,
                                                 DOANDULICH = ve.DOAN.TEN,
                                                 CMND = kh.CMND,
                                                 SDT = kh.SDT,
                                                 DIACHI = kh.DIACHI,
                                                 GIOITINH = kh.GIOITINH,


                                             }
                                        ).Distinct().ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            showAll();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string value = tb_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    //if (rdIDSearch.Checked)
                    if (cbbxSearchType.SelectedItem.ToString() == "ID")
                    {
                        guna2DataGridView1.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                         join kh in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals kh.ID
                                                         where ve.IsDeleted == false && kh.IsDeleted == false
                                                         && SqlFunctions.PatIndex("%" + value + "%", kh.ID) > 0
                                                         select new
                                                         {
                                                             TENKH = kh.TENKH,
                                                             ID = kh.ID,
                                                             DOANDULICH = ve.DOAN.TEN,
                                                             CMND = kh.CMND,
                                                             SDT = kh.SDT,
                                                             DIACHI = kh.DIACHI,
                                                             GIOITINH = kh.GIOITINH,


                                                         }
                                        ).Distinct().ToList();

                    }
                    //else if (rdNameSearch.Checked)
                    else if (cbbxSearchType.SelectedItem.ToString() == "NAME")
                    {
                        guna2DataGridView1.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                         join kh in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals kh.ID
                                                         where ve.IsDeleted == false && kh.IsDeleted == false
                                                         && SqlFunctions.PatIndex("%" + value + "%", kh.TENKH) > 0
                                                         select new
                                                         {
                                                             TENKH = kh.TENKH,
                                                             ID = kh.ID,
                                                             DOANDULICH = ve.DOAN.TEN,
                                                             CMND = kh.CMND,
                                                             SDT = kh.SDT,
                                                             DIACHI = kh.DIACHI,
                                                             GIOITINH = kh.GIOITINH,


                                                         }
                                        ).Distinct().ToList();

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
