using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour
{
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void btnPickPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(dialog.FileName);
                pcbxLocation.Image = bitmap;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
