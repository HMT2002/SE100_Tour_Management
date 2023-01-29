
namespace Tour
{
    partial class Location
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
            this.components = new System.ComponentModel.Container();
            this.pcbxLocation = new System.Windows.Forms.PictureBox();
            this.rchtxtbxDetail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cbbxLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbboxProvince = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxMeal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxOthers = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPlay = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).BeginInit();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbxLocation
            // 
            this.pcbxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxLocation.Image = global::Tour.Properties.Resources.ic_image_empty_128;
            this.pcbxLocation.Location = new System.Drawing.Point(4, 4);
            this.pcbxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.pcbxLocation.Name = "pcbxLocation";
            this.pcbxLocation.Size = new System.Drawing.Size(737, 601);
            this.pcbxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLocation.TabIndex = 0;
            this.pcbxLocation.TabStop = false;
            this.pcbxLocation.Click += new System.EventHandler(this.pcbxLocation_Click);
            // 
            // rchtxtbxDetail
            // 
            this.rchtxtbxDetail.BackColor = System.Drawing.Color.Bisque;
            this.rchtxtbxDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtbxDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.rchtxtbxDetail.Location = new System.Drawing.Point(55, 688);
            this.rchtxtbxDetail.Margin = new System.Windows.Forms.Padding(5);
            this.rchtxtbxDetail.Name = "rchtxtbxDetail";
            this.rchtxtbxDetail.Size = new System.Drawing.Size(693, 297);
            this.rchtxtbxDetail.TabIndex = 7;
            this.rchtxtbxDetail.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(175, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pcbxLocation);
            this.panel3.Location = new System.Drawing.Point(837, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 609);
            this.panel3.TabIndex = 3;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // cbbxLocation
            // 
            this.cbbxLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbbxLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbbxLocation.BorderRadius = 10;
            this.cbbxLocation.BorderThickness = 2;
            this.cbbxLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxLocation.FillColor = System.Drawing.Color.Bisque;
            this.cbbxLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbxLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbxLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbbxLocation.ItemHeight = 30;
            this.cbbxLocation.Location = new System.Drawing.Point(277, 268);
            this.cbbxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbbxLocation.Name = "cbbxLocation";
            this.cbbxLocation.ShadowDecoration.BorderRadius = 10;
            this.cbbxLocation.ShadowDecoration.Depth = 15;
            this.cbbxLocation.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.cbbxLocation.Size = new System.Drawing.Size(471, 36);
            this.cbbxLocation.TabIndex = 1;
            this.cbbxLocation.SelectedValueChanged += new System.EventHandler(this.cbbxLocation_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(150, 490);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(134, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(54, 568);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Province/City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(106, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Location";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 994);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1600, 108);
            this.guna2Panel1.TabIndex = 41;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnClear.BorderRadius = 5;
            this.btnClear.BorderThickness = 2;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Linen;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1183, 27);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(321, 57);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Linen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(853, 27);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(321, 57);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Linen;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(524, 27);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(321, 57);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Linen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(195, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(321, 57);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(54, 651);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Detail";
            // 
            // txtbxName
            // 
            this.txtbxName.BackColor = System.Drawing.Color.Transparent;
            this.txtbxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.BorderRadius = 10;
            this.txtbxName.BorderThickness = 2;
            this.txtbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxName.DefaultText = "";
            this.txtbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxName.FillColor = System.Drawing.Color.Bisque;
            this.txtbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.Location = new System.Drawing.Point(277, 411);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.PasswordChar = '\0';
            this.txtbxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxName.PlaceholderText = "";
            this.txtbxName.SelectedText = "";
            this.txtbxName.ShadowDecoration.BorderRadius = 10;
            this.txtbxName.ShadowDecoration.Depth = 15;
            this.txtbxName.ShadowDecoration.Enabled = true;
            this.txtbxName.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.txtbxName.Size = new System.Drawing.Size(471, 44);
            this.txtbxName.TabIndex = 2;
            // 
            // txtbxGia
            // 
            this.txtbxGia.BackColor = System.Drawing.Color.Transparent;
            this.txtbxGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxGia.BorderRadius = 10;
            this.txtbxGia.BorderThickness = 2;
            this.txtbxGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxGia.DefaultText = "";
            this.txtbxGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxGia.FillColor = System.Drawing.Color.Bisque;
            this.txtbxGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxGia.Location = new System.Drawing.Point(509, 633);
            this.txtbxGia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.PasswordChar = '\0';
            this.txtbxGia.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxGia.PlaceholderText = "";
            this.txtbxGia.ReadOnly = true;
            this.txtbxGia.SelectedText = "";
            this.txtbxGia.ShadowDecoration.BorderRadius = 10;
            this.txtbxGia.ShadowDecoration.Depth = 15;
            this.txtbxGia.ShadowDecoration.Enabled = true;
            this.txtbxGia.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.txtbxGia.Size = new System.Drawing.Size(238, 44);
            this.txtbxGia.TabIndex = 32;
            this.txtbxGia.TabStop = false;
            this.txtbxGia.TextChanged += new System.EventHandler(this.txtbxGia_TextChanged);
            this.txtbxGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxGia_KeyPress);
            // 
            // txtbxId
            // 
            this.txtbxId.BackColor = System.Drawing.Color.Transparent;
            this.txtbxId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxId.BorderRadius = 10;
            this.txtbxId.BorderThickness = 2;
            this.txtbxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxId.DefaultText = "";
            this.txtbxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxId.FillColor = System.Drawing.Color.Bisque;
            this.txtbxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxId.Location = new System.Drawing.Point(277, 337);
            this.txtbxId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbxId.Name = "txtbxId";
            this.txtbxId.PasswordChar = '\0';
            this.txtbxId.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxId.PlaceholderText = "";
            this.txtbxId.ReadOnly = true;
            this.txtbxId.SelectedText = "";
            this.txtbxId.ShadowDecoration.BorderRadius = 10;
            this.txtbxId.ShadowDecoration.Depth = 15;
            this.txtbxId.ShadowDecoration.Enabled = true;
            this.txtbxId.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.txtbxId.Size = new System.Drawing.Size(471, 44);
            this.txtbxId.TabIndex = 8;
            this.txtbxId.TabStop = false;
            // 
            // cbboxProvince
            // 
            this.cbboxProvince.BackColor = System.Drawing.Color.Transparent;
            this.cbboxProvince.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbboxProvince.BorderRadius = 10;
            this.cbboxProvince.BorderThickness = 2;
            this.cbboxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxProvince.DropDownHeight = 50;
            this.cbboxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxProvince.FillColor = System.Drawing.Color.Bisque;
            this.cbboxProvince.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxProvince.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxProvince.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbboxProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.cbboxProvince.IntegralHeight = false;
            this.cbboxProvince.ItemHeight = 30;
            this.cbboxProvince.Location = new System.Drawing.Point(277, 564);
            this.cbboxProvince.Margin = new System.Windows.Forms.Padding(4);
            this.cbboxProvince.MaxDropDownItems = 5;
            this.cbboxProvince.Name = "cbboxProvince";
            this.cbboxProvince.ShadowDecoration.BorderRadius = 10;
            this.cbboxProvince.ShadowDecoration.Depth = 15;
            this.cbboxProvince.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.cbboxProvince.Size = new System.Drawing.Size(471, 36);
            this.cbboxProvince.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::Tour.Properties.Resources.BeFunky_sample;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1600, 240);
            this.guna2Panel2.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(433, 645);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total";
            // 
            // txtbxMeal
            // 
            this.txtbxMeal.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtbxMeal.BackColor = System.Drawing.Color.Transparent;
            this.txtbxMeal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxMeal.BorderRadius = 10;
            this.txtbxMeal.BorderThickness = 2;
            this.txtbxMeal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxMeal.DefaultText = "";
            this.txtbxMeal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxMeal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxMeal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMeal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMeal.FillColor = System.Drawing.Color.Bisque;
            this.txtbxMeal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMeal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbxMeal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMeal.Location = new System.Drawing.Point(277, 485);
            this.txtbxMeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxMeal.Name = "txtbxMeal";
            this.txtbxMeal.PasswordChar = '\0';
            this.txtbxMeal.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxMeal.PlaceholderText = "Meal";
            this.txtbxMeal.SelectedText = "";
            this.txtbxMeal.Size = new System.Drawing.Size(148, 44);
            this.txtbxMeal.TabIndex = 3;
            this.txtbxMeal.TextChanged += new System.EventHandler(this.txtbxMeal_TextChanged);
            this.txtbxMeal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMeal_KeyPress);
            this.txtbxMeal.Leave += new System.EventHandler(this.txtbxMeal_Leave);
            // 
            // txtbxOthers
            // 
            this.txtbxOthers.BackColor = System.Drawing.Color.Transparent;
            this.txtbxOthers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxOthers.BorderRadius = 10;
            this.txtbxOthers.BorderThickness = 2;
            this.txtbxOthers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxOthers.DefaultText = "";
            this.txtbxOthers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxOthers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxOthers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxOthers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxOthers.FillColor = System.Drawing.Color.Bisque;
            this.txtbxOthers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxOthers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxOthers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxOthers.Location = new System.Drawing.Point(600, 485);
            this.txtbxOthers.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbxOthers.Name = "txtbxOthers";
            this.txtbxOthers.PasswordChar = '\0';
            this.txtbxOthers.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxOthers.PlaceholderText = "Others";
            this.txtbxOthers.SelectedText = "";
            this.txtbxOthers.ShadowDecoration.BorderRadius = 10;
            this.txtbxOthers.ShadowDecoration.Depth = 15;
            this.txtbxOthers.ShadowDecoration.Enabled = true;
            this.txtbxOthers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.txtbxOthers.Size = new System.Drawing.Size(148, 44);
            this.txtbxOthers.TabIndex = 5;
            this.txtbxOthers.TextChanged += new System.EventHandler(this.txtbxOthers_TextChanged);
            this.txtbxOthers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxOthers_KeyPress);
            this.txtbxOthers.Leave += new System.EventHandler(this.txtbxOthers_Leave);
            // 
            // txtbxPlay
            // 
            this.txtbxPlay.BackColor = System.Drawing.Color.Transparent;
            this.txtbxPlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxPlay.BorderRadius = 10;
            this.txtbxPlay.BorderThickness = 2;
            this.txtbxPlay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPlay.DefaultText = "";
            this.txtbxPlay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPlay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPlay.FillColor = System.Drawing.Color.Bisque;
            this.txtbxPlay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPlay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPlay.Location = new System.Drawing.Point(439, 485);
            this.txtbxPlay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbxPlay.Name = "txtbxPlay";
            this.txtbxPlay.PasswordChar = '\0';
            this.txtbxPlay.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(112)))));
            this.txtbxPlay.PlaceholderText = "Play";
            this.txtbxPlay.SelectedText = "";
            this.txtbxPlay.ShadowDecoration.BorderRadius = 10;
            this.txtbxPlay.ShadowDecoration.Depth = 15;
            this.txtbxPlay.ShadowDecoration.Enabled = true;
            this.txtbxPlay.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.txtbxPlay.Size = new System.Drawing.Size(148, 44);
            this.txtbxPlay.TabIndex = 4;
            this.txtbxPlay.TextChanged += new System.EventHandler(this.txtbxPlay_TextChanged);
            this.txtbxPlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPlay_KeyPress);
            this.txtbxPlay.Leave += new System.EventHandler(this.txtbxPlay_Leave);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 1102);
            this.Controls.Add(this.txtbxMeal);
            this.Controls.Add(this.txtbxOthers);
            this.Controls.Add(this.txtbxPlay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.cbboxProvince);
            this.Controls.Add(this.txtbxId);
            this.Controls.Add(this.txtbxGia);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbxLocation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchtxtbxDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLocation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxLocation;
        private System.Windows.Forms.RichTextBox rchtxtbxDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbxLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtbxGia;
        private Guna.UI2.WinForms.Guna2TextBox txtbxName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxId;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxProvince;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtbxMeal;
        private Guna.UI2.WinForms.Guna2TextBox txtbxOthers;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPlay;
    }
}