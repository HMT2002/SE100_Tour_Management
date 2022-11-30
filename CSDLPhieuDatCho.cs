using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.CrystalReport;
using Tour.Model;

namespace Tour
{
    public partial class CSDLPhieuDatCho : Form
    {

        string id;

        public VE selected_ve = new VE();

        void Clear()
        {
            this.selected_ve = null;
            lblCustomer.Text = "ID";
            tbName.Text = "";
            tbAddress.Text = "";
            tbCMND.Text = "";
            tbTelephone.Text = "";
            tbEmail.Text = "";
            RdMale.Checked = true;
            tbTourName.Text = "";
            tbGroupName.Text = "";
            tbStartDate.Text = "";
            tbEndDate.Text = "";
            tbPrice.Text = "";
            tbBookDate.Text = "";
        }
        public CSDLPhieuDatCho()
        {

            InitializeComponent();
            dgvTicket.AutoGenerateColumns = false;
        }



        public void ShowAll()
        {
            var ves = (from ve in DataProvider.Ins.DB.VEs
                       join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                       join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                       join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                       where tour.IsDeleted == false && ve.IsDeleted == false && doan.IsDeleted == false && khachhang.IsDeleted == false
                       select new
                       {
                           ID = ve.ID,
                           TENKH = khachhang.TENKH,
                           TOURNAME = tour.TEN,
                           GROUPNAME = doan.TEN,
                           GIA = ve.GIA,
                           BOOKDATE = ve.NGAYMUA,
                       })
                         .ToList();

            dgvTicket.DataSource = ves;
        }

        private void CSDLPhieuDatCho_Load(object sender, EventArgs e)
        {
            ShowAll();
            Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = tbSearchTicket.Text;
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    //if (rdIDSearch.Checked)
                    if (cbbxSearchType.SelectedItem.ToString() == "Ticket ID")
                    {
                        dgvTicket.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                                join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                                                join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                where tour.IsDeleted == false
                                                && ve.IsDeleted == false
                                                && doan.IsDeleted == false
                                                && khachhang.IsDeleted == false
                                                && SqlFunctions.PatIndex("%" + value + "%", ve.ID) > 0
                                                select new
                                                {
                                                    ID = ve.ID,
                                                    TENKH = khachhang.TENKH,
                                                    TOURNAME = tour.TEN,
                                                    GROUPNAME = doan.TEN,
                                                    GIA = ve.GIA,
                                                    BOOKDATE = ve.NGAYMUA,
                                                })
                 .ToList();

                    }
                    //else if (rdNameSearch.Checked)
                    else if (cbbxSearchType.SelectedItem.ToString() == "Customer's name")
                    {
                        dgvTicket.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                                join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                                                join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                where tour.IsDeleted == false
                                                && ve.IsDeleted == false
                                                && doan.IsDeleted == false
                                                && khachhang.IsDeleted == false
                                                && SqlFunctions.PatIndex("%" + value + "%", khachhang.TENKH) > 0
                                                select new
                                                {
                                                    ID = ve.ID,
                                                    TENKH = khachhang.TENKH,
                                                    TOURNAME = tour.TEN,
                                                    GROUPNAME = doan.TEN,
                                                    GIA = ve.GIA,
                                                    BOOKDATE = ve.NGAYMUA,
                                                })
                 .ToList();
                    }
                    else if (cbbxSearchType.SelectedItem.ToString() == "Tour's name")
                    {
                        dgvTicket.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                                join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                                                join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                where tour.IsDeleted == false
                                                && ve.IsDeleted == false
                                                && doan.IsDeleted == false
                                                && khachhang.IsDeleted == false
                                                && SqlFunctions.PatIndex("%" + value + "%", tour.TEN) > 0
                                                select new
                                                {
                                                    ID = ve.ID,
                                                    TENKH = khachhang.TENKH,
                                                    TOURNAME = tour.TEN,
                                                    GROUPNAME = doan.TEN,
                                                    GIA = ve.GIA,
                                                    BOOKDATE = ve.NGAYMUA,
                                                })
                 .ToList();
                    }
                    else if (cbbxSearchType.SelectedItem.ToString() == "Group's name")
                    {
                        dgvTicket.DataSource = (from ve in DataProvider.Ins.DB.VEs
                                                join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                                join doan in DataProvider.Ins.DB.DOANs on ve.IDDOAN equals doan.ID
                                                join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                                where tour.IsDeleted == false
                                                && ve.IsDeleted == false
                                                && doan.IsDeleted == false
                                                && khachhang.IsDeleted == false
                                                && SqlFunctions.PatIndex("%" + value + "%", doan.TEN) > 0
                                                select new
                                                {
                                                    ID = ve.ID,
                                                    TENKH = khachhang.TENKH,
                                                    TOURNAME = tour.TEN,
                                                    GROUPNAME = doan.TEN,
                                                    GIA = ve.GIA,
                                                    BOOKDATE = ve.NGAYMUA,
                                                })
                 .ToList();
                    }
                }
                catch
                {

                }
            }
            else { ShowAll(); }
        }




        private void tbphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearchResID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearchTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTraVe_Click(object sender, EventArgs e)
        {
            if (this.selected_ve == null)
            {
                return;
            }
            if (MessageBox.Show("Are you sure want to return ticket?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    this.selected_ve.IsDeleted = true;
                    DataProvider.Ins.DB.SaveChanges();
                    ShowAll();
                    Clear();
                }
                catch
                {

                }
            }


        }
        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string gender, tourist;
            if (index >= 0)
            {
                id = dgvTicket.Rows[index].Cells["data_id"].Value.ToString();

                this.selected_ve = DataProvider.Ins.DB.VEs.Where(x => x.ID == id && x.IsDeleted == false).FirstOrDefault();

                lblCustomer.Text = selected_ve.KHACHHANG.ID;
                tbName.Text = selected_ve.KHACHHANG.TENKH;
                tbAddress.Text = selected_ve.KHACHHANG.DIACHI;
                tbCMND.Text = selected_ve.KHACHHANG.CMND;
                tbTelephone.Text = selected_ve.KHACHHANG.MAIL;
                tbEmail.Text = selected_ve.KHACHHANG.MAIL;
                if (selected_ve.KHACHHANG.GIOITINH == "Male")
                {
                    RdMale.Checked = true;
                }
                else
                {
                    RdFmale.Checked = true;
                }

                tbTourName.Text = selected_ve.DOAN.TOUR.TEN;
                tbGroupName.Text = selected_ve.DOAN.TEN;
                tbStartDate.Text = selected_ve.DOAN.NGAYKHOIHANH.Value.ToString("dd/MM/yyyy");
                tbEndDate.Text = selected_ve.DOAN.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");


                tbPrice.Text = selected_ve.GIA.ToString();
                tbBookDate.Text = selected_ve.NGAYMUA.Value.ToString("dd/MM/yyyy");

            }
        }
        private void AskForReport()
        {
            if (this.selected_ve == null)
            {
                return;
            }
            if (MessageBox.Show("Do you want to ticket?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                VE ve = DataProvider.Ins.DB.VEs.Where(x => (x.ID == this.selected_ve.ID && x.IsDeleted == false)).SingleOrDefault();

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
        private void btnDel_Click(object sender, EventArgs e)
        {
            AskForReport();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShowAll();
            Clear();
        }


    }
}
