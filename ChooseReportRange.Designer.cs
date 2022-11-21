namespace Tour
{
    partial class ChooseReportRange
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
            this.cbbxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbxYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnShowReport = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cbbxMonth
            // 
            this.cbbxMonth.BackColor = System.Drawing.Color.Transparent;
            this.cbbxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxMonth.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxMonth.FocusedState.Parent = this.cbbxMonth;
            this.cbbxMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxMonth.FormattingEnabled = true;
            this.cbbxMonth.HoverState.Parent = this.cbbxMonth;
            this.cbbxMonth.ItemHeight = 30;
            this.cbbxMonth.ItemsAppearance.Parent = this.cbbxMonth;
            this.cbbxMonth.Location = new System.Drawing.Point(12, 12);
            this.cbbxMonth.Name = "cbbxMonth";
            this.cbbxMonth.ShadowDecoration.Parent = this.cbbxMonth;
            this.cbbxMonth.Size = new System.Drawing.Size(193, 36);
            this.cbbxMonth.TabIndex = 0;
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
            this.cbbxYear.Location = new System.Drawing.Point(211, 12);
            this.cbbxYear.Name = "cbbxYear";
            this.cbbxYear.ShadowDecoration.Parent = this.cbbxYear;
            this.cbbxYear.Size = new System.Drawing.Size(252, 36);
            this.cbbxYear.TabIndex = 1;
            // 
            // btnShowReport
            // 
            this.btnShowReport.CheckedState.Parent = this.btnShowReport;
            this.btnShowReport.CustomImages.Parent = this.btnShowReport;
            this.btnShowReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowReport.ForeColor = System.Drawing.Color.White;
            this.btnShowReport.HoverState.Parent = this.btnShowReport;
            this.btnShowReport.Location = new System.Drawing.Point(469, 12);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.ShadowDecoration.Parent = this.btnShowReport;
            this.btnShowReport.Size = new System.Drawing.Size(174, 85);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Show report";
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // ChooseReportRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 109);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.cbbxYear);
            this.Controls.Add(this.cbbxMonth);
            this.Name = "ChooseReportRange";
            this.Text = "ChooseReportRange";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbbxMonth;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxYear;
        private Guna.UI2.WinForms.Guna2Button btnShowReport;
    }
}