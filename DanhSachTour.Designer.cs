namespace Tour
{
    partial class DanhSachTour
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTOUR,
            this.TENTOUR,
            this.IDDOAN});
            this.dataGridView1.Location = new System.Drawing.Point(178, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // IDTOUR
            // 
            this.IDTOUR.DataPropertyName = "IDTOUR";
            this.IDTOUR.HeaderText = "ID Tour";
            this.IDTOUR.MinimumWidth = 6;
            this.IDTOUR.Name = "IDTOUR";
            this.IDTOUR.Width = 125;
            // 
            // TENTOUR
            // 
            this.TENTOUR.DataPropertyName = "TENTOUR";
            this.TENTOUR.HeaderText = "Tên Tour";
            this.TENTOUR.MinimumWidth = 6;
            this.TENTOUR.Name = "TENTOUR";
            this.TENTOUR.Width = 125;
            // 
            // IDDOAN
            // 
            this.IDDOAN.DataPropertyName = "IDDOAN";
            this.IDDOAN.HeaderText = "ID Đoàn";
            this.IDDOAN.MinimumWidth = 6;
            this.IDDOAN.Name = "IDDOAN";
            this.IDDOAN.Width = 125;
            // 
            // DanhSachTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachTour";
            this.Text = "DanhSachTour";
            this.Load += new System.EventHandler(this.DanhSachTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDOAN;
    }
}