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
            dataGridView1.DataSource = (from khachhang in DataProvider.Ins.DB.KHACHHANGs
                                        join tb_doan in DataProvider.Ins.DB.tb_DOAN on khachhang.ID equals tb_doan.IDKHACHHANG
                                        join doan in DataProvider.Ins.DB.DOANs on tb_doan.IDDOAN equals doan.ID

                                        select new
                                        {
                                            TENKH=khachhang.TENKH,
                                            IDKHACH=khachhang.ID,
                                            TENDOAN=doan.TEN
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
