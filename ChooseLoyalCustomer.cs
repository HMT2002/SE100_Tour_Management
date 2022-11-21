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
    public partial class ChooseLoyalCustomer : Form
    {
        public KHACHHANG ChosedKhachHang = null;


        public ChooseLoyalCustomer()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            guna2DataGridView1.DataSource = DataProvider.Ins.DB.KHACHHANGs.Where(x => x.IsDeleted == false && x.IsVIP == true).ToList();
        }

        string id = "";

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = guna2DataGridView1.Rows[index].Cells["ID"].Value.ToString();

                ChosedKhachHang= DataProvider.Ins.DB.KHACHHANGs.Where(x => x.ID == id && x.IsDeleted == false).FirstOrDefault();

                VIPCategory();

                this.Close();
            }
        }

        private void VIPCategory()
        {
            if (ChosedKhachHang.SPENDING >= 15000000)
            {
                ChosedKhachHang.PRI = "SILVER";
            }
            if (ChosedKhachHang.SPENDING >= 30000000)
            {
                ChosedKhachHang.PRI = "GOLD";
            }
            if (ChosedKhachHang.SPENDING >= 50000000)
            {
                ChosedKhachHang.PRI = "PLATINUM";
            }
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
