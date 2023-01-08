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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleForGroup));
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btngunaExit = new Guna.UI2.WinForms.Guna2Button();
            this.btngunaUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(11, 269);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(782, 100);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 240);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btngunaExit
            // 
            this.btngunaExit.BackColor = System.Drawing.Color.Transparent;
            this.btngunaExit.CheckedState.Parent = this.btngunaExit;
            this.btngunaExit.CustomImages.Parent = this.btngunaExit;
            this.btngunaExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngunaExit.ForeColor = System.Drawing.Color.White;
            this.btngunaExit.HoverState.Parent = this.btngunaExit;
            this.btngunaExit.Location = new System.Drawing.Point(624, 393);
            this.btngunaExit.Name = "btngunaExit";
            this.btngunaExit.ShadowDecoration.Parent = this.btngunaExit;
            this.btngunaExit.Size = new System.Drawing.Size(164, 45);
            this.btngunaExit.TabIndex = 14;
            this.btngunaExit.Text = "Cancel";
            this.btngunaExit.UseTransparentBackground = true;
            this.btngunaExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngunaUpdate
            // 
            this.btngunaUpdate.CheckedState.Parent = this.btngunaUpdate;
            this.btngunaUpdate.CustomImages.Parent = this.btngunaUpdate;
            this.btngunaUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngunaUpdate.ForeColor = System.Drawing.Color.White;
            this.btngunaUpdate.HoverState.Parent = this.btngunaUpdate;
            this.btngunaUpdate.Location = new System.Drawing.Point(438, 393);
            this.btngunaUpdate.Name = "btngunaUpdate";
            this.btngunaUpdate.ShadowDecoration.Parent = this.btngunaUpdate;
            this.btngunaUpdate.Size = new System.Drawing.Size(180, 45);
            this.btngunaUpdate.TabIndex = 13;
            this.btngunaUpdate.Text = "Update";
            this.btngunaUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddVehicalForGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngunaExit);
            this.Controls.Add(this.btngunaUpdate);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVehicalForGroup";
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