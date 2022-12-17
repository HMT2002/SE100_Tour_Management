using System;
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
using System.Data.Entity;
using Tour.CrystalReport;
using System.Globalization;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Tour
{
    public partial class Tour : Form
    {
        string id;
        string randomcode;

        TOUR selected_tour = new TOUR();
        List<string> ListTypeTour = new List<string> { "Bussiness", "Vacation", "Cuisine", "Culture" };

        List<DIADIEM> LocationList = new List<DIADIEM>();

        public Tour()
        {
            InitializeComponent();
            dgv_trip.AutoGenerateColumns = false;
            cb_typetour.DataSource = ListTypeTour;
        }

        public void ShowAllChuyen()
        {
            dgv_trip.DataSource = (from tour in DataProvider.Ins.DB.TOURs
                                   join giamgia in DataProvider.Ins.DB.GIAMGIAs on tour.ID equals giamgia.IDTOUR
                                   where tour.IsDeleted == false && giamgia.IsDeleted == false
                                   group tour by new { tour, giamgia } into g
                                   select new
                                   {
                                       ID = g.Key.tour.ID,
                                       TENTOUR = g.Key.tour.TEN,
                                       GIA = g.Key.tour.GIA,
                                       BANNER = g.Key.giamgia.PICBI,
                                       TOURTYPE = g.Key.tour.LOAI,


                                   }).Distinct().ToList(); 

            //lstbxLocation.DataSource = LocationList;
            //lstbxLocation.DisplayMember = "TEN";

        }

        private void CheckBannerAndRemove()
        {
            var banners = (from banner in DataProvider.Ins.DB.GIAMGIAs select banner).ToList();
            foreach (var banner in banners)
            {
                if (banner.NGAYKETTHUC.Value < DateTime.Today)
                {
                    banner.NGAYBATDAU = DateTime.Today;
                    banner.NGAYKETTHUC = DateTime.Today;
                    banner.DISCOUNT = 0;
                    banner.PICBI = Utils.Converter.Instance.ImageToByte(Properties.Resources.ic_image_empty_128);
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
        }

        private void TRIPManageTour_Load(object sender, EventArgs e)
        {
            CheckBannerAndRemove();
            ShowAllChuyen();
            Clear();

        }

        public string price = null, typetour = null, nametour = null;

        public bool CheckData()
        {
            bool flag = true;

            if (tb_nametour.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tb_nametour);
                flag = false;
            }
            if (tb_price.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tb_price);
                flag = false;
            }
            if (cb_typetour.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationSelect(cb_typetour);
                flag = false;
            }

            return flag;
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

            id = Converter.Instance.RandomString2(5);
            tb_idtrip.Text = id;
            lstbxLocation.DataSource = null;
            LocationList = new List<DIADIEM>();


            //this.price = this.typetour = this.nametour = null;

            this.selected_tour = null;


            UnnotifyAllFields();

        }

        public void UnnotifyAllFields()
        {
            Notify.UnnotificationField(tb_price);
            Notify.UnnotificationSelect(tb_nametour);
            Notify.UnnotificationSelect(cb_typetour);



        }

        public void AddNewTour()
        {
            try
            {
                //randomcode = Converter.Instance.RandomString2(5);

                var tour = new TOUR() { ID = tb_idtrip.Text, GIA = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tb_price.Text), TEN = tb_nametour.Text, LOAI = cb_typetour.Text, DACDIEM = "", IsDeleted = false };
                DataProvider.Ins.DB.TOURs.Add(tour);
                string randomecode = Converter.Instance.RandomString2(5);
                GIAMGIA giamgia = new GIAMGIA() { ID = randomecode, IDTOUR = tb_idtrip.Text, DISCOUNT = 0, PICBI =Converter.Instance.ImageToByte(Properties.Resources.ic_image_empty_128), NGAYBATDAU =DateTime.Today, NGAYKETTHUC = DateTime.Today, IsDeleted = false };
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
                TOUR tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == id&&x.IsDeleted==false).FirstOrDefault();
                tour.IsDeleted = true;
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
            using (ManageBanner h = new ManageBanner(selected_tour))
            {
                Clear();
                this.Hide();
                h.ShowDialog();
                this.Show();

            }
            ShowAllChuyen();

        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            if (selected_tour==null)
            {
                return;
            }
            OpenBannerForm();

        }


        private void tb_price_TextChanged(object sender, EventArgs e)
        {

            Utils.Validate.EnterCurrencyVnd(sender);
        }

        private void tb_nametour_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.UnnotificationField(sender);

        }

        private void cb_typetour_Enter(object sender, EventArgs e)
        {
            Notify.UnnotificationSelect(sender);

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

                    if (cbbxSearchType.SelectedItem.ToString() == "ID")
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t => (SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0) && (t.IsDeleted == false)).Select(t => t).ToList();

                    }
                    else if (cbbxSearchType.SelectedItem.ToString() == "NAME")
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t => (SqlFunctions.PatIndex("%" + value + "%", t.TEN) > 0) && (t.IsDeleted == false)).Select(t => t).ToList();

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
            Notify.UnnotificationField(sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
            AddLocationForTour h = new AddLocationForTour(id);
            Clear();
            this.Hide();
            h.ShowDialog();
            this.Show();
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
