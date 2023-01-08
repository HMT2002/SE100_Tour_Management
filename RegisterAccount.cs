using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;
using Tour.Utils;
using Tour.Model;
using Org.BouncyCastle.Utilities.Net;
using System.Xml.Linq;

namespace Tour
{
    public partial class RegisterAccount : Form
    {
        string randomcode;
        public static string to;
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

        Image img;
        Byte[] img_data = null;

        public RegisterAccount()
        {
            /*String a = Converter.Instance.MD5Decrypt("f4pA3ImzdFIU5/zNCSNOuA==");
            txbHo.Text = Converter.Instance.DecryptEncrypt("Q5YjLGwD3qo=");*/
            InitializeComponent();
        }

        bool CheckDuplicateEmail(string email)
        {
            string query = "select * from User where Email='" + email + "'";

            return false;
        }

        public bool CheckData()
        {
            bool flag = true;

            if (CheckDuplicateEmail(txbGmail.Text) == true)
            {
                MessageBox.Show("Your Email is already in use");
                flag = false;
            }
            if (txbGmail.Text == "")
            {
                Utils.Notify.NotificationField(txbGmail);
                flag = false;

            }

            if (txbHo.Text == "")
            {
                Utils.Notify.NotificationField(txbHo);
                flag = false;
            }
            if (txbTen.Text == "")
            {
                Utils.Notify.NotificationField(txbTen);
                flag = false;
            }
            if(txbSDT.Text == "")
            {
                Utils.Notify.NotificationField(txbSDT);
                flag = false;
            }

            if (txbPass.Text == "")
            {
                Utils.Notify.NotificationField(txbPass);
                flag = false;

            }

            if (txbConfirm.Text =="")
            {
                Utils.Notify.NotificationField(txbConfirm);

                flag = false;

            }
            if (txbConfirm.Text != txbPass.Text)
            {
                MessageBox.Show("Password not match!!!");
                Utils.Notify.NotificationField(txbConfirm);
                Utils.Notify.NotificationField(txbPass);

                flag = false;

            }
            if (randomcode != txbCode.Text.ToString() || txbGmail.Text.ToString() != email)
            {
                MessageBox.Show("Code Box is wrong or empty!!!");
                Utils.Notify.NotificationField(txbCode);

                flag = false;

            }


            return flag;
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                label12.Text = "";
                label12.ForeColor = Color.Green;
                SignUpbtn.Enabled = true;
                try
                {

                    int id_num = 1;
                    string id = "NV" + id_num;

                    while (DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == id).FirstOrDefault() != null)
                    {
                        id_num++;
                        id = "NV" + id_num.ToString();
                    }

                    var nv = new NHANVIEN() { ID = id,  TEN = txbHo.Text+" "+ txbTen.Text, SDT = txbSDT.Text, MAIL = txbGmail.Text,PICBI=img_data,IsDeleted=false,isAvailable=true,SLDI = 0,IDACC= id };
                    var account = new ACCOUNT() { ACC = txbGmail.Text, PASS = Converter.Instance.EncryptPassword( (txbPass.Text)), ID = id,IsDeleted=false,ACCROLE="Employee" };
                    DataProvider.Ins.DB.ACCOUNTs.Add(account);
                    DataProvider.Ins.DB.NHANVIENs.Add(nv);

                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("SignUp success!!!");
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

        }
        void Clear()
        {
            txbHo.Text = txbTen.Text = txbSDT.Text = txbGmail.Text = txbPass.Text = txbConfirm.Text = "";
            UnnotifyAllFields();
        }

        public void UnnotifyAllFields()
        {
            Notify.UnnotificationField(txbHo);
            Notify.UnnotificationField(txbTen);
            Notify.UnnotificationField(txbSDT);
            Notify.UnnotificationField(txbGmail);
            Notify.UnnotificationField(txbPass);
            Notify.UnnotificationField(txbConfirm);


        }

        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        string email;
        private void txbGmail_Validating(object sender, CancelEventArgs e)
        {
            //if (txbGmail.Text.Length > 0)
            //{
            //    if (!rEMail.IsMatch(txbGmail.Text))
            //    {
            //        MessageBox.Show("Invalidate Email", "Error");
            //        txbGmail.SelectAll();
            //        SignUpbtn.Enabled = false;
            //        //e.Cancel = true;
            //    }
            //    else
            //    {
            //        SignUpbtn.Enabled = true;
            //    }
            //}
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txbGmail.Text.Length > 0)
            {
                if (rEMail.IsMatch(txbGmail.Text))
                {
                    email = txbGmail.Text.ToString();
                    randomcode = Converter.Instance.RandomString2(5);
                    List<string> listto = new List<string>();
                    listto.Add(email);
                    try
                    {
                        Utils.Features.Instance.SendMail(listto, "Verify code","Verify code to register account: "+ randomcode);
                        label12.Text = "Sent!!!";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void txbGmail_TextChanged(object sender, EventArgs e)
        {
            txbCode.Text = "";
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPickPicture_Click(object sender, EventArgs e)
        {

        }

        private void SignUpbtn_MouseHover(object sender, EventArgs e)
        {
            SignUpbtn.BackColor = Color.Green;
            SignUpbtn.ForeColor = Color.White;
            SignUpbtn.ShadowDecoration.Enabled = true;
        }

        private void SignUpbtn_MouseLeave(object sender, EventArgs e)
        {
            SignUpbtn.BackColor= Color.FromArgb(94, 148, 255);
            SignUpbtn.ForeColor = Color.White;
            SignUpbtn.ShadowDecoration.Enabled = false;
        }

        private void Cancelbtn_MouseHover(object sender, EventArgs e)
        {
            Cancelbtn.BackColor = Color.Red;
            Cancelbtn.ForeColor = Color.White;
        }

        private void Cancelbtn_MouseLeave(object sender, EventArgs e)
        {
            Cancelbtn.BackColor = Color.Transparent;
            Cancelbtn.ForeColor = Color.FromArgb(94, 148, 255);
        }

        private void txbHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                Utils.Validate.CapitaLetter(sender, e);
                return;
            }
            e.Handled = true;
        }

        private void txbTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                Utils.Validate.CapitaLetter(sender, e);
                return;
            }
            e.Handled = true;
        }

        private void txbGmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

        }

        private void txbConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

        }

        private void txbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.Notify.UnnotificationField(sender);

        }

        private void pcbxAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                img = image;
                img_data = Converter.Instance.ImageToByte(image);
                pcbxAvatar.Image = image;

            }
        }
    }
}
