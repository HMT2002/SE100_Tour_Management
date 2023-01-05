using Guna.UI2.WinForms;
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
using Tour.CrystalReport;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class DangKy : Form
    {
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

        KHACHHANG khachhang ;

        public TOUR selected_tour = new TOUR();
        public DOAN selected_group = new DOAN();
        
        public DangKy()
        {
            InitializeComponent();
            //tbCMND.ForeColor = Color.LightGray;
            //tbCMND.Text = "Please Enter Identification Card Number";

        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            LoadCombobox(cbDes);

            showAll();
            reset();
            Clear();
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

        }

        private void tbCMND_Enter(object sender, EventArgs e)
        {

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
            RdMale.Checked = true;
            tbDuration.Clear();
            Notify.UnnotificationSelect(cbDes);
            Notify.UnnotificationSelect(cbGroup);
            cbGroup.DataSource = null;

            pcbxBanner.Visible = false;
            pcbxBanner.Image = Properties.Resources.ic_image_empty_128;
            selected_group = null;
            selected_tour = null;

            lblReciptGroupName.Text = "";
            lblReciptPrice.Text = "";
            lblReciptStartDate.Text = "";
            lblReciptEndDate.Text = "";
            lblReciptTourName.Text = "";
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void UnnotifyAllFields()
        {
            Notify.UnnotificationField(tbName);
            Notify.UnnotificationField(tbAddress);
            Notify.UnnotificationField(tbEmail);
            Notify.UnnotificationField(tbCMND);
            Notify.UnnotificationField(tbTelephone);

        }


        public bool CheckData()
        {
            bool flag = true;
            if (tbName.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tbName);
                flag = false;
            }

            if (tbAddress.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tbAddress);
                flag = false;

            }

            if (tbTelephone.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tbTelephone);
                flag = false;
            }

            if (tbCMND.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tbCMND);
                flag = false;
            }

            if (tbEmail.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(tbEmail);
                flag = false;
            }


            if (cbDes.SelectedValue == null)
            {
                Notify.NotificationSelect(cbDes);
                flag = false;
            }


            if (cbGroup.SelectedValue == null)
            {
                Notify.NotificationSelect(cbGroup);
                flag = false;
            }



            return flag;
        }
        public string SurName, address, phonenumber,typeCus, gender,CMND,TourID,tourist,typeoftour,RouteID,TenChuyen;
        public int Year, Month, Day, vYear, vMonth, vDay,price,tienhoantra,lephihoantra;

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        public double customer_discount = 0;
        public double banner_discount = 0;


        public void OpenChooseLoyalCustomer()
        {
            using (ChooseLoyalCustomer t = new ChooseLoyalCustomer())
            {

                this.Hide();
                t.ShowDialog();
                this.Show();
                if (t.ChosedKhachHang == null)
                {
                    Clear();
                    return;
                }
                khachhang = t.ChosedKhachHang;

                lblChooseCustomer.Text = t.ChosedKhachHang.ID;

                tbName.Text = t.ChosedKhachHang.TENKH;
                tbName.Enabled = false;
                tbAddress.Text = t.ChosedKhachHang.DIACHI;
                tbAddress.Enabled = false;

                tbCMND.Text = t.ChosedKhachHang.CMND;
                tbCMND.Enabled = false;

                tbTelephone.Text = t.ChosedKhachHang.SDT;
                tbTelephone.Enabled = false;

                tbEmail.Text = t.ChosedKhachHang.MAIL;
                tbEmail.Enabled = false;

                if (t.ChosedKhachHang.GIOITINH == "Male")
                {
                    RdMale.Checked = true;
                }
                else
                {
                    RdFmale.Checked = true;
                }

                RdMale.Enabled = false;
                RdFmale.Enabled = false;


                switch (t.ChosedKhachHang.PRI)
                {
                    case "BRONZE":
                        customer_discount = 5;
                        break;

                    case "SILVER":
                        customer_discount = 7;
                        break;

                    case "GOLD":
                        customer_discount = 13;
                        break;

                    case "PLATINUM":
                        customer_discount = 18;
                        break;

                    default:
                        customer_discount = 0;
                        break;
                }

                lblCustomerDiscount.Text = customer_discount.ToString();
                tbDiscount.Text = (banner_discount + customer_discount).ToString();



                try
                {
                    decimal res = 0;
                    double discount = banner_discount + customer_discount;
                    decimal price = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tbPrice.Text);
                    res = price - (price * (decimal)(discount / 100));
                    tbTotal.Text = res.ToString();
                }
                catch
                {

                    tbTotal.Text = tbPrice.Text;
                }


                lblReciptPrice.Text = tbTotal.Text;

                UnnotifyAllFields();
            }
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            lblReciptCustomerName.Text = tbName.Text;

        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

        }

        private void lblChooseCustomer_Click(object sender, EventArgs e)
        {
            OpenChooseLoyalCustomer();
        }

        private void cbGroup_SelectedValueChanged(object sender, EventArgs e)
        {

            int index = cbGroup.SelectedIndex;

            if (index >= 0)
            {
                Type t = cbGroup.SelectedItem.GetType();

                string iddoan = t.GetProperty("IDDOAN").GetValue(cbGroup.SelectedItem, null).ToString();
                selected_group = DataProvider.Ins.DB.DOANs.Where(x => x.ID == iddoan).FirstOrDefault();
                tbDate.Text = selected_group.NGAYKHOIHANH.Value.ToString("dd/MM/yyyy");
                tbDuration.Text = ((DateTime)selected_group.NGAYKETTHUC - (DateTime)selected_group.NGAYKHOIHANH).TotalDays.ToString();

                lblReciptStartDate.Text= selected_group.NGAYKHOIHANH.Value.ToString("dd/MM/yyyy");
                lblReciptEndDate.Text= selected_group.NGAYKETTHUC.ToString();
                lblReciptGroupName.Text = selected_group.TEN;

            }

        }
        public void AddTicket()
        {


            if (CheckData())
            {
                if (MessageBox.Show("Confirm create ticket? ", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        //MessageBox.Show(Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tbPrice.Text).ToString());
                        //return;

                        if (RdFmale.Checked == true)
                        {
                            gender = "Male";
                        }
                        else gender = "Female";
                        string idkhach = lblChooseCustomer.Text.Trim();
                        string randomcode = Converter.Instance.RandomString2(5);

                        if (khachhang == null)
                        {
                            idkhach = randomcode;
                            khachhang = new KHACHHANG()
                            {
                                ID = idkhach,
                                TENKH = tbName.Text,
                                CMND = this.tbCMND.Text,
                                GIOITINH = gender,
                                DIACHI = tbAddress.Text,
                                SDT = tbTelephone.Text,
                                IsDeleted = false,
                            };
                            DataProvider.Ins.DB.KHACHHANGs.Add(khachhang);
                        }
                        else
                        {
                            khachhang.SPENDING += Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tbTotal.Text);
                        }

                        var ve = new VE()
                        {
                            ID = lblReciptTicketID.Text,
                            IDKHACH = idkhach,
                            IDDOAN = cbGroup.SelectedValue.ToString(),
                            NGAYMUA = DateTime.Today,
                            GIA = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tbTotal.Text),
                        IsDeleted = false,
                        };
                        DataProvider.Ins.DB.VEs.Add(ve);
                        DataProvider.Ins.DB.SaveChanges();
                        temp_ticket_id = lblReciptTicketID.Text;
                        showAll();
                        Clear();
                        MessageBox.Show("Ticket Booked!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
        }

        public string temp_ticket_id = "";
        private void btCreate_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                AddTicket();
                AskForReport();
            }

        }

        private void AskForReport()
        {
            if (MessageBox.Show("Do you want to print ticket?", "Print ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                VE ve = DataProvider.Ins.DB.VEs.Where(x => (x.ID == temp_ticket_id && x.IsDeleted == false)).SingleOrDefault();

                using (fPrint f = new fPrint(ve))
                {
                    rptTicket crys = new rptTicket();
                    crys.Load(@"rptTicket.rep");

                    f.rptViewer.ReportSource = crys;
                    f.rptViewer.Refresh();

                    f.rptViewer.SelectionFormula = "{VE.ID} = '" + ve.ID + "' ";

                    f.ShowDialog();
                }
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Clear();
            showAll();
        }

        private void LoadCombobox(ComboBox cb)
        {

        }

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
                ).Distinct().ToList();

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
                reset();

                Type t = cbDes.SelectedItem.GetType();
                string idtour = t.GetProperty("IDTOUR").GetValue(cbDes.SelectedItem, null).ToString();
                selected_tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == idtour).FirstOrDefault();
                cbGroup.DataSource = (from tour in DataProvider.Ins.DB.TOURs
                                      join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                                      where tour.ID == selected_tour.ID && tour.IsDeleted == false && doan.IsDeleted == false
                                      select new
                                      {
                                          TENDOAN = doan.TEN,
                                          IDDOAN = doan.ID,
                                          NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                          NGAYKETTHUC = doan.NGAYKETTHUC
                                      }
                                            ).Distinct().ToList();
                cbGroup.ValueMember = "IDDOAN";
                cbGroup.DisplayMember = "TENDOAN";
                cbGroup.SelectedIndex = -1;
                tbPrice.Text = Converter.Instance.CurrencyDisplay((decimal)selected_tour.GIA);

                GIAMGIA giamgia = DataProvider.Ins.DB.GIAMGIAs.Where(x => x.IDTOUR == selected_tour.ID && x.IsDeleted == false && x.NGAYBATDAU >= DateTime.Today).FirstOrDefault();
                
                if (giamgia != null)
                {
                banner_discount = (double)giamgia.DISCOUNT;
                    if (giamgia.DISCOUNT != 0)
                    {
                        pcbxBanner.Image = Converter.Instance.ByteArrayToImage(giamgia.PICBI);
                        pcbxBanner.Visible = true;
                    }
                }
                tbDiscount.Text = (banner_discount + customer_discount).ToString();


                try
                {
                    decimal res = 0;
                    double discount = banner_discount + customer_discount;
                    decimal price = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(tbPrice.Text);
                    res = price - (price * (decimal)(discount / 100));
                    tbTotal.Text = Converter.Instance.CurrencyDisplay(res);
                }
                catch
                {
                    tbTotal.Text = tbPrice.Text;

                }



                lblReciptPrice.Text = tbTotal.Text;
                lblReciptTourName.Text = selected_tour.TEN;
                selected_group = null;


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
            lblChooseCustomer.Text = "Click to choose customer";
            khachhang = null;
            banner_discount = 0;
            customer_discount = 0;
            RdMale.Checked = true;
            lblCustomerDiscount.Text = customer_discount.ToString();
            UnnotifyAllFields();

            lblReciptCustomerName.Text = "";
            lblReciptTicketID.Text = Converter.Instance.RandomString2(5);

            tbName.Enabled = true;
            tbAddress.Enabled = true;
            tbTelephone.Enabled = true;
            tbEmail.Enabled = true;
            tbCMND.Enabled = true;
            RdMale.Enabled = true;
            RdFmale.Enabled = true;

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
                }
                else
                {

                }
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbTelephone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {

                Utils.Validate.CapitaLetter(sender,e);

                return;
            }
            e.Handled = true;
        }

    }
}
