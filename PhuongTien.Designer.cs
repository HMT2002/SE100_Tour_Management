
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPickPicture = new System.Windows.Forms.Button();
            this.pcbxVehical = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVehical)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnPickPicture);
            this.panel3.Controls.Add(this.pcbxVehical);
            this.panel3.Location = new System.Drawing.Point(16, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 423);
            this.panel3.TabIndex = 8;
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.Location = new System.Drawing.Point(256, 391);
            this.btnPickPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(100, 28);
            this.btnPickPicture.TabIndex = 4;
            this.btnPickPicture.Text = "Chọn ảnh";
            this.btnPickPicture.UseVisualStyleBackColor = true;
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // pcbxVehical
            // 
            this.pcbxVehical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxVehical.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxVehical.Location = new System.Drawing.Point(4, 4);
            this.pcbxVehical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbxVehical.Name = "pcbxVehical";
            this.pcbxVehical.Size = new System.Drawing.Size(596, 380);
            this.pcbxVehical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxVehical.TabIndex = 0;
            this.pcbxVehical.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cbbxKind);
            this.panel1.Controls.Add(this.cbboxProvince);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rchtxtbxDetail);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.cbbxVehical);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(624, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 423);
            this.panel1.TabIndex = 7;
            // 
            // cbbxKind
            // 
            this.cbbxKind.FormattingEnabled = true;
            this.cbbxKind.Location = new System.Drawing.Point(113, 70);
            this.cbbxKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbxKind.Name = "cbbxKind";
            this.cbbxKind.Size = new System.Drawing.Size(308, 24);
            this.cbbxKind.TabIndex = 19;
            // 
            // cbboxProvince
            // 
            this.cbboxProvince.FormattingEnabled = true;
            this.cbboxProvince.Location = new System.Drawing.Point(113, 103);
            this.cbboxProvince.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.Size = new System.Drawing.Size(308, 24);
            this.cbboxProvince.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tỉnh/Quốc gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng kí";
            // 
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.Location = new System.Drawing.Point(8, 137);
            this.rchtxtbxDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(417, 246);
            this.rchtxtbxDetail.TabIndex = 8;
            this.rchtxtbxDetail.Text = "";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(113, 39);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(308, 22);
            this.txtbxName.TabIndex = 6;
            // 
            // cbbxVehical
            // 
            this.cbbxVehical.FormattingEnabled = true;
            this.cbbxVehical.Location = new System.Drawing.Point(4, 6);
            this.cbbxVehical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbxVehical.Name = "cbbxVehical";
            this.cbbxVehical.Size = new System.Drawing.Size(309, 24);
            this.cbbxVehical.TabIndex = 4;
            this.cbbxVehical.SelectedValueChanged += new System.EventHandler(this.cbbxVehical_SelectedValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(323, 4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 391);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(159, 391);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 391);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(16, 446);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 156);
            this.panel2.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(931, 124);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhuongTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhuongTien";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxVehical)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPickPicture;
        private System.Windows.Forms.PictureBox pcbxVehical;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbxKind;
    }
}