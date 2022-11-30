﻿namespace Tour
{
    partial class Tour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tour));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBanner = new System.Windows.Forms.Button();
            this.pcbxBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lstbxLocation = new System.Windows.Forms.ListBox();
            this.btn_newid = new System.Windows.Forms.Button();
            this.tb_idtrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_idtrip = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_idtour = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_nametour = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbxSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddLocation = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_trip = new Guna.UI2.WinForms.Guna2DataGridView();
            this.data_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOURTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANNER = new System.Windows.Forms.DataGridViewImageColumn();
            this.cb_typetour = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_trip);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour list";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(476, 327);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(278, 35);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_typetour);
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.tb_nametour);
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Controls.Add(this.btnBanner);
            this.groupBox2.Controls.Add(this.pcbxBanner);
            this.groupBox2.Controls.Add(this.lstbxLocation);
            this.groupBox2.Controls.Add(this.tb_idtrip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_idtrip);
            this.groupBox2.Controls.Add(this.lb_price);
            this.groupBox2.Controls.Add(this.lb_idtour);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour details";
            // 
            // btnBanner
            // 
            this.btnBanner.BackColor = System.Drawing.Color.Transparent;
            this.btnBanner.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btnBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanner.FlatAppearance.BorderSize = 0;
            this.btnBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanner.Location = new System.Drawing.Point(794, 120);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(71, 47);
            this.btnBanner.TabIndex = 54;
            this.btnBanner.Text = "Banner";
            this.btnBanner.UseVisualStyleBackColor = true;
            this.btnBanner.Click += new System.EventHandler(this.btnBanner_Click);
            // 
            // pcbxBanner
            // 
            this.pcbxBanner.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxBanner.ImageRotate = 0F;
            this.pcbxBanner.Location = new System.Drawing.Point(750, 23);
            this.pcbxBanner.Name = "pcbxBanner";
            this.pcbxBanner.Size = new System.Drawing.Size(115, 91);
            this.pcbxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxBanner.TabIndex = 53;
            this.pcbxBanner.TabStop = false;
            // 
            // lstbxLocation
            // 
            this.lstbxLocation.FormattingEnabled = true;
            this.lstbxLocation.ItemHeight = 19;
            this.lstbxLocation.Location = new System.Drawing.Point(394, 23);
            this.lstbxLocation.Name = "lstbxLocation";
            this.lstbxLocation.Size = new System.Drawing.Size(234, 175);
            this.lstbxLocation.TabIndex = 52;
            // 
            // btn_newid
            // 
            this.btn_newid.BackColor = System.Drawing.Color.Transparent;
            this.btn_newid.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_newid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newid.FlatAppearance.BorderSize = 0;
            this.btn_newid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newid.Location = new System.Drawing.Point(790, 50);
            this.btn_newid.Name = "btn_newid";
            this.btn_newid.Size = new System.Drawing.Size(100, 38);
            this.btn_newid.TabIndex = 49;
            this.btn_newid.Text = "CLEAR";
            this.btn_newid.UseVisualStyleBackColor = true;
            this.btn_newid.Click += new System.EventHandler(this.btn_newid_Click);
            // 
            // tb_idtrip
            // 
            this.tb_idtrip.Enabled = false;
            this.tb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idtrip.Location = new System.Drawing.Point(139, 24);
            this.tb_idtrip.MaxLength = 15;
            this.tb_idtrip.Name = "tb_idtrip";
            this.tb_idtrip.ReadOnly = true;
            this.tb_idtrip.Size = new System.Drawing.Size(249, 26);
            this.tb_idtrip.TabIndex = 1;
            this.tb_idtrip.Enter += new System.EventHandler(this.tb_idtrip_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type of tour";
            // 
            // lb_idtrip
            // 
            this.lb_idtrip.AutoSize = true;
            this.lb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtrip.Location = new System.Drawing.Point(18, 26);
            this.lb_idtrip.Name = "lb_idtrip";
            this.lb_idtrip.Size = new System.Drawing.Size(57, 19);
            this.lb_idtrip.TabIndex = 20;
            this.lb_idtrip.Text = "Tour ID";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(18, 166);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(40, 19);
            this.lb_price.TabIndex = 5;
            this.lb_price.Text = "Price";
            // 
            // lb_idtour
            // 
            this.lb_idtour.AutoSize = true;
            this.lb_idtour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtour.Location = new System.Drawing.Point(17, 72);
            this.lb_idtour.Name = "lb_idtour";
            this.lb_idtour.Size = new System.Drawing.Size(78, 19);
            this.lb_idtour.TabIndex = 0;
            this.lb_idtour.Text = "Tour Name";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Tour.Properties.Resources.addp;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(26, 321);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 38);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "   ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Tour.Properties.Resources.deleteicon;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(249, 321);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 38);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = global::Tour.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(368, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "  EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::Tour.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(132, 321);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 38);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.update_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(156, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(596, 76);
            this.label8.TabIndex = 44;
            this.label8.Text = "TOUR MANAGEMENT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_price
            // 
            this.tb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_price.DefaultText = "";
            this.tb_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_price.Location = new System.Drawing.Point(139, 153);
            this.tb_price.Name = "tb_price";
            this.tb_price.PasswordChar = '\0';
            this.tb_price.PlaceholderText = "";
            this.tb_price.SelectedText = "";
            this.tb_price.Size = new System.Drawing.Size(249, 32);
            this.tb_price.TabIndex = 2;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // tb_nametour
            // 
            this.tb_nametour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nametour.DefaultText = "";
            this.tb_nametour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_nametour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_nametour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nametour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_nametour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nametour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_nametour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_nametour.Location = new System.Drawing.Point(139, 62);
            this.tb_nametour.Name = "tb_nametour";
            this.tb_nametour.PasswordChar = '\0';
            this.tb_nametour.PlaceholderText = "";
            this.tb_nametour.SelectedText = "";
            this.tb_nametour.Size = new System.Drawing.Size(249, 36);
            this.tb_nametour.TabIndex = 45;
            // 
            // cbbxSearchType
            // 
            this.cbbxSearchType.BackColor = System.Drawing.Color.Transparent;
            this.cbbxSearchType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cbbxSearchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxSearchType.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxSearchType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxSearchType.FormattingEnabled = true;
            this.cbbxSearchType.ItemHeight = 30;
            this.cbbxSearchType.Items.AddRange(new object[] {
            "ID",
            "NAME"});
            this.cbbxSearchType.Location = new System.Drawing.Point(760, 327);
            this.cbbxSearchType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxSearchType.Name = "cbbxSearchType";
            this.cbbxSearchType.Size = new System.Drawing.Size(132, 36);
            this.cbbxSearchType.StartIndex = 0;
            this.cbbxSearchType.TabIndex = 45;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAddLocation.BorderRadius = 5;
            this.btnAddLocation.BorderThickness = 2;
            this.btnAddLocation.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddLocation.CustomImages.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAddLocation.FillColor = System.Drawing.Color.Transparent;
            this.btnAddLocation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.ForeColor = System.Drawing.Color.Black;
            this.btnAddLocation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAddLocation.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddLocation.Location = new System.Drawing.Point(633, 23);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(50, 41);
            this.btnAddLocation.TabIndex = 55;
            this.btnAddLocation.Text = "+";
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // dgv_trip
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_trip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_trip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_id,
            this.TENTOUR,
            this.GIA,
            this.TOURTYPE,
            this.BANNER});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_trip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_trip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_trip.Location = new System.Drawing.Point(6, 25);
            this.dgv_trip.Name = "dgv_trip";
            this.dgv_trip.RowHeadersVisible = false;
            this.dgv_trip.RowHeadersWidth = 50;
            this.dgv_trip.RowTemplate.Height = 80;
            this.dgv_trip.Size = new System.Drawing.Size(863, 351);
            this.dgv_trip.TabIndex = 2;
            this.dgv_trip.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trip.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_trip.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_trip.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_trip.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_trip.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trip.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_trip.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_trip.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_trip.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_trip.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_trip.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trip.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_trip.ThemeStyle.ReadOnly = false;
            this.dgv_trip.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trip.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_trip.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_trip.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_trip.ThemeStyle.RowsStyle.Height = 80;
            this.dgv_trip.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_trip.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick_1);
            // 
            // data_id
            // 
            this.data_id.DataPropertyName = "ID";
            this.data_id.FillWeight = 50F;
            this.data_id.HeaderText = "ID";
            this.data_id.Name = "data_id";
            // 
            // TENTOUR
            // 
            this.TENTOUR.DataPropertyName = "TENTOUR";
            this.TENTOUR.HeaderText = "Tour\'s name";
            this.TENTOUR.Name = "TENTOUR";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Price";
            this.GIA.Name = "GIA";
            // 
            // TOURTYPE
            // 
            this.TOURTYPE.DataPropertyName = "TOURTYPE";
            this.TOURTYPE.FillWeight = 75F;
            this.TOURTYPE.HeaderText = "Type";
            this.TOURTYPE.Name = "TOURTYPE";
            // 
            // BANNER
            // 
            this.BANNER.DataPropertyName = "BANNER";
            this.BANNER.FillWeight = 150F;
            this.BANNER.HeaderText = "Discount banner";
            this.BANNER.Name = "BANNER";
            // 
            // cb_typetour
            // 
            this.cb_typetour.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_typetour.FormattingEnabled = true;
            this.cb_typetour.Items.AddRange(new object[] {
            "Bussiness",
            "Culture",
            "Vacation",
            "Cuisine"});
            this.cb_typetour.Location = new System.Drawing.Point(139, 117);
            this.cb_typetour.Name = "cb_typetour";
            this.cb_typetour.Size = new System.Drawing.Size(249, 31);
            this.cb_typetour.TabIndex = 3;
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(900, 768);
            this.Controls.Add(this.cbbxSearchType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_newid);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.TRIPManageTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_idtrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_idtrip;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_idtour;
        private System.Windows.Forms.Button btn_newid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dACDIEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOANsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lstbxLocation;
        private System.Windows.Forms.Button btnBanner;
        private Guna.UI2.WinForms.Guna2PictureBox pcbxBanner;
        private Guna.UI2.WinForms.Guna2TextBox tb_price;
        private Guna.UI2.WinForms.Guna2TextBox tb_nametour;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxSearchType;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_trip;
        private Guna.UI2.WinForms.Guna2Button btnAddLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOURTYPE;
        private System.Windows.Forms.DataGridViewImageColumn BANNER;
        private System.Windows.Forms.ComboBox cb_typetour;
    }
}