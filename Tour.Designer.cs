namespace Tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tour));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_trip = new System.Windows.Forms.DataGridView();
            this.data_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DACDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBanner = new System.Windows.Forms.Button();
            this.pcbxBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lstbxLocation = new System.Windows.Forms.ListBox();
            this.btn_newid = new System.Windows.Forms.Button();
            this.cb_typetour = new System.Windows.Forms.ComboBox();
            this.tb_nametour = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_idtrip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_idtrip = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_idtour = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rdNameSearch = new System.Windows.Forms.RadioButton();
            this.rdIDSearch = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_trip);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 462);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1171, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour list";
            // 
            // dgv_trip
            // 
            this.dgv_trip.AllowUserToAddRows = false;
            this.dgv_trip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_trip.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_ID,
            this.TEN,
            this.GIA,
            this.DACDIEM,
            this.LOAI});
            this.dgv_trip.Location = new System.Drawing.Point(19, 27);
            this.dgv_trip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_trip.Name = "dgv_trip";
            this.dgv_trip.ReadOnly = true;
            this.dgv_trip.RowHeadersWidth = 51;
            this.dgv_trip.Size = new System.Drawing.Size(1140, 435);
            this.dgv_trip.TabIndex = 1;
            this.dgv_trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick_1);
            // 
            // data_ID
            // 
            this.data_ID.DataPropertyName = "ID";
            this.data_ID.HeaderText = "ID";
            this.data_ID.MinimumWidth = 6;
            this.data_ID.Name = "data_ID";
            this.data_ID.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên tour du lịch";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.MinimumWidth = 6;
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // DACDIEM
            // 
            this.DACDIEM.DataPropertyName = "DACDIEM";
            this.DACDIEM.HeaderText = "Đặc điểm";
            this.DACDIEM.MinimumWidth = 6;
            this.DACDIEM.Name = "DACDIEM";
            this.DACDIEM.ReadOnly = true;
            // 
            // LOAI
            // 
            this.LOAI.DataPropertyName = "LOAI";
            this.LOAI.HeaderText = "Loại";
            this.LOAI.MinimumWidth = 6;
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(634, 402);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(369, 34);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBanner);
            this.groupBox2.Controls.Add(this.pcbxBanner);
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.lstbxLocation);
            this.groupBox2.Controls.Add(this.btn_newid);
            this.groupBox2.Controls.Add(this.cb_typetour);
            this.groupBox2.Controls.Add(this.tb_nametour);
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Controls.Add(this.tb_idtrip);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_idtrip);
            this.groupBox2.Controls.Add(this.lb_price);
            this.groupBox2.Controls.Add(this.lb_idtour);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1166, 279);
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
            this.btnBanner.Location = new System.Drawing.Point(887, 173);
            this.btnBanner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(95, 58);
            this.btnBanner.TabIndex = 54;
            this.btnBanner.Text = "Banner";
            this.btnBanner.UseVisualStyleBackColor = true;
            this.btnBanner.Click += new System.EventHandler(this.btnBanner_Click);
            // 
            // pcbxBanner
            // 
            this.pcbxBanner.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxBanner.ImageRotate = 0F;
            this.pcbxBanner.Location = new System.Drawing.Point(562, 151);
            this.pcbxBanner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbxBanner.Name = "pcbxBanner";
            this.pcbxBanner.Size = new System.Drawing.Size(317, 112);
            this.pcbxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxBanner.TabIndex = 53;
            this.pcbxBanner.TabStop = false;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLocation.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btnAddLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLocation.Image")));
            this.btnAddLocation.Location = new System.Drawing.Point(914, 22);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(68, 58);
            this.btnAddLocation.TabIndex = 48;
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // lstbxLocation
            // 
            this.lstbxLocation.FormattingEnabled = true;
            this.lstbxLocation.ItemHeight = 22;
            this.lstbxLocation.Location = new System.Drawing.Point(563, 22);
            this.lstbxLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbxLocation.Name = "lstbxLocation";
            this.lstbxLocation.Size = new System.Drawing.Size(316, 114);
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
            this.btn_newid.Location = new System.Drawing.Point(990, 29);
            this.btn_newid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_newid.Name = "btn_newid";
            this.btn_newid.Size = new System.Drawing.Size(133, 47);
            this.btn_newid.TabIndex = 49;
            this.btn_newid.Text = "CLEAR";
            this.btn_newid.UseVisualStyleBackColor = true;
            this.btn_newid.Click += new System.EventHandler(this.btn_newid_Click);
            // 
            // cb_typetour
            // 
            this.cb_typetour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typetour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_typetour.FormattingEnabled = true;
            this.cb_typetour.Items.AddRange(new object[] {
            "Du lịch",
            "Văn hóa",
            "Ẩm thực",
            "Công tác"});
            this.cb_typetour.Location = new System.Drawing.Point(185, 142);
            this.cb_typetour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_typetour.Name = "cb_typetour";
            this.cb_typetour.Size = new System.Drawing.Size(331, 30);
            this.cb_typetour.TabIndex = 48;
            // 
            // tb_nametour
            // 
            this.tb_nametour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nametour.Location = new System.Drawing.Point(185, 80);
            this.tb_nametour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nametour.MaxLength = 30;
            this.tb_nametour.Name = "tb_nametour";
            this.tb_nametour.Size = new System.Drawing.Size(331, 30);
            this.tb_nametour.TabIndex = 47;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(185, 201);
            this.tb_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_price.MaxLength = 25;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(271, 30);
            this.tb_price.TabIndex = 17;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_price.Enter += new System.EventHandler(this.tb_price_Enter);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // tb_idtrip
            // 
            this.tb_idtrip.Enabled = false;
            this.tb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idtrip.Location = new System.Drawing.Point(185, 30);
            this.tb_idtrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_idtrip.MaxLength = 15;
            this.tb_idtrip.Name = "tb_idtrip";
            this.tb_idtrip.ReadOnly = true;
            this.tb_idtrip.Size = new System.Drawing.Size(331, 30);
            this.tb_idtrip.TabIndex = 1;
            this.tb_idtrip.Enter += new System.EventHandler(this.tb_idtrip_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type of tour";
            // 
            // lb_idtrip
            // 
            this.lb_idtrip.AutoSize = true;
            this.lb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtrip.Location = new System.Drawing.Point(24, 32);
            this.lb_idtrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idtrip.Name = "lb_idtrip";
            this.lb_idtrip.Size = new System.Drawing.Size(72, 22);
            this.lb_idtrip.TabIndex = 20;
            this.lb_idtrip.Text = "Tour ID";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(24, 204);
            this.lb_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(52, 22);
            this.lb_price.TabIndex = 5;
            this.lb_price.Text = "Price";
            // 
            // lb_idtour
            // 
            this.lb_idtour.AutoSize = true;
            this.lb_idtour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtour.Location = new System.Drawing.Point(23, 89);
            this.lb_idtour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idtour.Name = "lb_idtour";
            this.lb_idtour.Size = new System.Drawing.Size(98, 22);
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
            this.btn_add.Location = new System.Drawing.Point(35, 395);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 47);
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
            this.btn_delete.Location = new System.Drawing.Point(332, 395);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 47);
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
            this.btnExit.Location = new System.Drawing.Point(491, 395);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 47);
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
            this.btn_update.Location = new System.Drawing.Point(176, 395);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 47);
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
            this.label8.Location = new System.Drawing.Point(208, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(795, 94);
            this.label8.TabIndex = 44;
            this.label8.Text = "TOUR MANAGEMENT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdNameSearch
            // 
            this.rdNameSearch.AutoSize = true;
            this.rdNameSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNameSearch.ForeColor = System.Drawing.Color.Black;
            this.rdNameSearch.Location = new System.Drawing.Point(1068, 406);
            this.rdNameSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNameSearch.Name = "rdNameSearch";
            this.rdNameSearch.Size = new System.Drawing.Size(77, 26);
            this.rdNameSearch.TabIndex = 18;
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
            this.rdIDSearch.Location = new System.Drawing.Point(1011, 406);
            this.rdIDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdIDSearch.Name = "rdIDSearch";
            this.rdIDSearch.Size = new System.Drawing.Size(51, 26);
            this.rdIDSearch.TabIndex = 17;
            this.rdIDSearch.TabStop = true;
            this.rdIDSearch.Text = "ID";
            this.rdIDSearch.UseVisualStyleBackColor = true;
            this.rdIDSearch.Enter += new System.EventHandler(this.rdIDSearch_Enter);
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 945);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdNameSearch);
            this.Controls.Add(this.rdIDSearch);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.TRIPManageTour_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dgv_trip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_idtrip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_idtrip;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_idtour;
        private System.Windows.Forms.ComboBox cb_typetour;
        private System.Windows.Forms.TextBox tb_nametour;
        private System.Windows.Forms.Button btn_newid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dACDIEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOANsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lstbxLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.RadioButton rdNameSearch;
        private System.Windows.Forms.RadioButton rdIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DACDIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
        private System.Windows.Forms.Button btnBanner;
        private Guna.UI2.WinForms.Guna2PictureBox pcbxBanner;
    }
}