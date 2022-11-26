using System;
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
    public partial class LoyalCustomer : Form
    {
        public LoyalCustomer()
        {
            InitializeComponent();
            EnableCustomer();
        }

        public void EnableCustomer()
        {
            pnUpdateCustomer.Visible = false;
            pnCreateCustomer.Visible = true;

            btnAdd.Visible = true;
            btnNew.Visible = true;
            btnUpdate.Visible = false;

            txtbxRePassword.Visible = true;
            lblRePassword.Visible = true;

            btnChangePassword.Visible = false;
            txtbxNewPassword.Visible = false;
        }

        KHACHHANG Khachhang=new KHACHHANG();

        public void DisableCustomer()
        {
            pnCreateCustomer.Visible=false;
            pnUpdateCustomer.Visible = true;

            btnAdd.Visible = false;
            btnNew.Visible = false;
            btnUpdate.Visible = true;

            txtbxRePassword.Visible = false;
            lblRePassword.Visible = false;

            btnChangePassword.Visible = true;
            txtbxNewPassword.Visible = false;
        }

        public LoyalCustomer(KHACHHANG khachhang)
        {
            InitializeComponent();
            this.Khachhang = khachhang;

            DisableCustomer();
            LoadData();
        }

        private void LoadData()
        {
            tbName.Text = this.Khachhang.TENKH;
            tbAddress.Text = this.Khachhang.DIACHI;
            tbTelephone.Text = this.Khachhang.SDT;
            tbEmail.Text = this.Khachhang.MAIL;

            if (this.Khachhang.GIOITINH == "Male")
            {
                RdFmale.Checked = true;
            }
            else
            {
                RdFmale.Checked = true;
            }

            tbCMND.Text=this.Khachhang.CMND;

            pcbxAvtatar.Image = Converter.Instance.ByteArrayToImage(this.Khachhang.PICBI);
            img_data = Khachhang.PICBI;
            string password = Converter.Instance.DecryptEncrypt(this.Khachhang.ACCOUNT.PASS);

            string last3word = "";
            if (password.Length >= 3)
            {
                last3word = password.Substring(password.Length - 3);

            }
            lblNotes.Text = "********" + last3word;
            txtbxPassword.Text = "";
        }

        public bool ChechData()
        {
            if(txtbxPassword.Text.Trim().CompareTo(string.Empty)==0|| txtbxRePassword.Text.Trim().CompareTo(string.Empty) == 0 || tbAddress.Text.Trim().CompareTo(string.Empty) == 0 || tbCMND.Text.Trim().CompareTo(string.Empty) == 0 || tbEmail.Text.Trim().CompareTo(string.Empty) == 0 || tbTelephone.Text.Trim().CompareTo(string.Empty) == 0 || tbName.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return false;
            }
            if (txtbxPassword.Text.Trim().CompareTo(txtbxRePassword.Text.Trim()) != 0)
            {
                return false;
            }
            if (txtbxPassword.Text.Length <= 5)
            {
                MessageBox.Show("Password have to be over 5 letters");
                return false;
            }
            return true;
        }

        public bool ChechDataUpdate()
        {
            if (txtbxPassword.Text.Trim().CompareTo(string.Empty) == 0 || tbAddress.Text.Trim().CompareTo(string.Empty) == 0 || tbCMND.Text.Trim().CompareTo(string.Empty) == 0 || tbEmail.Text.Trim().CompareTo(string.Empty) == 0 || tbTelephone.Text.Trim().CompareTo(string.Empty) == 0 || tbName.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return false;
            }
            if (txtbxPassword.Text.CompareTo(Converter.Instance.DecryptEncrypt( Khachhang.ACCOUNT.PASS)) != 0)
            {
                return false;
            }
            return true;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ChechData())
            {
                string gender = "Male";
                if (RdFmale.Checked == true)
                {
                    gender = "Female";
                }
                string randomcode = Converter.Instance.RandomString2(5);
                var account = new ACCOUNT() { ACC = tbEmail.Text, PASS = Converter.Instance.EncryptPassword((txtbxPassword.Text)), ID = randomcode, IsDeleted = false,ACCROLE="Customer" };
                DataProvider.Ins.DB.ACCOUNTs.Add(account);
                var kh = new KHACHHANG() { ID = randomcode, TENKH = tbName.Text, SDT = tbTelephone.Text, CMND = tbCMND.Text, DIACHI = tbAddress.Text, PICBI = img_data, GIOITINH = gender,IDACC=randomcode,MAIL=tbEmail.Text, IsDeleted = false, IsVIP = true, SPENDING = 0, PRI = "BRONZE" };
                DataProvider.Ins.DB.KHACHHANGs.Add(kh);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("SignUp success!!!");
                Clear();
            }
        }

        private void Clear()
        {
            tbAddress.Text = "";
            tbCMND.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            tbTelephone.Text = "";
            RdFmale.Checked = true;
            txtbxPassword.Text = "";
            txtbxRePassword.Text = "";
            pcbxAvtatar.Image = Properties.Resources.ic_image_empty_128;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void UpdateCustomer()
        {
            Khachhang.TENKH = tbName.Text;
            Khachhang.SDT = tbTelephone.Text;
            Khachhang.CMND = tbCMND.Text;
            Khachhang.DIACHI = tbAddress.Text;
            Khachhang.MAIL = tbEmail.Text;
            Khachhang.PICBI = img_data;
            if (RdMale.Checked == true)
            {
                Khachhang.GIOITINH = "Male";
            }
            else
            {
                Khachhang.GIOITINH = "Female";

            }

            ACCOUNT acc = DataProvider.Ins.DB.ACCOUNTs.Where(x => x.ID == Khachhang.IDACC && x.IsDeleted == false).FirstOrDefault();

            acc.ACC = tbEmail.Text.Trim();
            if (txtbxNewPassword.Visible == true)
            {
                if (txtbxNewPassword.Text.Length <= 5)
                {
                    MessageBox.Show("Password have to be over 5 letters");
                    return;
                }
                acc.PASS =Converter.Instance.EncryptPassword( txtbxNewPassword.Text.Trim());
                DisableChangePass();
            }

            DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Update success");
            LoadData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ChechDataUpdate())
            {
                UpdateCustomer();
            }

        }


        Image img;
        Byte[] img_data;
        private void pcbxAvtatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                img = image;
                img_data = Converter.Instance.ImageToByte(image);
                pcbxAvtatar.Image = image;

            }
        }

        private void tbTelephone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
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



        public void EnableChangePass()
        {
            lblRePassword.Visible = !lblRePassword.Visible;
            txtbxRePassword.Visible = !txtbxRePassword.Visible;
            txtbxNewPassword.Visible = !txtbxNewPassword.Visible;

            if (lblNotes.Text.CompareTo("Enter new password") != 0)
            {
                lblNotes.Text = "Enter new password";

            }
            else
            {
                string password = Converter.Instance.DecryptEncrypt(this.Khachhang.ACCOUNT.PASS);

                string last3word = "";
                if (password.Length >= 3)
                {
                    last3word = password.Substring(password.Length - 3);

                }
                lblNotes.Text = "********" + last3word;
            }
        }

        public void DisableChangePass()
        {
            lblRePassword.Visible = false;
            txtbxRePassword.Visible = false;
            txtbxNewPassword.Visible =false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            EnableChangePass();
        }
    }
}
