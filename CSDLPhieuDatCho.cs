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
            rdbFemale.Checked = rdbMale.Checked = false;
        }
        public CSDLPhieuDatCho()
        {

            InitializeComponent();

        }



        public void ShowTicket()
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

                gender = dgvQuanLy.Rows[index].Cells["GioiTinh"].Value.ToString();
                if (gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdbFemale.Checked = true;
                }
            }
        }
        private void CSDLPhieuDatCho_Load(object sender, EventArgs e)
        {

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