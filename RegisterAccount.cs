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
            InitializeComponent();
        }

        bool CheckDuplicateEmail(string email)
        {
            string query = "select * from User where Email='" + email + "'";

            return false;
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {

            if (CheckDuplicateEmail(txbGmail.Text) == true)
            {
                MessageBox.Show("Your Email is already in use");
            }
            else if (txbGmail.Text == "" || txbHo.Text == "" || txbTen.Text == "" || txbSDT.Text == "")
            {
                MessageBox.Show("Please enter FULL INFORMATION!!!");
            }
            else if (txbPass.Text == "")
                MessageBox.Show("Please Enter Password!!!");
            else if (txbConfirm.Text != txbPass.Text)
                MessageBox.Show("Password not match!!!");
            //else if (randomcode != txbCode.Text.ToString() || txbGmail.Text.ToString() != email)
            //{
            //    MessageBox.Show("Code Box is wrong or empty!!!");
            //}
            else
            {
                label12.Text = "Checked";
                label12.ForeColor = Color.Green;
                SignUpbtn.Enabled = true;
                try
                {

                    var nv = new NHANVIEN() { ID = randomcode,  TEN = txbHo.Text+" "+ txbTen.Text, SDT = txbSDT.Text, MAIL = txbGmail.Text,PICBI=img_data };
                    var account = new ACCOUNT() { ACC = txbGmail.Text, PASS = Converter.Instance.MD5Encrypt(Converter.Instance.Base64Encode(txbPass.Text)), ID = randomcode, IDNHANVIEN = randomcode,IsDeleted=false };
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
        }

        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        string email;
        private void txbGmail_Validating(object sender, CancelEventArgs e)
        {
            if (txbGmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txbGmail.Text))
                {
                    MessageBox.Show("Invalidate Email", "Error");
                    txbGmail.SelectAll();
                    SignUpbtn.Enabled = false;
                    //e.Cancel = true;
                }
                else
                {
                    SignUpbtn.Enabled = true;
                }
            }
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txbGmail.Text.Length > 0)
            {
                if (rEMail.IsMatch(txbGmail.Text))
                {
                    email = txbGmail.Text.ToString();
                    string from, pass, messageBody;
                    Random random = new Random();
                    randomcode = Converter.Instance.RandomString(5);
                    List<string> listto = new List<string>();
                    listto.Add(email);
                    //MailMessage message = new MailMessage();
                    //to = (txbGmail.Text).ToString();
                    //from = "PTS.UIT.Group@gmail.com";
                    //pass = "PTS@uitGroup";
                    //messageBody = "Verification code exists for your email :" + randomcode;
                    //message.To.Add(to);
                    //message.From = new MailAddress(from);
                    //message.Body = messageBody;
                    //message.Subject = "Confirm Email Code";
                    //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    //smtp.EnableSsl = true;
                    //smtp.Port = 587;
                    //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        Utils.Features.Instance.SendMail(listto, "Verify code", randomcode);
                        label12.Text = "Code send success!!!";
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
