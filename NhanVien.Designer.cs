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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPickPicture = new System.Windows.Forms.Button();
            this.pcbxAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgv_trip = new System.Windows.Forms.DataGridView();
            this.txtbxSDT = new System.Windows.Forms.TextBox();
            this.txtbxMail = new System.Windows.Forms.TextBox();
            this.data_employeeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnPickPicture);
            this.panel3.Controls.Add(this.pcbxAvatar);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 170);
            this.panel3.TabIndex = 11;
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.Location = new System.Drawing.Point(85, 144);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPickPicture.TabIndex = 4;
            this.btnPickPicture.Text = "Chọn ảnh";
            this.btnPickPicture.UseVisualStyleBackColor = true;
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // pcbxAvatar
            // 
            this.pcbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxAvatar.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxAvatar.Location = new System.Drawing.Point(3, 3);
            this.pcbxAvatar.Name = "pcbxAvatar";
            this.pcbxAvatar.Size = new System.Drawing.Size(223, 135);
            this.pcbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxAvatar.TabIndex = 0;
            this.pcbxAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.txtbxMail);
            this.panel1.Controls.Add(this.txtbxSDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(248, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 170);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(85, 32);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(232, 20);
            this.txtbxName.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(161, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dgv_trip);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(12, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 301);
            this.panel2.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(702, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgv_trip
            // 
            this.dgv_trip.AllowUserToAddRows = false;
            this.dgv_trip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_trip.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_employeeid,
            this.TEN,
            this.SDT,
            this.MAIL});
            this.dgv_trip.Location = new System.Drawing.Point(9, 0);
            this.dgv_trip.Name = "dgv_trip";
            this.dgv_trip.ReadOnly = true;
            this.dgv_trip.RowHeadersWidth = 51;
            this.dgv_trip.Size = new System.Drawing.Size(768, 269);
            this.dgv_trip.TabIndex = 4;
            this.dgv_trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick);
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.Location = new System.Drawing.Point(85, 58);
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.Size = new System.Drawing.Size(232, 20);
            this.txtbxSDT.TabIndex = 11;
            // 
            // txtbxMail
            // 
            this.txtbxMail.Location = new System.Drawing.Point(85, 84);
            this.txtbxMail.Name = "txtbxMail";
            this.txtbxMail.Size = new System.Drawing.Size(232, 20);
            this.txtbxMail.TabIndex = 12;
            // 
            // data_employeeid
            // 
            this.data_employeeid.DataPropertyName = "ID";
            this.data_employeeid.HeaderText = "ID";
            this.data_employeeid.Name = "data_employeeid";
            this.data_employeeid.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // MAIL
            // 
            this.MAIL.DataPropertyName = "MAIL";
            this.MAIL.HeaderText = "Mail";
            this.MAIL.Name = "MAIL";
            this.MAIL.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 506);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPickPicture;
        private System.Windows.Forms.PictureBox pcbxAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgv_trip;
        private System.Windows.Forms.TextBox txtbxMail;
        private System.Windows.Forms.TextBox txtbxSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_employeeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
    }
}