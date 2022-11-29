using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using Tour.Model;
using Tour.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tour
{
    public partial class forgotpass : Form
    {
        string randomcode;
        public static string to;
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
        public forgotpass()
        {
            InitializeComponent();
            emailtxb.ForeColor = Color.LightGray;
            emailtxb.Text = "Enter Your Email";
            this.emailtxb.Leave += new System.EventHandler(this.textBox1_Leave);
            this.emailtxb.Enter += new System.EventHandler(this.textBox1_Enter);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (emailtxb.Text == "")
            {
                emailtxb.ForeColor = Color.LightGray;
                emailtxb.Text = "Enter Your Email";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (emailtxb.Text == "Enter Your Email")
            {
                emailtxb.Text = "";
                emailtxb.ForeColor = Color.Black;
            }
        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (emailtxb.Text.Trim() == "")
            {
                Notify.NotificationField(emailtxb);
                MessageBox.Show("Empty mail address");
                return;
            }
            if (DataProvider.Ins.DB.ACCOUNTs.Where(x => x.ACC == emailtxb.Text.Trim() && x.IsDeleted == false).FirstOrDefault() != null)
            {
                try
                {
                    string email = emailtxb.Text.ToString();
                    randomcode = Converter.Instance.RandomString2(5);
                    List<string> listto = new List<string>();
                    listto.Add(email);
                    Utils.Features.Instance.SendMail(listto, "Verify code", "Verify code to change password: " + randomcode);


                    label2.Visible = true;
                    codetxb.Visible = true;
                    verifybtn.Visible = true;
                    sendbtn.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check your internet connection");
                    return;
                }

            }

            MessageBox.Show("Please check your mail box");

        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            if (randomcode == (codetxb.Text).ToString())
            {
                to = emailtxb.Text.Trim();
                ChangePass change = new ChangePass(DataProvider.Ins.DB.ACCOUNTs.Where(x=>x.ACC==to).FirstOrDefault());
                this.Close();
                change.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong reset Code!!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm change = new LoginForm();
            this.Hide();
            change.ShowDialog();
            this.Show();
        }

        private void emailtxb_Validated(object sender, EventArgs e)
        {
            if (emailtxb.Text.Length > 0)
            {
                if (!rEMail.IsMatch(emailtxb.Text))
                {
                    MessageBox.Show("Invalidate Email", "Error");
                    emailtxb.SelectAll();
                    sendbtn.Enabled = false;
                    //e.Cancel = true;
                }
                else
                {
                    sendbtn.Enabled = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.UnnotificationField(sender);
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void codetxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.UnnotificationField(sender);

        }
    }
}
