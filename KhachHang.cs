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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void showAll()
        {
            guna2DataGridView1.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                        where ve.IsDeleted==false
                                        select new
                                        {
                                            TENKH=ve.KHACHHANG.TENKH,
                                            IDKHACH=ve.KHACHHANG.ID,
                                            TENDOAN=ve.DOAN.TEN
                                        }
                                        ).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            showAll();
        }
    }
}
