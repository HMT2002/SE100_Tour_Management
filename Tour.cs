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

namespace Tour
{
    public partial class Tour : Form
    {
        ChuyenBLL bllChuyen;
        string id;
        string randomcode;

        public Tour()
        {
            InitializeComponent();
            bllChuyen = new ChuyenBLL();
            tb_search.ForeColor = Color.LightGray;
            tb_search.Text = "Enter Tour ID to search";
            this.tb_search.Leave += new System.EventHandler(this.textBox1_Leave);
            this.tb_search.Enter += new System.EventHandler(this.textBox1_Enter);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {
                tb_search.ForeColor = Color.LightGray;
                tb_search.Text = "Enter Tour ID to search";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tb_search.Text == "Enter Tour ID to search")
            {
                tb_search.Text = "";
                tb_search.ForeColor = Color.Black;
            }
        }
        public void ShowAllChuyen()
        {
            dgv_trip.DataSource = bllChuyen.getAllChuyen();
        }
        private void TRIPManageTour_Load(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }
        public bool CheckData()
        {
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
                tblChuyen route = new tblChuyen();
                int Hour, Minute;
                DateTime temp = new DateTime();
                DateTime date = new DateTime();
                route.MaChuyen = Guid.Parse(tb_idtrip.Text);
                route.MaChuyenSearch = route.MaChuyen.ToString();
                route.ThoiGianKhoiHanh = date;
                route.GiaVe = Int32.Parse(tb_price.Text);

                if (bllChuyen.UpdateChuyen(route))
                {
                    ShowAllChuyen();
                }
                else
                    MessageBox.Show("Error, Please try again later", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
        void Clear()
        {
            tb_price.Text = cb_typetour.Text = tb_nametour.Text = tb_idtrip.Text = cb_typetour.Text =richtbDetail.Text= "";
            cb_typetour.SelectedItem = null;
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                int Hour, Minute;
                DateTime temp = new DateTime();
                DateTime date = new DateTime();
                tblChuyen route = new tblChuyen();
                route.MaChuyen = Guid.NewGuid();
                route.MaChuyenSearch = route.MaChuyen.ToString();
                route.ThoiGianKhoiHanh = date;
                route.GiaVe = Int32.Parse(tb_price.Text);
                try
                {
                    randomcode = Converter.Instance.RandomString(5);
                    var tour = new TOUR() { ID = randomcode, GIA = Convert.ToDecimal(tb_price.Text), TEN = tb_nametour.Text, LOAI = cb_typetour.Text, DACDIEM = richtbDetail.Text };
                    DataProvider.Ins.DB.TOURs.Add(tour);
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
                tblChuyen route = new tblChuyen();
                route.MaChuyen = Guid.Parse(tb_idtrip.Text);
                if (bllChuyen.DeleteChuyen(route))
                {
                    ShowAllChuyen();
                }
                else
                    MessageBox.Show("Error, Please try again later", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
        public string TourID, TourName, TourCode, TypeofTour, Transport, RouteID;
        public int Hour, Minute, Year, Month, Day, Tickets, Price;
        public bool addChuyen()
        {
            DateTime date;
            tblChuyen route = new tblChuyen();
            date = new DateTime(Year, Month, Day, Hour, Minute, 0);
            route.MaTuyen = Guid.Parse(RouteID);
            route.MaChuyen = Guid.NewGuid();
            route.TenTuyen = TourName;
            route.ThoiGianKhoiHanh = date;
            route.PhuongTien = Transport;
            route.SoLuongVeMax = Tickets;
            route.GiaVe = Price;
            route.MaLoaiChuyen = TourCode;
            route.TenLoaiChuyen = TypeofTour;
            route.MaChuyenSearch = route.MaChuyen.ToString();
            if (bllChuyen.InsertChuyen(route))
            {
                return true;
            }
            return false;
        }
        public bool deleteChuyen()
        {
            tblChuyen route = new tblChuyen();
            route.MaChuyen = Guid.Parse(TourID);
            if (bllChuyen.DeleteChuyen(route))
            {
                return true;
            }
            return false;
        }
        public bool updateChuyen()
        {
            DateTime date;
            tblChuyen route = new tblChuyen();
            date = new DateTime(Year, Month, Day, Hour, Minute, 0);
            route.MaTuyen = Guid.Parse(RouteID);
            route.MaChuyen = Guid.Parse(TourID);
            route.TenTuyen = TourName;
            route.ThoiGianKhoiHanh = date;
            route.PhuongTien = Transport;
            route.SoLuongVeMax = Tickets;
            route.GiaVe = Price;
            route.MaLoaiChuyen = TourCode;
            route.TenLoaiChuyen = TypeofTour;
            if (bllChuyen.UpdateChuyen(route))
            {
                return true;
            }
            return false;
        }
        private void dgv_trip_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DateTime Time = new DateTime();
            string kind;
            if (index >= 0)
            {
                id = dgv_trip.Rows[index].Cells["MaTuyen"].Value.ToString();
                tb_idtrip.Text = dgv_trip.Rows[index].Cells["MaChuyen"].Value.ToString();
                Time = Convert.ToDateTime(dgv_trip.Rows[index].Cells["ThoiGianKhoiHanh"].Value.ToString());
                kind = dgv_trip.Rows[index].Cells["TenLoaiChuyen"].Value.ToString();
                tb_price.Text = dgv_trip.Rows[index].Cells["GiaVe"].Value.ToString();
            }
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            string value = tb_search.Text;
            if (!string.IsNullOrEmpty(value) && value != "Enter Tour ID to search")
            {
                dgv_trip.DataSource = bllChuyen.FindChuyen(value);
            }
            else { ShowAllChuyen(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbMinute_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_newid_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void idTuyencb_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void tb_idtrip_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void rdbRegular_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void rdbPromotional_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void tb_price_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void dtpKhoiHanh_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void cbHour_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void cbMinute_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void cbTTransporation_Enter(object sender, EventArgs e)
        {
            ShowAllChuyen();
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
            ShowAllChuyen();
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
