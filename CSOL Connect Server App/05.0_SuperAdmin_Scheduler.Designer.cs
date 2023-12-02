namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_Scheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_Scheduler));
            Panel_SideNav = new Panel();
            Button_Logout = new Button();
            Button_Accounts = new Button();
            Button_Scheduler = new Button();
            Button_Mapping = new Button();
            Button_Dashboard = new Button();
            PicBox_SuperAdmin_CSOLLogo = new PictureBox();
            dataGridView = new DataGridView();
            Button_NewSchedule = new Button();
            Label_ComputerLabSchedule = new Label();
            SearchBtn = new PictureBox();
            Searchbar = new TextBox();
            OngoingLabs = new Label();
            instructorbtn = new Button();
            GraSec_button = new Button();
            Panel_SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).BeginInit();
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
            Panel_SideNav.TabIndex = 2;
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
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Hand;
            dataGridView.Location = new Point(283, 125);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ShowCellToolTips = false;
            dataGridView.Size = new Size(951, 475);
            dataGridView.TabIndex = 12;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Button_NewSchedule
            // 
            Button_NewSchedule.BackColor = Color.FromArgb(7, 25, 82);
            Button_NewSchedule.Cursor = Cursors.Hand;
            Button_NewSchedule.FlatStyle = FlatStyle.Popup;
            Button_NewSchedule.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_NewSchedule.ForeColor = SystemColors.Control;
            Button_NewSchedule.ImageAlign = ContentAlignment.MiddleRight;
            Button_NewSchedule.Location = new Point(1085, 52);
            Button_NewSchedule.Name = "Button_NewSchedule";
            Button_NewSchedule.Size = new Size(149, 39);
            Button_NewSchedule.TabIndex = 11;
            Button_NewSchedule.Text = "+ New";
            Button_NewSchedule.UseVisualStyleBackColor = false;
            Button_NewSchedule.Click += Button_NewSchedule_Click;
            // 
            // Label_ComputerLabSchedule
            // 
            Label_ComputerLabSchedule.AutoSize = true;
            Label_ComputerLabSchedule.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label_ComputerLabSchedule.ForeColor = Color.FromArgb(7, 25, 82);
            Label_ComputerLabSchedule.Location = new Point(283, 42);
            Label_ComputerLabSchedule.Name = "Label_ComputerLabSchedule";
            Label_ComputerLabSchedule.Size = new Size(435, 50);
            Label_ComputerLabSchedule.TabIndex = 10;
            Label_ComputerLabSchedule.Text = "Computer Lab Schedule";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(192, 0, 0);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.Image = Properties.Resources.search_icon;
            SearchBtn.Location = new Point(1024, 57);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(36, 31);
            SearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchBtn.TabIndex = 19;
            SearchBtn.TabStop = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchbar
            // 
            Searchbar.Location = new Point(787, 60);
            Searchbar.Name = "Searchbar";
            Searchbar.PlaceholderText = "Search from Schedules";
            Searchbar.Size = new Size(232, 23);
            Searchbar.TabIndex = 18;
            Searchbar.KeyPress += Searchbar_KeyPress;
            // 
            // OngoingLabs
            // 
            OngoingLabs.BackColor = Color.FromArgb(192, 0, 0);
            OngoingLabs.BorderStyle = BorderStyle.FixedSingle;
            OngoingLabs.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OngoingLabs.ForeColor = Color.White;
            OngoingLabs.Location = new Point(772, 52);
            OngoingLabs.Name = "OngoingLabs";
            OngoingLabs.Size = new Size(299, 39);
            OngoingLabs.TabIndex = 17;
            // 
            // instructorbtn
            // 
            instructorbtn.BackColor = Color.LimeGreen;
            instructorbtn.Cursor = Cursors.Hand;
            instructorbtn.FlatStyle = FlatStyle.Popup;
            instructorbtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            instructorbtn.ForeColor = SystemColors.Control;
            instructorbtn.ImageAlign = ContentAlignment.MiddleRight;
            instructorbtn.Location = new Point(283, 626);
            instructorbtn.Name = "instructorbtn";
            instructorbtn.Size = new Size(134, 39);
            instructorbtn.TabIndex = 20;
            instructorbtn.Text = "Instructors";
            instructorbtn.UseVisualStyleBackColor = false;
            instructorbtn.Click += instructorbtn_Click;
            // 
            // GraSec_button
            // 
            GraSec_button.BackColor = Color.LimeGreen;
            GraSec_button.Cursor = Cursors.Hand;
            GraSec_button.FlatStyle = FlatStyle.Popup;
            GraSec_button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            GraSec_button.ForeColor = SystemColors.Control;
            GraSec_button.ImageAlign = ContentAlignment.MiddleRight;
            GraSec_button.Location = new Point(448, 626);
            GraSec_button.Name = "GraSec_button";
            GraSec_button.Size = new Size(104, 39);
            GraSec_button.TabIndex = 21;
            GraSec_button.Text = "Classes";
            GraSec_button.UseVisualStyleBackColor = false;
            GraSec_button.Click += GraSec_button_Click;
            // 
            // SuperAdmin_Scheduler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1264, 681);
            Controls.Add(GraSec_button);
            Controls.Add(instructorbtn);
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar);
            Controls.Add(OngoingLabs);
            Controls.Add(dataGridView);
            Controls.Add(Button_NewSchedule);
            Controls.Add(Label_ComputerLabSchedule);
            Controls.Add(Panel_SideNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SuperAdmin_Scheduler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin - Scheduler";
            FormClosing += SuperAdmin_Scheduler_FormClosing;
            Load += SuperAdmin_Scheduler_Load;
            Panel_SideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBox_SuperAdmin_CSOLLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel_SideNav;
        private Button Button_Logout;
        private Button Button_Accounts;
        private Button Button_Scheduler;
        private Button Button_Mapping;
        private Button Button_Dashboard;
        private PictureBox PicBox_SuperAdmin_CSOLLogo;
        private DataGridView dataGridView;
        private Button Button_NewSchedule;
        private Label Label_ComputerLabSchedule;
        private PictureBox SearchBtn;
        private TextBox Searchbar;
        private Label OngoingLabs;
        private Button instructorbtn;
        private Button GraSec_button;
    }
}