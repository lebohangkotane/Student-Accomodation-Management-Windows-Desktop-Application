namespace HostelManagementSystem
{
    partial class AddNewRoomfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRoomfrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxAddnewRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.chckbxYesANR = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtbxUpDelRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChckbxYesUpDelRoom = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchRoom = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewALLRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblRoomExists = new System.Windows.Forms.Label();
            this.lblRoomUpDel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewALLRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW ROOM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "UPDATE / DELETE ROOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Number";
            // 
            // txtbxAddnewRoomNumber
            // 
            this.txtbxAddnewRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxAddnewRoomNumber.DefaultText = "";
            this.txtbxAddnewRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxAddnewRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxAddnewRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxAddnewRoomNumber.DisabledState.Parent = this.txtbxAddnewRoomNumber;
            this.txtbxAddnewRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxAddnewRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxAddnewRoomNumber.FocusedState.Parent = this.txtbxAddnewRoomNumber;
            this.txtbxAddnewRoomNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAddnewRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtbxAddnewRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxAddnewRoomNumber.HoverState.Parent = this.txtbxAddnewRoomNumber;
            this.txtbxAddnewRoomNumber.Location = new System.Drawing.Point(113, 71);
            this.txtbxAddnewRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxAddnewRoomNumber.Name = "txtbxAddnewRoomNumber";
            this.txtbxAddnewRoomNumber.PasswordChar = '\0';
            this.txtbxAddnewRoomNumber.PlaceholderText = "";
            this.txtbxAddnewRoomNumber.SelectedText = "";
            this.txtbxAddnewRoomNumber.ShadowDecoration.Parent = this.txtbxAddnewRoomNumber;
            this.txtbxAddnewRoomNumber.Size = new System.Drawing.Size(200, 22);
            this.txtbxAddnewRoomNumber.TabIndex = 6;
            // 
            // chckbxYesANR
            // 
            this.chckbxYesANR.AutoSize = true;
            this.chckbxYesANR.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckbxYesANR.CheckedState.BorderRadius = 0;
            this.chckbxYesANR.CheckedState.BorderThickness = 0;
            this.chckbxYesANR.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckbxYesANR.ForeColor = System.Drawing.Color.White;
            this.chckbxYesANR.Location = new System.Drawing.Point(573, 75);
            this.chckbxYesANR.Name = "chckbxYesANR";
            this.chckbxYesANR.Size = new System.Drawing.Size(59, 17);
            this.chckbxYesANR.TabIndex = 7;
            this.chckbxYesANR.Text = "Active ";
            this.chckbxYesANR.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckbxYesANR.UncheckedState.BorderRadius = 0;
            this.chckbxYesANR.UncheckedState.BorderThickness = 0;
            this.chckbxYesANR.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtbxUpDelRoomNumber
            // 
            this.txtbxUpDelRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUpDelRoomNumber.DefaultText = "";
            this.txtbxUpDelRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxUpDelRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxUpDelRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUpDelRoomNumber.DisabledState.Parent = this.txtbxUpDelRoomNumber;
            this.txtbxUpDelRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUpDelRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUpDelRoomNumber.FocusedState.Parent = this.txtbxUpDelRoomNumber;
            this.txtbxUpDelRoomNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUpDelRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtbxUpDelRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUpDelRoomNumber.HoverState.Parent = this.txtbxUpDelRoomNumber;
            this.txtbxUpDelRoomNumber.Location = new System.Drawing.Point(113, 179);
            this.txtbxUpDelRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxUpDelRoomNumber.Name = "txtbxUpDelRoomNumber";
            this.txtbxUpDelRoomNumber.PasswordChar = '\0';
            this.txtbxUpDelRoomNumber.PlaceholderText = "";
            this.txtbxUpDelRoomNumber.SelectedText = "";
            this.txtbxUpDelRoomNumber.ShadowDecoration.Parent = this.txtbxUpDelRoomNumber;
            this.txtbxUpDelRoomNumber.Size = new System.Drawing.Size(200, 22);
            this.txtbxUpDelRoomNumber.TabIndex = 8;
            this.txtbxUpDelRoomNumber.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // ChckbxYesUpDelRoom
            // 
            this.ChckbxYesUpDelRoom.AutoSize = true;
            this.ChckbxYesUpDelRoom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChckbxYesUpDelRoom.CheckedState.BorderRadius = 0;
            this.ChckbxYesUpDelRoom.CheckedState.BorderThickness = 0;
            this.ChckbxYesUpDelRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChckbxYesUpDelRoom.ForeColor = System.Drawing.Color.White;
            this.ChckbxYesUpDelRoom.Location = new System.Drawing.Point(573, 179);
            this.ChckbxYesUpDelRoom.Name = "ChckbxYesUpDelRoom";
            this.ChckbxYesUpDelRoom.Size = new System.Drawing.Size(59, 17);
            this.ChckbxYesUpDelRoom.TabIndex = 9;
            this.ChckbxYesUpDelRoom.Text = "Active ";
            this.ChckbxYesUpDelRoom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChckbxYesUpDelRoom.UncheckedState.BorderRadius = 0;
            this.ChckbxYesUpDelRoom.UncheckedState.BorderThickness = 0;
            this.ChckbxYesUpDelRoom.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChckbxYesUpDelRoom.CheckedChanged += new System.EventHandler(this.ChckbxYesUpDelRoom_CheckedChanged);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BorderRadius = 16;
            this.btnDeleteRoom.CheckedState.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.CustomImages.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.FillColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.HoverState.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.Image")));
            this.btnDeleteRoom.Location = new System.Drawing.Point(709, 207);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.ShadowDecoration.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Size = new System.Drawing.Size(117, 41);
            this.btnDeleteRoom.TabIndex = 10;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BorderRadius = 16;
            this.btnSearchRoom.CheckedState.Parent = this.btnSearchRoom;
            this.btnSearchRoom.CustomImages.Parent = this.btnSearchRoom;
            this.btnSearchRoom.FillColor = System.Drawing.Color.White;
            this.btnSearchRoom.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearchRoom.HoverState.Parent = this.btnSearchRoom;
            this.btnSearchRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRoom.Image")));
            this.btnSearchRoom.Location = new System.Drawing.Point(332, 173);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.ShadowDecoration.Parent = this.btnSearchRoom;
            this.btnSearchRoom.Size = new System.Drawing.Size(114, 33);
            this.btnSearchRoom.TabIndex = 11;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // dataGridViewALLRooms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewALLRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewALLRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewALLRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewALLRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewALLRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewALLRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewALLRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewALLRooms.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewALLRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewALLRooms.EnableHeadersVisualStyles = false;
            this.dataGridViewALLRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewALLRooms.Location = new System.Drawing.Point(39, 311);
            this.dataGridViewALLRooms.Name = "dataGridViewALLRooms";
            this.dataGridViewALLRooms.RowHeadersVisible = false;
            this.dataGridViewALLRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewALLRooms.Size = new System.Drawing.Size(792, 173);
            this.dataGridViewALLRooms.TabIndex = 12;
            this.dataGridViewALLRooms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewALLRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewALLRooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewALLRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewALLRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewALLRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewALLRooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewALLRooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewALLRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewALLRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewALLRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewALLRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewALLRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewALLRooms.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewALLRooms.ThemeStyle.ReadOnly = false;
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewALLRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewALLRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDridViewALLRooms_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(380, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "ALL ROOMS";
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BorderRadius = 16;
            this.btnUpdateRoom.CheckedState.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.CustomImages.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.FillColor = System.Drawing.Color.White;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.HoverState.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRoom.Image")));
            this.btnUpdateRoom.Location = new System.Drawing.Point(573, 207);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.ShadowDecoration.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Size = new System.Drawing.Size(117, 41);
            this.btnUpdateRoom.TabIndex = 14;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 16;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.Location = new System.Drawing.Point(705, 65);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(121, 41);
            this.btnAddRoom.TabIndex = 15;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
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
            this.btnExit.Location = new System.Drawing.Point(816, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(47, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRoomExists
            // 
            this.lblRoomExists.AutoSize = true;
            this.lblRoomExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomExists.ForeColor = System.Drawing.Color.Yellow;
            this.lblRoomExists.Location = new System.Drawing.Point(173, 98);
            this.lblRoomExists.Name = "lblRoomExists";
            this.lblRoomExists.Size = new System.Drawing.Size(54, 17);
            this.lblRoomExists.TabIndex = 17;
            this.lblRoomExists.Text = "setText";
            // 
            // lblRoomUpDel
            // 
            this.lblRoomUpDel.AutoSize = true;
            this.lblRoomUpDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomUpDel.ForeColor = System.Drawing.Color.Yellow;
            this.lblRoomUpDel.Location = new System.Drawing.Point(173, 207);
            this.lblRoomUpDel.Name = "lblRoomUpDel";
            this.lblRoomUpDel.Size = new System.Drawing.Size(54, 17);
            this.lblRoomUpDel.TabIndex = 18;
            this.lblRoomUpDel.Text = "setText";
            // 
            // AddNewRoomfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.lblRoomUpDel);
            this.Controls.Add(this.lblRoomExists);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewALLRooms);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.ChckbxYesUpDelRoom);
            this.Controls.Add(this.txtbxUpDelRoomNumber);
            this.Controls.Add(this.chckbxYesANR);
            this.Controls.Add(this.txtbxAddnewRoomNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewRoomfrm";
            this.Text = "frmAddNewRoom";
            this.Load += new System.EventHandler(this.frmAddNewRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewALLRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtbxAddnewRoomNumber;
        private Guna.UI2.WinForms.Guna2CheckBox chckbxYesANR;
        private Guna.UI2.WinForms.Guna2TextBox txtbxUpDelRoomNumber;
        private Guna.UI2.WinForms.Guna2CheckBox ChckbxYesUpDelRoom;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRoom;
        private Guna.UI2.WinForms.Guna2Button btnSearchRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewALLRooms;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRoom;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblRoomExists;
        private System.Windows.Forms.Label lblRoomUpDel;
    }
}