namespace HostelManagementSystem
{
    partial class Loginfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnklblSignUp = new System.Windows.Forms.LinkLabel();
            this.txtbxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(141, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(79, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, Please Login";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.BorderRadius = 22;
            this.btnSignIn.BorderThickness = 1;
            this.btnSignIn.CheckedState.Parent = this.btnSignIn;
            this.btnSignIn.CustomImages.Parent = this.btnSignIn;
            this.btnSignIn.FillColor = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSignIn.HoverState.FillColor = System.Drawing.Color.Teal;
            this.btnSignIn.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverState.Parent = this.btnSignIn;
            this.btnSignIn.Location = new System.Drawing.Point(138, 255);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.ShadowDecoration.Parent = this.btnSignIn;
            this.btnSignIn.Size = new System.Drawing.Size(118, 39);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Snow;
            this.lblForgotPassword.Location = new System.Drawing.Point(138, 314);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(122, 17);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(58, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Don\'t have an account yet?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lnklblSignUp
            // 
            this.lnklblSignUp.AutoSize = true;
            this.lnklblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblSignUp.LinkColor = System.Drawing.Color.White;
            this.lnklblSignUp.Location = new System.Drawing.Point(245, 340);
            this.lnklblSignUp.Name = "lnklblSignUp";
            this.lnklblSignUp.Size = new System.Drawing.Size(70, 20);
            this.lnklblSignUp.TabIndex = 6;
            this.lnklblSignUp.TabStop = true;
            this.lnklblSignUp.Text = "Sign Up!";
            this.lnklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSignUp_LinkClicked);
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.BorderRadius = 24;
            this.txtbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUsername.DefaultText = "";
            this.txtbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUsername.DisabledState.Parent = this.txtbxUsername;
            this.txtbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUsername.FillColor = System.Drawing.Color.Teal;
            this.txtbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUsername.FocusedState.Parent = this.txtbxUsername;
            this.txtbxUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtbxUsername.ForeColor = System.Drawing.Color.White;
            this.txtbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUsername.HoverState.Parent = this.txtbxUsername;
            this.txtbxUsername.Location = new System.Drawing.Point(82, 134);
            this.txtbxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.PasswordChar = '\0';
            this.txtbxUsername.PlaceholderText = "Username";
            this.txtbxUsername.SelectedText = "";
            this.txtbxUsername.ShadowDecoration.Parent = this.txtbxUsername;
            this.txtbxUsername.Size = new System.Drawing.Size(231, 46);
            this.txtbxUsername.TabIndex = 7;
            this.txtbxUsername.TextChanged += new System.EventHandler(this.txtbxUsername_TextChanged);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BorderRadius = 24;
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.DefaultText = "";
            this.txtbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.DisabledState.Parent = this.txtbxPassword;
            this.txtbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.FillColor = System.Drawing.Color.Teal;
            this.txtbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.FocusedState.Parent = this.txtbxPassword;
            this.txtbxPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtbxPassword.ForeColor = System.Drawing.Color.White;
            this.txtbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.HoverState.Parent = this.txtbxPassword;
            this.txtbxPassword.Location = new System.Drawing.Point(82, 192);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = 'X';
            this.txtbxPassword.PlaceholderText = "Password";
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.ShadowDecoration.Parent = this.txtbxPassword;
            this.txtbxPassword.Size = new System.Drawing.Size(231, 46);
            this.txtbxPassword.TabIndex = 8;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 29;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lnklblSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnklblSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtbxUsername;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

