﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class ManageBanner : Form
    {
        string ID_tour = "HKOIJ";

        public TOUR Tour = new TOUR();

        public ManageBanner()
        {
            InitializeComponent();
            ShowAll();
            Clear();
        }


        public ManageBanner(string id_tour)
        {
            InitializeComponent();
            ID_tour = id_tour;
            LoadData();
        }

        public ManageBanner(TOUR tour)
        {
            InitializeComponent();
            this.Tour = tour;
            datepckBegin.Value = DateTime.Now;
            datepckEnd.Value = DateTime.Now;
            LoadDataTour();
        }

        private void LoadDataTour()
        {
            lblTour.Text = this.Tour.ID;
            cbDes.Visible = false;
            tbPrice.Text = Tour.GIA.ToString();


            if (DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == Tour.ID && x.IsDeleted == false).FirstOrDefault() == null)
            {
                return;
            }
            GIAMGIA giamgia = DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == Tour.ID && x.IsDeleted == false).FirstOrDefault();

            txtbxDiscount.Text = giamgia.DISCOUNT.ToString();

            if (giamgia.PICBI != null)
            {
                pcbxBanner.Image = Converter.Instance.ByteArrayToImage(giamgia.PICBI);
                img_data = giamgia.PICBI;
            }

            if (giamgia.NGAYBATDAU == null)
            {
                datepckBegin.Value = DateTime.Now;
            }
            else
            {
                datepckBegin.Value = (DateTime)giamgia.NGAYBATDAU;

            }

            if (giamgia.NGAYKETTHUC == null)
            {
                datepckEnd.Value = DateTime.Now;
            }
            else
            {
                datepckEnd.Value = (DateTime)giamgia.NGAYKETTHUC;

            }


            try
            {
                if (Convert.ToInt32(txtbxDiscount.Text) != 0 || Convert.ToDecimal(tbPrice) != 0)
                {
                    decimal res = 0;
                    double discount = Convert.ToInt64(txtbxDiscount.Text);
                    decimal price = Convert.ToDecimal(tbPrice.Text);
                    res = price - (price * (decimal)(discount / 100));

                    tbTotal.Text = res.ToString();

                }
            }
            catch
            {

                tbTotal.Text = tbPrice.Text;
            }
        }

        private void LoadData()
        {
            lblTour.Text = ID_tour;
            cbDes.Visible = false;

            GIAMGIA giamgia = DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == ID_tour && x.IsDeleted == false && x.NGAYBATDAU >= DateTime.Today).FirstOrDefault();

            if (giamgia == null)
            {
                return;
            }

            txtbxDiscount.Text = giamgia.DISCOUNT.ToString();
            tbPrice.Text = giamgia.TOUR.GIA.ToString();

            if (giamgia.PICBI != null)
            {
                pcbxBanner.Image = Converter.Instance.ByteArrayToImage(giamgia.PICBI);
                img_data = giamgia.PICBI;
            }

            if (giamgia.NGAYBATDAU == null)
            {
                datepckBegin.Value = DateTime.Now;
            }
            else
            {
                datepckBegin.Value = (DateTime)giamgia.NGAYBATDAU;

            }

            if (giamgia.NGAYKETTHUC == null)
            {
                datepckEnd.Value = DateTime.Now;
            }
            else
            {
                datepckEnd.Value = (DateTime)giamgia.NGAYKETTHUC;

            }


            try
            {
                if (Convert.ToInt32(txtbxDiscount.Text) != 0 || Convert.ToDecimal(tbPrice) != 0)
                {
                    decimal res = 0;
                    double discount = Convert.ToInt64(txtbxDiscount.Text);
                    decimal price = Convert.ToDecimal(tbPrice.Text);
                    res = price - (price * (decimal)(discount / 100));

                    tbTotal.Text = res.ToString();

                }
            }
            catch
            {

                tbTotal.Text = tbPrice.Text;
            }
        }

        private void cbDes_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbDes.SelectedIndex;

            if (index >= 0)
            {

                Type t = cbDes.SelectedItem.GetType();
                string idtour = t.GetProperty("IDTOUR").GetValue(cbDes.SelectedItem, null).ToString();
            }
        }

        public void Clear()
        {
            txtbxDiscount.Text = "";
            datepckBegin.Value = DateTime.Now;
            datepckEnd.Value = DateTime.Now;
            pcbxBanner.Image = null;
            img_data = null;

        }

        public void ShowAll()
        {
            cbDes.Refresh();
            cbDes.DataSource = (from tour in DataProvider.Ins.DB.TOURs
                                join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                                where tour.IsDeleted == false && doan.IsDeleted == false

                                select new
                                {
                                    TENTOUR = tour.TEN,
                                    IDTOUR = tour.ID,
                                    GIA = tour.GIA,
                                }
                ).ToList();

            cbDes.ValueMember = "IDTOUR";
            cbDes.DisplayMember = "TENTOUR";//DisplayMember phải trùng trên select new
            cbDes.SelectedIndex = -1;
        }

        private void ManageBanner_Load(object sender, EventArgs e)
        {

        }

        public bool CheckData()
        {
            if (Convert.ToInt64(txtbxDiscount.Text) == 0)
            {
                return false;
            }
            if (datepckBegin.Value.Date > datepckEnd.Value.Date || datepckBegin.Value.Date < DateTime.Now.Date)
            {
                return false;
            }

            return true;
        }

        Image img;
        Byte[] img_data;
        private void pcbxBanner_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                img = image;
                img_data = Converter.Instance.ImageToByte(image);
                pcbxBanner.Image = image;

            }
        }


        public void RemoveCurrentBanner()
        {
            try
            {
                GIAMGIA temp = DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == this.Tour.ID && x.IsDeleted == false && x.NGAYBATDAU >= DateTime.Today).FirstOrDefault();
                temp.NGAYBATDAU = DateTime.Now;
                temp.NGAYKETTHUC = DateTime.Now;
                temp.PICBI = Converter.Instance.ImageToByte(Properties.Resources.ic_image_empty_128);
                temp.DISCOUNT = 0;
                DataProvider.Ins.DB.SaveChanges();

                Clear();
                this.Close();
            }
            catch
            {

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm create banner? ", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                RemoveCurrentBanner();

            }
        }

        private void CreateBanner()
        {
            try
            {
                GIAMGIA temp = DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == this.Tour.ID && x.IsDeleted == false && x.NGAYBATDAU >= DateTime.Today).FirstOrDefault();
                if (temp != null)
                {
                    temp.IsDeleted = true;
                    DataProvider.Ins.DB.SaveChanges();
                }

                string randomecode = Converter.Instance.RandomString2(5);
                GIAMGIA giamgia = new GIAMGIA() { ID = randomecode, IDTOUR = Tour.ID, DISCOUNT = Convert.ToInt32(txtbxDiscount.Text), PICBI =Converter.Instance.ImageToByte(pcbxBanner.Image), NGAYBATDAU = datepckBegin.Value.Date, NGAYKETTHUC = datepckEnd.Value.Date, IsDeleted = false };
                DataProvider.Ins.DB.GIAMGIAs.Add(giamgia);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Add banner succeed");

                Clear();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (MessageBox.Show("Confirm create banner? ", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    CreateBanner();


                }

            }
        }

        private void txtbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbxDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtbxDiscount.Text) != 0 || Convert.ToDecimal(tbPrice) != 0)
                {
                    decimal res = 0;
                    double discount = Convert.ToInt64(txtbxDiscount.Text);
                    decimal price = Convert.ToDecimal(tbPrice.Text);
                    res = price - (price * (decimal)(discount / 100));

                    tbTotal.Text = res.ToString();

                }
            }
            catch
            {

                tbTotal.Text = tbPrice.Text;
            }
        }
    }
}
