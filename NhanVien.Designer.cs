﻿
namespace Tour
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbxAvatar = new System.Windows.Forms.PictureBox();
            this.rdNameSearch = new System.Windows.Forms.RadioButton();
            this.rdIDSearch = new System.Windows.Forms.RadioButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxMail = new System.Windows.Forms.TextBox();
            this.txtbxSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.data_employeeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnPickPicture = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.pcbxAvatar);
            this.panel3.Controls.Add(this.btnPickPicture);
            this.panel3.Location = new System.Drawing.Point(16, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 209);
            this.panel3.TabIndex = 11;
            // 
            // pcbxAvatar
            // 
            this.pcbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxAvatar.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxAvatar.Location = new System.Drawing.Point(4, 4);
            this.pcbxAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbxAvatar.Name = "pcbxAvatar";
            this.pcbxAvatar.Size = new System.Drawing.Size(297, 166);
            this.pcbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxAvatar.TabIndex = 0;
            this.pcbxAvatar.TabStop = false;
            // 
            // rdNameSearch
            // 
            this.rdNameSearch.AutoSize = true;
            this.rdNameSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNameSearch.ForeColor = System.Drawing.Color.Black;
            this.rdNameSearch.Location = new System.Drawing.Point(396, 191);
            this.rdNameSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNameSearch.Name = "rdNameSearch";
            this.rdNameSearch.Size = new System.Drawing.Size(77, 26);
            this.rdNameSearch.TabIndex = 22;
            this.rdNameSearch.Text = "Name";
            this.rdNameSearch.UseVisualStyleBackColor = true;
            this.rdNameSearch.Enter += new System.EventHandler(this.rdNameSearch_Enter);
            // 
            // rdIDSearch
            // 
            this.rdIDSearch.AutoSize = true;
            this.rdIDSearch.Checked = true;
            this.rdIDSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIDSearch.ForeColor = System.Drawing.Color.Black;
            this.rdIDSearch.Location = new System.Drawing.Point(328, 193);
            this.rdIDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdIDSearch.Name = "rdIDSearch";
            this.rdIDSearch.Size = new System.Drawing.Size(51, 26);
            this.rdIDSearch.TabIndex = 21;
            this.rdIDSearch.TabStop = true;
            this.rdIDSearch.Text = "ID";
            this.rdIDSearch.UseVisualStyleBackColor = true;
            this.rdIDSearch.Enter += new System.EventHandler(this.rdIDSearch_Enter);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(488, 187);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(215, 34);
            this.tb_search.TabIndex = 20;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(397, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(344, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số điện thoại";
            // 
            // txtbxMail
            // 
            this.txtbxMail.Location = new System.Drawing.Point(448, 155);
            this.txtbxMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxMail.Name = "txtbxMail";
            this.txtbxMail.Size = new System.Drawing.Size(299, 22);
            this.txtbxMail.TabIndex = 12;
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.Location = new System.Drawing.Point(448, 123);
            this.txtbxSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.Size = new System.Drawing.Size(299, 22);
            this.txtbxSDT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(397, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AllowUserToAddRows = false;
            this.dgv_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_employeeid,
            this.TEN,
            this.SDT,
            this.MAIL,
            this.SLDi,
            this.isAvailable});
            this.dgv_nhanvien.Location = new System.Drawing.Point(16, 231);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.ReadOnly = true;
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1040, 331);
            this.dgv_nhanvien.TabIndex = 4;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick);
            this.dgv_nhanvien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_nhanvien_CellFormatting);
            // 
            // data_employeeid
            // 
            this.data_employeeid.DataPropertyName = "ID";
            this.data_employeeid.HeaderText = "ID";
            this.data_employeeid.MinimumWidth = 6;
            this.data_employeeid.Name = "data_employeeid";
            this.data_employeeid.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // MAIL
            // 
            this.MAIL.DataPropertyName = "MAIL";
            this.MAIL.HeaderText = "Mail";
            this.MAIL.MinimumWidth = 6;
            this.MAIL.Name = "MAIL";
            this.MAIL.ReadOnly = true;
            // 
            // SLDi
            // 
            this.SLDi.DataPropertyName = "SLDi";
            this.SLDi.HeaderText = "SLDi";
            this.SLDi.MinimumWidth = 6;
            this.SLDi.Name = "SLDi";
            this.SLDi.ReadOnly = true;
            // 
            // isAvailable
            // 
            this.isAvailable.DataPropertyName = "isAvailable";
            this.isAvailable.HeaderText = "isAvailable";
            this.isAvailable.MinimumWidth = 6;
            this.isAvailable.Name = "isAvailable";
            this.isAvailable.ReadOnly = true;
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(448, 54);
            this.txtbxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.ReadOnly = true;
            this.txtbxID.Size = new System.Drawing.Size(176, 22);
            this.txtbxID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(397, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(928, 570);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(832, 95);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Add";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(832, 164);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(956, 164);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.CheckedState.Parent = this.btnPickPicture;
            this.btnPickPicture.CustomImages.Parent = this.btnPickPicture;
            this.btnPickPicture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPickPicture.ForeColor = System.Drawing.Color.White;
            this.btnPickPicture.HoverState.Parent = this.btnPickPicture;
            this.btnPickPicture.Location = new System.Drawing.Point(102, 174);
            this.btnPickPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.ShadowDecoration.Parent = this.btnPickPicture;
            this.btnPickPicture.Size = new System.Drawing.Size(106, 28);
            this.btnPickPicture.TabIndex = 4;
            this.btnPickPicture.Text = "Update Image";
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // btnClear
            // 
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(956, 95);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(448, 91);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(299, 22);
            this.txtbxName.TabIndex = 6;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 623);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdNameSearch);
            this.Controls.Add(this.rdIDSearch);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxMail);
            this.Controls.Add(this.txtbxSDT);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcbxAvatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.TextBox txtbxMail;
        private System.Windows.Forms.TextBox txtbxSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.RadioButton rdNameSearch;
        private System.Windows.Forms.RadioButton rdIDSearch;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_employeeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailable;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnPickPicture;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.TextBox txtbxName;
    }
}