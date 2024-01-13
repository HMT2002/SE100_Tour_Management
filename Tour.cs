﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Tour.Model;
using Tour.Utils;
using System.Data.Entity.SqlServer;
using Tour.CollectionLists;

namespace Tour
{
    public partial class Tour : Form
    {
        string id;
        string randomcode;
        TOUR selected_tour = new TOUR();

        List<DIADIEM> LocationList = new List<DIADIEM>();

        public Tour()
        {
            InitializeComponent();
            this.tb_search.Leave += new System.EventHandler(this.textBox1_Leave);
            this.tb_search.Enter += new System.EventHandler(this.textBox1_Enter);
            dgv_trip.AutoGenerateColumns = false;
        }

        private void AddDataBinding()
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }
        public void ShowAllChuyen()
        {
            DALTourCollection tourCollection=new DALTourCollection();
            dgv_trip.DataSource = tourCollection.AllTourList();



        }
        private void TRIPManageTour_Load(object sender, EventArgs e)
        {
            ShowAllChuyen();

        }

        public string price = null, typetour = null, nametour = null;

        public bool CheckData()
        {

                this.price = tb_price.Text;
                this.typetour = cb_typetour.Text;
                this.nametour = tb_nametour.Text;

            if (this.price.Trim().CompareTo(string.Empty) == 0|| this.typetour.Trim().CompareTo(string.Empty) == 0 || this.nametour.Trim().CompareTo(string.Empty) == 0)
            {
                return false;
            }
            return true;
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (selected_tour == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                UpdateTour();

            }
        }
        public void UpdateTour()
        {
            try
            {
                //MessageBox.Show(Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tb_price.Text).ToString());
                //return;

                var tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == id).FirstOrDefault();
                tour.TEN = tb_nametour.Text;
                tour.LOAI = cb_typetour.Text;
                tour.GIA = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tb_price.Text);
                tour.DACDIEM = "";
                DataProvider.Ins.DB.SaveChanges();
                ShowAllChuyen();
                Clear();

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
        public void Clear()
        {
            cb_typetour.SelectedIndex = -1;

            cb_typetour.Text = "";
            cb_typetour.SelectedText = "";

            tb_nametour.Text = "";
            tb_price.Text = "";
            int id_num = 1;
            id = "TR" + id_num;

            while (DataProvider.Ins.DB.TOURs.Where(x => x.ID == id).FirstOrDefault() != null)
            {
                id_num++;
                id = "TR" + id_num.ToString();
            }

            tb_idtrip.Text = id;
            lstbxLocation.DataSource = null;
            LocationList = new List<DIADIEM>();


            //this.price = this.typetour = this.nametour = null;

            this.selected_tour = null;


            UnnotifyAllFields();

        }

        public void UnnotifyAllFields()
        {
            Notify.Unnotification(tb_price);
            Notify.Unnotification(tb_nametour);
            Notify.Unnotification(cb_typetour);
        }


        public void AddNewTour()
        {
            try
            {
                //randomcode = Converter.Instance.RandomString2(5);

                var tour = new TOUR() { ID = tb_idtrip.Text, GIA = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tb_price.Text), TEN = tb_nametour.Text, LOAI = cb_typetour.Text, DACDIEM = "", IsDeleted = false };
                DataProvider.Ins.DB.TOURs.Add(tour);
                string randomecode = Converter.Instance.RandomString2(5);
                GIAMGIA giamgia = new GIAMGIA() { ID = randomecode, IDTOUR = tb_idtrip.Text, DISCOUNT = 0, PICBI = Converter.Instance.ImageToByte(Properties.Resources.ic_image_empty_128), NGAYBATDAU = DateTime.Today, NGAYKETTHUC = DateTime.Today, IsDeleted = false };
                DataProvider.Ins.DB.GIAMGIAs.Add(giamgia);
                DataProvider.Ins.DB.SaveChanges();
                ShowAllChuyen();
                Clear();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (CheckData() == true)
            {
                AddNewTour();

            }
        }



