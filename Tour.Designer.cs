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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tour));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_trip = new Guna.UI2.WinForms.Guna2DataGridView();
            this.data_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOURTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANNER = new System.Windows.Forms.DataGridViewImageColumn();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_typetour = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnAddLocation = new Guna.UI2.WinForms.Guna2Button();
            this.tb_nametour = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.lstbxLocation = new System.Windows.Forms.ListBox();
            this.tb_idtrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_idtrip = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_idtour = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbxSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_newid = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_trip);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 476);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1568, 672);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour list";
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
            this.dgv_trip.ColumnHeadersHeight = 21;
            this.dgv_trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            this.dgv_trip.Location = new System.Drawing.Point(8, 31);
            this.dgv_trip.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_trip.Name = "dgv_trip";
            this.dgv_trip.RowHeadersVisible = false;
            this.dgv_trip.RowHeadersWidth = 50;
            this.dgv_trip.RowTemplate.Height = 100;
            this.dgv_trip.Size = new System.Drawing.Size(1552, 634);
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
            this.dgv_trip.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_trip.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_trip.ThemeStyle.ReadOnly = false;
            this.dgv_trip.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trip.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_trip.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_trip.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_trip.ThemeStyle.RowsStyle.Height = 100;
            this.dgv_trip.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_trip.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick_1);
            // 
            // data_id
            // 
            this.data_id.DataPropertyName = "ID";
            this.data_id.FillWeight = 50F;
            this.data_id.HeaderText = "ID";
            this.data_id.MinimumWidth = 6;
            this.data_id.Name = "data_id";
            // 
            // TENTOUR
            // 
            this.TENTOUR.DataPropertyName = "TENTOUR";
            this.TENTOUR.HeaderText = "Tour\'s name";
            this.TENTOUR.MinimumWidth = 6;
            this.TENTOUR.Name = "TENTOUR";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Price";
            this.GIA.MinimumWidth = 6;
            this.GIA.Name = "GIA";
            // 
            // TOURTYPE
            // 
            this.TOURTYPE.DataPropertyName = "TOURTYPE";
            this.TOURTYPE.FillWeight = 75F;
            this.TOURTYPE.HeaderText = "Type";
            this.TOURTYPE.MinimumWidth = 6;
            this.TOURTYPE.Name = "TOURTYPE";
            // 
            // BANNER
            // 
            this.BANNER.DataPropertyName = "BANNER";
            this.BANNER.FillWeight = 150F;
            this.BANNER.HeaderText = "Discount banner";
            this.BANNER.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.BANNER.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.BANNER.MinimumWidth = 6;
            this.BANNER.Name = "BANNER";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(856, 14);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(475, 42);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_typetour);
            this.groupBox2.Controls.Add(this.guna2VSeparator1);
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.tb_nametour);
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Controls.Add(this.lstbxLocation);
            this.groupBox2.Controls.Add(this.tb_idtrip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_idtrip);
            this.groupBox2.Controls.Add(this.lb_price);
            this.groupBox2.Controls.Add(this.lb_idtour);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1563, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour details";
            // 
            // cb_typetour
            // 
            this.cb_typetour.BackColor = System.Drawing.Color.Transparent;
            this.cb_typetour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_typetour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typetour.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typetour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typetour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_typetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_typetour.ItemHeight = 30;
            this.cb_typetour.Location = new System.Drawing.Point(185, 143);
            this.cb_typetour.Margin = new System.Windows.Forms.Padding(4);
            this.cb_typetour.Name = "cb_typetour";
            this.cb_typetour.Size = new System.Drawing.Size(471, 36);
            this.cb_typetour.TabIndex = 3;
            this.cb_typetour.Enter += new System.EventHandler(this.cb_typetour_Enter);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(713, 21);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(13, 251);
            this.guna2VSeparator1.TabIndex = 56;
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
            this.btnAddLocation.Location = new System.Drawing.Point(1489, 30);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(67, 50);
            this.btnAddLocation.TabIndex = 55;
            this.btnAddLocation.Text = "+";
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
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
            this.tb_nametour.Location = new System.Drawing.Point(185, 76);
            this.tb_nametour.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nametour.Name = "tb_nametour";
            this.tb_nametour.PasswordChar = '\0';
            this.tb_nametour.PlaceholderText = "";
            this.tb_nametour.SelectedText = "";
            this.tb_nametour.Size = new System.Drawing.Size(472, 44);
            this.tb_nametour.TabIndex = 45;
            this.tb_nametour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nametour_KeyPress);
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
            this.tb_price.Location = new System.Drawing.Point(185, 206);
            this.tb_price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_price.Name = "tb_price";
            this.tb_price.PasswordChar = '\0';
            this.tb_price.PlaceholderText = "";
            this.tb_price.SelectedText = "";
            this.tb_price.Size = new System.Drawing.Size(472, 39);
            this.tb_price.TabIndex = 2;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // lstbxLocation
            // 
            this.lstbxLocation.FormattingEnabled = true;
            this.lstbxLocation.ItemHeight = 22;
            this.lstbxLocation.Location = new System.Drawing.Point(789, 30);
            this.lstbxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxLocation.Name = "lstbxLocation";
            this.lstbxLocation.Size = new System.Drawing.Size(692, 202);
            this.lstbxLocation.TabIndex = 52;
            // 
            // tb_idtrip
            // 
            this.tb_idtrip.Enabled = false;
            this.tb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idtrip.Location = new System.Drawing.Point(185, 30);
            this.tb_idtrip.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idtrip.MaxLength = 15;
            this.tb_idtrip.Name = "tb_idtrip";
            this.tb_idtrip.ReadOnly = true;
            this.tb_idtrip.Size = new System.Drawing.Size(471, 30);
            this.tb_idtrip.TabIndex = 1;
            this.tb_idtrip.Enter += new System.EventHandler(this.tb_idtrip_Enter);
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
            this.lb_price.Location = new System.Drawing.Point(24, 222);
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
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(424, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(795, 94);
            this.label8.TabIndex = 44;
            this.label8.Text = "TOUR MANAGEMENT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbbxSearchType.Location = new System.Drawing.Point(1340, 12);
            this.cbbxSearchType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbxSearchType.Name = "cbbxSearchType";
            this.cbbxSearchType.Size = new System.Drawing.Size(175, 36);
            this.cbbxSearchType.StartIndex = 0;
            this.cbbxSearchType.TabIndex = 45;
            // 
            // btn_newid
            // 
            this.btn_newid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_newid.BorderRadius = 5;
            this.btn_newid.BorderThickness = 2;
            this.btn_newid.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_newid.CustomImages.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_newid.FillColor = System.Drawing.Color.Transparent;
            this.btn_newid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newid.ForeColor = System.Drawing.Color.Black;
            this.btn_newid.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_newid.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_newid.Location = new System.Drawing.Point(557, 12);
            this.btn_newid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newid.Name = "btn_newid";
            this.btn_newid.Size = new System.Drawing.Size(132, 50);
            this.btn_newid.TabIndex = 56;
            this.btn_newid.Text = "Clear";
            this.btn_newid.Click += new System.EventHandler(this.btn_newid_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_delete.BorderRadius = 5;
            this.btn_delete.BorderThickness = 2;
            this.btn_delete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.CustomImages.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_delete.FillColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::Tour.Properties.Resources.deleteicon;
            this.btn_delete.Location = new System.Drawing.Point(356, 12);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(164, 50);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_update.BorderRadius = 5;
            this.btn_update.BorderThickness = 2;
            this.btn_update.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_update.CustomImages.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_update.FillColor = System.Drawing.Color.Transparent;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_update.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = global::Tour.Properties.Resources.update;
            this.btn_update.Location = new System.Drawing.Point(187, 12);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(164, 50);
            this.btn_update.TabIndex = 58;
            this.btn_update.Text = "UPDATE";
            this.btn_update.Click += new System.EventHandler(this.update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_add.BorderRadius = 5;
            this.btn_add.BorderThickness = 2;
            this.btn_add.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_add.CustomImages.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_add.FillColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btn_add.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::Tour.Properties.Resources.addp;
            this.btn_add.Location = new System.Drawing.Point(17, 12);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(164, 50);
            this.btn_add.TabIndex = 57;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.add_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_delete);
            this.guna2Panel1.Controls.Add(this.cbbxSearchType);
            this.guna2Panel1.Controls.Add(this.btn_newid);
            this.guna2Panel1.Controls.Add(this.tb_search);
            this.guna2Panel1.Controls.Add(this.btn_update);
            this.guna2Panel1.Controls.Add(this.btn_add);
            this.guna2Panel1.Location = new System.Drawing.Point(21, 395);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1563, 74);
            this.guna2Panel1.TabIndex = 60;
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1600, 1102);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
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
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_idtrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_idtrip;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_idtour;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dACDIEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOANsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lstbxLocation;
        private Guna.UI2.WinForms.Guna2TextBox tb_price;
        private Guna.UI2.WinForms.Guna2TextBox tb_nametour;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxSearchType;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_trip;
        private Guna.UI2.WinForms.Guna2Button btnAddLocation;
        private Guna.UI2.WinForms.Guna2Button btn_newid;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2ComboBox cb_typetour;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOURTYPE;
        private System.Windows.Forms.DataGridViewImageColumn BANNER;
    }
}