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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cartesianchartYearly = new LiveCharts.WinForms.CartesianChart();
            this.piechartTour = new LiveCharts.WinForms.PieChart();
            this.btnViewYearlyReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthlyReport = new Guna.UI2.WinForms.Guna2Button();
            this.columnchartYearly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_report = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tour_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnViewTourReport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbxYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.columnchartYearly)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianchartYearly
            // 
            this.cartesianchartYearly.Location = new System.Drawing.Point(8, 441);
            this.cartesianchartYearly.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianchartYearly.Name = "cartesianchartYearly";
            this.cartesianchartYearly.Size = new System.Drawing.Size(1147, 347);
            this.cartesianchartYearly.TabIndex = 0;
            this.cartesianchartYearly.Text = "cartesianChart1";
            // 
            // piechartTour
            // 
            this.piechartTour.Location = new System.Drawing.Point(735, 36);
            this.piechartTour.Margin = new System.Windows.Forms.Padding(4);
            this.piechartTour.Name = "piechartTour";
            this.piechartTour.Size = new System.Drawing.Size(420, 316);
            this.piechartTour.TabIndex = 1;
            this.piechartTour.Text = "pieChart1";
            // 
            // btnViewYearlyReport
            // 
            this.btnViewYearlyReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewYearlyReport.ForeColor = System.Drawing.Color.White;
            this.btnViewYearlyReport.Location = new System.Drawing.Point(733, 8);
            this.btnViewYearlyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewYearlyReport.Name = "btnViewYearlyReport";
            this.btnViewYearlyReport.Size = new System.Drawing.Size(180, 55);
            this.btnViewYearlyReport.TabIndex = 1;
            this.btnViewYearlyReport.Text = "View Year Reports";
            this.btnViewYearlyReport.Click += new System.EventHandler(this.btnViewYearlyReport_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonthlyReport.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyReport.Location = new System.Drawing.Point(921, 8);
            this.btnMonthlyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(180, 55);
            this.btnMonthlyReport.TabIndex = 0;
            this.btnMonthlyReport.Text = "View Monthly Reports";
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // columnchartYearly
            // 
            chartArea1.Name = "ChartArea1";
            this.columnchartYearly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.columnchartYearly.Legends.Add(legend1);
            this.columnchartYearly.Location = new System.Drawing.Point(8, 9);
            this.columnchartYearly.Margin = new System.Windows.Forms.Padding(4);
            this.columnchartYearly.Name = "columnchartYearly";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.columnchartYearly.Series.Add(series1);
            this.columnchartYearly.Size = new System.Drawing.Size(746, 411);
            this.columnchartYearly.TabIndex = 3;
            this.columnchartYearly.Text = "chart1";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1200, 945);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 4;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cartesianchartYearly);
            this.tabPage1.Controls.Add(this.columnchartYearly);
            this.tabPage1.Controls.Add(this.piechartTour);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1192, 897);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_report);
            this.tabPage2.Controls.Add(this.guna2HtmlLabel3);
            this.tabPage2.Controls.Add(this.btnViewTourReport);
            this.tabPage2.Controls.Add(this.btnViewYearlyReport);
            this.tabPage2.Controls.Add(this.guna2HtmlLabel2);
            this.tabPage2.Controls.Add(this.btnMonthlyReport);
            this.tabPage2.Controls.Add(this.cbbxYear);
            this.tabPage2.Controls.Add(this.cbbxMonth);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1192, 897);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_report.ColumnHeadersHeight = 25;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tour_id,
            this.TEN,
            this.Income,
            this.Month,
            this.Year});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_report.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_report.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_report.Location = new System.Drawing.Point(7, 105);
            this.dgv_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.RowHeadersVisible = false;
            this.dgv_report.RowHeadersWidth = 51;
            this.dgv_report.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_report.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgv_report.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_report.RowTemplate.DividerHeight = 5;
            this.dgv_report.RowTemplate.Height = 40;
            this.dgv_report.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_report.Size = new System.Drawing.Size(1182, 684);
            this.dgv_report.TabIndex = 59;
            this.dgv_report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_report.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_report.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_report.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_report.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgv_report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_report.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_report.ThemeStyle.ReadOnly = false;
            this.dgv_report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_report.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_report.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_report.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_report_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // tour_id
            // 
            this.tour_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tour_id.DataPropertyName = "ID";
            this.tour_id.FillWeight = 288.7687F;
            this.tour_id.HeaderText = "ID";
            this.tour_id.MinimumWidth = 6;
            this.tour_id.Name = "tour_id";
            this.tour_id.Width = 150;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TOURNAME";
            this.TEN.FillWeight = 16.19263F;
            this.TEN.HeaderText = "Name";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            // 
            // Income
            // 
            this.Income.DataPropertyName = "INCOME";
            this.Income.HeaderText = "Income";
            this.Income.MinimumWidth = 6;
            this.Income.Name = "Income";
            // 
            // Month
            // 
            this.Month.DataPropertyName = "MONTH";
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "YEAR";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(16, 18);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(68, 33);
            this.guna2HtmlLabel3.TabIndex = 58;
            this.guna2HtmlLabel3.Text = "Year: ";
            // 
            // btnViewTourReport
            // 
            this.btnViewTourReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewTourReport.ForeColor = System.Drawing.Color.White;
            this.btnViewTourReport.Location = new System.Drawing.Point(545, 8);
            this.btnViewTourReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewTourReport.Name = "btnViewTourReport";
            this.btnViewTourReport.Size = new System.Drawing.Size(180, 55);
            this.btnViewTourReport.TabIndex = 54;
            this.btnViewTourReport.Text = "View Tour Report";
            this.btnViewTourReport.Click += new System.EventHandler(this.btnViewTourReport_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(267, 18);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(86, 33);
            this.guna2HtmlLabel2.TabIndex = 57;
            this.guna2HtmlLabel2.Text = "Month: ";
            // 
            // cbbxYear
            // 
            this.cbbxYear.BackColor = System.Drawing.Color.Transparent;
            this.cbbxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxYear.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxYear.FormattingEnabled = true;
            this.cbbxYear.ItemHeight = 30;
            this.cbbxYear.Location = new System.Drawing.Point(97, 18);
            this.cbbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbbxYear.Name = "cbbxYear";
            this.cbbxYear.Size = new System.Drawing.Size(160, 36);
            this.cbbxYear.TabIndex = 56;
            this.cbbxYear.SelectedValueChanged += new System.EventHandler(this.cbbxYear_SelectedValueChanged);
            // 
            // cbbxMonth
            // 
            this.cbbxMonth.BackColor = System.Drawing.Color.Transparent;
            this.cbbxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxMonth.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxMonth.FormattingEnabled = true;
            this.cbbxMonth.ItemHeight = 30;
            this.cbbxMonth.Location = new System.Drawing.Point(367, 18);
            this.cbbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbbxMonth.Name = "cbbxMonth";
            this.cbbxMonth.Size = new System.Drawing.Size(160, 36);
            this.cbbxMonth.TabIndex = 55;
            this.cbbxMonth.SelectedValueChanged += new System.EventHandler(this.cbbxMonth_SelectedValueChanged);
            // 
            // ReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 945);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 945);
            this.Name = "ReportChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportChart";
            ((System.ComponentModel.ISupportInitialize)(this.columnchartYearly)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianchartYearly;
        private LiveCharts.WinForms.PieChart piechartTour;
        private Guna.UI2.WinForms.Guna2Button btnViewYearlyReport;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart columnchartYearly;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxYear;
        private Guna.UI2.WinForms.Guna2Button btnViewTourReport;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxMonth;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tour_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}