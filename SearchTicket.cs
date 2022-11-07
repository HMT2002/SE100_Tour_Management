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

namespace Tour
{
    public partial class SearchTicket : Form
    {
        string Ticket_id;
        public SearchTicket()
        {
            InitializeComponent();
        }

        public SearchTicket(string ticket_id)
        {
            InitializeComponent();

            this.Ticket_id = ticket_id;

        }

        private void SearchTicket_Load(object sender, EventArgs e)
        {
            showAll();
        }

        private void showAll()
        {
            dgvTicket.DataSource = (from doan in DataProvider.Ins.DB.DOANs
                                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                    join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                                    join khachhang in DataProvider.Ins.DB.KHACHHANGs on ve.IDKHACH equals khachhang.ID
                                    where ve.ID==this.Ticket_id && doan.IsDeleted == false && tour.IsDeleted == false && ve.IsDeleted == false && khachhang.IsDeleted == false

                                    select new
                                    {
                                        ID = ve.ID,
                                        TEN_KH = khachhang.TENKH,
                                        TEN_DOAN = doan.TEN,
                                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                        NGAYTROVE = doan.NGAYKETTHUC,
                                        GIA_TOUR = tour.GIA,
                                        TEN_TOUR = tour.TEN,
                                    }).ToList();
        }
    }
}
