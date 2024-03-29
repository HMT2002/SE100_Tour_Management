﻿
namespace Tour
{
    partial class Hotel
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbxLocation = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbboxProvince = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbxHotel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rchtxtbxDetail = new System.Windows.Forms.RichTextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.pcbxLocation);
            this.panel3.Location = new System.Drawing.Point(743, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 671);
            this.panel3.TabIndex = 5;
            // 
            // pcbxLocation
            // 
            this.pcbxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxLocation.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxLocation.Location = new System.Drawing.Point(4, 14);
            this.pcbxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.pcbxLocation.Name = "pcbxLocation";
            this.pcbxLocation.Size = new System.Drawing.Size(841, 652);
            this.pcbxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLocation.TabIndex = 0;
            this.pcbxLocation.TabStop = false;
            this.pcbxLocation.Click += new System.EventHandler(this.pcbxLocation_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cbboxProvince);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbxHotel);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.txtbxDiaChi);
            this.panel1.Controls.Add(this.txtbxGia);
            this.panel1.Controls.Add(this.txtbxSDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rchtxtbxDetail);
            this.panel1.Location = new System.Drawing.Point(12, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 708);
            this.panel1.TabIndex = 4;
            // 
            // cbboxProvince
            // 
            this.cbboxProvince.BackColor = System.Drawing.Color.Transparent;
            this.cbboxProvince.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbboxProvince.BorderRadius = 10;
            this.cbboxProvince.BorderThickness = 2;
            this.cbboxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxProvince.DropDownHeight = 50;
            this.cbboxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxProvince.FillColor = System.Drawing.Color.Bisque;
            this.cbboxProvince.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxProvince.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxProvince.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbboxProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbboxProvince.IntegralHeight = false;
            this.cbboxProvince.ItemHeight = 30;
            this.cbboxProvince.Location = new System.Drawing.Point(156, 261);
            this.cbboxProvince.Margin = new System.Windows.Forms.Padding(4);
            this.cbboxProvince.MaxDropDownItems = 5;
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.ShadowDecoration.BorderRadius = 10;
            this.cbboxProvince.ShadowDecoration.Depth = 15;
            this.cbboxProvince.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.cbboxProvince.Size = new System.Drawing.Size(563, 36);
            this.cbboxProvince.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(11, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(11, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cost/day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hotel";
            // 
            // cbbxHotel
            // 
            this.cbbxHotel.BackColor = System.Drawing.Color.Transparent;
            this.cbbxHotel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbbxHotel.BorderRadius = 10;
            this.cbbxHotel.BorderThickness = 2;
            this.cbbxHotel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxHotel.FillColor = System.Drawing.Color.Bisque;
            this.cbbxHotel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbxHotel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbxHotel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbxHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbbxHotel.ItemHeight = 30;
            this.cbbxHotel.Location = new System.Drawing.Point(156, 2);
            this.cbbxHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxHotel.Name = "cbbxHotel";
            this.cbbxHotel.Size = new System.Drawing.Size(563, 36);
            this.cbbxHotel.TabIndex = 1;
            this.cbbxHotel.SelectedValueChanged += new System.EventHandler(this.cbbxHotel_SelectedValueChanged);
            // 
            // txtbxName
            // 
            this.txtbxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.BorderRadius = 10;
            this.txtbxName.BorderThickness = 2;
            this.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxName.DefaultText = "";
            this.txtbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.FillColor = System.Drawing.Color.Bisque;
            this.txtbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Location = new System.Drawing.Point(156, 54);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.PasswordChar = '\0';
            this.txtbxName.PlaceholderText = "";
            this.txtbxName.SelectedText = "";
            this.txtbxName.Size = new System.Drawing.Size(563, 36);
            this.txtbxName.TabIndex = 2;
            // 
            // txtbxDiaChi
            // 
            this.txtbxDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxDiaChi.BorderRadius = 10;
            this.txtbxDiaChi.BorderThickness = 2;
            this.txtbxDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxDiaChi.DefaultText = "";
            this.txtbxDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxDiaChi.FillColor = System.Drawing.Color.Bisque;
            this.txtbxDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxDiaChi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbxDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxDiaChi.Location = new System.Drawing.Point(156, 106);
            this.txtbxDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxDiaChi.Name = "txtbxDiaChi";
            this.txtbxDiaChi.PasswordChar = '\0';
            this.txtbxDiaChi.PlaceholderText = "";
            this.txtbxDiaChi.SelectedText = "";
            this.txtbxDiaChi.Size = new System.Drawing.Size(563, 36);
            this.txtbxDiaChi.TabIndex = 3;
            // 
            // txtbxGia
            // 
            this.txtbxGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxGia.BorderRadius = 10;
            this.txtbxGia.BorderThickness = 2;
            this.txtbxGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxGia.DefaultText = "";
            this.txtbxGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.FillColor = System.Drawing.Color.Bisque;
            this.txtbxGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbxGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Location = new System.Drawing.Point(156, 158);
            this.txtbxGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.PasswordChar = '\0';
            this.txtbxGia.PlaceholderText = "";
            this.txtbxGia.SelectedText = "";
            this.txtbxGia.Size = new System.Drawing.Size(563, 36);
            this.txtbxGia.TabIndex = 4;
            this.txtbxGia.TextChanged += new System.EventHandler(this.txtbxGia_TextChanged);
            this.txtbxGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxGia_KeyPress);
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtbxSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxSDT.BorderRadius = 10;
            this.txtbxSDT.BorderThickness = 2;
            this.txtbxSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSDT.DefaultText = "";
            this.txtbxSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSDT.FillColor = System.Drawing.Color.Bisque;
            this.txtbxSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbxSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSDT.Location = new System.Drawing.Point(156, 208);
            this.txtbxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxSDT.MaxLength = 13;
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.PasswordChar = '\0';
            this.txtbxSDT.PlaceholderText = "";
            this.txtbxSDT.SelectedText = "";
            this.txtbxSDT.Size = new System.Drawing.Size(563, 36);
            this.txtbxSDT.TabIndex = 5;
            this.txtbxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSDT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(11, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "City";
            // 
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.BackColor = System.Drawing.Color.Bisque;
            this.rchtxtbxDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rchtxtbxDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.rchtxtbxDetail.Location = new System.Drawing.Point(11, 313);
            this.rchtxtbxDetail.Margin = new System.Windows.Forms.Padding(4);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(707, 386);
            this.rchtxtbxDetail.TabIndex = 7;
            this.rchtxtbxDetail.Text = "";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::Tour.Properties.Resources.BeFunky_sample;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1600, 240);
            this.guna2Panel2.TabIndex = 44;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Linen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(860, 21);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(321, 57);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Linen;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(531, 21);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(321, 57);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Linen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(201, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(321, 57);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 986);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1600, 116);
            this.guna2Panel1.TabIndex = 48;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnClear.BorderRadius = 5;
            this.btnClear.BorderThickness = 2;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Linen;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1189, 21);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(321, 57);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 1102);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcbxLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchtxtbxDetail;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxHotel;
        private Guna.UI2.WinForms.Guna2TextBox txtbxName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtbxGia;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxProvince;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}