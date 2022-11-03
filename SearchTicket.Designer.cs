
namespace Tour
{
    partial class SearchTicket
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
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.data_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKHOIHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTROVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_id,
            this.TEN,
            this.TOUR,
            this.DOAN,
            this.NGAYKHOIHANH,
            this.NGAYTROVE,
            this.GIA});
            this.dgvTicket.Location = new System.Drawing.Point(12, 12);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(776, 252);
            this.dgvTicket.TabIndex = 0;
            // 
            // data_id
            // 
            this.data_id.DataPropertyName = "ID";
            this.data_id.HeaderText = "ID";
            this.data_id.Name = "data_id";
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN_KH";
            this.TEN.HeaderText = "Tên khách hàng";
            this.TEN.Name = "TEN";
            // 
            // TOUR
            // 
            this.TOUR.DataPropertyName = "TEN_TOUR";
            this.TOUR.HeaderText = "Tour du lịch";
            this.TOUR.Name = "TOUR";
            // 
            // DOAN
            // 
            this.DOAN.DataPropertyName = "TEN_DOAN";
            this.DOAN.HeaderText = "Đoàn du lịch";
            this.DOAN.Name = "DOAN";
            // 
            // NGAYKHOIHANH
            // 
            this.NGAYKHOIHANH.DataPropertyName = "NGAYKHOIHANH";
            this.NGAYKHOIHANH.HeaderText = "Ngày khởi hành";
            this.NGAYKHOIHANH.Name = "NGAYKHOIHANH";
            // 
            // NGAYTROVE
            // 
            this.NGAYTROVE.DataPropertyName = "NGAYTROVE";
            this.NGAYTROVE.HeaderText = "Ngày trở về";
            this.NGAYTROVE.Name = "NGAYTROVE";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            // 
            // SearchTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTicket);
            this.Name = "SearchTicket";
            this.Text = "SearchTicket";
            this.Load += new System.EventHandler(this.SearchTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKHOIHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTROVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
    }
}