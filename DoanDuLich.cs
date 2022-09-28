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

namespace Tour
{
    public partial class DoanDuLich : Form
    {
        string id;
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
                 NGAYKHOIHANH=doan.NGAYKHOIHANH,
                 NGAYKETTHUC=doan.NGAYKETTHUC,
                 CHITIETCHUONGTRINH = tour.DACDIEM,
                 TONG=chiphi.TONG,
                 TEN_TOUR=tour.TEN 
             }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = dataGridView1.Rows[index].Cells["data_ID"].Value.ToString();
                textBox1.Text = id;

                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[index].Cells["NGAYKHOIHANH"].Value;
                dateTimePicker2.Value = (DateTime)dataGridView1.Rows[index].Cells["NGAYKETTHUC"].Value;

                textBox2.Text= dataGridView1.Rows[index].Cells["TEN"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[index].Cells["CHIPHI"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[index].Cells["TENTOUR"].Value.ToString();
                richTextBox1.Text= dataGridView1.Rows[index].Cells["CHITIETCHUONGTRINH"].Value.ToString();

            }

        }

        private void rdIDSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void rdNameSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string value = tb_search.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    if (rdIDSearch.Checked)
                    {
                        dataGridView1.DataSource = (from doan in DataProvider.Ins.DB.DOANs
                                                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                    join chiphi in DataProvider.Ins.DB.CHIPHIs on doan.IDCHIPHI equals chiphi.ID
                                                    where doan.ID.Contains(value)

                                                    select new
                                                    {
                                                        ID = doan.ID,
                                                        TEN = doan.TEN,
                                                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                                        NGAYKETTHUC = doan.NGAYKETTHUC,
                                                        CHITIETCHUONGTRINH = tour.DACDIEM,
                                                        TONG = chiphi.TONG,
                                                        TEN_TOUR = tour.TEN
                                                    }).ToList();

                    }
                    else if (rdNameSearch.Checked)
                    {
                        dataGridView1.DataSource = (from doan in DataProvider.Ins.DB.DOANs
                                                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                    join chiphi in DataProvider.Ins.DB.CHIPHIs on doan.IDCHIPHI equals chiphi.ID
                                                    where doan.TEN.Contains(value)
                                                    select new
                                                    {
                                                        ID = doan.ID,
                                                        TEN = doan.TEN,
                                                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                                        NGAYKETTHUC = doan.NGAYKETTHUC,
                                                        CHITIETCHUONGTRINH = tour.DACDIEM,
                                                        TONG = chiphi.TONG,
                                                        TEN_TOUR = tour.TEN
                                                    }).ToList();
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
