using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class DangKy : Form
    {
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
        public DangKy()
        {
            InitializeComponent();
            //tbCMND.ForeColor = Color.LightGray;
            //tbCMND.Text = "Please Enter Identification Card Number";

        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            //LoadCombobox(cbDes);

            showAll();
            reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime itime = DateTime.Now;
            lbTime.Text = itime.ToLongTimeString();

            DateTime idate = DateTime.Now;
            lbDate.Text = idate.ToLongDateString();
        }

        private void rdIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDomestic.Checked == true)
            {
                //tbCMND.Text = "Please Enter Identification Card Number";
                //tbCMND.ForeColor = Color.LightGray;
                PnFore.Visible = false;
            }
            else
            {
                PnFore.Visible = true;
                //tbCMND.Text = "Please Enter Passport Number";
                //tbCMND.ForeColor = Color.LightGray;
            }
        }

        private void tbCMND_Enter(object sender, EventArgs e)
        {
            //if (rdDomestic.Checked == true && tbCMND.Text == "Please Enter Identification Card Number")
            //{
            //    tbCMND.Text = "";
            //    tbCMND.ForeColor = Color.Black;
            //}
            //else tbCMND.Text = ""; tbCMND.ForeColor = Color.Black;
        }

        private void tbCMND_Leave(object sender, EventArgs e)
        {
            //if(rdDomestic.Checked == true && tbCMND.Text == "")
            //{
            //    tbCMND.Text = "Please Enter Identification Card Number";
            //    tbCMND.ForeColor = Color.LightGray;
            //}
            //else if(RdForeign.Checked == true && tbCMND.Text=="")
            //{
            //    tbCMND.Text = "Please Enter Passport Number";
            //    tbCMND.ForeColor = Color.LightGray;
            //}
        }

        private void btExit_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Confirm if you want to exit ?", "Travel Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reset()
        {
            tbDate.Clear();
            tbPrice.Clear();
            tbDiscount.Clear();
            tbTotal.Clear();
            cbDes.Text = "None";
            RdFmale.Checked = true;
            rdDomestic.Checked = true;
            rtbreservation.Clear();
            rtbTicket.Clear();
            tbDuration.Clear();
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public bool CheckData()
        {


            if (tbName.Text.Trim().CompareTo(string.Empty) == 0 || tbAddress.Text.Trim().CompareTo(string.Empty) == 0 || tbCMND.Text.Trim().CompareTo(string.Empty) == 0||cbGroup.SelectedValue==null||cbDes.SelectedValue==null)
            {
                MessageBox.Show("Please fill in all the information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public string SurName, address, phonenumber,typeCus, gender,CMND,TourID,tourist,typeoftour,RouteID,TenChuyen;
        public int Year, Month, Day, vYear, vMonth, vDay,price,tienhoantra,lephihoantra;

        private void cbGroup_SelectedValueChanged(object sender, EventArgs e)
        {

            int index = cbGroup.SelectedIndex;

            if (index >= 0)
            {
                Type t = cbGroup.SelectedItem.GetType();

                object iddoan = t.GetProperty("IDDOAN").GetValue(cbGroup.SelectedItem, null);
                object ngaykhoihanh = t.GetProperty("NGAYKHOIHANH").GetValue(cbGroup.SelectedItem, null);
                object ngayketthuc = t.GetProperty("NGAYKETTHUC").GetValue(cbGroup.SelectedItem, null);
                tbDate.Text= t.GetProperty("NGAYKHOIHANH").GetValue(cbGroup.SelectedItem, null).ToString();
                tbDuration.Text = ((DateTime)ngayketthuc - (DateTime)ngaykhoihanh).TotalDays.ToString();
            }

        }

        private void btCreate_Click(object sender, EventArgs e)
        {

            if (RdFmale.Checked == true)
            {
                gender = "Nam";
            }
            else gender = "Nữ";


            if (CheckData())
            {
                try
                {
                    string randomcode = Converter.Instance.RandomString2(5);
                    string idkhach = randomcode;
                    var khachhang = new KHACHHANG()
                    {
                        ID = idkhach,
                        TENKH = tbName.Text,
                        CMND = tbCMND.Text,
                        GIOITINH = gender,
                        DIACHI = tbAddress.Text,
                        SDT = tbTelephone.Text,
                        IsDeleted = false,
                    };
                    DataProvider.Ins.DB.KHACHHANGs.Add(khachhang);

                    randomcode = Converter.Instance.RandomString2(5);
                    var ve = new VE()
                    {
                        ID = randomcode,
                        IDKHACH = idkhach,
                        IDDOAN = cbGroup.SelectedValue.ToString(),
                        NGAYMUA = DateTime.Today,
                        GIA = Convert.ToDecimal(tbPrice.Text),
                        IsDeleted = false,
                    };
                    DataProvider.Ins.DB.VEs.Add(ve);
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                    Clear();
                }
                catch (Exception ex)
                {

                }

            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void LoadCombobox(ComboBox cb)
        {

        }

        static string sqlconnectStr = @"Data Source=.\mssqlserver01;initial catalog=QL_TOUR_DU_LICH;integrated security=True";
        SqlConnection sqlconnect = new SqlConnection(sqlconnectStr);

        private void showAll()
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
            reset();


        }

        private void cbDes_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbDes.SelectedIndex;

            if (index >= 0)
            {

                Type t = cbDes.SelectedItem.GetType();
                string idtour = t.GetProperty("IDTOUR").GetValue(cbDes.SelectedItem, null).ToString();

                cbGroup.DataSource = (from tour in DataProvider.Ins.DB.TOURs
                                      join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                                      where tour.ID == idtour && tour.IsDeleted == false && doan.IsDeleted == false
                                      select new
                                      {
                                          TENDOAN = doan.TEN,
                                          IDDOAN = doan.ID,
                                          NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                          NGAYKETTHUC = doan.NGAYKETTHUC
                                      }
                                            ).ToList();
                cbGroup.ValueMember = "IDDOAN";
                cbGroup.DisplayMember = "TENDOAN";
                cbGroup.SelectedIndex = -1;
                reset();
                tbPrice.Text = cbDes.SelectedItem.GetType().GetProperty("GIA").GetValue(cbDes.SelectedItem, null).ToString();
            }

        }

        private void backtotourbtn_Click(object sender, EventArgs e)
        {
            Tour t = new Tour();
            this.Hide();
            t.ShowDialog();
        }
        void Clear()
        {
            tbName.Text = tbAddress.Text = tbTelephone.Text = tbEmail.Text = tbCMND.Text = "";
        }
        private void tbTelephone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(tbEmail.Text))
                {
                    MessageBox.Show("Invalidate Email", "Error");
                    tbEmail.SelectAll();
                    btCreate.Enabled = false;
                }
                else
                {
                    btCreate.Enabled = true;
                }
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            e.Handled = true;
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbTelephone_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void btngotocsdl_Click(object sender, EventArgs e)
        {
            CSDLPhieuDatCho t = new CSDLPhieuDatCho();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
