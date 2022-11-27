
namespace Tour
{
    partial class CSDLPhieuDatCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSDLPhieuDatCho));
            this.Information = new System.Windows.Forms.GroupBox();
            this.dgvQuanLy = new System.Windows.Forms.DataGridView();
            this.MaDuKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDatCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenloaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanVisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND_Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LePhiHoanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienHoanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraVe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbICN = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.tbSearchTicket = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Transparent;
            this.Information.Controls.Add(this.dgvQuanLy);
            this.Information.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(14, 394);
            this.Information.Margin = new System.Windows.Forms.Padding(2);
            this.Information.Name = "Information";
            this.Information.Padding = new System.Windows.Forms.Padding(2);
            this.Information.Size = new System.Drawing.Size(1118, 284);
            this.Information.TabIndex = 2;
            this.Information.TabStop = false;
            this.Information.Text = "Ticket";
            // 
            // dgvQuanLy
            // 
            this.dgvQuanLy.AllowUserToAddRows = false;
            this.dgvQuanLy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDuKhach,
            this.MaChuyen,
            this.MaVe,
            this.MaPhieuDatCho,
            this.HoTen,
            this.DiaChi,
            this.SDT,
            this.GioiTinh,
            this.TenloaiKhach,
            this.HanPassport,
            this.HanVisa,
            this.CMND_Passport,
            this.TenLoaiChuyen,
            this.TenLoaiTuyen,
            this.GiaVe,
            this.LePhiHoanTra,
            this.TienHoanTra});
            this.dgvQuanLy.Location = new System.Drawing.Point(5, 17);
            this.dgvQuanLy.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanLy.Name = "dgvQuanLy";
            this.dgvQuanLy.ReadOnly = true;
            this.dgvQuanLy.RowHeadersWidth = 51;
            this.dgvQuanLy.RowTemplate.Height = 24;
            this.dgvQuanLy.Size = new System.Drawing.Size(1105, 260);
            this.dgvQuanLy.TabIndex = 0;
            this.dgvQuanLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLy_CellClick);
            // 
            // MaDuKhach
            // 
            this.MaDuKhach.DataPropertyName = "MaDuKhach";
            this.MaDuKhach.HeaderText = "Customer ID";
            this.MaDuKhach.MinimumWidth = 6;
            this.MaDuKhach.Name = "MaDuKhach";
            this.MaDuKhach.ReadOnly = true;
            this.MaDuKhach.Visible = false;
            this.MaDuKhach.Width = 125;
            // 
            // MaChuyen
            // 
            this.MaChuyen.DataPropertyName = "MaChuyen";
            this.MaChuyen.HeaderText = "Tour ID";
            this.MaChuyen.MinimumWidth = 6;
            this.MaChuyen.Name = "MaChuyen";
            this.MaChuyen.ReadOnly = true;
            this.MaChuyen.Width = 125;
            // 
            // MaVe
            // 
            this.MaVe.DataPropertyName = "MaVe";
            this.MaVe.HeaderText = "Ticket ID";
            this.MaVe.MinimumWidth = 6;
            this.MaVe.Name = "MaVe";
            this.MaVe.ReadOnly = true;
            this.MaVe.Visible = false;
            this.MaVe.Width = 125;
            // 
            // MaPhieuDatCho
            // 
            this.MaPhieuDatCho.DataPropertyName = "MaPhieu";
            this.MaPhieuDatCho.HeaderText = "Reservation ID";
            this.MaPhieuDatCho.MinimumWidth = 6;
            this.MaPhieuDatCho.Name = "MaPhieuDatCho";
            this.MaPhieuDatCho.ReadOnly = true;
            this.MaPhieuDatCho.Visible = false;
            this.MaPhieuDatCho.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Name";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 170;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Address";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 170;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Phone Number";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 160;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Gender";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // TenloaiKhach
            // 
            this.TenloaiKhach.DataPropertyName = "TenLoaiKhach";
            this.TenloaiKhach.HeaderText = "Tourist";
            this.TenloaiKhach.MinimumWidth = 6;
            this.TenloaiKhach.Name = "TenloaiKhach";
            this.TenloaiKhach.ReadOnly = true;
            this.TenloaiKhach.Width = 125;
            // 
            // HanPassport
            // 
            this.HanPassport.DataPropertyName = "HanPassport";
            this.HanPassport.HeaderText = "Passport";
            this.HanPassport.MinimumWidth = 6;
            this.HanPassport.Name = "HanPassport";
            this.HanPassport.ReadOnly = true;
            this.HanPassport.Width = 125;
            // 
            // HanVisa
            // 
            this.HanVisa.DataPropertyName = "HanVisa";
            this.HanVisa.HeaderText = "Visa";
            this.HanVisa.MinimumWidth = 6;
            this.HanVisa.Name = "HanVisa";
            this.HanVisa.ReadOnly = true;
            this.HanVisa.Width = 125;
            // 
            // CMND_Passport
            // 
            this.CMND_Passport.DataPropertyName = "CMND_Passport";
            this.CMND_Passport.HeaderText = "Identification Card Num";
            this.CMND_Passport.MinimumWidth = 6;
            this.CMND_Passport.Name = "CMND_Passport";
            this.CMND_Passport.ReadOnly = true;
            this.CMND_Passport.Width = 170;
            // 
            // TenLoaiChuyen
            // 
            this.TenLoaiChuyen.DataPropertyName = "TenLoaiChuyen";
            this.TenLoaiChuyen.HeaderText = "Type of Tour";
            this.TenLoaiChuyen.MinimumWidth = 6;
            this.TenLoaiChuyen.Name = "TenLoaiChuyen";
            this.TenLoaiChuyen.ReadOnly = true;
            this.TenLoaiChuyen.Width = 125;
            // 
            // TenLoaiTuyen
            // 
            this.TenLoaiTuyen.DataPropertyName = "TenLoaiTuyen";
            this.TenLoaiTuyen.HeaderText = "Type of Route";
            this.TenLoaiTuyen.MinimumWidth = 6;
            this.TenLoaiTuyen.Name = "TenLoaiTuyen";
            this.TenLoaiTuyen.ReadOnly = true;
            this.TenLoaiTuyen.Width = 125;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Cost";
            this.GiaVe.MinimumWidth = 6;
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            this.GiaVe.Width = 125;
            // 
            // LePhiHoanTra
            // 
            this.LePhiHoanTra.DataPropertyName = "LePhiHoanTra";
            this.LePhiHoanTra.HeaderText = "Price refund";
            this.LePhiHoanTra.MinimumWidth = 6;
            this.LePhiHoanTra.Name = "LePhiHoanTra";
            this.LePhiHoanTra.ReadOnly = true;
            this.LePhiHoanTra.Visible = false;
            this.LePhiHoanTra.Width = 125;
            // 
            // TienHoanTra
            // 
            this.TienHoanTra.DataPropertyName = "TienHoanTra";
            this.TienHoanTra.HeaderText = "Rate Price refund";
            this.TienHoanTra.MinimumWidth = 6;
            this.TienHoanTra.Name = "TienHoanTra";
            this.TienHoanTra.ReadOnly = true;
            this.TienHoanTra.Visible = false;
            this.TienHoanTra.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTraVe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.tbICN);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbphone);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1106, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnTraVe
            // 
            this.btnTraVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraVe.BackgroundImage")));
            this.btnTraVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraVe.FlatAppearance.BorderSize = 0;
            this.btnTraVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraVe.Location = new System.Drawing.Point(458, 152);
            this.btnTraVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraVe.Name = "btnTraVe";
            this.btnTraVe.Size = new System.Drawing.Size(112, 38);
            this.btnTraVe.TabIndex = 20;
            this.btnTraVe.Text = "Return Ticket";
            this.btnTraVe.UseVisualStyleBackColor = true;
            this.btnTraVe.Click += new System.EventHandler(this.btnTraVe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "ICNumber";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(371, 152);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 38);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbICN
            // 
            this.tbICN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbICN.Location = new System.Drawing.Point(397, 111);
            this.tbICN.Margin = new System.Windows.Forms.Padding(2);
            this.tbICN.MaxLength = 20;
            this.tbICN.Name = "tbICN";
            this.tbICN.Size = new System.Drawing.Size(164, 26);
            this.tbICN.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(280, 152);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Addr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone ";
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(58, 156);
            this.tbphone.Margin = new System.Windows.Forms.Padding(2);
            this.tbphone.MaxLength = 20;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(210, 26);
            this.tbphone.TabIndex = 5;
            this.tbphone.Enter += new System.EventHandler(this.tbphone_Enter);
            this.tbphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbphone_KeyPress);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(58, 107);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.MaxLength = 30;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(210, 26);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.Enter += new System.EventHandler(this.tbAddress_Enter);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(58, 61);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(210, 26);
            this.tbName.TabIndex = 3;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(58, 18);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaxLength = 20;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(210, 26);
            this.tbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TourID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rdbFemale);
            this.panel1.Controls.Add(this.rdbMale);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(311, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 39);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(169, 10);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(71, 23);
            this.rdbFemale.TabIndex = 12;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(76, 10);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(58, 23);
            this.rdbMale.TabIndex = 11;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // tbSearchTicket
            // 
            this.tbSearchTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchTicket.Location = new System.Drawing.Point(885, 371);
            this.tbSearchTicket.Name = "tbSearchTicket";
            this.tbSearchTicket.Size = new System.Drawing.Size(240, 26);
            this.tbSearchTicket.TabIndex = 6;
            this.tbSearchTicket.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbSearchTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchTicket_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ticket search";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(280, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 36);
            this.label11.TabIndex = 16;
            this.label11.Text = "MANAGE TICKETS";
            // 
            // CSDLPhieuDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tour.Properties.Resources.Tour1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 677);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSearchTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CSDLPhieuDatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSDLPhieuDatCho";
            this.Load += new System.EventHandler(this.CSDLPhieuDatCho_Load);
            this.Information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.DataGridView dgvQuanLy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbICN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchTicket;
        private System.Windows.Forms.Button btnTraVe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDuKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenloaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanVisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND_Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LePhiHoanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienHoanTra;
    }
}