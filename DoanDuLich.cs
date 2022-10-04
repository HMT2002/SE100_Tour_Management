﻿using System;
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
using Tour.Utils;

namespace Tour
{
    public partial class DoanDuLich : Form
    {
        string id;
        string randomcode;

        public DoanDuLich()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

        }

        private void DoanDuLich_Load(object sender, EventArgs e)
        {
            showAll();
            Clear();
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
                 CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                 TONG=chiphi.TONG,
                 TEN_TOUR=tour.TEN 
             }).ToList();
            comboBox1.DataSource = DataProvider.Ins.DB.TOURs.Select(t => t).ToList();
            comboBox1.DisplayMember = "TEN";
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
                dataGridView2.DataSource= (from tb_doan in DataProvider.Ins.DB.tb_DOAN
                                           join khachhang in DataProvider.Ins.DB.KHACHHANGs on tb_doan.IDKHACHHANG equals khachhang.ID
                                           where tb_doan.IDDOAN == id
                                           select new
                                           {
                                               ID = khachhang.ID,
                                               TEN = khachhang.TENKH,
                                           }).ToList();
                
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
        public bool CheckData()
        {
            if (DateTime.Compare(dateTimePicker1.Value,dateTimePicker2.Value)>0)
            {
                return false;
            }

            if (textBox2.Text.Trim().CompareTo(string.Empty) == 0 || comboBox1.Text.Trim().CompareTo(string.Empty) == 0  )
            {
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    randomcode = Converter.Instance.RandomString2(5);
                    var doan = new DOAN() { ID = randomcode, TEN = textBox2.Text, NGAYKHOIHANH = dateTimePicker1.Value, NGAYKETTHUC = dateTimePicker2.Value,IDTOUR= ((TOUR)(comboBox1.SelectedItem)).ID,IDCHIPHI="0" };
                    DataProvider.Ins.DB.DOANs.Add(doan);
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                }
                catch
                {

                }
                Clear();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id==null||id.CompareTo(string.Empty) == 0)
            {
                return;
            }
            try
            {
                DOAN doan = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id).FirstOrDefault();
                DataProvider.Ins.DB.DOANs.Remove(doan);
                DataProvider.Ins.DB.SaveChanges();
                showAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                try
                {
                    var doan = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id).FirstOrDefault();
                    doan.TEN = textBox2.Text;
                    doan.NGAYKHOIHANH = dateTimePicker1.Value;
                    doan.NGAYKETTHUC = dateTimePicker2.Value;
                    doan.IDTOUR = ((TOUR)(comboBox1.SelectedItem)).ID;
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();

                }
                catch
                {

                }
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = comboBox1.Text="";
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}