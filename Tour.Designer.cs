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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.cbbxLocation = new System.Windows.Forms.ComboBox();
            this.lstbxLocation = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richtbDetail = new System.Windows.Forms.RichTextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gotoregistbtn = new System.Windows.Forms.Button();
            this.backtoroutebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.data_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DACDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_trip);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 253);
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
            this.data_id,
            this.TEN,
            this.DACDIEM,
            this.GIA,
            this.LOAI});
            this.dgv_trip.Location = new System.Drawing.Point(14, 22);
            this.dgv_trip.Name = "dgv_trip";
            this.dgv_trip.ReadOnly = true;
            this.dgv_trip.RowHeadersWidth = 51;
            this.dgv_trip.Size = new System.Drawing.Size(1434, 225);
            this.dgv_trip.TabIndex = 1;
            this.dgv_trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick_1);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(526, 361);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(278, 29);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.cbbxLocation);
            this.groupBox2.Controls.Add(this.lstbxLocation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.richtbDetail);
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
            this.groupBox2.Location = new System.Drawing.Point(16, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1444, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour details";
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
            this.btnAddLocation.Location = new System.Drawing.Point(1354, 18);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(22, 25);
            this.btnAddLocation.TabIndex = 48;
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // cbbxLocation
            // 
            this.cbbxLocation.FormattingEnabled = true;
            this.cbbxLocation.Location = new System.Drawing.Point(844, 18);
            this.cbbxLocation.Name = "cbbxLocation";
            this.cbbxLocation.Size = new System.Drawing.Size(504, 27);
            this.cbbxLocation.TabIndex = 53;
            // 
            // lstbxLocation
            // 
            this.lstbxLocation.FormattingEnabled = true;
            this.lstbxLocation.ItemHeight = 19;
            this.lstbxLocation.Location = new System.Drawing.Point(844, 56);
            this.lstbxLocation.Name = "lstbxLocation";
            this.lstbxLocation.Size = new System.Drawing.Size(504, 175);
            this.lstbxLocation.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Detail ( max 500)";
            // 
            // richtbDetail
            // 
            this.richtbDetail.Location = new System.Drawing.Point(462, 90);
            this.richtbDetail.MaxLength = 499;
            this.richtbDetail.Name = "richtbDetail";
            this.richtbDetail.Size = new System.Drawing.Size(326, 143);
            this.richtbDetail.TabIndex = 50;
            this.richtbDetail.Text = "";
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
            this.btn_newid.Location = new System.Drawing.Point(10, 33);
            this.btn_newid.Name = "btn_newid";
            this.btn_newid.Size = new System.Drawing.Size(100, 38);
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
            "Plane",
            "Passenger Car",
            "Boat",
            "Train"});
            this.cb_typetour.Location = new System.Drawing.Point(128, 181);
            this.cb_typetour.Name = "cb_typetour";
            this.cb_typetour.Size = new System.Drawing.Size(249, 27);
            this.cb_typetour.TabIndex = 48;
            // 
            // tb_nametour
            // 
            this.tb_nametour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nametour.Location = new System.Drawing.Point(128, 131);
            this.tb_nametour.MaxLength = 30;
            this.tb_nametour.Name = "tb_nametour";
            this.tb_nametour.Size = new System.Drawing.Size(249, 26);
            this.tb_nametour.TabIndex = 47;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(536, 18);
            this.tb_price.Margin = new System.Windows.Forms.Padding(2);
            this.tb_price.MaxLength = 25;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(204, 26);
            this.tb_price.TabIndex = 17;
            this.tb_price.Enter += new System.EventHandler(this.tb_price_Enter);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // tb_idtrip
            // 
            this.tb_idtrip.Enabled = false;
            this.tb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idtrip.Location = new System.Drawing.Point(128, 90);
            this.tb_idtrip.MaxLength = 15;
            this.tb_idtrip.Name = "tb_idtrip";
            this.tb_idtrip.ReadOnly = true;
            this.tb_idtrip.Size = new System.Drawing.Size(249, 26);
            this.tb_idtrip.TabIndex = 1;
            this.tb_idtrip.Enter += new System.EventHandler(this.tb_idtrip_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(744, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type of tour";
            // 
            // lb_idtrip
            // 
            this.lb_idtrip.AutoSize = true;
            this.lb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtrip.Location = new System.Drawing.Point(7, 92);
            this.lb_idtrip.Name = "lb_idtrip";
            this.lb_idtrip.Size = new System.Drawing.Size(57, 19);
            this.lb_idtrip.TabIndex = 20;
            this.lb_idtrip.Text = "Tour ID";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(456, 20);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(40, 19);
            this.lb_price.TabIndex = 5;
            this.lb_price.Text = "Price";
            // 
            // lb_idtour
            // 
            this.lb_idtour.AutoSize = true;
            this.lb_idtour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtour.Location = new System.Drawing.Point(6, 138);
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
            this.btn_add.Location = new System.Drawing.Point(26, 355);
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
            this.btn_delete.Location = new System.Drawing.Point(249, 355);
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
            this.btnExit.Location = new System.Drawing.Point(368, 355);
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
            this.btn_update.Location = new System.Drawing.Point(132, 355);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 38);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tour.Properties.Resources.Tour1;
            this.panel1.Controls.Add(this.gotoregistbtn);
            this.panel1.Controls.Add(this.backtoroutebtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 77);
            this.panel1.TabIndex = 47;
            // 
            // gotoregistbtn
            // 
            this.gotoregistbtn.BackColor = System.Drawing.Color.Transparent;
            this.gotoregistbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gotoregistbtn.BackgroundImage")));
            this.gotoregistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gotoregistbtn.FlatAppearance.BorderSize = 0;
            this.gotoregistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoregistbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoregistbtn.Location = new System.Drawing.Point(669, 12);
            this.gotoregistbtn.Name = "gotoregistbtn";
            this.gotoregistbtn.Size = new System.Drawing.Size(174, 45);
            this.gotoregistbtn.TabIndex = 10;
            this.gotoregistbtn.Text = "Go to Ticket Register";
            this.gotoregistbtn.UseVisualStyleBackColor = true;
            this.gotoregistbtn.Click += new System.EventHandler(this.gotoregistbtn_Click);
            // 
            // backtoroutebtn
            // 
            this.backtoroutebtn.BackColor = System.Drawing.Color.Transparent;
            this.backtoroutebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtoroutebtn.BackgroundImage")));
            this.backtoroutebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoroutebtn.FlatAppearance.BorderSize = 0;
            this.backtoroutebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoroutebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoroutebtn.Location = new System.Drawing.Point(3, 12);
            this.backtoroutebtn.Name = "backtoroutebtn";
            this.backtoroutebtn.Size = new System.Drawing.Size(123, 45);
            this.backtoroutebtn.TabIndex = 10;
            this.backtoroutebtn.Text = "Back to Route";
            this.backtoroutebtn.UseVisualStyleBackColor = true;
            this.backtoroutebtn.Click += new System.EventHandler(this.backtoroutebtn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(112, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(596, 76);
            this.label8.TabIndex = 44;
            this.label8.Text = "TOUR MANAGEMENT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_id
            // 
            this.data_id.DataPropertyName = "ID";
            this.data_id.HeaderText = "ID";
            this.data_id.Name = "data_id";
            this.data_id.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // DACDIEM
            // 
            this.DACDIEM.DataPropertyName = "DACDIEM";
            this.DACDIEM.HeaderText = "Chi tiết";
            this.DACDIEM.Name = "DACDIEM";
            this.DACDIEM.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // LOAI
            // 
            this.LOAI.DataPropertyName = "LOAI";
            this.LOAI.HeaderText = "Loại";
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1478, 656);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.TRIPManageTour_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button backtoroutebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gotoregistbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_idtrip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_idtrip;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_idtour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_typetour;
        private System.Windows.Forms.TextBox tb_nametour;
        private System.Windows.Forms.Button btn_newid;
        private System.Windows.Forms.RichTextBox richtbDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dACDIEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOANsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lstbxLocation;
        private System.Windows.Forms.ComboBox cbbxLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DACDIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
    }
}