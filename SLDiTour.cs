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
    public partial class SLDiTour : Form
    {
        public SLDiTour()
        {
            InitializeComponent();
        }

        private void SLDiTour_Load(object sender, EventArgs e)
        {
            showAll();
        }

        private void showAll()
        {
            dataGridView1.DataSource = (from nhanvien in DataProvider.Ins.DB.NHANVIENs
                                        join phutrach in DataProvider.Ins.DB.tb_PHUTRACH on nhanvien.ID equals phutrach.ID
                                        join doan in DataProvider.Ins.DB.DOANs on phutrach.IDDOAN equals doan.ID
                                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                        select new
                                        {
                                            TEN = nhanvien.TEN,
                                            MSNV = nhanvien.ID,
                                            SL_Di_Tour = 1,
                                        }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DanhSachTour dsTour = new DanhSachTour();
        }
    }
}
