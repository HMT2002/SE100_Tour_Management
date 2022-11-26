namespace Tour
{
    partial class ReportChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cartesianchartYearly = new LiveCharts.WinForms.CartesianChart();
            this.piechartTour = new LiveCharts.WinForms.PieChart();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbxYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnViewYearlyReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthlyReport = new Guna.UI2.WinForms.Guna2Button();
            this.columnchartYearly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnchartYearly)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianchartYearly
            // 
            this.cartesianchartYearly.Location = new System.Drawing.Point(12, 240);
            this.cartesianchartYearly.Name = "cartesianchartYearly";
            this.cartesianchartYearly.Size = new System.Drawing.Size(1192, 237);
            this.cartesianchartYearly.TabIndex = 0;
            this.cartesianchartYearly.Text = "cartesianChart1";
            // 
            // piechartTour
            // 
            this.piechartTour.Location = new System.Drawing.Point(589, 12);
            this.piechartTour.Name = "piechartTour";
            this.piechartTour.Size = new System.Drawing.Size(323, 222);
            this.piechartTour.TabIndex = 1;
            this.piechartTour.Text = "pieChart1";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GradientPanel1.Controls.Add(this.cbbxYear);
            this.guna2GradientPanel1.Controls.Add(this.btnViewYearlyReport);
            this.guna2GradientPanel1.Controls.Add(this.btnMonthlyReport);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(918, 12);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(289, 222);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(37, 12);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(55, 27);
            this.guna2HtmlLabel3.TabIndex = 57;
            this.guna2HtmlLabel3.Text = "Year: ";
            // 
            // cbbxYear
            // 
            this.cbbxYear.BackColor = System.Drawing.Color.Transparent;
            this.cbbxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxYear.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxYear.FocusedState.Parent = this.cbbxYear;
            this.cbbxYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxYear.FormattingEnabled = true;
            this.cbbxYear.HoverState.Parent = this.cbbxYear;
            this.cbbxYear.ItemHeight = 30;
            this.cbbxYear.ItemsAppearance.Parent = this.cbbxYear;
            this.cbbxYear.Location = new System.Drawing.Point(132, 3);
            this.cbbxYear.Name = "cbbxYear";
            this.cbbxYear.ShadowDecoration.Parent = this.cbbxYear;
            this.cbbxYear.Size = new System.Drawing.Size(154, 36);
            this.cbbxYear.TabIndex = 55;
            this.cbbxYear.SelectedValueChanged += new System.EventHandler(this.cbbxYear_SelectedValueChanged);
            // 
            // btnViewYearlyReport
            // 
            this.btnViewYearlyReport.CheckedState.Parent = this.btnViewYearlyReport;
            this.btnViewYearlyReport.CustomImages.Parent = this.btnViewYearlyReport;
            this.btnViewYearlyReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewYearlyReport.ForeColor = System.Drawing.Color.White;
            this.btnViewYearlyReport.HoverState.Parent = this.btnViewYearlyReport;
            this.btnViewYearlyReport.Location = new System.Drawing.Point(106, 102);
            this.btnViewYearlyReport.Name = "btnViewYearlyReport";
            this.btnViewYearlyReport.ShadowDecoration.Parent = this.btnViewYearlyReport;
            this.btnViewYearlyReport.Size = new System.Drawing.Size(180, 45);
            this.btnViewYearlyReport.TabIndex = 1;
            this.btnViewYearlyReport.Text = "View Tour Reports";
            this.btnViewYearlyReport.Click += new System.EventHandler(this.btnViewYearlyReport_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.CheckedState.Parent = this.btnMonthlyReport;
            this.btnMonthlyReport.CustomImages.Parent = this.btnMonthlyReport;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonthlyReport.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyReport.HoverState.Parent = this.btnMonthlyReport;
            this.btnMonthlyReport.Location = new System.Drawing.Point(106, 153);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.ShadowDecoration.Parent = this.btnMonthlyReport;
            this.btnMonthlyReport.Size = new System.Drawing.Size(180, 45);
            this.btnMonthlyReport.TabIndex = 0;
            this.btnMonthlyReport.Text = "View Monthly Reports";
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // columnchartYearly
            // 
            chartArea2.Name = "ChartArea1";
            this.columnchartYearly.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.columnchartYearly.Legends.Add(legend2);
            this.columnchartYearly.Location = new System.Drawing.Point(12, 12);
            this.columnchartYearly.Name = "columnchartYearly";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.columnchartYearly.Series.Add(series2);
            this.columnchartYearly.Size = new System.Drawing.Size(571, 222);
            this.columnchartYearly.TabIndex = 3;
            this.columnchartYearly.Text = "chart1";
            // 
            // ReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 489);
            this.Controls.Add(this.columnchartYearly);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.piechartTour);
            this.Controls.Add(this.cartesianchartYearly);
            this.Name = "ReportChart";
            this.Text = "ReportChart";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnchartYearly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianchartYearly;
        private LiveCharts.WinForms.PieChart piechartTour;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnViewYearlyReport;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyReport;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart columnchartYearly;
    }
}