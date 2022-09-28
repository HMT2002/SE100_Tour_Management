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

namespace Tour
{
    public partial class Tour : Form
    {
        string id;
        string randomcode;
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
            dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Select(t => t).ToList();

            lstbxLocation.DataSource = LocationList;
            lstbxLocation.DisplayMember = "TEN";

        }
        private void TRIPManageTour_Load(object sender, EventArgs e)
        {
            ShowAllChuyen();

        }
        public bool CheckData()
        {
            if (Convert.ToDecimal(tb_price.Text) == 0)
            {
                MessageBox.Show(Convert.ToDecimal(tb_price.Text).ToString());
                return false;
            }
            if (tb_price.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return false;
            }

            return true;
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                try
                {
                    var tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == id).FirstOrDefault();
                    tour.TEN = tb_nametour.Text;
                    tour.LOAI = cb_typetour.Text;
                    tour.GIA = Convert.ToDecimal(tb_price.Text);
                    tour.DACDIEM = richtbDetail.Text;
                    DataProvider.Ins.DB.SaveChanges();
                    ShowAllChuyen();

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

                Clear();
            }
        }
        public void Clear()
        {
            cb_typetour.SelectedIndex = -1;
            id = tb_price.Text = cb_typetour.Text = tb_nametour.Text = tb_idtrip.Text = cb_typetour.Text = richtbDetail.Text = "";
            lstbxLocation.DataSource = null;
            LocationList = new List<DIADIEM>();
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                try
                {
                    randomcode = Converter.Instance.RandomString(5);
                    var tour = new TOUR() { ID = randomcode, GIA = Convert.ToDecimal(tb_price.Text), TEN = tb_nametour.Text, LOAI = cb_typetour.Text, DACDIEM = richtbDetail.Text };
                    DataProvider.Ins.DB.TOURs.Add(tour);

                    foreach (DIADIEM Location in LocationList)
                    {
                        string randomcode2 = Converter.Instance.RandomString2(5);
                        var diadiemdulich = new tb_DIADIEM_DULICH() { ID = randomcode2, IDDIADIEM = Location.ID, IDTOUR = id };
                        DataProvider.Ins.DB.tb_DIADIEM_DULICH.Add(diadiemdulich);
                    }
                    DataProvider.Ins.DB.SaveChanges();
                    ShowAllChuyen();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Clear();
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
                try
                {
                    TOUR tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == id).FirstOrDefault();
                    DataProvider.Ins.DB.TOURs.Remove(tour);
                    DataProvider.Ins.DB.SaveChanges();
                    ShowAllChuyen();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Clear();
            }
        }
        public string TourID, TourName, TourCode, TypeofTour, Transport, RouteID;
        public int Hour, Minute, Year, Month, Day, Tickets, Price;
        private void dgv_trip_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = dgv_trip.Rows[index].Cells["data_ID"].Value.ToString();
                tb_idtrip.Text = id;
                tb_nametour.Text = dgv_trip.Rows[index].Cells["TEN"].Value.ToString();
                tb_price.Text = dgv_trip.Rows[index].Cells["GIA"].Value.ToString();
                cb_typetour.Text = dgv_trip.Rows[index].Cells["LOAI"].Value.ToString();
                richtbDetail.Text = dgv_trip.Rows[index].Cells["DACDIEM"].Value.ToString();

                LocationList = new List<DIADIEM>();
                foreach (var item in (from dd in DataProvider.Ins.DB.DIADIEMs
                                      join tb_belong in DataProvider.Ins.DB.tb_DIADIEM_DULICH on dd.ID equals tb_belong.IDDIADIEM
                                      where tb_belong.IDTOUR == id
                                      select dd)
                                     .ToList())
                {
                    LocationList.Add(item);
                }
                lstbxLocation.DataSource = LocationList;
                lstbxLocation.DisplayMember = "TEN";
            }
        }

        DataTable dt = new DataTable("TOUR");

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
                    if (rdIDSearch.Checked)
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.ID) > 0).Select(t => t).ToList();

                    }
                    else if(rdNameSearch.Checked)
                    {
                        dgv_trip.DataSource = DataProvider.Ins.DB.TOURs.Where(t => SqlFunctions.PatIndex("%" + value + "%", t.TEN) > 0).Select(t => t).ToList();

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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
            if (id == null)
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
