
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
            this.txtbxGia = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
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
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.Location = new System.Drawing.Point(474, 149);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(314, 175);
            this.rchtxtbxDetail.TabIndex = 8;
            this.rchtxtbxDetail.Text = "";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(553, 44);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(232, 20);
            this.txtbxName.TabIndex = 6;
            // 
            // cbbxVehical
            // 
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
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(668, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(587, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
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
            // PhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
        private System.Windows.Forms.TextBox txtbxGia;
    }
}