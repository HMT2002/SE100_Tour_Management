
namespace Tour
{
    partial class PhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhuongTien));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPickPicture = new System.Windows.Forms.Button();
            this.pcbxVehical = new System.Windows.Forms.PictureBox();
            this.cbbxKind = new System.Windows.Forms.ComboBox();
            this.cbboxProvince = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rchtxtbxDetail = new System.Windows.Forms.RichTextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.cbbxVehical = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< Updated upstream
            this.txtbxGia = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
=======
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbxVehical = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rchtxtbxDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbboxProvince = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbxKind = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbxGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPickPicture = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pcbxVehical = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVehical)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnPickPicture);
            this.panel3.Controls.Add(this.pcbxVehical);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 344);
            this.panel3.TabIndex = 8;
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.Location = new System.Drawing.Point(192, 318);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPickPicture.TabIndex = 4;
            this.btnPickPicture.Text = "Add picture";
            this.btnPickPicture.UseVisualStyleBackColor = true;
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // pcbxVehical
            // 
            this.pcbxVehical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxVehical.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxVehical.Location = new System.Drawing.Point(3, 3);
            this.pcbxVehical.Name = "pcbxVehical";
            this.pcbxVehical.Size = new System.Drawing.Size(447, 309);
            this.pcbxVehical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxVehical.TabIndex = 0;
            this.pcbxVehical.TabStop = false;
            // 
            // cbbxKind
            // 
            this.cbbxKind.FormattingEnabled = true;
            this.cbbxKind.Location = new System.Drawing.Point(553, 69);
            this.cbbxKind.Name = "cbbxKind";
            this.cbbxKind.Size = new System.Drawing.Size(232, 21);
            this.cbbxKind.TabIndex = 19;
            // 
            // cbboxProvince
            // 
            this.cbboxProvince.FormattingEnabled = true;
            this.cbboxProvince.Location = new System.Drawing.Point(553, 122);
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.Size = new System.Drawing.Size(232, 21);
            this.cbboxProvince.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(471, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tỉnh/Quốc gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(471, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(471, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng kí";
            // 
<<<<<<< Updated upstream
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.Location = new System.Drawing.Point(474, 149);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(314, 175);
            this.rchtxtbxDetail.TabIndex = 8;
            this.rchtxtbxDetail.Text = "";
=======
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cost/day";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.CustomImages.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(19, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 67);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.FillColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(326, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(300, 67);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
>>>>>>> Stashed changes
            // 
            // txtbxName
            // 
<<<<<<< Updated upstream
            this.txtbxName.Location = new System.Drawing.Point(553, 44);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(232, 20);
            this.txtbxName.TabIndex = 6;
=======
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(19, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 67);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
>>>>>>> Stashed changes
            // 
            // cbbxVehical
            // 
<<<<<<< Updated upstream
            this.cbbxVehical.FormattingEnabled = true;
            this.cbbxVehical.Location = new System.Drawing.Point(471, 17);
            this.cbbxVehical.Name = "cbbxVehical";
            this.cbbxVehical.Size = new System.Drawing.Size(233, 21);
            this.cbbxVehical.TabIndex = 4;
            this.cbbxVehical.SelectedValueChanged += new System.EventHandler(this.cbbxVehical_SelectedValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(710, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
=======
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnExit.BorderRadius = 5;
            this.btnExit.BorderThickness = 2;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(326, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 67);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 5;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(197)))), ((int)(((byte)(175)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(276, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 26;
>>>>>>> Stashed changes
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
<<<<<<< Updated upstream
            // btnUpdate
=======
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(197)))), ((int)(((byte)(175)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.cbbxVehical);
            this.guna2Panel1.Controls.Add(this.rchtxtbxDetail);
            this.guna2Panel1.Controls.Add(this.cbboxProvince);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.cbbxKind);
            this.guna2Panel1.Controls.Add(this.txtbxGia);
            this.guna2Panel1.Controls.Add(this.txtbxName);
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(46, 120);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(408, 647);
            this.guna2Panel1.TabIndex = 27;
>>>>>>> Stashed changes
            // 
            this.btnUpdate.Location = new System.Drawing.Point(668, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
<<<<<<< Updated upstream
            // btnXoa
=======
            this.cbbxVehical.BackColor = System.Drawing.Color.Transparent;
            this.cbbxVehical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbbxVehical.BorderRadius = 5;
            this.cbbxVehical.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxVehical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxVehical.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxVehical.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxVehical.ForeColor = System.Drawing.Color.Black;
            this.cbbxVehical.FormattingEnabled = true;
            this.cbbxVehical.ItemHeight = 30;
            this.cbbxVehical.Location = new System.Drawing.Point(27, 35);
            this.cbbxVehical.Name = "cbbxVehical";
            this.cbbxVehical.Size = new System.Drawing.Size(243, 36);
            this.cbbxVehical.TabIndex = 33;
            this.cbbxVehical.SelectedValueChanged += new System.EventHandler(this.cbbxVehical_SelectedValueChanged);
>>>>>>> Stashed changes
            // 
            this.btnXoa.Location = new System.Drawing.Point(587, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
<<<<<<< Updated upstream
            // btnAdd
=======
            this.rchtxtbxDetail.AutoScroll = true;
            this.rchtxtbxDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.rchtxtbxDetail.BorderRadius = 5;
            this.rchtxtbxDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rchtxtbxDetail.DefaultText = "";
            this.rchtxtbxDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rchtxtbxDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rchtxtbxDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rchtxtbxDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rchtxtbxDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rchtxtbxDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rchtxtbxDetail.ForeColor = System.Drawing.Color.Black;
            this.rchtxtbxDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rchtxtbxDetail.Location = new System.Drawing.Point(27, 419);
            this.rchtxtbxDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rchtxtbxDetail.Multiline = true;
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.PasswordChar = '\0';
            this.rchtxtbxDetail.PlaceholderText = "";
            this.rchtxtbxDetail.SelectedText = "";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(349, 204);
            this.rchtxtbxDetail.TabIndex = 32;
>>>>>>> Stashed changes
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
<<<<<<< Updated upstream
            // btnExit
=======
            this.cbboxProvince.BackColor = System.Drawing.Color.Transparent;
            this.cbboxProvince.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbboxProvince.BorderRadius = 5;
            this.cbboxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxProvince.DropDownHeight = 150;
            this.cbboxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxProvince.FocusedColor = System.Drawing.Color.Empty;
            this.cbboxProvince.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxProvince.ForeColor = System.Drawing.Color.Black;
            this.cbboxProvince.FormattingEnabled = true;
            this.cbboxProvince.IntegralHeight = false;
            this.cbboxProvince.ItemHeight = 30;
            this.cbboxProvince.Location = new System.Drawing.Point(27, 351);
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.Size = new System.Drawing.Size(349, 36);
            this.cbboxProvince.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Detail";
>>>>>>> Stashed changes
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
<<<<<<< Updated upstream
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giá/ngày";
            // 
            // txtbxGia
            // 
            this.txtbxGia.Location = new System.Drawing.Point(553, 96);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.Size = new System.Drawing.Size(235, 20);
            this.txtbxGia.TabIndex = 20;
            this.txtbxGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxGia_KeyPress);
            // 
=======
            this.cbbxKind.BackColor = System.Drawing.Color.Transparent;
            this.cbbxKind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbbxKind.BorderRadius = 5;
            this.cbbxKind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxKind.FocusedColor = System.Drawing.Color.Empty;
            this.cbbxKind.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxKind.ForeColor = System.Drawing.Color.Black;
            this.cbbxKind.FormattingEnabled = true;
            this.cbbxKind.ItemHeight = 30;
            this.cbbxKind.Location = new System.Drawing.Point(27, 201);
            this.cbbxKind.Name = "cbbxKind";
            this.cbbxKind.Size = new System.Drawing.Size(349, 36);
            this.cbbxKind.TabIndex = 28;
            // 
            // txtbxGia
            // 
            this.txtbxGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxGia.BorderRadius = 5;
            this.txtbxGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxGia.DefaultText = "";
            this.txtbxGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxGia.ForeColor = System.Drawing.Color.Black;
            this.txtbxGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Location = new System.Drawing.Point(27, 269);
            this.txtbxGia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.PasswordChar = '\0';
            this.txtbxGia.PlaceholderText = "Cost/day";
            this.txtbxGia.SelectedText = "";
            this.txtbxGia.Size = new System.Drawing.Size(349, 44);
            this.txtbxGia.TabIndex = 27;
            this.txtbxGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxGia_KeyPress);
            // 
            // txtbxName
            // 
            this.txtbxName.BackColor = System.Drawing.Color.Transparent;
            this.txtbxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.BorderRadius = 5;
            this.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxName.DefaultText = "";
            this.txtbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.ForeColor = System.Drawing.Color.Black;
            this.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Location = new System.Drawing.Point(27, 125);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.PasswordChar = '\0';
            this.txtbxName.PlaceholderText = "Register Name";
            this.txtbxName.SelectedText = "";
            this.txtbxName.Size = new System.Drawing.Size(349, 44);
            this.txtbxName.TabIndex = 10;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(197)))), ((int)(((byte)(175)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.btnUpdate);
            this.guna2Panel2.Controls.Add(this.btnXoa);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(509, 557);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(664, 210);
            this.guna2Panel2.TabIndex = 28;
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnPickPicture.BorderRadius = 5;
            this.btnPickPicture.BorderThickness = 2;
            this.btnPickPicture.FillColor = System.Drawing.Color.Transparent;
            this.btnPickPicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickPicture.ForeColor = System.Drawing.Color.Black;
            this.btnPickPicture.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnPickPicture.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPickPicture.Location = new System.Drawing.Point(771, 498);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(156, 45);
            this.btnPickPicture.TabIndex = 24;
            this.btnPickPicture.Text = "Add picture";
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(197)))), ((int)(((byte)(175)))));
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.pcbxVehical);
            this.guna2Panel3.Location = new System.Drawing.Point(509, 120);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(664, 364);
            this.guna2Panel3.TabIndex = 29;
            // 
            // pcbxVehical
            // 
            this.pcbxVehical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxVehical.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxVehical.Location = new System.Drawing.Point(29, 21);
            this.pcbxVehical.Margin = new System.Windows.Forms.Padding(4);
            this.pcbxVehical.Name = "pcbxVehical";
            this.pcbxVehical.Size = new System.Drawing.Size(610, 321);
            this.pcbxVehical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxVehical.TabIndex = 0;
            this.pcbxVehical.TabStop = false;
            this.pcbxVehical.Click += new System.EventHandler(this.pcbxVehical_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(410, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(446, 55);
            this.label7.TabIndex = 40;
            this.label7.Text = "Quản lý phương tiện";
            // 
>>>>>>> Stashed changes
            // PhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxGia);
            this.Controls.Add(this.cbbxKind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbboxProvince);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rchtxtbxDetail);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbbxVehical);
=======
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btnPickPicture);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
>>>>>>> Stashed changes
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhuongTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhuongTien";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVehical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPickPicture;
        private System.Windows.Forms.PictureBox pcbxVehical;
        private System.Windows.Forms.ComboBox cbboxProvince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchtxtbxDetail;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.ComboBox cbbxVehical;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbxKind;
        private System.Windows.Forms.Label label1;
<<<<<<< Updated upstream
        private System.Windows.Forms.TextBox txtbxGia;
=======
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtbxName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxGia;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxKind;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxProvince;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox rchtxtbxDetail;
        private Guna.UI2.WinForms.Guna2Button btnPickPicture;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.PictureBox pcbxVehical;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxVehical;
        private System.Windows.Forms.Label label7;
>>>>>>> Stashed changes
    }
}