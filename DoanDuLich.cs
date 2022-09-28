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
    public partial class DoanDuLich : Form
    {
        public DoanDuLich()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

        }

        private void DoanDuLich_Load(object sender, EventArgs e)
        {
            showAll();
        }

        private void showAll()
        {

            dataGridView1.DataSource= (from doan in DataProvider.Ins.DB.DOANs
             join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
             join chiphi in DataProvider.Ins.DB.CHIPHIs on doan.IDCHIPHI equals chiphi.ID
             select new {
                 ID=doan.ID,
                 TEN=doan.TEN,
                 NGAYKHOIHANH=doan.NGAYKHOIHANH.ToString(),
                 NGAYKETTHUC=doan.NGAYKETTHUC.ToString(),
                 CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                 TONG=chiphi.TONG,
                 TEN_TOUR=tour.TEN 
             }).ToList();
        }
    }
}
