using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class DangKy : Form
    {
        CustomerDAL cusDAL = new CustomerDAL();
        ticketDAL tkDAL = new ticketDAL();
        ReservationDAL resDAL = new ReservationDAL();
        DataConnection dc;// = new DataConnection();

        tblChuyen chuyen;
        decimal TienHoanTra;
        int LePhiHoanTra;
        string ThoiGianToChuc;
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
        public DangKy()
        {
            InitializeComponent();
            tbCMND.ForeColor = Color.LightGray;
            tbCMND.Text = " Please Enter Identification Card Number";
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            LoadCombobox(cbDes);
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
                tbCMND.Text = "Please Enter Identification Card Number";
                tbCMND.ForeColor = Color.LightGray;
                PnFore.Visible = false;
            }
            else
            {
                PnFore.Visible = true;
                tbCMND.Text = "Please Enter Passport Number";
                tbCMND.ForeColor = Color.LightGray;
            }
        }

        private void tbCMND_Enter(object sender, EventArgs e)
        {
            if (rdDomestic.Checked == true && tbCMND.Text == "Please Enter Identification Card Number")
            {
                tbCMND.Text = "";
                tbCMND.ForeColor = Color.Black;
            }
            else tbCMND.Text = ""; tbCMND.ForeColor = Color.Black;
        }

        private void tbCMND_Leave(object sender, EventArgs e)
        {
            if(rdDomestic.Checked == true && tbCMND.Text == "")
            {
                tbCMND.Text = "Please Enter Identification Card Number";
                tbCMND.ForeColor = Color.LightGray;
            }
            else if(RdForeign.Checked == true && tbCMND.Text=="")
            {
                tbCMND.Text = "Please Enter Passport Number";
                tbCMND.ForeColor = Color.LightGray;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult msExit;

            msExit = MessageBox.Show("Confirm if you want to exit ?", "Travel Management System", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(msExit ==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reset()
        {
            tbName.Clear();
            tbSurname.Clear();
            tbEmail.Clear();
            tbTelephone.Clear();
            tbAddress.Clear();
            tbCMND.Clear();
            tbVehicle.Clear();
            tbAmount.Clear();
            tbDate.Clear();
            tbPrice.Clear();
            tbDiscount.Clear();
            tbTotal.Clear();
            cbDes.Text = "None";
            RdMale.Checked = true;
            rdDomestic.Checked = true;
            rtbreservation.Clear();
            rtbTicket.Clear();
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public bool CheckData()
        {


            if (String.IsNullOrEmpty(tbName.Text)|| String.IsNullOrEmpty(tbSurname.Text)|| String.IsNullOrEmpty(tbAddress.Text)||String.IsNullOrEmpty(tbCMND.Text))
            {
                MessageBox.Show("Please fill in all the information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public string SurName, Name, address, phonenumber,typeCus, gender,CMND,TourID,tourist,typeoftour,RouteID,TenChuyen;
        public int Year, Month, Day, vYear, vMonth, vDay,price,tienhoantra,lephihoantra;
        bool checkCus,checkRes;
        public bool CreateCustomer()
        {
            tblTicket tk = new tblTicket();
            Customer cus = new Customer();
            DateTime date = new DateTime(Year, Month, Day);
            DateTime datevisa = new DateTime(vYear, vMonth, vDay);
            Reservation res = new Reservation();
            cus.MaDuKhach = Guid.NewGuid();
            cus.HoTen = SurName + " " + Name;
            cus.DiaChi = address;
            cus.SDT = phonenumber;
            cus.MaLoaiKhach = typeCus;
            cus.GioiTinh = gender;
            cus.CMND_Passport = CMND;
            cus.HanPassport = date;
            cus.HanVisa = datevisa;
            tk.TenLoaiKhach = tourist;
            res.MaChuyen = Guid.Parse(TourID);
            res.MaPhieu = Guid.NewGuid();
            if (tk.TenLoaiKhach=="Foreign")
            {

                checkCus = cusDAL.InsertForeign(cus);
            }
            else checkCus = cusDAL.InsertDomestic(cus);
            checkRes = resDAL.Insert(res);
            tk.MaVe = Guid.NewGuid();
            tk.MaDuKhach = cus.MaDuKhach;
            tk.MaPhieu = res.MaPhieu;
            tk.GiaVe = price;
            tk.HoTen = cus.HoTen;
            tk.DiaChi = cus.DiaChi;
            tk.SDT = cus.SDT;
            tk.CMND_Passport = cus.CMND_Passport;
            tk.HanPassport = cus.HanPassport;
            tk.HanVisa = cus.HanVisa;
            tk.GioiTinh = cus.GioiTinh;
            tk.TenLoaiChuyen = TenChuyen;

            tk.TenLoaiTuyen = typeoftour;
            tk.TienHoanTra = tienhoantra;

            tk.LePhiHoanTra = lephihoantra ;
            tk.MaChuyen = Guid.Parse(RouteID);
            tk.MaChuyenSearch = tk.MaChuyen.ToString();


            if (checkCus && tkDAL.Insert(tk) && checkRes)
            {
                return true;
            }
            return false;
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            string MaVe = "", MaPhieu = "";
            tblTicket tk = new tblTicket();
            Customer cus = new Customer();
            Reservation res = new Reservation();
            String gender, typeCus;
            bool checkCus, checkRes;

            if (RdMale.Checked == true)
            {
                gender = "Nam";
            }
            else gender = "Nữ";

            String Kind, Tourist;

            if (CheckData())
            {
                string randomcode = Converter.Instance.RandomString2(5);
                var khachhang = new KHACHHANG() { ID = randomcode,TENKH=tbSurname.Text+tbName.Text,CMND=tbCMND.Text,GIOITINH=gender,DIACHI=tbAddress.Text,SDT=tbTelephone.Text, };
                DataProvider.Ins.DB.KHACHHANGs.Add(khachhang);

                Clear();
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            CSDLPhieuDatCho csdl = new CSDLPhieuDatCho();
            csdl.StartPosition = FormStartPosition.CenterParent;
            csdl.ShowDialog();
        }

        private void LoadCombobox(ComboBox cb)
        {
            cbDes.DataSource = (from tour in DataProvider.Ins.DB.TOURs
                                        join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR

                                        select new
                                        {
                                            TEN = doan.TOUR.TEN,
                                            TENDOAN = doan.TEN
                                        }
                            ).ToList();
            cbDes.DisplayMember = "TEN";
        }

        private void cbDes_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbDes.)
            //ChuyenDAL chuyenDAL = new ChuyenDAL();

            //tbVehicle.Text = chuyen.PhuongTien;
            //tbDate.Text = chuyen.ThoiGianKhoiHanh.ToString();

            //tbDuration.Text = ThoiGianToChuc;
            //tbPrice.Text = chuyen.GiaVe.ToString();
            //Amount(cbDes.Text);
        }

        private void backtotourbtn_Click(object sender, EventArgs e)
        {
            Tour t = new Tour();
            this.Hide();
            t.ShowDialog();
        }

        private void Amount(String MaChuyen)
        {
            int result = 0;
            result = GetMax(MaChuyen) - GetCount(MaChuyen);
            tbAmount.Text = result.ToString(); 
        }

        private int GetMax(string MaChuyen)
        {
            return chuyen.SoLuongVeMax;
        }
        private int GetCount(string MaChuyen)
        {
            string query = "SELECT COUNT(*) FROM PhieuDatCho WHERE MaChuyen = " + Guid.Parse(MaChuyen);

            return 0;
        }
        void Clear()
        {
            tbName.Text = tbSurname.Text = tbAddress.Text = tbTelephone.Text = tbEmail.Text = tbCMND.Text = "";
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
            DateTime current = DateTime.Now;
            DateTime date = GetTime(cbDes.Text);
            TimeSpan interval = date - current;
            if (interval.Days >= 3 && chuyen.TenLoaiChuyen == "National")
            {
                tbDiscount.Text = ((Int32.Parse(tbPrice.Text) * 20) / 100).ToString();
            }
            else if (interval.Days >= 10 && chuyen.TenLoaiChuyen == "International")
            {
                tbDiscount.Text = ((Int32.Parse(tbPrice.Text) * 20) / 100).ToString();
            }
            else tbDiscount.Text = "0";
            if(String.IsNullOrEmpty(tbPrice.Text))
            { 
                tbDiscount.Text = tbTotal.Text = " "; 
            }
            else
            {
                tbTotal.Text = (Int32.Parse(tbPrice.Text) - Int32.Parse(tbDiscount.Text)).ToString();
            }
        }

        public DateTime GetTime(string MaChuyen)
        {
            return chuyen.ThoiGianKhoiHanh;
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSurname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
