
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPickPicture = new System.Windows.Forms.Button();
            this.pcbxLocation = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbboxProvince = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchtxtbxDetail = new System.Windows.Forms.RichTextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.cbbxHotel = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(710, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnPickPicture);
            this.panel3.Controls.Add(this.pcbxLocation);
            this.panel3.Location = new System.Drawing.Point(12, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 241);
            this.panel3.TabIndex = 5;
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.Location = new System.Drawing.Point(172, 213);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPickPicture.TabIndex = 4;
            this.btnPickPicture.Text = "Chọn ảnh";
            this.btnPickPicture.UseVisualStyleBackColor = true;
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // pcbxLocation
            // 
            this.pcbxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxLocation.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxLocation.Location = new System.Drawing.Point(3, 3);
            this.pcbxLocation.Name = "pcbxLocation";
            this.pcbxLocation.Size = new System.Drawing.Size(385, 204);
            this.pcbxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLocation.TabIndex = 0;
            this.pcbxLocation.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cbboxProvince);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbxSDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbxGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbxDiaChi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rchtxtbxDetail);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.cbbxHotel);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(412, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 344);
            this.panel1.TabIndex = 4;
            // 
            // cbboxProvince
            // 
            this.cbboxProvince.FormattingEnabled = true;
            this.cbboxProvince.Location = new System.Drawing.Point(85, 136);
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.Size = new System.Drawing.Size(288, 21);
            this.cbboxProvince.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tỉnh/Quốc gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SĐT";
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.Location = new System.Drawing.Point(85, 110);
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.Size = new System.Drawing.Size(288, 20);
            this.txtbxSDT.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá/ngày";
            // 
            // txtbxGia
            // 
            this.txtbxGia.Location = new System.Drawing.Point(85, 84);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.Size = new System.Drawing.Size(288, 20);
            this.txtbxGia.TabIndex = 13;
            this.txtbxGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxGia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ";
            // 
            // txtbxDiaChi
            // 
            this.txtbxDiaChi.Location = new System.Drawing.Point(85, 58);
            this.txtbxDiaChi.Name = "txtbxDiaChi";
            this.txtbxDiaChi.Size = new System.Drawing.Size(288, 20);
            this.txtbxDiaChi.TabIndex = 11;
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
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.Location = new System.Drawing.Point(3, 163);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(370, 149);
            this.rchtxtbxDetail.TabIndex = 8;
            this.rchtxtbxDetail.Text = "";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(85, 32);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(288, 20);
            this.txtbxName.TabIndex = 6;
            // 
            // cbbxHotel
            // 
            this.cbbxHotel.FormattingEnabled = true;
            this.cbbxHotel.Location = new System.Drawing.Point(85, 5);
            this.cbbxHotel.Name = "cbbxHotel";
            this.cbbxHotel.Size = new System.Drawing.Size(207, 21);
            this.cbbxHotel.TabIndex = 4;
            this.cbbxHotel.SelectedValueChanged += new System.EventHandler(this.cbbxHotel_SelectedValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(298, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(252, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(171, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnExit);
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPickPicture;
        private System.Windows.Forms.PictureBox pcbxLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchtxtbxDetail;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.ComboBox cbbxHotel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxSDT;
        private System.Windows.Forms.ComboBox cbboxProvince;
        private System.Windows.Forms.Label label5;
    }
}