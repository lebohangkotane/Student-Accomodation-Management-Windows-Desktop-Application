namespace HostelManagementSystem
{
    partial class NewEmployeefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeefrm));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxjobDescrip = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbxIDNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxEmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPhyAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxSur = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxMNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 17;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Location = new System.Drawing.Point(820, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(57, 46);
            this.btnExit.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "NEW EMPLOYEE REGISTRATION";
            // 
            // cbxjobDescrip
            // 
            this.cbxjobDescrip.BackColor = System.Drawing.Color.Transparent;
            this.cbxjobDescrip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxjobDescrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxjobDescrip.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxjobDescrip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxjobDescrip.FocusedState.Parent = this.cbxjobDescrip;
            this.cbxjobDescrip.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbxjobDescrip.ForeColor = System.Drawing.Color.Black;
            this.cbxjobDescrip.HoverState.Parent = this.cbxjobDescrip;
            this.cbxjobDescrip.ItemHeight = 30;
            this.cbxjobDescrip.Items.AddRange(new object[] {
            "Building Caretaker",
            "Cleaning Stuff",
            "Accounts Manager",
            "Security Stuff",
            "Building Manager "});
            this.cbxjobDescrip.ItemsAppearance.Parent = this.cbxjobDescrip;
            this.cbxjobDescrip.Location = new System.Drawing.Point(212, 384);
            this.cbxjobDescrip.Name = "cbxjobDescrip";
            this.cbxjobDescrip.ShadowDecoration.Parent = this.cbxjobDescrip;
            this.cbxjobDescrip.Size = new System.Drawing.Size(553, 36);
            this.cbxjobDescrip.TabIndex = 39;
            // 
            // txtbxIDNo
            // 
            this.txtbxIDNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxIDNo.DefaultText = "";
            this.txtbxIDNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxIDNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxIDNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxIDNo.DisabledState.Parent = this.txtbxIDNo;
            this.txtbxIDNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxIDNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxIDNo.FocusedState.Parent = this.txtbxIDNo;
            this.txtbxIDNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxIDNo.ForeColor = System.Drawing.Color.Black;
            this.txtbxIDNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxIDNo.HoverState.Parent = this.txtbxIDNo;
            this.txtbxIDNo.Location = new System.Drawing.Point(212, 272);
            this.txtbxIDNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxIDNo.Name = "txtbxIDNo";
            this.txtbxIDNo.PasswordChar = '\0';
            this.txtbxIDNo.PlaceholderText = "";
            this.txtbxIDNo.SelectedText = "";
            this.txtbxIDNo.ShadowDecoration.Parent = this.txtbxIDNo;
            this.txtbxIDNo.Size = new System.Drawing.Size(553, 30);
            this.txtbxIDNo.TabIndex = 37;
            this.txtbxIDNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxIDNo_KeyPress);
            // 
            // txtbxEmpID
            // 
            this.txtbxEmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxEmpID.DefaultText = "";
            this.txtbxEmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxEmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxEmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxEmpID.DisabledState.Parent = this.txtbxEmpID;
            this.txtbxEmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxEmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxEmpID.FocusedState.Parent = this.txtbxEmpID;
            this.txtbxEmpID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmpID.ForeColor = System.Drawing.Color.Black;
            this.txtbxEmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxEmpID.HoverState.Parent = this.txtbxEmpID;
            this.txtbxEmpID.Location = new System.Drawing.Point(212, 329);
            this.txtbxEmpID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxEmpID.Name = "txtbxEmpID";
            this.txtbxEmpID.PasswordChar = '\0';
            this.txtbxEmpID.PlaceholderText = "";
            this.txtbxEmpID.SelectedText = "";
            this.txtbxEmpID.ShadowDecoration.Parent = this.txtbxEmpID;
            this.txtbxEmpID.Size = new System.Drawing.Size(553, 30);
            this.txtbxEmpID.TabIndex = 36;
            // 
            // txtbxPhyAdd
            // 
            this.txtbxPhyAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPhyAdd.DefaultText = "";
            this.txtbxPhyAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPhyAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPhyAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPhyAdd.DisabledState.Parent = this.txtbxPhyAdd;
            this.txtbxPhyAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPhyAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPhyAdd.FocusedState.Parent = this.txtbxPhyAdd;
            this.txtbxPhyAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhyAdd.ForeColor = System.Drawing.Color.Black;
            this.txtbxPhyAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPhyAdd.HoverState.Parent = this.txtbxPhyAdd;
            this.txtbxPhyAdd.Location = new System.Drawing.Point(212, 220);
            this.txtbxPhyAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxPhyAdd.Name = "txtbxPhyAdd";
            this.txtbxPhyAdd.PasswordChar = '\0';
            this.txtbxPhyAdd.PlaceholderText = "";
            this.txtbxPhyAdd.SelectedText = "";
            this.txtbxPhyAdd.ShadowDecoration.Parent = this.txtbxPhyAdd;
            this.txtbxPhyAdd.Size = new System.Drawing.Size(553, 30);
            this.txtbxPhyAdd.TabIndex = 35;
            // 
            // txtbxEm
            // 
            this.txtbxEm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxEm.DefaultText = "";
            this.txtbxEm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxEm.DisabledState.Parent = this.txtbxEm;
            this.txtbxEm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxEm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxEm.FocusedState.Parent = this.txtbxEm;
            this.txtbxEm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEm.ForeColor = System.Drawing.Color.Black;
            this.txtbxEm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxEm.HoverState.Parent = this.txtbxEm;
            this.txtbxEm.Location = new System.Drawing.Point(212, 121);
            this.txtbxEm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxEm.Name = "txtbxEm";
            this.txtbxEm.PasswordChar = '\0';
            this.txtbxEm.PlaceholderText = "";
            this.txtbxEm.SelectedText = "";
            this.txtbxEm.ShadowDecoration.Parent = this.txtbxEm;
            this.txtbxEm.Size = new System.Drawing.Size(553, 30);
            this.txtbxEm.TabIndex = 34;
            // 
            // txtbxSur
            // 
            this.txtbxSur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSur.DefaultText = "";
            this.txtbxSur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSur.DisabledState.Parent = this.txtbxSur;
            this.txtbxSur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSur.FocusedState.Parent = this.txtbxSur;
            this.txtbxSur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSur.ForeColor = System.Drawing.Color.Black;
            this.txtbxSur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSur.HoverState.Parent = this.txtbxSur;
            this.txtbxSur.Location = new System.Drawing.Point(551, 76);
            this.txtbxSur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSur.Name = "txtbxSur";
            this.txtbxSur.PasswordChar = '\0';
            this.txtbxSur.PlaceholderText = "";
            this.txtbxSur.SelectedText = "";
            this.txtbxSur.ShadowDecoration.Parent = this.txtbxSur;
            this.txtbxSur.Size = new System.Drawing.Size(214, 30);
            this.txtbxSur.TabIndex = 32;
            // 
            // txtbxN
            // 
            this.txtbxN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxN.DefaultText = "";
            this.txtbxN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxN.DisabledState.Parent = this.txtbxN;
            this.txtbxN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxN.FocusedState.Parent = this.txtbxN;
            this.txtbxN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxN.ForeColor = System.Drawing.Color.Black;
            this.txtbxN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxN.HoverState.Parent = this.txtbxN;
            this.txtbxN.Location = new System.Drawing.Point(212, 76);
            this.txtbxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxN.Name = "txtbxN";
            this.txtbxN.PasswordChar = '\0';
            this.txtbxN.PlaceholderText = "";
            this.txtbxN.SelectedText = "";
            this.txtbxN.ShadowDecoration.Parent = this.txtbxN;
            this.txtbxN.Size = new System.Drawing.Size(214, 30);
            this.txtbxN.TabIndex = 31;
            // 
            // txtbxMNo
            // 
            this.txtbxMNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxMNo.DefaultText = "";
            this.txtbxMNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxMNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxMNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMNo.DisabledState.Parent = this.txtbxMNo;
            this.txtbxMNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMNo.FocusedState.Parent = this.txtbxMNo;
            this.txtbxMNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMNo.ForeColor = System.Drawing.Color.Black;
            this.txtbxMNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMNo.HoverState.Parent = this.txtbxMNo;
            this.txtbxMNo.Location = new System.Drawing.Point(212, 170);
            this.txtbxMNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxMNo.Name = "txtbxMNo";
            this.txtbxMNo.PasswordChar = '\0';
            this.txtbxMNo.PlaceholderText = "";
            this.txtbxMNo.SelectedText = "";
            this.txtbxMNo.ShadowDecoration.Parent = this.txtbxMNo;
            this.txtbxMNo.Size = new System.Drawing.Size(553, 30);
            this.txtbxMNo.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 16;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(763, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(99, 31);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 16;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(643, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(99, 31);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(73, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Job Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID Number ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Physical Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(73, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mobile Number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label5_Click);
            // 
            // NewEmployeefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.cbxjobDescrip);
            this.Controls.Add(this.txtbxIDNo);
            this.Controls.Add(this.txtbxEmpID);
            this.Controls.Add(this.txtbxPhyAdd);
            this.Controls.Add(this.txtbxEm);
            this.Controls.Add(this.txtbxSur);
            this.Controls.Add(this.txtbxN);
            this.Controls.Add(this.txtbxMNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewEmployeefrm";
            this.Text = "NewEmployeefrm";
            this.Load += new System.EventHandler(this.NewEmployeefrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxjobDescrip;
        private Guna.UI2.WinForms.Guna2TextBox txtbxIDNo;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEmpID;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPhyAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEm;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSur;
        private Guna.UI2.WinForms.Guna2TextBox txtbxN;
        private Guna.UI2.WinForms.Guna2TextBox txtbxMNo;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
    }
}