        public void DeleteTour()
        {
            try
            {
                TOUR tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == id && x.IsDeleted == false).FirstOrDefault();
                DataProvider.Ins.DB.GIAMGIAs.Remove(DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == tour.ID).FirstOrDefault());
                DataProvider.Ins.DB.tb_DIADIEM_DULICH.RemoveRange(DataProvider.Ins.DB.tb_DIADIEM_DULICH.Where(x => x.IDTOUR == tour.ID));
                DataProvider.Ins.DB.TOURs.Remove(tour);

                DataProvider.Ins.DB.SaveChanges();
                ShowAllChuyen();
                Clear();

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                DeleteTour();
            }
        }
        public string TourID, TourName, TourCode, TypeofTour, Transport, RouteID;
        public int Hour, Minute, Year, Month, Day, Tickets, Price;


        public void EnableFields()
        {
            tb_idtrip.Text = selected_tour.ID;
            tb_nametour.Text = selected_tour.TEN;
            tb_price.Text = selected_tour.GIA.ToString();
            cb_typetour.Text = selected_tour.LOAI;

        }

        public void EnableBanner()
        {

        }

        public void EnableLocationsSource()
        {
            LocationList = new List<DIADIEM>();
            var listDIADIEM = (from dd in DataProvider.Ins.DB.DIADIEMs
                               join tb_belong in DataProvider.Ins.DB.tb_DIADIEM_DULICH on dd.ID equals tb_belong.IDDIADIEM
                               where tb_belong.IDTOUR == selected_tour.ID && tb_belong.IsDeleted == false
                               select dd)
                                 .ToList();
            foreach (var item in listDIADIEM)
            {
                LocationList.Add(item);
            }
            lstbxLocation.DataSource = LocationList;
            lstbxLocation.DisplayMember = "TEN";
        }

        public void OpenBannerForm()
        {

        }

        private void dgv_trip_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = dgv_trip.Rows[index].Cells["data_ID"].Value.ToString();

                selected_tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == id && x.IsDeleted == false).FirstOrDefault();

                EnableFields();

                EnableLocationsSource();

                EnableBanner();

                if (dgv_trip.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    OpenBannerForm();
                }

            }
        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {

            Utils.Validate.EnterNumberOnly(sender,e);
            Utils.Notify.Unnotification(sender);
        }

        private void tb_nametour_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.Unnotification(sender);

        }

        private void cb_typetour_Enter(object sender, EventArgs e)
        {
            Notify.Unnotification(sender);

        }
        private void rdIDSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void rdNameSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            string value = tb_search.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    DALTourCollection tourCollection = new DALTourCollection();
                    if (rdIDSearch.Checked)
                    {

                        dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t => (SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0)).Select(t => t).ToList();

                    }
                    else if(rdNameSearch.Checked)
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t =>( SqlFunctions.PatIndex("%" + value + "%", t.TEN) > 0)).Select(t => t).ToList();

                    }
                }
                catch
                {

                }
            }
            else { ShowAllChuyen(); }
        }

        private void backtoroutebtn_Click(object sender, EventArgs e)
        {
            Route r = new Route();
            this.Hide();
            r.ShowDialog();
        }

        private void gotoregistbtn_Click(object sender, EventArgs e)
        {
            DangKy d = new DangKy();
            this.Hide();
            d.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

            Utils.Validate.EnterNumberOnly(sender, e);

        }

        private void btn_newid_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (this.selected_tour == null)
            {
                return;
            }
            using (AddLocationForTour h = new AddLocationForTour(id))
            {
                Clear();
                this.Hide();
                h.ShowDialog();
                this.Show();

            }
            ShowAllChuyen();
            //AddLocationForTour h = new AddLocationForTour(id);
            //Clear();
            //this.Hide();
            //h.ShowDialog();
            //this.Show();

        }



        private void tb_idtrip_Enter(object sender, EventArgs e)
        {
        }

        private void tb_price_Enter(object sender, EventArgs e)
        {
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
