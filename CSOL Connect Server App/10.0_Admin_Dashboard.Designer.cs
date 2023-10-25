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
            OngoingLabsLabel = new Label();
            PrevSched = new PictureBox();
            NextSched = new PictureBox();
            OngoingLabsTrackbar = new TrackBar();
            OngoingLabs = new Label();
            SearchBtn = new PictureBox();
            Searchbar = new TextBox();
            label1 = new Label();
            Label_HistoryLog = new Label();
            dataGridView1 = new DataGridView();
            PictureBox_ExportCSV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).BeginInit();
            Panel_SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevSched).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextSched).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OngoingLabsTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // OngoingLabsLabel
            // 
            OngoingLabsLabel.BackColor = Color.White;
            OngoingLabsLabel.BorderStyle = BorderStyle.Fixed3D;
            OngoingLabsLabel.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OngoingLabsLabel.Location = new Point(1016, 149);
            OngoingLabsLabel.Name = "OngoingLabsLabel";
            OngoingLabsLabel.Size = new Size(191, 29);
            OngoingLabsLabel.TabIndex = 24;
            OngoingLabsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PrevSched
            // 
            PrevSched.BackColor = Color.SpringGreen;
            PrevSched.Cursor = Cursors.Hand;
            PrevSched.Image = Properties.Resources.previous_icon;
            PrevSched.Location = new Point(979, 149);
            PrevSched.Name = "PrevSched";
            PrevSched.Size = new Size(31, 29);
            PrevSched.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevSched.TabIndex = 23;
            PrevSched.TabStop = false;
            PrevSched.Click += PrevSched_Click;
            // 
            // NextSched
            // 
            NextSched.BackColor = Color.SpringGreen;
            NextSched.Cursor = Cursors.Hand;
            NextSched.Image = Properties.Resources.next_icon;
            NextSched.Location = new Point(1213, 149);
            NextSched.Name = "NextSched";
            NextSched.Size = new Size(31, 29);
            NextSched.SizeMode = PictureBoxSizeMode.StretchImage;
            NextSched.TabIndex = 22;
            NextSched.TabStop = false;
            NextSched.Click += NextSched_Click;
            // 
            // OngoingLabsTrackbar
            // 
            OngoingLabsTrackbar.Location = new Point(1012, 181);
            OngoingLabsTrackbar.Name = "OngoingLabsTrackbar";
            OngoingLabsTrackbar.Size = new Size(200, 45);
            OngoingLabsTrackbar.TabIndex = 21;
            OngoingLabsTrackbar.Visible = false;
            OngoingLabsTrackbar.ValueChanged += OngoingLabsTrackbar_ValueChanged;
            // 
            // OngoingLabs
            // 
            OngoingLabs.BackColor = Color.SpringGreen;
            OngoingLabs.BorderStyle = BorderStyle.FixedSingle;
            OngoingLabs.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OngoingLabs.ForeColor = Color.White;
            OngoingLabs.Location = new Point(973, 110);
            OngoingLabs.Name = "OngoingLabs";
            OngoingLabs.Size = new Size(277, 95);
            OngoingLabs.TabIndex = 25;
            OngoingLabs.Text = "Ongoing Labs";
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
            // PictureBox_ExportCSV
            // 
            PictureBox_ExportCSV.BackColor = Color.Transparent;
            PictureBox_ExportCSV.Cursor = Cursors.Hand;
            PictureBox_ExportCSV.Image = Properties.Resources.icon_csv;
            PictureBox_ExportCSV.Location = new Point(979, 573);
            PictureBox_ExportCSV.Name = "PictureBox_ExportCSV";
            PictureBox_ExportCSV.Size = new Size(92, 92);
            PictureBox_ExportCSV.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_ExportCSV.TabIndex = 33;
            PictureBox_ExportCSV.TabStop = false;
            PictureBox_ExportCSV.Click += PictureBox_ExportCSV_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(PictureBox_ExportCSV);
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar);
            Controls.Add(label1);
            Controls.Add(Label_HistoryLog);
            Controls.Add(dataGridView1);
            Controls.Add(OngoingLabsLabel);
            Controls.Add(PrevSched);
            Controls.Add(NextSched);
            Controls.Add(OngoingLabsTrackbar);
            Controls.Add(OngoingLabs);
            Controls.Add(Panel_SideNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Dashboard";
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).EndInit();
            Panel_SideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PrevSched).EndInit();
            ((System.ComponentModel.ISupportInitialize)NextSched).EndInit();
            ((System.ComponentModel.ISupportInitialize)OngoingLabsTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label OngoingLabsLabel;
        private PictureBox PrevSched;
        private PictureBox NextSched;
        private TrackBar OngoingLabsTrackbar;
        private Label OngoingLabs;
        private PictureBox SearchBtn;
        private TextBox Searchbar;
        private Label label1;
        private Label Label_HistoryLog;
        private DataGridView dataGridView1;
        private PictureBox PictureBox_ExportCSV;
    }
}