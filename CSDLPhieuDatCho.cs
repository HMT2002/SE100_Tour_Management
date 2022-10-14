using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;

namespace Tour
{
    public partial class CSDLPhieuDatCho : Form
    {

        string id;
        void Clear()
        {
            tbName.Text=tbAddress.Text = tbID.Text = tbICN.Text = tbphone.Text = tbAddress.Text = "";
            rdbDomestic.Checked = rdbFemale.Checked = rdbMale.Checked = rdbForeign.Checked = false;
        }
        public CSDLPhieuDatCho()
        {

            InitializeComponent();

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbSearchTicket.Text == "")
            {
                tbSearchTicket.ForeColor = Color.LightGray;
                tbSearchTicket.Text = "Enter Tour ID to search";
                ShowTicket();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbSearchTicket.Text == "Enter Tour ID to search")
            {
                tbSearchTicket.Text = "";
                tbSearchTicket.ForeColor = Color.Black;
                ShowTicket();
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tbSearchResID.Text == "")
            {
                tbSearchResID.ForeColor = Color.LightGray;
                tbSearchResID.Text = "Enter Tour ID to search";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tbSearchResID.Text == "Enter Tour ID to search")
            {
                tbSearchResID.Text = "";
                tbSearchResID.ForeColor = Color.Black;
            }
        }
        public void ShowTicket()
        {

            dgvDatCho.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                    join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                                    join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                    where doan.ID==id
                                    select new
                                    {
                                        IDVE = ve.ID,
                                        TENKHACHHANG = khachhang.TENKH,
                                        TENTOUR=tour.TEN,

                                    }).ToList();

        }

        public void ShowTicketv2()
        {


        }


        decimal CostTicket;
        string NameOfRouteType, NameOfTourType;

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            String gender, tourist;
            if (index >= 0)
            {
                id= dgvQuanLy.Rows[index].Cells["IDTOUR"].Value.ToString();


                NameOfTourType = dgvQuanLy.Rows[index].Cells["TenLoaiChuyen"].Value.ToString();
                NameOfRouteType = dgvQuanLy.Rows[index].Cells["TenloaiTuyen"].Value.ToString();
                CostTicket = decimal.Parse(dgvQuanLy.Rows[index].Cells["GiaVe"].Value.ToString());

                tbID.Text = dgvQuanLy.Rows[index].Cells["MaChuyen"].Value.ToString();
                tbName.Text = dgvQuanLy.Rows[index].Cells["HoTen"].Value.ToString();
                tbAddress.Text = dgvQuanLy.Rows[index].Cells["DiaChi"].Value.ToString();
                tbphone.Text = dgvQuanLy.Rows[index].Cells["SDT"].Value.ToString();
                tbICN.Text = dgvQuanLy.Rows[index].Cells["CMND_Passport"].Value.ToString();

                dtpVisa.Value = DateTime.Parse(dgvQuanLy.Rows[index].Cells["HanVisa"].Value.ToString());
                dtpPassport.Value = DateTime.Parse(dgvQuanLy.Rows[index].Cells["HanPassport"].Value.ToString());

                gender = dgvQuanLy.Rows[index].Cells["GioiTinh"].Value.ToString();
                if (gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdbFemale.Checked = true;
                }
                tourist = dgvQuanLy.Rows[index].Cells["TenLoaiKhach"].Value.ToString();
                if (tourist == "Foreign")
                {
                    rdbForeign.Checked = true;
                }
                else if (tourist == "Domestic")
                {
                    rdbDomestic.Checked = true;
                }
            }
        }
        private void CSDLPhieuDatCho_Load(object sender, EventArgs e)
        {
            ShowTicket();
            tientong();
        }
        void tientong()
        {
            int sum = 0;
            for (int i = 0; i < dgvQuanLy.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvQuanLy.Rows[i].Cells["GiaVe"].Value);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {

                Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string value = tbSearchResID.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                        dgvDatCho.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                                                join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                                join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                where SqlMethods.Like(ve.ID, "%" + value + "%")
                                                select new
                                                {
                                                    IDVE = ve.ID,
                                                    TENKHACHHANG = khachhang.TENKH,
                                                    TENTOUR = tour.TEN,

                                                }).ToList();
                }
                catch
                {

                }
            }
            else { ShowTicket(); }
        }

        public bool CheckData()
        {

            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbphone.Text) || String.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Please fill in all the information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void tbphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rdbForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDomestic.Checked)
            {
                panelTime.Visible = false;
            }
            else
            {
                panelTime.Visible = true;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearchResID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearchTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            ShowTicket();
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            ShowTicket();
        }

        private void tbphone_Enter(object sender, EventArgs e)
        {
            ShowTicket();
        }

        private void btnTraVe_Click(object sender, EventArgs e)
        {

            Customer cus = new Customer();



            decimal result;
            decimal costA = 1;
            int costB = 0;



            result = (CostTicket * costA) - costB;
            if (result > 0)
            {
                MessageBox.Show("You get paid " + result + " for ticket refund ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result < 0)
            {
                MessageBox.Show("You have to pay extra " + result * (-1) + " for ticket refund ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clear();

        }
        public string mave,maphieu,madukhach,tourID;
        public bool XoaKhach()
        {
            tblTicket tk = new tblTicket();
            tk.MaVe = Guid.Parse(mave);
            tk.MaPhieu =Guid.Parse(maphieu);
            tk.MaDuKhach = Guid.Parse(madukhach);
            Customer cus = new Customer();
            cus.MaDuKhach= Guid.Parse(madukhach);
            Reservation res = new Reservation();
            res.MaPhieu = Guid.Parse(maphieu);
            res.MaChuyen = Guid.Parse(tourID);


            tientong();
            return false;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }
            else { 
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 

            }

                tientong();
                Clear();

        }
        public float getTienHoantra(string TenLoaiChuyen)
        {
            float cost = 0;
            string sql = "SELECT TienHoanTra FROM LoaiChuyen WHERE TenLoaiChuyen = @TenLoaiChuyen";
            SqlConnection con = null; // dc.getConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@TenLoaiChuyen", TenLoaiChuyen);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                cost = float.Parse(da.GetValue(0).ToString());
            }
            return cost;
        }

        public int getLePhiHoanTra(string TenLoaiTuyen)
        {
            int cost = 0;
            string sql = "SELECT LePhiHoanTra FROM LoaiTuyen WHERE TenLoaiTuyen = @TenLoaiTuyen";
            SqlConnection con = null; // dc.getConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@TenLoaiTuyen", TenLoaiTuyen);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                cost = Int32.Parse( da.GetValue(0).ToString());             
            }
            return cost;
        }

        public DateTime GetTime(Guid MaChuyen)
        {
            DateTime date = new DateTime();
            
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Error, Please try again later", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return date;
        }
    }
}