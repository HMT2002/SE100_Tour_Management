namespace Tour
{
    partial class AddVehicleForGroup
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btngunaExit = new Guna.UI2.WinForms.Guna2Button();
            this.btngunaUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(15, 331);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1041, 147);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 12);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1040, 310);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btngunaExit
            // 
            this.btngunaExit.BackColor = System.Drawing.Color.Transparent;
            this.btngunaExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaExit.BorderThickness = 2;
            this.btngunaExit.FillColor = System.Drawing.Color.Linen;
            this.btngunaExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngunaExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaExit.Location = new System.Drawing.Point(832, 484);
            this.btngunaExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngunaExit.Name = "btngunaExit";
            this.btngunaExit.Size = new System.Drawing.Size(219, 55);
            this.btngunaExit.TabIndex = 14;
            this.btngunaExit.Text = "Cancel";
            this.btngunaExit.UseTransparentBackground = true;
            this.btngunaExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngunaUpdate
            // 
            this.btngunaUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaUpdate.BorderThickness = 2;
            this.btngunaUpdate.FillColor = System.Drawing.Color.Linen;
            this.btngunaUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngunaUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btngunaUpdate.Location = new System.Drawing.Point(584, 484);
            this.btngunaUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngunaUpdate.Name = "btngunaUpdate";
            this.btngunaUpdate.Size = new System.Drawing.Size(240, 55);
            this.btngunaUpdate.TabIndex = 13;
            this.btngunaUpdate.Text = "Update";
            this.btngunaUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddVehicleForGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btngunaExit);
            this.Controls.Add(this.btngunaUpdate);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddVehicleForGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVehicalForGroup";
            this.Load += new System.EventHandler(this.AddVehicalForGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button btngunaExit;
        private Guna.UI2.WinForms.Guna2Button btngunaUpdate;
    }
}