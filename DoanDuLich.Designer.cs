
namespace Tour
{
    partial class DoanDuLich
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.rdNameSearch = new System.Windows.Forms.RadioButton();
            this.rdIDSearch = new System.Windows.Forms.RadioButton();
            this.data_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKHOIHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHITIETCHUONGTRINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(588, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(588, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(588, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(588, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(570, 147);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_ID,
            this.TEN,
            this.NGAYKHOIHANH,
            this.NGAYKETTHUC,
            this.CHITIETCHUONGTRINH,
            this.CHIPHI,
            this.TENTOUR});
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 244);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(12, 168);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(315, 20);
            this.tb_search.TabIndex = 10;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // rdNameSearch
            // 
            this.rdNameSearch.AutoSize = true;
            this.rdNameSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNameSearch.ForeColor = System.Drawing.Color.Black;
            this.rdNameSearch.Location = new System.Drawing.Point(392, 166);
            this.rdNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdNameSearch.Name = "rdNameSearch";
            this.rdNameSearch.Size = new System.Drawing.Size(64, 23);
            this.rdNameSearch.TabIndex = 20;
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
            this.rdIDSearch.Location = new System.Drawing.Point(341, 168);
            this.rdIDSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdIDSearch.Name = "rdIDSearch";
            this.rdIDSearch.Size = new System.Drawing.Size(43, 23);
            this.rdIDSearch.TabIndex = 19;
            this.rdIDSearch.TabStop = true;
            this.rdIDSearch.Text = "ID";
            this.rdIDSearch.UseVisualStyleBackColor = true;
            this.rdIDSearch.Enter += new System.EventHandler(this.rdIDSearch_Enter);
            // 
            // data_ID
            // 
            this.data_ID.DataPropertyName = "ID";
            this.data_ID.HeaderText = "ID";
            this.data_ID.Name = "data_ID";
            this.data_ID.Width = 90;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên đoàn";
            this.TEN.Name = "TEN";
            // 
            // NGAYKHOIHANH
            // 
            this.NGAYKHOIHANH.DataPropertyName = "NGAYKHOIHANH";
            this.NGAYKHOIHANH.HeaderText = "Ngày khởi hành";
            this.NGAYKHOIHANH.Name = "NGAYKHOIHANH";
            this.NGAYKHOIHANH.Width = 120;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.DataPropertyName = "NGAYKETTHUC";
            this.NGAYKETTHUC.HeaderText = "Ngày kết thúc";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Width = 120;
            // 
            // CHITIETCHUONGTRINH
            // 
            this.CHITIETCHUONGTRINH.DataPropertyName = "CHITIETCHUONGTRINH";
            this.CHITIETCHUONGTRINH.HeaderText = "Chi tiết chương trình";
            this.CHITIETCHUONGTRINH.Name = "CHITIETCHUONGTRINH";
            // 
            // CHIPHI
            // 
            this.CHIPHI.DataPropertyName = "TONG";
            this.CHIPHI.HeaderText = "Chi phí";
            this.CHIPHI.Name = "CHIPHI";
            // 
            // TENTOUR
            // 
            this.TENTOUR.DataPropertyName = "TEN_TOUR";
            this.TENTOUR.HeaderText = "Tour";
            this.TENTOUR.Name = "TENTOUR";
            // 
            // DoanDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdNameSearch);
            this.Controls.Add(this.rdIDSearch);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanDuLich";
            this.Text = "DoanDuLich";
            this.Load += new System.EventHandler(this.DoanDuLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.RadioButton rdNameSearch;
        private System.Windows.Forms.RadioButton rdIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKHOIHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHITIETCHUONGTRINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIPHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTOUR;
    }
}