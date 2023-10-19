using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows.Forms;
using Tour.Model;

namespace Tour
{
    public partial class SearchTicket : Form
    {
        string Ticket_id;

        VE Ve=new VE();

        public SearchTicket()
        {
            InitializeComponent();

        }

        public SearchTicket(string ticket_id)
        {
            InitializeComponent();

            this.Ticket_id = ticket_id;

        }

        public SearchTicket(VE ve)
        {
            InitializeComponent();

            this.Ve = ve;
            LoadData();
        }

        private void LoadData()
        {
            lblReciptCustomerName.Text = this.Ve.KHACHHANG.TENKH;
            lblReciptPrice.Text =Utils.Converter.Instance.CurrencyDisplay((decimal) this.Ve.GIA);
            lblReciptTourName.Text = this.Ve.DOAN.TOUR.TEN;
            lblReciptGroupName.Text = this.Ve.DOAN.TEN;
            lblReciptStartDate.Text=this.Ve.DOAN.NGAYKHOIHANH.Value.ToString("dd/MM/yyyy");
            lblReciptEndDate.Text = this.Ve.DOAN.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
            lblReciptTicketID.Text = this.Ve.ID;
            lbDate.Text=this.Ve.NGAYMUA.Value.ToString("dd/MM/yyyy");
        }

        private void SearchTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if (this.Ve == null)
            {
                return;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime itime = DateTime.Now;
            lbTime.Text = itime.ToLongTimeString();

            DateTime idate = DateTime.Now;
            lbDate.Text = idate.ToLongDateString();
        }
    }
}
