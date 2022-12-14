namespace Tour
{
    partial class ListNhanVienAvailable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_nhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_employeeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_nhanvien.ColumnHeadersHeight = 35;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.data_employeeid,
            this.TEN,
            this.SDT,
            this.MAIL,
            this.isAvailable});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhanvien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_nhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanvien.Location = new System.Drawing.Point(12, 11);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersVisible = false;
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_nhanvien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nhanvien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_nhanvien.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nhanvien.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_nhanvien.RowTemplate.DividerHeight = 10;
            this.dgv_nhanvien.RowTemplate.Height = 40;
            this.dgv_nhanvien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1160, 388);
            this.dgv_nhanvien.TabIndex = 33;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_nhanvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_nhanvien.ThemeStyle.ReadOnly = false;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_nhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nhanvien.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // data_employeeid
            // 
            this.data_employeeid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.data_employeeid.DataPropertyName = "ID";
            this.data_employeeid.FillWeight = 288.7687F;
            this.data_employeeid.HeaderText = "ID";
            this.data_employeeid.MinimumWidth = 6;
            this.data_employeeid.Name = "data_employeeid";
            this.data_employeeid.Width = 150;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.FillWeight = 16.19263F;
            this.TEN.HeaderText = "Name";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 16.19263F;
            this.SDT.HeaderText = "Phone";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // MAIL
            // 
            this.MAIL.DataPropertyName = "MAIL";
            this.MAIL.FillWeight = 16.19263F;
            this.MAIL.HeaderText = "Mail";
            this.MAIL.MinimumWidth = 6;
            this.MAIL.Name = "MAIL";
            // 
            // isAvailable
            // 
            this.isAvailable.DataPropertyName = "isAvailable";
            this.isAvailable.FillWeight = 16.19263F;
            this.isAvailable.HeaderText = "isAvailable";
            this.isAvailable.MinimumWidth = 6;
            this.isAvailable.Name = "isAvailable";
            // 
            // bttExit
            // 
            this.bttExit.BackColor = System.Drawing.Color.White;
            this.bttExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.bttExit.BorderRadius = 5;
            this.bttExit.BorderThickness = 1;
            this.bttExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttExit.FillColor = System.Drawing.Color.Linen;
            this.bttExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.bttExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.bttExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.bttExit.Location = new System.Drawing.Point(1037, 426);
            this.bttExit.Margin = new System.Windows.Forms.Padding(2);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(135, 37);
            this.bttExit.TabIndex = 34;
            this.bttExit.Text = "Exit";
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // ListNhanVienAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 474);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.dgv_nhanvien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListNhanVienAvailable";
            this.Text = "ListNhanVienAvailable";
            this.Load += new System.EventHandler(this.ListNhanVienAvailable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_employeeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailable;
        private Guna.UI2.WinForms.Guna2Button bttExit;
    }
}