namespace HostelManagementSystem
{
    partial class EmplSalariesfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmplSalariesfrm));
            this.dgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.dtePickMonth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtbxSalaryPay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxIDNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxjobDescrip = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid.BackgroundColor = System.Drawing.Color.White;
            this.dgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrid.EnableHeadersVisualStyles = false;
            this.dgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgrid.Location = new System.Drawing.Point(21, 330);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowHeadersVisible = false;
            this.dgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid.Size = new System.Drawing.Size(832, 164);
            this.dgrid.TabIndex = 64;
            this.dgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrid.ThemeStyle.HeaderStyle.Height = 4;
            this.dgrid.ThemeStyle.ReadOnly = false;
            this.dgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgrid.ThemeStyle.RowsStyle.Height = 22;
            this.dgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 16;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.White;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(521, 261);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(97, 33);
            this.btnPay.TabIndex = 63;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dtePickMonth
            // 
            this.dtePickMonth.CheckedState.Parent = this.dtePickMonth;
            this.dtePickMonth.FillColor = System.Drawing.Color.DimGray;
            this.dtePickMonth.ForeColor = System.Drawing.Color.Black;
            this.dtePickMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtePickMonth.HoverState.Parent = this.dtePickMonth;
            this.dtePickMonth.Location = new System.Drawing.Point(221, 220);
            this.dtePickMonth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtePickMonth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtePickMonth.Name = "dtePickMonth";
            this.dtePickMonth.ShadowDecoration.Parent = this.dtePickMonth;
            this.dtePickMonth.Size = new System.Drawing.Size(553, 36);
            this.dtePickMonth.TabIndex = 62;
            this.dtePickMonth.Value = new System.DateTime(2021, 1, 27, 17, 42, 51, 973);
            this.dtePickMonth.ValueChanged += new System.EventHandler(this.dtePickMonth_ValueChanged);
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
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(828, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(47, 38);
            this.btnExit.TabIndex = 61;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnClear.Location = new System.Drawing.Point(674, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 16;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(521, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbxSalaryPay
            // 
            this.txtbxSalaryPay.AutoRoundedCorners = true;
            this.txtbxSalaryPay.BorderRadius = 14;
            this.txtbxSalaryPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSalaryPay.DefaultText = "";
            this.txtbxSalaryPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSalaryPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSalaryPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSalaryPay.DisabledState.Parent = this.txtbxSalaryPay;
            this.txtbxSalaryPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSalaryPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSalaryPay.FocusedState.Parent = this.txtbxSalaryPay;
            this.txtbxSalaryPay.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtbxSalaryPay.ForeColor = System.Drawing.Color.Black;
            this.txtbxSalaryPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSalaryPay.HoverState.Parent = this.txtbxSalaryPay;
            this.txtbxSalaryPay.Location = new System.Drawing.Point(221, 264);
            this.txtbxSalaryPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSalaryPay.Name = "txtbxSalaryPay";
            this.txtbxSalaryPay.PasswordChar = '\0';
            this.txtbxSalaryPay.PlaceholderText = "";
            this.txtbxSalaryPay.SelectedText = "";
            this.txtbxSalaryPay.ShadowDecoration.Parent = this.txtbxSalaryPay;
            this.txtbxSalaryPay.Size = new System.Drawing.Size(271, 30);
            this.txtbxSalaryPay.TabIndex = 58;
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
            this.txtbxIDNo.Location = new System.Drawing.Point(221, 58);
            this.txtbxIDNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxIDNo.Name = "txtbxIDNo";
            this.txtbxIDNo.PasswordChar = '\0';
            this.txtbxIDNo.PlaceholderText = "";
            this.txtbxIDNo.SelectedText = "";
            this.txtbxIDNo.ShadowDecoration.Parent = this.txtbxIDNo;
            this.txtbxIDNo.Size = new System.Drawing.Size(271, 30);
            this.txtbxIDNo.TabIndex = 56;
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
            this.txtbxEm.Location = new System.Drawing.Point(221, 138);
            this.txtbxEm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxEm.Name = "txtbxEm";
            this.txtbxEm.PasswordChar = '\0';
            this.txtbxEm.PlaceholderText = "";
            this.txtbxEm.SelectedText = "";
            this.txtbxEm.ShadowDecoration.Parent = this.txtbxEm;
            this.txtbxEm.Size = new System.Drawing.Size(553, 30);
            this.txtbxEm.TabIndex = 54;
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
            this.txtbxN.Location = new System.Drawing.Point(221, 98);
            this.txtbxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxN.Name = "txtbxN";
            this.txtbxN.PasswordChar = '\0';
            this.txtbxN.PlaceholderText = "";
            this.txtbxN.SelectedText = "";
            this.txtbxN.ShadowDecoration.Parent = this.txtbxN;
            this.txtbxN.Size = new System.Drawing.Size(553, 30);
            this.txtbxN.TabIndex = 57;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(82, 274);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(117, 20);
            this.lbl.TabIndex = 53;
            this.lbl.Text = "Salary Amount ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Month ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(82, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Job Description ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(82, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "ID Number ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 33);
            this.label4.TabIndex = 65;
            this.label4.Text = "EMPLOYEE FINANCES";
            // 
            // cbxjobDescrip
            // 
            this.cbxjobDescrip.AutoRoundedCorners = true;
            this.cbxjobDescrip.BackColor = System.Drawing.Color.Transparent;
            this.cbxjobDescrip.BorderRadius = 17;
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
            this.cbxjobDescrip.Location = new System.Drawing.Point(221, 176);
            this.cbxjobDescrip.Name = "cbxjobDescrip";
            this.cbxjobDescrip.ShadowDecoration.Parent = this.cbxjobDescrip;
            this.cbxjobDescrip.Size = new System.Drawing.Size(553, 36);
            this.cbxjobDescrip.TabIndex = 66;
            // 
            // EmplSalariesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.cbxjobDescrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dtePickMonth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSalaryPay);
            this.Controls.Add(this.txtbxIDNo);
            this.Controls.Add(this.txtbxEm);
            this.Controls.Add(this.txtbxN);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmplSalariesfrm";
            this.Text = "EmplSalariesfrm";
            this.Load += new System.EventHandler(this.EmplSalariesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgrid;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtePickMonth;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSalaryPay;
        private Guna.UI2.WinForms.Guna2TextBox txtbxIDNo;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEm;
        private Guna.UI2.WinForms.Guna2TextBox txtbxN;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxjobDescrip;
    }
}