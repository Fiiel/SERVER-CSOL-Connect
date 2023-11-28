namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_Dashboard));
            Panel_SideNav = new Panel();
            Button_Logout = new Button();
            Button_Accounts = new Button();
            Button_Scheduler = new Button();
            Button_Mapping = new Button();
            Button_Dashboard = new Button();
            PicBox_SuperAdmin_CSOLLogo = new PictureBox();
            dataGridView1 = new DataGridView();
            PictureBox_Notification = new PictureBox();
            NotifCount = new Label();
            SearchBtn = new PictureBox();
            Searchbar = new TextBox();
            label1 = new Label();
            Label_HistoryLog = new Label();
            PictureBox_ExportCSV = new PictureBox();
            OngoingLabsTable = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PCName_Filter_ComboBox = new ComboBox();
            CL_Filter_ComboBox = new ComboBox();
            Device_Filter_ComboBox = new ComboBox();
            Button_Refresh = new Button();
            label5 = new Label();
            Label_CL = new Label();
            Label_PCName = new Label();
            Label_Device = new Label();
            DateTimePicker = new DateTimePicker();
            label7 = new Label();
            Button_Search = new Button();
            Time_Filter_TextBox = new TextBox();
            Label_Time = new Label();
            Button_Clear = new Button();
            label6 = new Label();
            Panel_SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Notification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_ExportCSV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OngoingLabsTable).BeginInit();
            SuspendLayout();
            // 
            // Panel_SideNav
            // 
            Panel_SideNav.BackColor = Color.FromArgb(7, 25, 82);
            Panel_SideNav.Controls.Add(Button_Logout);
            Panel_SideNav.Controls.Add(Button_Accounts);
            Panel_SideNav.Controls.Add(Button_Scheduler);
            Panel_SideNav.Controls.Add(Button_Mapping);
            Panel_SideNav.Controls.Add(Button_Dashboard);
            Panel_SideNav.Controls.Add(PicBox_SuperAdmin_CSOLLogo);
            Panel_SideNav.Dock = DockStyle.Left;
            Panel_SideNav.Location = new Point(0, 0);
            Panel_SideNav.Name = "Panel_SideNav";
            Panel_SideNav.Size = new Size(249, 681);
            Panel_SideNav.TabIndex = 0;
            // 
            // Button_Logout
            // 
            Button_Logout.Cursor = Cursors.Hand;
            Button_Logout.FlatAppearance.BorderSize = 0;
            Button_Logout.FlatStyle = FlatStyle.Flat;
            Button_Logout.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Logout.ForeColor = Color.White;
            Button_Logout.Image = Properties.Resources.logout_symbol;
            Button_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            Button_Logout.Location = new Point(0, 592);
            Button_Logout.Name = "Button_Logout";
            Button_Logout.Padding = new Padding(12, 0, 0, 0);
            Button_Logout.Size = new Size(251, 73);
            Button_Logout.TabIndex = 4;
            Button_Logout.Text = "Logout";
            Button_Logout.UseVisualStyleBackColor = true;
            Button_Logout.Click += Button_Logout_Click;
            // 
            // Button_Accounts
            // 
            Button_Accounts.Cursor = Cursors.Hand;
            Button_Accounts.FlatAppearance.BorderSize = 0;
            Button_Accounts.FlatStyle = FlatStyle.Flat;
            Button_Accounts.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Accounts.ForeColor = Color.White;
            Button_Accounts.Image = Properties.Resources.accounts_symbol;
            Button_Accounts.ImageAlign = ContentAlignment.MiddleLeft;
            Button_Accounts.Location = new Point(0, 457);
            Button_Accounts.Name = "Button_Accounts";
            Button_Accounts.Padding = new Padding(12, 0, 0, 0);
            Button_Accounts.Size = new Size(251, 73);
            Button_Accounts.TabIndex = 3;
            Button_Accounts.Text = "   Accounts";
            Button_Accounts.UseVisualStyleBackColor = true;
            Button_Accounts.Click += Button_Accounts_Click;
            // 
            // Button_Scheduler
            // 
            Button_Scheduler.Cursor = Cursors.Hand;
            Button_Scheduler.FlatAppearance.BorderSize = 0;
            Button_Scheduler.FlatStyle = FlatStyle.Flat;
            Button_Scheduler.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Scheduler.ForeColor = Color.White;
            Button_Scheduler.Image = Properties.Resources.schedule_symbol;
            Button_Scheduler.ImageAlign = ContentAlignment.MiddleLeft;
            Button_Scheduler.Location = new Point(0, 377);
            Button_Scheduler.Name = "Button_Scheduler";
            Button_Scheduler.Padding = new Padding(12, 0, 0, 0);
            Button_Scheduler.Size = new Size(251, 73);
            Button_Scheduler.TabIndex = 2;
            Button_Scheduler.Text = "    Scheduler";
            Button_Scheduler.UseVisualStyleBackColor = true;
            Button_Scheduler.Click += Button_Scheduler_Click;
            // 
            // Button_Mapping
            // 
            Button_Mapping.Cursor = Cursors.Hand;
            Button_Mapping.FlatAppearance.BorderSize = 0;
            Button_Mapping.FlatStyle = FlatStyle.Flat;
            Button_Mapping.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Mapping.ForeColor = Color.White;
            Button_Mapping.Image = Properties.Resources.mapping_symbol;
            Button_Mapping.ImageAlign = ContentAlignment.MiddleLeft;
            Button_Mapping.Location = new Point(0, 297);
            Button_Mapping.Name = "Button_Mapping";
            Button_Mapping.Padding = new Padding(12, 0, 0, 0);
            Button_Mapping.Size = new Size(251, 73);
            Button_Mapping.TabIndex = 1;
            Button_Mapping.Text = "  Mapping";
            Button_Mapping.UseVisualStyleBackColor = true;
            Button_Mapping.Click += Button_Mapping_Click;
            // 
            // Button_Dashboard
            // 
            Button_Dashboard.Cursor = Cursors.Hand;
            Button_Dashboard.FlatAppearance.BorderSize = 0;
            Button_Dashboard.FlatStyle = FlatStyle.Flat;
            Button_Dashboard.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Dashboard.ForeColor = Color.White;
            Button_Dashboard.Image = (Image)resources.GetObject("Button_Dashboard.Image");
            Button_Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Button_Dashboard.Location = new Point(0, 217);
            Button_Dashboard.Name = "Button_Dashboard";
            Button_Dashboard.Padding = new Padding(12, 0, 0, 0);
            Button_Dashboard.Size = new Size(251, 73);
            Button_Dashboard.TabIndex = 0;
            Button_Dashboard.Text = "    Dashboard";
            Button_Dashboard.UseVisualStyleBackColor = true;
            Button_Dashboard.Click += Button_Dashboard_Click;
            // 
            // PicBox_SuperAdmin_CSOLLogo
            // 
            PicBox_SuperAdmin_CSOLLogo.Image = Properties.Resources.csol_logo;
            PicBox_SuperAdmin_CSOLLogo.Location = new Point(12, 12);
            PicBox_SuperAdmin_CSOLLogo.Name = "PicBox_SuperAdmin_CSOLLogo";
            PicBox_SuperAdmin_CSOLLogo.Size = new Size(222, 186);
            PicBox_SuperAdmin_CSOLLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PicBox_SuperAdmin_CSOLLogo.TabIndex = 0;
            PicBox_SuperAdmin_CSOLLogo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(273, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(685, 580);
            dataGridView1.TabIndex = 1;
            // 
            // PictureBox_Notification
            // 
            PictureBox_Notification.Cursor = Cursors.Hand;
            PictureBox_Notification.Image = Properties.Resources.notification_icon1;
            PictureBox_Notification.Location = new Point(1217, 18);
            PictureBox_Notification.Name = "PictureBox_Notification";
            PictureBox_Notification.Size = new Size(35, 38);
            PictureBox_Notification.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Notification.TabIndex = 8;
            PictureBox_Notification.TabStop = false;
            PictureBox_Notification.Click += PictureBox_Notification_Click;
            // 
            // NotifCount
            // 
            NotifCount.AutoSize = true;
            NotifCount.BackColor = Color.Red;
            NotifCount.FlatStyle = FlatStyle.Flat;
            NotifCount.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NotifCount.ForeColor = Color.White;
            NotifCount.Location = new Point(1241, 12);
            NotifCount.Name = "NotifCount";
            NotifCount.Size = new Size(0, 23);
            NotifCount.TabIndex = 9;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(192, 0, 0);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.Image = Properties.Resources.search_icon;
            SearchBtn.Location = new Point(908, 35);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(36, 31);
            SearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchBtn.TabIndex = 23;
            SearchBtn.TabStop = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchbar
            // 
            Searchbar.Location = new Point(674, 39);
            Searchbar.Name = "Searchbar";
            Searchbar.PlaceholderText = "Search from History Log";
            Searchbar.Size = new Size(228, 23);
            Searchbar.TabIndex = 22;
            Searchbar.KeyPress += Searchbar_KeyPress;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(656, 31);
            label1.Name = "label1";
            label1.Size = new Size(301, 39);
            label1.TabIndex = 21;
            // 
            // Label_HistoryLog
            // 
            Label_HistoryLog.AutoSize = true;
            Label_HistoryLog.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label_HistoryLog.ForeColor = Color.FromArgb(7, 25, 82);
            Label_HistoryLog.Location = new Point(273, 18);
            Label_HistoryLog.Name = "Label_HistoryLog";
            Label_HistoryLog.Size = new Size(225, 50);
            Label_HistoryLog.TabIndex = 20;
            Label_HistoryLog.Text = "History Log";
            // 
            // PictureBox_ExportCSV
            // 
            PictureBox_ExportCSV.BackColor = Color.FromArgb(192, 255, 192);
            PictureBox_ExportCSV.Cursor = Cursors.Hand;
            PictureBox_ExportCSV.Image = Properties.Resources.icon_csv;
            PictureBox_ExportCSV.Location = new Point(985, 601);
            PictureBox_ExportCSV.Name = "PictureBox_ExportCSV";
            PictureBox_ExportCSV.Size = new Size(56, 58);
            PictureBox_ExportCSV.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_ExportCSV.TabIndex = 24;
            PictureBox_ExportCSV.TabStop = false;
            PictureBox_ExportCSV.Click += PictureBox_ExportCSV_Click;
            // 
            // OngoingLabsTable
            // 
            OngoingLabsTable.AllowUserToResizeColumns = false;
            OngoingLabsTable.AllowUserToResizeRows = false;
            OngoingLabsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OngoingLabsTable.BackgroundColor = Color.SpringGreen;
            OngoingLabsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OngoingLabsTable.Cursor = Cursors.Hand;
            OngoingLabsTable.Location = new Point(979, 420);
            OngoingLabsTable.Name = "OngoingLabsTable";
            OngoingLabsTable.RowHeadersVisible = false;
            OngoingLabsTable.RowTemplate.Height = 25;
            OngoingLabsTable.Size = new Size(277, 128);
            OngoingLabsTable.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(7, 25, 82);
            label2.Location = new Point(978, 387);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 26;
            label2.Text = "Ongoing Labs";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 0, 0);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(979, 123);
            label3.Name = "label3";
            label3.Size = new Size(277, 250);
            label3.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(7, 25, 82);
            label4.Location = new Point(979, 84);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 28;
            label4.Text = "Filter";
            // 
            // PCName_Filter_ComboBox
            // 
            PCName_Filter_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PCName_Filter_ComboBox.FormattingEnabled = true;
            PCName_Filter_ComboBox.Items.AddRange(new object[] { "Elem1", "Elem2", "Elem3", "Elem4", "Elem5", "Elem6", "HS1", "HS2", "HS3", "HS4", "SHS1", "SHS2" });
            PCName_Filter_ComboBox.Location = new Point(996, 165);
            PCName_Filter_ComboBox.MaxLength = 50;
            PCName_Filter_ComboBox.Name = "PCName_Filter_ComboBox";
            PCName_Filter_ComboBox.Size = new Size(102, 23);
            PCName_Filter_ComboBox.TabIndex = 55;
            // 
            // CL_Filter_ComboBox
            // 
            CL_Filter_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CL_Filter_ComboBox.FormattingEnabled = true;
            CL_Filter_ComboBox.Items.AddRange(new object[] { "1", "2", "3" });
            CL_Filter_ComboBox.Location = new Point(996, 223);
            CL_Filter_ComboBox.MaxLength = 50;
            CL_Filter_ComboBox.Name = "CL_Filter_ComboBox";
            CL_Filter_ComboBox.Size = new Size(102, 23);
            CL_Filter_ComboBox.TabIndex = 56;
            // 
            // Device_Filter_ComboBox
            // 
            Device_Filter_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Device_Filter_ComboBox.FormattingEnabled = true;
            Device_Filter_ComboBox.Items.AddRange(new object[] { "Mouse", "Keyboard", "LAN" });
            Device_Filter_ComboBox.Location = new Point(1119, 165);
            Device_Filter_ComboBox.MaxLength = 50;
            Device_Filter_ComboBox.Name = "Device_Filter_ComboBox";
            Device_Filter_ComboBox.Size = new Size(117, 23);
            Device_Filter_ComboBox.TabIndex = 57;
            // 
            // Button_Refresh
            // 
            Button_Refresh.BackColor = Color.FromArgb(7, 25, 82);
            Button_Refresh.Cursor = Cursors.Hand;
            Button_Refresh.FlatStyle = FlatStyle.Popup;
            Button_Refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Refresh.ForeColor = SystemColors.Control;
            Button_Refresh.Location = new Point(1086, 337);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.Size = new Size(75, 23);
            Button_Refresh.TabIndex = 58;
            Button_Refresh.Text = "Refresh";
            Button_Refresh.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(7, 25, 82);
            label5.Location = new Point(978, 564);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 59;
            label5.Text = "Export to CSV";
            // 
            // Label_CL
            // 
            Label_CL.AutoSize = true;
            Label_CL.BackColor = Color.FromArgb(192, 0, 0);
            Label_CL.FlatStyle = FlatStyle.Flat;
            Label_CL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_CL.ForeColor = Color.Transparent;
            Label_CL.Location = new Point(991, 199);
            Label_CL.Name = "Label_CL";
            Label_CL.Size = new Size(41, 21);
            Label_CL.TabIndex = 60;
            Label_CL.Text = "CL #";
            // 
            // Label_PCName
            // 
            Label_PCName.AutoSize = true;
            Label_PCName.BackColor = Color.FromArgb(192, 0, 0);
            Label_PCName.FlatStyle = FlatStyle.Flat;
            Label_PCName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_PCName.ForeColor = Color.Transparent;
            Label_PCName.Location = new Point(991, 141);
            Label_PCName.Name = "Label_PCName";
            Label_PCName.Size = new Size(80, 21);
            Label_PCName.TabIndex = 61;
            Label_PCName.Text = "PC Name";
            // 
            // Label_Device
            // 
            Label_Device.AutoSize = true;
            Label_Device.BackColor = Color.FromArgb(192, 0, 0);
            Label_Device.FlatStyle = FlatStyle.Flat;
            Label_Device.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Device.ForeColor = Color.Transparent;
            Label_Device.Location = new Point(1114, 141);
            Label_Device.Name = "Label_Device";
            Label_Device.Size = new Size(62, 21);
            Label_Device.TabIndex = 62;
            Label_Device.Text = "Device";
            // 
            // DateTimePicker
            // 
            DateTimePicker.CustomFormat = "";
            DateTimePicker.Format = DateTimePickerFormat.Short;
            DateTimePicker.Location = new Point(996, 280);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(102, 23);
            DateTimePicker.TabIndex = 63;
            DateTimePicker.Value = new DateTime(2023, 11, 28, 22, 15, 13, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 0, 0);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(991, 256);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 64;
            label7.Text = "Date";
            // 
            // Button_Search
            // 
            Button_Search.BackColor = Color.FromArgb(7, 25, 82);
            Button_Search.Cursor = Cursors.Hand;
            Button_Search.FlatStyle = FlatStyle.Popup;
            Button_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Search.ForeColor = SystemColors.Control;
            Button_Search.Location = new Point(1172, 337);
            Button_Search.Name = "Button_Search";
            Button_Search.Size = new Size(75, 23);
            Button_Search.TabIndex = 65;
            Button_Search.Text = "Search";
            Button_Search.UseVisualStyleBackColor = false;
            // 
            // Time_Filter_TextBox
            // 
            Time_Filter_TextBox.Location = new Point(1119, 280);
            Time_Filter_TextBox.Name = "Time_Filter_TextBox";
            Time_Filter_TextBox.PlaceholderText = "Type here the Time";
            Time_Filter_TextBox.Size = new Size(117, 23);
            Time_Filter_TextBox.TabIndex = 67;
            // 
            // Label_Time
            // 
            Label_Time.AutoSize = true;
            Label_Time.BackColor = Color.FromArgb(192, 0, 0);
            Label_Time.FlatStyle = FlatStyle.Flat;
            Label_Time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Time.ForeColor = Color.Transparent;
            Label_Time.Location = new Point(1114, 255);
            Label_Time.Name = "Label_Time";
            Label_Time.Size = new Size(48, 21);
            Label_Time.TabIndex = 68;
            Label_Time.Text = "Time";
            // 
            // Button_Clear
            // 
            Button_Clear.BackColor = Color.FromArgb(7, 25, 82);
            Button_Clear.Cursor = Cursors.Hand;
            Button_Clear.FlatStyle = FlatStyle.Popup;
            Button_Clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Clear.ForeColor = SystemColors.Control;
            Button_Clear.Location = new Point(996, 337);
            Button_Clear.Name = "Button_Clear";
            Button_Clear.Size = new Size(75, 23);
            Button_Clear.TabIndex = 69;
            Button_Clear.Text = "Clear";
            Button_Clear.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(979, 597);
            label6.Name = "label6";
            label6.Size = new Size(68, 68);
            label6.TabIndex = 70;
            // 
            // SuperAdmin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(PictureBox_ExportCSV);
            Controls.Add(label6);
            Controls.Add(Button_Clear);
            Controls.Add(Label_Time);
            Controls.Add(Time_Filter_TextBox);
            Controls.Add(Button_Search);
            Controls.Add(label7);
            Controls.Add(DateTimePicker);
            Controls.Add(Label_Device);
            Controls.Add(Label_PCName);
            Controls.Add(Label_CL);
            Controls.Add(label5);
            Controls.Add(Button_Refresh);
            Controls.Add(Device_Filter_ComboBox);
            Controls.Add(CL_Filter_ComboBox);
            Controls.Add(PCName_Filter_ComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OngoingLabsTable);
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar);
            Controls.Add(label1);
            Controls.Add(Label_HistoryLog);
            Controls.Add(NotifCount);
            Controls.Add(PictureBox_Notification);
            Controls.Add(dataGridView1);
            Controls.Add(Panel_SideNav);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SuperAdmin_Dashboard";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin - Dashboard";
            Load += SuperAdmin_Dashboard_Load;
            Panel_SideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Notification).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_ExportCSV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OngoingLabsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel_SideNav;
        private PictureBox PicBox_SuperAdmin_CSOLLogo;
        private Button Button_Dashboard;
        private Button button3;
        private Button Button_Mapping;
        private Button button4;
        private Button Button_Scheduler;
        private Button Button_Accounts;
        private Button Button_Logout;
        private DataGridView dataGridView1;
        private PictureBox PictureBox_Notification;
        private Label NotifCount;
        private PictureBox SearchBtn;
        private TextBox Searchbar;
        private Label label1;
        private Label Label_HistoryLog;
        private PictureBox PictureBox_ExportCSV;
        private DataGridView OngoingLabsTable;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox PCName_Filter_ComboBox;
        private ComboBox CL_Filter_ComboBox;
        private ComboBox Device_Filter_ComboBox;
        private Button Button_Refresh;
        private Label label5;
        private Label Label_CL;
        private Label Label_PCName;
        private Label Label_Device;
        private DateTimePicker DateTimePicker;
        private Label label7;
        private Button Button_Search;
        private TextBox Time_Filter_TextBox;
        private Label Label_Time;
        private Button Button_Clear;
        private Label label6;
    }
}