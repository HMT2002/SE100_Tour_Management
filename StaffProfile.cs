using System;
using System.Collections.Generic;
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
using System.Security.Cryptography;
using Tour.Model;

namespace Tour
{
    public partial class StaffProfile : Form
    {

        public StaffProfile()
        {
            InitializeComponent();
        }

        private void StaffProfile_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txbGmail.Text = Properties.Settings.Default.UserName;
            }

            string query = "Select Ho,Ten,SDT from User where Email='" + Properties.Settings.Default.UserName + "'";

            //MessageBox.Show(Properties.Settings.Default.UserName + " " + )

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
