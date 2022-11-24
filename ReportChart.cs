﻿using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class ReportChart : Form
    {
        public int selected_year = 0;


        public ReportChart()
        {
            InitializeComponent();
            EnableCalendarSource();
            LoadCharts();
        }

        //List<string> listMonth = new List<string>();
        List<string> listYear = new List<string>();


        public void EnableCalendarSource()
        {

            //listMonth = (from tour in DataProvider.Ins.DB.TOURs
            //             join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
            //             join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
            //             where tour.IsDeleted == false
            //             select ve.NGAYMUA.Value.Month.ToString())
            //         .Distinct().ToList();
            listYear = (from tour in DataProvider.Ins.DB.TOURs
                        join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                        join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                        where tour.IsDeleted == false
                        select ve.NGAYMUA.Value.Year.ToString())
                         .Distinct().ToList();

            cbbxYear.DataSource = listYear;
            selected_year = Convert.ToInt32(cbbxYear.SelectedValue);
        }

        public void OpenReportYearly()
        {
            using (fPrint f = new fPrint())
            {
                rptYearly crys = new rptYearly();
                crys.Load(@"rptYearly.rep");

                f.rptViewer.ReportSource = crys;
                f.rptViewer.Refresh();
                f.rptViewer.SelectionFormula = "{Command.NAM}=" + cbbxYear.SelectedValue.ToString();
                f.ShowDialog();
            }
        }

        public void OpenReportYearlyTour()
        {
            using (fPrint f = new fPrint())
            {
                rptYearly crys = new rptYearly();
                crys.Load(@"rptYearly.rep");

                f.rptViewer.ReportSource = crys;
                f.rptViewer.Refresh();
                f.rptViewer.SelectionFormula = "{Command.NAM}=" + cbbxYear.SelectedValue.ToString();
                f.ShowDialog();
            }
        }

        private void OpenReportMonthly()
        {
            using (fPrint f = new fPrint())
            {
                rptMonthly crys = new rptMonthly();
                crys.Load(@"rptYearly.rep");

                f.rptViewer.ReportSource = crys;
                f.rptViewer.Refresh();
                f.rptViewer.SelectionFormula = "{Command.NAM}=" + cbbxYear.SelectedValue.ToString();
                f.ShowDialog();
            }
        }

        public void LoadCharts()
        {
            LoadCartesianChartYearly();
            LoadPieChartTour();
            LoadColumnChartYearly();
        }



        public void SetUpCartesianChartYearly()
        {
            cartesianchartYearly.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", },

            });
            cartesianchartYearly.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C"),

            });

            cartesianchartYearly.LegendLocation = LiveCharts.LegendLocation.Right;

        }

        public void LoadSeriesCartesianChartYearly()
        {
            cartesianchartYearly.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            var tours = (from tour in DataProvider.Ins.DB.TOURs
                         join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                         join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                         where tour.IsDeleted == false && ve.IsDeleted == false && doan.IsDeleted == false && ve.NGAYMUA.Value.Year == selected_year
                         group tour by new { tour.ID, tour.TEN } into g
                         select new
                         {
                             ID = g.Key.ID,
                             TEN = g.Key.TEN,
                         })
                         .Distinct().ToList();

            foreach (var tour in tours)
            {
                List<decimal> value = new List<decimal>();
                for (int month = 1; month <= 12; month++)
                {
                    var ves = (from doan in DataProvider.Ins.DB.DOANs
                               join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                               where ve.IsDeleted == false
                               && ve.NGAYMUA.Value.Month == month
                               && ve.DOAN.TOUR.ID == tour.ID
                               && ve.NGAYMUA.Value.Year == selected_year
                               && doan.IsDeleted == false
                               select ve)
                             .Distinct().ToList();
                    decimal tong_ve = 0;
                    foreach (var ve in ves)
                    {
                        tong_ve += (decimal)ve.GIA;
                    }
                    value.Add((decimal)tong_ve);

                }

                series.Add(new LineSeries() { Title = tour.TEN, Values = new ChartValues<decimal>(value) });
            }

            cartesianchartYearly.Series = series;

        }

        private void LoadCartesianChartYearly()
        {
            SetUpCartesianChartYearly();
            LoadSeriesCartesianChartYearly();
        }


        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:})", chartpoint.Y, chartpoint.Participation);


        public void SetUpPieChartTour()
        {
            piechartTour.LegendLocation = LegendLocation.Right;
        }

        public void LoadSeriesPieChartTour()
        {
            piechartTour.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            var tours = (from tour in DataProvider.Ins.DB.TOURs
                         join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                         join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                         where tour.IsDeleted == false && ve.IsDeleted == false && doan.IsDeleted == false && ve.NGAYMUA.Value.Year == selected_year
                         group tour by new { tour.ID, tour.TEN, ve.NGAYMUA.Value.Year } into g
                         select new
                         {
                             ID = g.Key.ID,
                             TEN = g.Key.TEN,
                         })
             .Distinct().ToList();

            //var tours = (from tour in DataProvider.Ins.DB.TOURs
            //             join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
            //             join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
            //             where tour.IsDeleted == false && ve.IsDeleted == false && doan.IsDeleted == false && ve.NGAYMUA.Value.Year == selected_year
            //             group tour by new { tour.ID, tour.TEN,ve.NGAYMUA.Value.Year} into g
            //             select new
            //             {
            //                 ID = g.Key.ID,
            //                 TEN = g.Key.TEN,
            //                 REVENUE=g.Sum(s=>s.),
            //                 YEAR=g.Key.Year,

            //             }).Distinct().ToList();

            foreach (var tour in tours)
            {
                List<decimal> value = new List<decimal>();
                    var ves = (from doan in DataProvider.Ins.DB.DOANs
                               join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                               where ve.IsDeleted == false
                               && ve.DOAN.TOUR.ID==tour.ID
                               && ve.DOAN.TOUR.ID == tour.ID
                               && ve.NGAYMUA.Value.Year == selected_year
                               && doan.IsDeleted == false
                               select ve)
                             .Distinct().ToList();
                    decimal tong_ve = 0;
                    foreach (var ve in ves)
                    {
                        tong_ve += (decimal)ve.GIA;
                    }
                    value.Add((decimal)tong_ve);

                series.Add(new PieSeries()
                {
                    Title = tour.TEN,
                    Values = new ChartValues<decimal>(value),
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            piechartTour.Series = series;
        }

        private void LoadPieChartTour()
        {
            SetUpPieChartTour();
            LoadSeriesPieChartTour();
        }


        public void ClearColumnChartYearly()
        {
            foreach (var series in columnchartYearly.Series)
            {
                series.Points.Clear();
            }
        }

        private void LoadColumnChartYearly()
        {
            ClearColumnChartYearly();
            for (int month = 1; month <= 12; month++)
            {

                var ves = (from ve in DataProvider.Ins.DB.VEs
                           where ve.IsDeleted == false && ve.NGAYMUA.Value.Month == month && ve.NGAYMUA.Value.Year == selected_year
                           select ve)
                            .Distinct().ToList();
                decimal tong_ve = 0;
                foreach (var ve in ves)
                {

                    tong_ve += (decimal)ve.GIA;
                }

                columnchartYearly.Series["Revenue"].Points.AddXY(month.ToString(), tong_ve);

            }

        }

        private void btnViewYearlyReport_Click(object sender, EventArgs e)
        {
            OpenReportYearlyTour();
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            OpenReportMonthly();
        }

        private void cbbxYear_SelectedValueChanged(object sender, EventArgs e)
        {
            selected_year = Convert.ToInt32(cbbxYear.SelectedValue);
            LoadSeriesCartesianChartYearly();
            LoadSeriesPieChartTour();
            LoadColumnChartYearly();
        }
    }
}