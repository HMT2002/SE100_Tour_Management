﻿namespace Tour
{
    partial class forgotpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codetxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailtxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verifybtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sendbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(91, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Forgot Password";
            // 
            // codetxb
            // 
            this.codetxb.BorderColor = System.Drawing.Color.Black;
            this.codetxb.BorderRadius = 8;
            this.codetxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codetxb.DefaultText = "";
            this.codetxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codetxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codetxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codetxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codetxb.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.codetxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codetxb.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.codetxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codetxb.IconLeft = ((System.Drawing.Image)(resources.GetObject("codetxb.IconLeft")));
            this.codetxb.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.codetxb.Location = new System.Drawing.Point(98, 192);
            this.codetxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codetxb.Name = "codetxb";
            this.codetxb.PasswordChar = '\0';
            this.codetxb.PlaceholderText = "Code";
            this.codetxb.SelectedText = "";
            this.codetxb.Size = new System.Drawing.Size(265, 36);
            this.codetxb.TabIndex = 21;
            this.codetxb.Visible = false;
            this.codetxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codetxb_KeyPress);
            // 
            // emailtxb
            // 
            this.emailtxb.BorderColor = System.Drawing.Color.Black;
            this.emailtxb.BorderRadius = 8;
            this.emailtxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxb.DefaultText = "";
            this.emailtxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxb.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailtxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.emailtxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxb.IconLeft = ((System.Drawing.Image)(resources.GetObject("emailtxb.IconLeft")));
            this.emailtxb.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.emailtxb.Location = new System.Drawing.Point(98, 128);
            this.emailtxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxb.Name = "emailtxb";
            this.emailtxb.PasswordChar = '\0';
            this.emailtxb.PlaceholderText = "Email";
            this.emailtxb.SelectedText = "";
            this.emailtxb.Size = new System.Drawing.Size(265, 36);
            this.emailtxb.TabIndex = 20;
            this.emailtxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailtxb_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tour.Properties.Resources.cancel1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(442, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // verifybtn
            // 
            this.verifybtn.BorderRadius = 20;
            this.verifybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verifybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verifybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verifybtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verifybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verifybtn.FillColor = System.Drawing.Color.BlueViolet;
            this.verifybtn.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.verifybtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.verifybtn.ForeColor = System.Drawing.Color.White;
            this.verifybtn.Location = new System.Drawing.Point(99, 274);
            this.verifybtn.Margin = new System.Windows.Forms.Padding(2);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(265, 36);
            this.verifybtn.TabIndex = 23;
            this.verifybtn.Text = "Verify";
            this.verifybtn.Visible = false;
            this.verifybtn.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.BorderRadius = 20;
            this.sendbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendbtn.FillColor = System.Drawing.Color.BlueViolet;
            this.sendbtn.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.sendbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.sendbtn.ForeColor = System.Drawing.Color.White;
            this.sendbtn.Location = new System.Drawing.Point(99, 274);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(265, 36);
            this.sendbtn.TabIndex = 24;
            this.sendbtn.Text = "Send verify code";
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 389);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.verifybtn);
            this.Controls.Add(this.codetxb);
            this.Controls.Add(this.emailtxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forgotpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotpass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox emailtxb;
        private Guna.UI2.WinForms.Guna2TextBox codetxb;
        private Guna.UI2.WinForms.Guna2GradientButton verifybtn;
        private Guna.UI2.WinForms.Guna2GradientButton sendbtn;
    }
}