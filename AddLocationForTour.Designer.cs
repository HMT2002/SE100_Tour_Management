
namespace Tour
{
    partial class AddLocationForTour
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btngunaExit = new Guna.UI2.WinForms.Guna2Button();
            this.btngunaUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(995, 330);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(16, 360);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(995, 160);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            // 
            // btngunaExit
            // 
            this.btngunaExit.BackColor = System.Drawing.Color.Transparent;
            this.btngunaExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaExit.BorderRadius = 10;
            this.btngunaExit.BorderThickness = 2;
            this.btngunaExit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(187)))));
            this.btngunaExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngunaExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaExit.Location = new System.Drawing.Point(792, 532);
            this.btngunaExit.Margin = new System.Windows.Forms.Padding(4);
            this.btngunaExit.Name = "btngunaExit";
            this.btngunaExit.Size = new System.Drawing.Size(220, 55);
            this.btngunaExit.TabIndex = 12;
            this.btngunaExit.Text = "Cancel";
            this.btngunaExit.UseTransparentBackground = true;
            this.btngunaExit.Click += new System.EventHandler(this.btngunaExit_Click);
            // 
            // btngunaUpdate
            // 
            this.btngunaUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btngunaUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaUpdate.BorderRadius = 10;
            this.btngunaUpdate.BorderThickness = 2;
            this.btngunaUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(187)))));
            this.btngunaUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngunaUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaUpdate.Location = new System.Drawing.Point(564, 532);
            this.btngunaUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btngunaUpdate.Name = "btngunaUpdate";
            this.btngunaUpdate.Size = new System.Drawing.Size(220, 55);
            this.btngunaUpdate.TabIndex = 11;
            this.btngunaUpdate.Text = "Update";
            this.btngunaUpdate.Click += new System.EventHandler(this.btngunaUpdate_Click);
            // 
            // AddLocationForTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(200)))), ((int)(((byte)(172)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.btngunaExit);
            this.Controls.Add(this.btngunaUpdate);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddLocationForTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLocationForTour";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private Guna.UI2.WinForms.Guna2Button btngunaExit;
        private Guna.UI2.WinForms.Guna2Button btngunaUpdate;
    }
}