
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPickPicture = new Guna.UI2.WinForms.Guna2Button();
            this.pcbxLocation = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cbboxProvince = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rchtxtbxDetail = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnPickPicture);
            this.panel3.Controls.Add(this.pcbxLocation);
            this.panel3.Location = new System.Drawing.Point(405, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 429);
            this.panel3.TabIndex = 5;
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.BorderRadius = 20;
            this.btnPickPicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPickPicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPickPicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPickPicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPickPicture.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPickPicture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPickPicture.ForeColor = System.Drawing.Color.White;
            this.btnPickPicture.Location = new System.Drawing.Point(139, 381);
            this.btnPickPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(135, 37);
            this.btnPickPicture.TabIndex = 5;
            this.btnPickPicture.Text = "Chọn ảnh";
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // pcbxLocation
            // 
            this.pcbxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxLocation.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxLocation.Location = new System.Drawing.Point(3, 11);
            this.pcbxLocation.Name = "pcbxLocation";
            this.pcbxLocation.Size = new System.Drawing.Size(385, 354);
            this.pcbxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLocation.TabIndex = 0;
            this.pcbxLocation.TabStop = false;
            this.pcbxLocation.Click += new System.EventHandler(this.pcbxLocation_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
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
            this.panel1.Controls.Add(this.cbboxProvince);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rchtxtbxDetail);
            this.panel1.Location = new System.Drawing.Point(13, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 430);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Giá/Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(8, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Khách sạn";
            // 
            // cbbxHotel
            // 
            this.cbbxHotel.BackColor = System.Drawing.Color.Transparent;
            this.cbbxHotel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxHotel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbxHotel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbxHotel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbxHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbxHotel.ItemHeight = 30;
            this.cbbxHotel.Location = new System.Drawing.Point(111, 2);
            this.cbbxHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbxHotel.Name = "cbbxHotel";
            this.cbbxHotel.Size = new System.Drawing.Size(266, 36);
            this.cbbxHotel.TabIndex = 28;
            this.cbbxHotel.SelectedValueChanged += new System.EventHandler(this.cbbxHotel_SelectedValueChanged);
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
            this.txtbxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Location = new System.Drawing.Point(111, 44);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.PasswordChar = '\0';
            this.txtbxName.PlaceholderText = "";
            this.txtbxName.SelectedText = "";
            this.txtbxName.Size = new System.Drawing.Size(266, 29);
            this.txtbxName.TabIndex = 30;
            // 
            // txtbxDiaChi
            // 
            this.txtbxDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxDiaChi.DefaultText = "";
            this.txtbxDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxDiaChi.Location = new System.Drawing.Point(111, 86);
            this.txtbxDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxDiaChi.Name = "txtbxDiaChi";
            this.txtbxDiaChi.PasswordChar = '\0';
            this.txtbxDiaChi.PlaceholderText = "";
            this.txtbxDiaChi.SelectedText = "";
            this.txtbxDiaChi.Size = new System.Drawing.Size(266, 29);
            this.txtbxDiaChi.TabIndex = 29;
            // 
            // txtbxGia
            // 
            this.txtbxGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxGia.DefaultText = "";
            this.txtbxGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Location = new System.Drawing.Point(111, 128);
            this.txtbxGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.PasswordChar = '\0';
            this.txtbxGia.PlaceholderText = "";
            this.txtbxGia.SelectedText = "";
            this.txtbxGia.Size = new System.Drawing.Size(266, 29);
            this.txtbxGia.TabIndex = 30;
            this.txtbxGia.TextChanged += new System.EventHandler(this.txtbxGia_TextChanged);
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
            this.txtbxSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSDT.Location = new System.Drawing.Point(111, 169);
            this.txtbxSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.PasswordChar = '\0';
            this.txtbxSDT.PlaceholderText = "";
            this.txtbxSDT.SelectedText = "";
            this.txtbxSDT.Size = new System.Drawing.Size(266, 29);
            this.txtbxSDT.TabIndex = 28;
            // 
            // cbboxProvince
            // 
            this.cbboxProvince.BackColor = System.Drawing.Color.Transparent;
            this.cbboxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxProvince.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxProvince.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxProvince.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxProvince.ItemHeight = 30;
            this.cbboxProvince.Location = new System.Drawing.Point(111, 210);
            this.cbboxProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.Size = new System.Drawing.Size(266, 36);
            this.cbboxProvince.TabIndex = 25;
            this.cbboxProvince.SelectedIndexChanged += new System.EventHandler(this.cbboxProvince_SelectedIndexChanged);
            this.cbboxProvince.Click += new System.EventHandler(this.pcbxLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tỉnh/Thành phố";
            // 
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rchtxtbxDetail.Location = new System.Drawing.Point(8, 254);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(370, 173);
            this.rchtxtbxDetail.TabIndex = 8;
            this.rchtxtbxDetail.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(241, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 43);
            this.label6.TabIndex = 24;
            this.label6.Text = "Quản lý khách sạn";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(210, 579);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 37);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(363, 579);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 37);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Gold;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(511, 579);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 37);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 637);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcbxLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchtxtbxDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxProvince;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxHotel;
        private Guna.UI2.WinForms.Guna2TextBox txtbxName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtbxGia;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSDT;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnPickPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}