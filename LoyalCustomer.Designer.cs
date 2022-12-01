namespace Tour
{
    partial class LoyalCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSpending = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RdFmale = new System.Windows.Forms.RadioButton();
            this.RdMale = new System.Windows.Forms.RadioButton();
            this.lblRank = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbxAvtatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.pnCRUD = new System.Windows.Forms.Panel();
            this.pnCreateCustomer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnUpdateCustomer = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbxNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.txtbxRePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvtatar)).BeginInit();
            this.pnCRUD.SuspendLayout();
            this.pnCreateCustomer.SuspendLayout();
            this.pnUpdateCustomer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSpending);
            this.panel1.Controls.Add(this.tbCMND);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbTelephone);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(11, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 445);
            this.panel1.TabIndex = 2;
            // 
            // lblSpending
            // 
            this.lblSpending.BackColor = System.Drawing.Color.Transparent;
            this.lblSpending.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpending.Location = new System.Drawing.Point(9, 398);
            this.lblSpending.Name = "lblSpending";
            this.lblSpending.Size = new System.Drawing.Size(186, 33);
            this.lblSpending.TabIndex = 32;
            this.lblSpending.Text = "Total spending:";
            // 
            // tbCMND
            // 
            this.tbCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMND.DefaultText = "";
            this.tbCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMND.Location = new System.Drawing.Point(9, 271);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCMND.MaxLength = 13;
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.PasswordChar = '\0';
            this.tbCMND.PlaceholderText = "Citizen ID";
            this.tbCMND.SelectedText = "";
            this.tbCMND.Size = new System.Drawing.Size(400, 43);
            this.tbCMND.TabIndex = 31;
            this.tbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCMND_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(9, 206);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(400, 43);
            this.tbEmail.TabIndex = 30;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTelephone.DefaultText = "";
            this.tbTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTelephone.Location = new System.Drawing.Point(9, 142);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelephone.MaxLength = 13;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.PasswordChar = '\0';
            this.tbTelephone.PlaceholderText = "Teleplhone";
            this.tbTelephone.SelectedText = "";
            this.tbTelephone.Size = new System.Drawing.Size(400, 43);
            this.tbTelephone.TabIndex = 30;
            this.tbTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelephone_KeyPress);
            // 
            // tbAddress
            // 
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(9, 78);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PlaceholderText = "Address";
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(400, 43);
            this.tbAddress.TabIndex = 30;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(9, 14);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Name";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(400, 43);
            this.tbName.TabIndex = 30;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.RdFmale);
            this.panel6.Controls.Add(this.RdMale);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(9, 331);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 41);
            this.panel6.TabIndex = 19;
            // 
            // RdFmale
            // 
            this.RdFmale.AutoSize = true;
            this.RdFmale.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdFmale.Location = new System.Drawing.Point(241, 8);
            this.RdFmale.Name = "RdFmale";
            this.RdFmale.Size = new System.Drawing.Size(86, 26);
            this.RdFmale.TabIndex = 31;
            this.RdFmale.Text = "Female";
            this.RdFmale.UseVisualStyleBackColor = true;
            // 
            // RdMale
            // 
            this.RdMale.AutoSize = true;
            this.RdMale.Checked = true;
            this.RdMale.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdMale.Location = new System.Drawing.Point(67, 8);
            this.RdMale.Name = "RdMale";
            this.RdMale.Size = new System.Drawing.Size(69, 26);
            this.RdMale.TabIndex = 30;
            this.RdMale.TabStop = true;
            this.RdMale.Text = "Male";
            this.RdMale.UseVisualStyleBackColor = true;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.Red;
            this.lblRank.Location = new System.Drawing.Point(191, 19);
            this.lblRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(539, 43);
            this.lblRank.TabIndex = 13;
            this.lblRank.Text = "CREATE LOYAL CUSTOMER";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pcbxAvtatar);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(469, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 309);
            this.panel2.TabIndex = 29;
            // 
            // pcbxAvtatar
            // 
            this.pcbxAvtatar.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxAvtatar.ImageRotate = 0F;
            this.pcbxAvtatar.Location = new System.Drawing.Point(15, 3);
            this.pcbxAvtatar.Name = "pcbxAvtatar";
            this.pcbxAvtatar.Size = new System.Drawing.Size(398, 247);
            this.pcbxAvtatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxAvtatar.TabIndex = 0;
            this.pcbxAvtatar.TabStop = false;
            this.pcbxAvtatar.Click += new System.EventHandler(this.pcbxAvtatar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(12, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(121, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnNew.BorderRadius = 5;
            this.btnNew.BorderThickness = 2;
            this.btnNew.FillColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(225, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(146, 44);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Clear";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnCRUD
            // 
            this.pnCRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCRUD.Controls.Add(this.pnCreateCustomer);
            this.pnCRUD.Location = new System.Drawing.Point(469, 377);
            this.pnCRUD.Name = "pnCRUD";
            this.pnCRUD.Size = new System.Drawing.Size(404, 66);
            this.pnCRUD.TabIndex = 30;
            // 
            // pnCreateCustomer
            // 
            this.pnCreateCustomer.Controls.Add(this.btnAdd);
            this.pnCreateCustomer.Controls.Add(this.btnNew);
            this.pnCreateCustomer.Location = new System.Drawing.Point(3, 3);
            this.pnCreateCustomer.Name = "pnCreateCustomer";
            this.pnCreateCustomer.Size = new System.Drawing.Size(397, 56);
            this.pnCreateCustomer.TabIndex = 0;
            // 
            // pnUpdateCustomer
            // 
            this.pnUpdateCustomer.Controls.Add(this.btnUpdate);
            this.pnUpdateCustomer.Location = new System.Drawing.Point(469, 448);
            this.pnUpdateCustomer.Name = "pnUpdateCustomer";
            this.pnUpdateCustomer.Size = new System.Drawing.Size(401, 60);
            this.pnUpdateCustomer.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtbxNewPassword);
            this.panel4.Controls.Add(this.btnChangePassword);
            this.panel4.Controls.Add(this.txtbxRePassword);
            this.panel4.Controls.Add(this.txtbxPassword);
            this.panel4.Controls.Add(this.lblNotes);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(9, 522);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 191);
            this.panel4.TabIndex = 29;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtbxNewPassword
            // 
            this.txtbxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxNewPassword.DefaultText = "";
            this.txtbxNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxNewPassword.Location = new System.Drawing.Point(4, 139);
            this.txtbxNewPassword.Margin = new System.Windows.Forms.Padding(9);
            this.txtbxNewPassword.Name = "txtbxNewPassword";
            this.txtbxNewPassword.PasswordChar = '●';
            this.txtbxNewPassword.PlaceholderText = "New password";
            this.txtbxNewPassword.SelectedText = "";
            this.txtbxNewPassword.Size = new System.Drawing.Size(623, 40);
            this.txtbxNewPassword.TabIndex = 7;
            this.txtbxNewPassword.UseSystemPasswordChar = true;
            this.txtbxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNewPassword_KeyPress);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnChangePassword.BorderRadius = 5;
            this.btnChangePassword.BorderThickness = 2;
            this.btnChangePassword.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(668, 109);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(183, 70);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtbxRePassword
            // 
            this.txtbxRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxRePassword.DefaultText = "";
            this.txtbxRePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxRePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxRePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxRePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxRePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxRePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxRePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxRePassword.Location = new System.Drawing.Point(4, 84);
            this.txtbxRePassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtbxRePassword.Name = "txtbxRePassword";
            this.txtbxRePassword.PasswordChar = '●';
            this.txtbxRePassword.PlaceholderText = "Re-enter password";
            this.txtbxRePassword.SelectedText = "";
            this.txtbxRePassword.Size = new System.Drawing.Size(623, 40);
            this.txtbxRePassword.TabIndex = 4;
            this.txtbxRePassword.UseSystemPasswordChar = true;
            this.txtbxRePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxRePassword_KeyPress);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.DefaultText = "";
            this.txtbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.Location = new System.Drawing.Point(4, 34);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '●';
            this.txtbxPassword.PlaceholderText = "Password";
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.Size = new System.Drawing.Size(623, 40);
            this.txtbxPassword.TabIndex = 1;
            this.txtbxPassword.UseSystemPasswordChar = true;
            this.txtbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPassword_KeyPress);
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(668, 155);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(183, 24);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "__________________";
            // 
            // LoyalCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1184, 906);
            this.Controls.Add(this.pnUpdateCustomer);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnCRUD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoyalCustomer";
            this.Text = "LoyalCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAvtatar)).EndInit();
            this.pnCRUD.ResumeLayout(false);
            this.pnCreateCustomer.ResumeLayout(false);
            this.pnUpdateCustomer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbTelephone;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton RdFmale;
        private System.Windows.Forms.RadioButton RdMale;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pcbxAvtatar;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Panel pnCRUD;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtbxRePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNotes;
        private Guna.UI2.WinForms.Guna2Panel pnUpdateCustomer;
        private Guna.UI2.WinForms.Guna2Panel pnCreateCustomer;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtbxNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbCMND;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSpending;
    }
}