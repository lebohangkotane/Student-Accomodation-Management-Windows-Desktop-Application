namespace HostelManagementSystem
{
    partial class Dashboardfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboardfrm));
            this.PicbxHostal = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSAS = new System.Windows.Forms.Label();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeePayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnFormerTenants = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpDelEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnFormerEmpl = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllEmpl = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.timr1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicbxHostal)).BeginInit();
            this.SuspendLayout();
            // 
            // PicbxHostal
            // 
            this.PicbxHostal.BorderRadius = 30;
            this.PicbxHostal.Image = ((System.Drawing.Image)(resources.GetObject("PicbxHostal.Image")));
            this.PicbxHostal.Location = new System.Drawing.Point(247, 81);
            this.PicbxHostal.Name = "PicbxHostal";
            this.PicbxHostal.ShadowDecoration.Parent = this.PicbxHostal;
            this.PicbxHostal.Size = new System.Drawing.Size(1107, 661);
            this.PicbxHostal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicbxHostal.TabIndex = 0;
            this.PicbxHostal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAVIGATION BAR";
            // 
            // lblSAS
            // 
            this.lblSAS.AutoSize = true;
            this.lblSAS.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAS.ForeColor = System.Drawing.Color.White;
            this.lblSAS.Location = new System.Drawing.Point(587, 24);
            this.lblSAS.Name = "lblSAS";
            this.lblSAS.Size = new System.Drawing.Size(362, 33);
            this.lblSAS.TabIndex = 2;
            this.lblSAS.Text = "STUDENT ACCOMMODATION SYSTEM";
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BorderRadius = 19;
            this.btnManageRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageRooms.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManageRooms.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageRooms.CheckedState.Parent = this.btnManageRooms;
            this.btnManageRooms.CustomImages.Parent = this.btnManageRooms;
            this.btnManageRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageRooms.ForeColor = System.Drawing.Color.White;
            this.btnManageRooms.HoverState.Parent = this.btnManageRooms;
            this.btnManageRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnManageRooms.Image")));
            this.btnManageRooms.Location = new System.Drawing.Point(35, 81);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.ShadowDecoration.Parent = this.btnManageRooms;
            this.btnManageRooms.Size = new System.Drawing.Size(203, 45);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BorderRadius = 19;
            this.btnNewStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewStudent.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewStudent.CheckedState.Parent = this.btnNewStudent;
            this.btnNewStudent.CustomImages.Parent = this.btnNewStudent;
            this.btnNewStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnNewStudent.HoverState.Parent = this.btnNewStudent;
            this.btnNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnNewStudent.Image")));
            this.btnNewStudent.Location = new System.Drawing.Point(35, 143);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.ShadowDecoration.Parent = this.btnNewStudent;
            this.btnNewStudent.Size = new System.Drawing.Size(203, 45);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.BorderRadius = 19;
            this.btnEmployeePayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployeePayment.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployeePayment.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployeePayment.CheckedState.Parent = this.btnEmployeePayment;
            this.btnEmployeePayment.CustomImages.Parent = this.btnEmployeePayment;
            this.btnEmployeePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployeePayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnEmployeePayment.HoverState.Parent = this.btnEmployeePayment;
            this.btnEmployeePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeePayment.Image")));
            this.btnEmployeePayment.Location = new System.Drawing.Point(35, 577);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.ShadowDecoration.Parent = this.btnEmployeePayment;
            this.btnEmployeePayment.Size = new System.Drawing.Size(203, 45);
            this.btnEmployeePayment.TabIndex = 5;
            this.btnEmployeePayment.Text = "Employee Salaries";
            this.btnEmployeePayment.Click += new System.EventHandler(this.btnEmployeePayment_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BorderRadius = 19;
            this.btnNewEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewEmployee.CheckedState.Parent = this.btnNewEmployee;
            this.btnNewEmployee.CustomImages.Parent = this.btnNewEmployee;
            this.btnNewEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployee.HoverState.Parent = this.btnNewEmployee;
            this.btnNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnNewEmployee.Image")));
            this.btnNewEmployee.Location = new System.Drawing.Point(35, 454);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.ShadowDecoration.Parent = this.btnNewEmployee;
            this.btnNewEmployee.Size = new System.Drawing.Size(203, 45);
            this.btnNewEmployee.TabIndex = 6;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnFormerTenants
            // 
            this.btnFormerTenants.BorderRadius = 19;
            this.btnFormerTenants.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFormerTenants.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFormerTenants.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormerTenants.CheckedState.Parent = this.btnFormerTenants;
            this.btnFormerTenants.CustomImages.Parent = this.btnFormerTenants;
            this.btnFormerTenants.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormerTenants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFormerTenants.ForeColor = System.Drawing.Color.White;
            this.btnFormerTenants.HoverState.Parent = this.btnFormerTenants;
            this.btnFormerTenants.Image = ((System.Drawing.Image)(resources.GetObject("btnFormerTenants.Image")));
            this.btnFormerTenants.Location = new System.Drawing.Point(35, 392);
            this.btnFormerTenants.Name = "btnFormerTenants";
            this.btnFormerTenants.ShadowDecoration.Parent = this.btnFormerTenants;
            this.btnFormerTenants.Size = new System.Drawing.Size(203, 45);
            this.btnFormerTenants.TabIndex = 7;
            this.btnFormerTenants.Text = "Former Tenants";
            this.btnFormerTenants.Click += new System.EventHandler(this.btnFormerTenants_Click);
            // 
            // btnAllStudent
            // 
            this.btnAllStudent.BorderRadius = 19;
            this.btnAllStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllStudent.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllStudent.CheckedState.Parent = this.btnAllStudent;
            this.btnAllStudent.CustomImages.Parent = this.btnAllStudent;
            this.btnAllStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAllStudent.ForeColor = System.Drawing.Color.White;
            this.btnAllStudent.HoverState.Parent = this.btnAllStudent;
            this.btnAllStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAllStudent.Image")));
            this.btnAllStudent.Location = new System.Drawing.Point(35, 330);
            this.btnAllStudent.Name = "btnAllStudent";
            this.btnAllStudent.ShadowDecoration.Parent = this.btnAllStudent;
            this.btnAllStudent.Size = new System.Drawing.Size(203, 45);
            this.btnAllStudent.TabIndex = 8;
            this.btnAllStudent.Text = "All Student Tenants";
            this.btnAllStudent.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnStudentFees
            // 
            this.btnStudentFees.BorderRadius = 19;
            this.btnStudentFees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentFees.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStudentFees.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudentFees.CheckedState.Parent = this.btnStudentFees;
            this.btnStudentFees.CustomImages.Parent = this.btnStudentFees;
            this.btnStudentFees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudentFees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStudentFees.ForeColor = System.Drawing.Color.White;
            this.btnStudentFees.HoverState.Parent = this.btnStudentFees;
            this.btnStudentFees.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentFees.Image")));
            this.btnStudentFees.Location = new System.Drawing.Point(35, 269);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.ShadowDecoration.Parent = this.btnStudentFees;
            this.btnStudentFees.Size = new System.Drawing.Size(203, 45);
            this.btnStudentFees.TabIndex = 9;
            this.btnStudentFees.Text = "Student Fees";
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
            // 
            // btnUpDel
            // 
            this.btnUpDel.BorderRadius = 19;
            this.btnUpDel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpDel.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpDel.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpDel.CheckedState.Parent = this.btnUpDel;
            this.btnUpDel.CustomImages.Parent = this.btnUpDel;
            this.btnUpDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpDel.ForeColor = System.Drawing.Color.White;
            this.btnUpDel.HoverState.Parent = this.btnUpDel;
            this.btnUpDel.Image = ((System.Drawing.Image)(resources.GetObject("btnUpDel.Image")));
            this.btnUpDel.Location = new System.Drawing.Point(35, 206);
            this.btnUpDel.Name = "btnUpDel";
            this.btnUpDel.ShadowDecoration.Parent = this.btnUpDel;
            this.btnUpDel.Size = new System.Drawing.Size(203, 45);
            this.btnUpDel.TabIndex = 10;
            this.btnUpDel.Text = "Update & Delete Student";
            this.btnUpDel.Click += new System.EventHandler(this.btnUpDel_Click);
            // 
            // btnUpDelEmployee
            // 
            this.btnUpDelEmployee.BorderRadius = 19;
            this.btnUpDelEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpDelEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpDelEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpDelEmployee.CheckedState.Parent = this.btnUpDelEmployee;
            this.btnUpDelEmployee.CustomImages.Parent = this.btnUpDelEmployee;
            this.btnUpDelEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpDelEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpDelEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpDelEmployee.HoverState.Parent = this.btnUpDelEmployee;
            this.btnUpDelEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpDelEmployee.Image")));
            this.btnUpDelEmployee.Location = new System.Drawing.Point(24, 516);
            this.btnUpDelEmployee.Name = "btnUpDelEmployee";
            this.btnUpDelEmployee.ShadowDecoration.Parent = this.btnUpDelEmployee;
            this.btnUpDelEmployee.Size = new System.Drawing.Size(203, 45);
            this.btnUpDelEmployee.TabIndex = 11;
            this.btnUpDelEmployee.Text = "Update & Delete Employees";
            this.btnUpDelEmployee.Click += new System.EventHandler(this.btnUpDelEmployee_Click);
            // 
            // btnFormerEmpl
            // 
            this.btnFormerEmpl.BorderRadius = 19;
            this.btnFormerEmpl.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFormerEmpl.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFormerEmpl.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormerEmpl.CheckedState.Parent = this.btnFormerEmpl;
            this.btnFormerEmpl.CustomImages.Parent = this.btnFormerEmpl;
            this.btnFormerEmpl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormerEmpl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFormerEmpl.ForeColor = System.Drawing.Color.White;
            this.btnFormerEmpl.HoverState.Parent = this.btnFormerEmpl;
            this.btnFormerEmpl.Image = ((System.Drawing.Image)(resources.GetObject("btnFormerEmpl.Image")));
            this.btnFormerEmpl.Location = new System.Drawing.Point(35, 698);
            this.btnFormerEmpl.Name = "btnFormerEmpl";
            this.btnFormerEmpl.ShadowDecoration.Parent = this.btnFormerEmpl;
            this.btnFormerEmpl.Size = new System.Drawing.Size(203, 45);
            this.btnFormerEmpl.TabIndex = 12;
            this.btnFormerEmpl.Text = "Former Employees";
            this.btnFormerEmpl.Click += new System.EventHandler(this.btnFormerEmpl_Click);
            // 
            // btnAllEmpl
            // 
            this.btnAllEmpl.BorderRadius = 19;
            this.btnAllEmpl.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllEmpl.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllEmpl.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllEmpl.CheckedState.Parent = this.btnAllEmpl;
            this.btnAllEmpl.CustomImages.Parent = this.btnAllEmpl;
            this.btnAllEmpl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllEmpl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAllEmpl.ForeColor = System.Drawing.Color.White;
            this.btnAllEmpl.HoverState.Parent = this.btnAllEmpl;
            this.btnAllEmpl.Image = ((System.Drawing.Image)(resources.GetObject("btnAllEmpl.Image")));
            this.btnAllEmpl.Location = new System.Drawing.Point(35, 639);
            this.btnAllEmpl.Name = "btnAllEmpl";
            this.btnAllEmpl.ShadowDecoration.Parent = this.btnAllEmpl;
            this.btnAllEmpl.Size = new System.Drawing.Size(203, 45);
            this.btnAllEmpl.TabIndex = 13;
            this.btnAllEmpl.Text = "All Activate Employees";
            this.btnAllEmpl.Click += new System.EventHandler(this.btnAllEmpl_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 22;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(1151, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(126, 45);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 22;
            this.btnExit.BorderThickness = 1;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Location = new System.Drawing.Point(1303, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(43, 45);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timr1
            // 
            this.timr1.Enabled = true;
            this.timr1.Interval = 1000;
            this.timr1.Tick += new System.EventHandler(this.timr1_Tick);
            // 
            // Dashboardfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAllEmpl);
            this.Controls.Add(this.btnFormerEmpl);
            this.Controls.Add(this.btnUpDelEmployee);
            this.Controls.Add(this.btnUpDel);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnAllStudent);
            this.Controls.Add(this.btnFormerTenants);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnEmployeePayment);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.lblSAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicbxHostal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboardfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicbxHostal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PicbxHostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSAS;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnEmployeePayment;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnFormerTenants;
        private Guna.UI2.WinForms.Guna2Button btnAllStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnUpDel;
        private Guna.UI2.WinForms.Guna2Button btnUpDelEmployee;
        private Guna.UI2.WinForms.Guna2Button btnFormerEmpl;
        private Guna.UI2.WinForms.Guna2Button btnAllEmpl;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Timer timr1;
    }
}