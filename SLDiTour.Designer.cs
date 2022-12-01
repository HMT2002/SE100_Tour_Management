namespace Tour
{
    partial class SLDiTour
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
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLANDITOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN,
            this.MSNV,
            this.SOLANDITOUR});
            this.dataGridView1.Location = new System.Drawing.Point(25, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên nhân viên";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.Width = 125;
            // 
            // MSNV
            // 
            this.MSNV.DataPropertyName = "MSNV";
            this.MSNV.HeaderText = "Mã số nhân viên";
            this.MSNV.MinimumWidth = 6;
            this.MSNV.Name = "MSNV";
            this.MSNV.Width = 125;
            // 
            // SOLANDITOUR
            // 
            this.SOLANDITOUR.DataPropertyName = "SL_Di_Tour";
            this.SOLANDITOUR.HeaderText = "Số lần đi tour";
            this.SOLANDITOUR.MinimumWidth = 6;
            this.SOLANDITOUR.Name = "SOLANDITOUR";
            this.SOLANDITOUR.Width = 125;
            // 
            // SLDiTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SLDiTour";
            this.Text = "SLDiTour";
            this.Load += new System.EventHandler(this.SLDiTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLANDITOUR;
    }
}