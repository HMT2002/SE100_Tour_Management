using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class ChangePass : Form
    {
        string email = Properties.Settings.Default.UserName;

        public ACCOUNT Account = new ACCOUNT();

        public ChangePass()
        {
            InitializeComponent();
        }

        public ChangePass(ACCOUNT account)
        {
            InitializeComponent();
            this.Account = account;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            if (newpasstxb.Text.Trim() == confirmtxb.Text.Trim() && newpasstxb.Text.Trim() != "")
            {
                this.Account.PASS = Converter.Instance.EncryptPassword(confirmtxb.Text);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Reset password success!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match!!!");
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
