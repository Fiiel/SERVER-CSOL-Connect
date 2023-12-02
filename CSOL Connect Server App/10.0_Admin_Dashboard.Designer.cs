namespace CSOL_Connect_Server_App
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            Button_Logout = new Button();
            Button_Scheduler = new Button();
            Button_Mapping = new Button();
            Button_Dashboard = new Button();
            PicBox_SuperAdmin_CSOLLogo = new PictureBox();
            Panel_SideNav = new Panel();
            SearchBtn = new PictureBox();
            Searchbar = new TextBox();
            label1 = new Label();
            Label_HistoryLog = new Label();
            dataGridView1 = new DataGridView();
            OngoingLabsTable = new DataGridView();
            Button_Refresh = new Button();
            Button_Clear = new Button();
            Label_Time = new Label();
            Time_Filter_TextBox = new TextBox();
            Button_Search = new Button();
            label7 = new Label();
            DateTimePicker = new DateTimePicker();
            Label_Device = new Label();
            Label_PCName = new Label();
            Label_CL = new Label();
            Device_Filter_ComboBox = new ComboBox();
            CL_Filter_ComboBox = new ComboBox();
            PCName_Filter_ComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            PictureBox_ExportCSV = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).BeginInit();
            Panel_SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OngoingLabsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_ExportCSV).BeginInit();
            SuspendLayout();
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
            Button_Scheduler.Text = "    Schedule";
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
            // Panel_SideNav
            // 
            Panel_SideNav.BackColor = Color.FromArgb(7, 25, 82);
            Panel_SideNav.Controls.Add(Button_Logout);
            Panel_SideNav.Controls.Add(Button_Scheduler);
            Panel_SideNav.Controls.Add(Button_Mapping);
            Panel_SideNav.Controls.Add(Button_Dashboard);
            Panel_SideNav.Controls.Add(PicBox_SuperAdmin_CSOLLogo);
            Panel_SideNav.Dock = DockStyle.Left;
            Panel_SideNav.Location = new Point(0, 0);
            Panel_SideNav.Name = "Panel_SideNav";
            Panel_SideNav.Size = new Size(249, 681);
            Panel_SideNav.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(192, 0, 0);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.Image = Properties.Resources.search_icon;
            SearchBtn.Location = new Point(910, 33);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(36, 31);
            SearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchBtn.TabIndex = 32;
            SearchBtn.TabStop = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchbar
            // 
            Searchbar.Location = new Point(673, 37);
            Searchbar.Name = "Searchbar";
            Searchbar.PlaceholderText = "Search from History Log";
            Searchbar.Size = new Size(232, 23);
            Searchbar.TabIndex = 31;
            Searchbar.KeyPress += Searchbar_KeyPress;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(658, 29);
            label1.Name = "label1";
            label1.Size = new Size(299, 39);
            label1.TabIndex = 30;
            // 
            // Label_HistoryLog
            // 
            Label_HistoryLog.AutoSize = true;
            Label_HistoryLog.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label_HistoryLog.ForeColor = Color.FromArgb(7, 25, 82);
            Label_HistoryLog.Location = new Point(272, 18);
            Label_HistoryLog.Name = "Label_HistoryLog";
            Label_HistoryLog.Size = new Size(225, 50);
            Label_HistoryLog.TabIndex = 29;
            Label_HistoryLog.Text = "History Log";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(685, 580);
            dataGridView1.TabIndex = 28;
            // 
            // OngoingLabsTable
            // 
            OngoingLabsTable.AllowUserToResizeColumns = false;
            OngoingLabsTable.AllowUserToResizeRows = false;
            OngoingLabsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OngoingLabsTable.BackgroundColor = Color.SpringGreen;
            OngoingLabsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OngoingLabsTable.Cursor = Cursors.Hand;
            OngoingLabsTable.Location = new Point(969, 408);
            OngoingLabsTable.Name = "OngoingLabsTable";
            OngoingLabsTable.RowHeadersVisible = false;
            OngoingLabsTable.RowTemplate.Height = 25;
            OngoingLabsTable.Size = new Size(277, 128);
            OngoingLabsTable.TabIndex = 34;
            // 
            // Button_Refresh
            // 
            Button_Refresh.BackColor = Color.FromArgb(7, 25, 82);
            Button_Refresh.Cursor = Cursors.Hand;
            Button_Refresh.FlatStyle = FlatStyle.Popup;
            Button_Refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Refresh.ForeColor = SystemColors.Control;
            Button_Refresh.Location = new Point(986, 324);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.Size = new Size(75, 23);
            Button_Refresh.TabIndex = 86;
            Button_Refresh.Text = "Refresh";
            Button_Refresh.UseVisualStyleBackColor = false;
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // Button_Clear
            // 
            Button_Clear.BackColor = Color.FromArgb(7, 25, 82);
            Button_Clear.Cursor = Cursors.Hand;
            Button_Clear.FlatStyle = FlatStyle.Popup;
            Button_Clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Clear.ForeColor = SystemColors.Control;
            Button_Clear.Location = new Point(1077, 324);
            Button_Clear.Name = "Button_Clear";
            Button_Clear.Size = new Size(75, 23);
            Button_Clear.TabIndex = 85;
            Button_Clear.Text = "Clear";
            Button_Clear.UseVisualStyleBackColor = false;
            Button_Clear.Click += Button_ClearFilter_Click;
            // 
            // Label_Time
            // 
            Label_Time.AutoSize = true;
            Label_Time.BackColor = Color.FromArgb(192, 0, 0);
            Label_Time.FlatStyle = FlatStyle.Flat;
            Label_Time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Time.ForeColor = Color.Transparent;
            Label_Time.Location = new Point(1104, 242);
            Label_Time.Name = "Label_Time";
            Label_Time.Size = new Size(48, 21);
            Label_Time.TabIndex = 84;
            Label_Time.Text = "Time";
            // 
            // Time_Filter_TextBox
            // 
            Time_Filter_TextBox.Location = new Point(1109, 267);
            Time_Filter_TextBox.Name = "Time_Filter_TextBox";
            Time_Filter_TextBox.PlaceholderText = "Type here the Time";
            Time_Filter_TextBox.Size = new Size(117, 23);
            Time_Filter_TextBox.TabIndex = 83;
            // 
            // Button_Search
            // 
            Button_Search.BackColor = Color.FromArgb(7, 25, 82);
            Button_Search.Cursor = Cursors.Hand;
            Button_Search.FlatStyle = FlatStyle.Popup;
            Button_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Search.ForeColor = SystemColors.Control;
            Button_Search.Location = new Point(1162, 324);
            Button_Search.Name = "Button_Search";
            Button_Search.Size = new Size(75, 23);
            Button_Search.TabIndex = 82;
            Button_Search.Text = "Search";
            Button_Search.UseVisualStyleBackColor = false;
            Button_Search.Click += Button_SearchFilter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 0, 0);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(981, 243);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 81;
            label7.Text = "Date";
            // 
            // DateTimePicker
            // 
            DateTimePicker.CustomFormat = "MMM dd yyyy";
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.Location = new Point(986, 267);
            DateTimePicker.MinDate = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(102, 23);
            DateTimePicker.TabIndex = 80;
            DateTimePicker.Value = new DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // Label_Device
            // 
            Label_Device.AutoSize = true;
            Label_Device.BackColor = Color.FromArgb(192, 0, 0);
            Label_Device.FlatStyle = FlatStyle.Flat;
            Label_Device.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Device.ForeColor = Color.Transparent;
            Label_Device.Location = new Point(1104, 128);
            Label_Device.Name = "Label_Device";
            Label_Device.Size = new Size(62, 21);
            Label_Device.TabIndex = 79;
            Label_Device.Text = "Device";
            // 
            // Label_PCName
            // 
            Label_PCName.AutoSize = true;
            Label_PCName.BackColor = Color.FromArgb(192, 0, 0);
            Label_PCName.FlatStyle = FlatStyle.Flat;
            Label_PCName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_PCName.ForeColor = Color.Transparent;
            Label_PCName.Location = new Point(981, 128);
            Label_PCName.Name = "Label_PCName";
            Label_PCName.Size = new Size(80, 21);
            Label_PCName.TabIndex = 78;
            Label_PCName.Text = "PC Name";
            // 
            // Label_CL
            // 
            Label_CL.AutoSize = true;
            Label_CL.BackColor = Color.FromArgb(192, 0, 0);
            Label_CL.FlatStyle = FlatStyle.Flat;
            Label_CL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_CL.ForeColor = Color.Transparent;
            Label_CL.Location = new Point(981, 186);
            Label_CL.Name = "Label_CL";
            Label_CL.Size = new Size(41, 21);
            Label_CL.TabIndex = 77;
            Label_CL.Text = "CL #";
            // 
            // Device_Filter_ComboBox
            // 
            Device_Filter_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Device_Filter_ComboBox.FormattingEnabled = true;
            Device_Filter_ComboBox.Items.AddRange(new object[] { "Mouse", "Keyboard", "LAN" });
            Device_Filter_ComboBox.Location = new Point(1109, 152);
            Device_Filter_ComboBox.MaxLength = 50;
            Device_Filter_ComboBox.Name = "Device_Filter_ComboBox";
            Device_Filter_ComboBox.Size = new Size(117, 23);
            Device_Filter_ComboBox.TabIndex = 76;
            // 
            // CL_Filter_ComboBox
            // 
            CL_Filter_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CL_Filter_ComboBox.FormattingEnabled = true;
            CL_Filter_ComboBox.Items.AddRange(new object[] { "1", "2", "3" });
            CL_Filter_ComboBox.Location = new Point(986, 210);
            CL_Filter_ComboBox.MaxLength = 50;
            CL_Filter_ComboBox.Name = "CL_Filter_ComboBox";
            CL_Filter_ComboBox.Size = new Size(102, 23);
            CL_Filter_ComboBox.TabIndex = 75;
            // 
            // PCName_Filter_ComboBox
            // 
            PCName_Filter_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PCName_Filter_ComboBox.FormattingEnabled = true;
            PCName_Filter_ComboBox.Items.AddRange(new object[] { "Elem1", "Elem2", "Elem3", "Elem4", "Elem5", "Elem6", "HS1", "HS2", "HS3", "HS4", "SHS1", "SHS2" });
            PCName_Filter_ComboBox.Location = new Point(986, 152);
            PCName_Filter_ComboBox.MaxLength = 50;
            PCName_Filter_ComboBox.Name = "PCName_Filter_ComboBox";
            PCName_Filter_ComboBox.Size = new Size(102, 23);
            PCName_Filter_ComboBox.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(7, 25, 82);
            label4.Location = new Point(963, 78);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 73;
            label4.Text = "Filter";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 0, 0);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(969, 110);
            label3.Name = "label3";
            label3.Size = new Size(277, 250);
            label3.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(7, 25, 82);
            label2.Location = new Point(969, 375);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 87;
            label2.Text = "Ongoing Labs";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(7, 25, 82);
            label5.Location = new Point(967, 564);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 88;
            label5.Text = "Export to CSV";
            // 
            // PictureBox_ExportCSV
            // 
            PictureBox_ExportCSV.BackColor = Color.FromArgb(192, 255, 192);
            PictureBox_ExportCSV.Cursor = Cursors.Hand;
            PictureBox_ExportCSV.Image = Properties.Resources.icon_csv;
            PictureBox_ExportCSV.Location = new Point(977, 600);
            PictureBox_ExportCSV.Name = "PictureBox_ExportCSV";
            PictureBox_ExportCSV.Size = new Size(56, 58);
            PictureBox_ExportCSV.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_ExportCSV.TabIndex = 89;
            PictureBox_ExportCSV.TabStop = false;
            PictureBox_ExportCSV.Click += PictureBox_ExportCSV_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(971, 596);
            label6.Name = "label6";
            label6.Size = new Size(68, 68);
            label6.TabIndex = 90;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1264, 681);
            Controls.Add(PictureBox_ExportCSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(Button_Refresh);
            Controls.Add(Button_Clear);
            Controls.Add(Label_Time);
            Controls.Add(Time_Filter_TextBox);
            Controls.Add(Button_Search);
            Controls.Add(label7);
            Controls.Add(DateTimePicker);
            Controls.Add(Label_Device);
            Controls.Add(Label_PCName);
            Controls.Add(Label_CL);
            Controls.Add(Device_Filter_ComboBox);
            Controls.Add(CL_Filter_ComboBox);
            Controls.Add(PCName_Filter_ComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(OngoingLabsTable);
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar);
            Controls.Add(label1);
            Controls.Add(Label_HistoryLog);
            Controls.Add(dataGridView1);
            Controls.Add(Panel_SideNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Dashboard";
            FormClosing += Admin_Dashboard_FormClosing;
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).EndInit();
            Panel_SideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OngoingLabsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_ExportCSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Logout;
        private Button Button_Scheduler;
        private Button Button_Mapping;
        private Button Button_Dashboard;
        private PictureBox PicBox_SuperAdmin_CSOLLogo;
        private Panel Panel_SideNav;
        private PictureBox SearchBtn;
        private TextBox Searchbar;
        private Label label1;
        private Label Label_HistoryLog;
        private DataGridView dataGridView1;
        private DataGridView OngoingLabsTable;
        private Button Button_Refresh;
        private Button Button_Clear;
        private Label Label_Time;
        private TextBox Time_Filter_TextBox;
        private Button Button_Search;
        private Label label7;
        private DateTimePicker DateTimePicker;
        private Label Label_Device;
        private Label Label_PCName;
        private Label Label_CL;
        private ComboBox Device_Filter_ComboBox;
        private ComboBox CL_Filter_ComboBox;
        private ComboBox PCName_Filter_ComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private PictureBox PictureBox_ExportCSV;
        private Label label6;
    }
}