
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.cbbxSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_employeeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pcbxAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbbxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 5;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(22, 781);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Add";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(238, 781);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 45);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(130, 781);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 5;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1071, 781);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.cbbxSearchType.Location = new System.Drawing.Point(1039, 341);
            this.cbbxSearchType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxSearchType.Name = "cbbxSearchType";
            this.cbbxSearchType.Size = new System.Drawing.Size(132, 36);
            this.cbbxSearchType.StartIndex = 0;
            this.cbbxSearchType.TabIndex = 29;
            this.cbbxSearchType.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(937, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Search By";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nhanvien.ColumnHeadersHeight = 35;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.data_employeeid,
            this.TEN,
            this.SDT,
            this.MAIL,
            this.SLDi,
            this.isAvailable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_nhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanvien.Location = new System.Drawing.Point(12, 386);
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
            this.dgv_nhanvien.TabIndex = 32;
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
            // SLDi
            // 
            this.SLDi.DataPropertyName = "SLDi";
            this.SLDi.FillWeight = 16.19263F;
            this.SLDi.HeaderText = "SLDi";
            this.SLDi.MinimumWidth = 6;
            this.SLDi.Name = "SLDi";
            // 
            // isAvailable
            // 
            this.isAvailable.DataPropertyName = "isAvailable";
            this.isAvailable.FillWeight = 16.19263F;
            this.isAvailable.HeaderText = "isAvailable";
            this.isAvailable.MinimumWidth = 6;
            this.isAvailable.Name = "isAvailable";
            // 
            // txtbxID
            // 
            this.txtbxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxID.DefaultText = "";
            this.txtbxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxID.Enabled = false;
            this.txtbxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxID.ForeColor = System.Drawing.Color.Black;
            this.txtbxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxID.Location = new System.Drawing.Point(376, 45);
            this.txtbxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.PasswordChar = '\0';
            this.txtbxID.PlaceholderText = "ID";
            this.txtbxID.ReadOnly = true;
            this.txtbxID.SelectedText = "";
            this.txtbxID.Size = new System.Drawing.Size(795, 45);
            this.txtbxID.TabIndex = 33;
            // 
            // txtbxMail
            // 
            this.txtbxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxMail.DefaultText = "";
            this.txtbxMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMail.ForeColor = System.Drawing.Color.Black;
            this.txtbxMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMail.Location = new System.Drawing.Point(376, 210);
            this.txtbxMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxMail.Name = "txtbxMail";
            this.txtbxMail.PasswordChar = '\0';
            this.txtbxMail.PlaceholderText = "Mail";
            this.txtbxMail.SelectedText = "";
            this.txtbxMail.Size = new System.Drawing.Size(795, 45);
            this.txtbxMail.TabIndex = 36;
            this.txtbxMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMail_KeyPress);
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSDT.DefaultText = "";
            this.txtbxSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSDT.ForeColor = System.Drawing.Color.Black;
            this.txtbxSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSDT.Location = new System.Drawing.Point(376, 155);
            this.txtbxSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSDT.MaxLength = 13;
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.PasswordChar = '\0';
            this.txtbxSDT.PlaceholderText = "Phone";
            this.txtbxSDT.SelectedText = "";
            this.txtbxSDT.Size = new System.Drawing.Size(795, 45);
            this.txtbxSDT.TabIndex = 35;
            this.txtbxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSDT_KeyPress);
            // 
            // txtbxName
            // 
            this.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxName.DefaultText = "";
            this.txtbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.ForeColor = System.Drawing.Color.Black;
            this.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Location = new System.Drawing.Point(376, 100);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.PasswordChar = '\0';
            this.txtbxName.PlaceholderText = "Name";
            this.txtbxName.SelectedText = "";
            this.txtbxName.Size = new System.Drawing.Size(795, 45);
            this.txtbxName.TabIndex = 34;
            this.txtbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxName_KeyPress);
            // 
            // tb_search
            // 
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.Black;
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Location = new System.Drawing.Point(530, 334);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Search";
            this.tb_search.SelectedText = "";
            this.tb_search.Size = new System.Drawing.Size(400, 45);
            this.tb_search.TabIndex = 38;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.DefaultText = "";
            this.txtbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.Location = new System.Drawing.Point(376, 265);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '\0';
            this.txtbxPassword.PlaceholderText = "Password";
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.Size = new System.Drawing.Size(795, 45);
            this.txtbxPassword.TabIndex = 37;
            this.txtbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPassword_KeyPress);
            // 
            // pcbxAvatar
            // 
            this.pcbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxAvatar.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxAvatar.ImageRotate = 0F;
            this.pcbxAvatar.InitialImage = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxAvatar.Location = new System.Drawing.Point(37, 40);
            this.pcbxAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbxAvatar.Name = "pcbxAvatar";
            this.pcbxAvatar.Size = new System.Drawing.Size(301, 282);
            this.pcbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxAvatar.TabIndex = 38;
            this.pcbxAvatar.TabStop = false;
            this.pcbxAvatar.Click += new System.EventHandler(this.pcbxAvatar_Click);
            // 
            // cbbxRole
            // 
            this.cbbxRole.BackColor = System.Drawing.Color.Transparent;
            this.cbbxRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cbbxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxRole.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxRole.FormattingEnabled = true;
            this.cbbxRole.ItemHeight = 30;
            this.cbbxRole.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.cbbxRole.Location = new System.Drawing.Point(39, 341);
            this.cbbxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxRole.Name = "cbbxRole";
            this.cbbxRole.Size = new System.Drawing.Size(299, 36);
            this.cbbxRole.StartIndex = 0;
            this.cbbxRole.TabIndex = 39;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 906);
            this.Controls.Add(this.cbbxRole);
            this.Controls.Add(this.pcbxAvatar);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxSDT);
            this.Controls.Add(this.txtbxMail);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbxSearchType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxSearchType;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_employeeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailable;
        private Guna.UI2.WinForms.Guna2TextBox txtbxID;
        private Guna.UI2.WinForms.Guna2TextBox txtbxMail;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtbxName;
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private Guna.UI2.WinForms.Guna2PictureBox pcbxAvatar;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxRole;
    }
}