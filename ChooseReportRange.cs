using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.CrystalReport;
using Tour.Model;

namespace Tour
{
    public partial class ChooseReportRange : Form
    {

        public TOUR Tour = null;
        public ChooseReportRange()
        {
            InitializeComponent();
        }

        public ChooseReportRange(TOUR tour)
        {
            InitializeComponent();
            this.Tour = tour;
            LoadData();
        }

        private void LoadData()
        {
            var listMonth = (from tour in DataProvider.Ins.DB.TOURs
                             join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                             join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                             where tour.ID == this.Tour.ID && tour.IsDeleted == false
                             select ve.NGAYMUA.Value.Month)
                                     .Distinct().ToList();
            var listYear = (from tour in DataProvider.Ins.DB.TOURs
                             join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                             join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                             where tour.ID == this.Tour.ID && tour.IsDeleted == false
                             select ve.NGAYMUA.Value.Year)
                         .Distinct().ToList();

            cbbxMonth.DataSource = listMonth;
            cbbxYear.DataSource = listYear;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (this.Tour == null)
            {
                return;
            }
            //MessageBox.Show(cbbxMonth.SelectedValue.ToString() + "  " + cbbxYear.SelectedValue.ToString());
            //return;
            using (fPrint f = new fPrint(this.Tour))
            {
                rptTourIncome crys = new rptTourIncome();
                crys.Load(@"rptTourIncome.rep");

                f.rptViewer.ReportSource = crys;
                f.rptViewer.Refresh();
                f.rptViewer.SelectionFormula = "{Command.TourID}='" + this.Tour.ID + "' and {Command.NAM}="+cbbxYear.SelectedValue.ToString()+ " and {Command.THANG}="+cbbxMonth.SelectedValue.ToString();
                f.ShowDialog();
            }
        }
    }
}
