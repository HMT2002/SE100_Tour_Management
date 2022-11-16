
namespace Tour
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.emailtxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.forgetlb = new System.Windows.Forms.Label();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.registaccountlb = new System.Windows.Forms.Label();
            this.cbghinho = new System.Windows.Forms.CheckBox();
            this.cbGuest = new System.Windows.Forms.CheckBox();
            this.pnSearchTicket = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtbxSearchTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnSearchTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailtxb
            // 
            this.emailtxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxb.Location = new System.Drawing.Point(17, 139);
            this.emailtxb.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxb.MaxLength = 35;
            this.emailtxb.Name = "emailtxb";
            this.emailtxb.Size = new System.Drawing.Size(265, 29);
            this.emailtxb.TabIndex = 1;
            this.emailtxb.Validating += new System.ComponentModel.CancelEventHandler(this.emailtxb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Green;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(75, 295);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(100, 24);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Crimson;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitbtn.Location = new System.Drawing.Point(182, 295);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(100, 24);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // forgetlb
            // 
            this.forgetlb.AutoSize = true;
            this.forgetlb.BackColor = System.Drawing.Color.Transparent;
            this.forgetlb.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetlb.ForeColor = System.Drawing.Color.White;
            this.forgetlb.Location = new System.Drawing.Point(13, 263);
            this.forgetlb.Name = "forgetlb";
            this.forgetlb.Size = new System.Drawing.Size(149, 21);
            this.forgetlb.TabIndex = 13;
            this.forgetlb.Text = "Forget password ?";
            this.forgetlb.Click += new System.EventHandler(this.forgetlb_Click);
            // 
            // passwordtxb
            // 
            this.passwordtxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxb.Location = new System.Drawing.Point(17, 187);
            this.passwordtxb.MaxLength = 25;
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(265, 29);
            this.passwordtxb.TabIndex = 2;
            this.passwordtxb.UseSystemPasswordChar = true;
            // 
            // registaccountlb
            // 
            this.registaccountlb.AutoSize = true;
            this.registaccountlb.BackColor = System.Drawing.Color.Transparent;
            this.registaccountlb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registaccountlb.ForeColor = System.Drawing.Color.White;
            this.registaccountlb.Location = new System.Drawing.Point(109, 322);
            this.registaccountlb.Name = "registaccountlb";
            this.registaccountlb.Size = new System.Drawing.Size(173, 22);
            this.registaccountlb.TabIndex = 16;
            this.registaccountlb.Text = "Register an account";
            this.registaccountlb.Click += new System.EventHandler(this.registaccountlb_Click);
            // 
            // cbghinho
            // 
            this.cbghinho.AutoSize = true;
            this.cbghinho.BackColor = System.Drawing.Color.Transparent;
            this.cbghinho.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbghinho.ForeColor = System.Drawing.Color.White;
            this.cbghinho.Location = new System.Drawing.Point(17, 237);
            this.cbghinho.Margin = new System.Windows.Forms.Padding(2);
            this.cbghinho.Name = "cbghinho";
            this.cbghinho.Size = new System.Drawing.Size(120, 24);
            this.cbghinho.TabIndex = 3;
            this.cbghinho.Text = "Remember ?";
            this.cbghinho.UseVisualStyleBackColor = false;
            // 
            // cbGuest
            // 
            this.cbGuest.AutoSize = true;
            this.cbGuest.BackColor = System.Drawing.Color.Transparent;
            this.cbGuest.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuest.ForeColor = System.Drawing.Color.White;
            this.cbGuest.Location = new System.Drawing.Point(17, 346);
            this.cbGuest.Margin = new System.Windows.Forms.Padding(2);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(141, 24);
            this.cbGuest.TabIndex = 17;
            this.cbGuest.Text = "Are you guest? ";
            this.cbGuest.UseVisualStyleBackColor = false;
            this.cbGuest.CheckedChanged += new System.EventHandler(this.cbGuest_CheckedChanged);
            // 
            // pnSearchTicket
            // 
            this.pnSearchTicket.BackColor = System.Drawing.Color.Transparent;
            this.pnSearchTicket.Controls.Add(this.btnSearch);
            this.pnSearchTicket.Controls.Add(this.label1);
            this.pnSearchTicket.Controls.Add(this.txtbxSearchTicket);
            this.pnSearchTicket.Location = new System.Drawing.Point(330, 64);
            this.pnSearchTicket.Name = "pnSearchTicket";
            this.pnSearchTicket.ShadowDecoration.Parent = this.pnSearchTicket;
            this.pnSearchTicket.Size = new System.Drawing.Size(344, 306);
            this.pnSearchTicket.TabIndex = 18;
            this.pnSearchTicket.Visible = false;
            // 
            // txtbxSearchTicket
            // 
            this.txtbxSearchTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSearchTicket.DefaultText = "";
            this.txtbxSearchTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSearchTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSearchTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSearchTicket.DisabledState.Parent = this.txtbxSearchTicket;
            this.txtbxSearchTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSearchTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSearchTicket.FocusedState.Parent = this.txtbxSearchTicket;
            this.txtbxSearchTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSearchTicket.HoverState.Parent = this.txtbxSearchTicket;
            this.txtbxSearchTicket.Location = new System.Drawing.Point(8, 75);
            this.txtbxSearchTicket.Name = "txtbxSearchTicket";
            this.txtbxSearchTicket.PasswordChar = '\0';
            this.txtbxSearchTicket.PlaceholderText = "";
            this.txtbxSearchTicket.SelectedText = "";
            this.txtbxSearchTicket.ShadowDecoration.Parent = this.txtbxSearchTicket;
            this.txtbxSearchTicket.Size = new System.Drawing.Size(286, 29);
            this.txtbxSearchTicket.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Ticket";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(3, 231);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 24);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tour.Properties.Resources.tour4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 430);
            this.Controls.Add(this.pnSearchTicket);
            this.Controls.Add(this.passwordtxb);
            this.Controls.Add(this.emailtxb);
            this.Controls.Add(this.registaccountlb);
            this.Controls.Add(this.cbGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.cbghinho);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.forgetlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnSearchTicket.ResumeLayout(false);
            this.pnSearchTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailtxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label forgetlb;
        private System.Windows.Forms.TextBox passwordtxb;
        private System.Windows.Forms.Label registaccountlb;
        private System.Windows.Forms.CheckBox cbghinho;
        private System.Windows.Forms.CheckBox cbGuest;
        private Guna.UI2.WinForms.Guna2GradientPanel pnSearchTicket;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSearchTicket;
    }
}

