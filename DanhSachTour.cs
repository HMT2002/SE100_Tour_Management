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
    public partial class DanhSachTour : Form
    {
        public DanhSachTour()
        {
            InitializeComponent();
        }

        private void DanhSachTour_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = (from nhanvien in DataProvider.Ins.DB.NHANVIENs
                                        join phutrach in DataProvider.Ins.DB.tb_PHUTRACH on nhanvien.ID equals phutrach.ID
                                        join doan in DataProvider.Ins.DB.DOANs on phutrach.IDDOAN equals doan.ID
                                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                        select new
                                        {
                                            IDTOUR = tour.ID,
                                            TENTOUR = tour.TEN,
                                            TENDOAN = doan.TEN,
                                        }).ToList();
        }
    }
}
