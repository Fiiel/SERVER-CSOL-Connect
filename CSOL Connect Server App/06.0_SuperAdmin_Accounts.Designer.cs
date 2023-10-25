namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_Accounts));
            Panel_SideNav = new Panel();
            Button_Logout = new Button();
            Button_Accounts = new Button();
            Button_Scheduler = new Button();
            Button_Mapping = new Button();
            Button_Dashboard = new Button();
            PicBox_SuperAdmin_CSOLLogo = new PictureBox();
            Button_AddUsers = new Button();
            dataGridView = new DataGridView();
            Label_AccountsManagement = new Label();
            SearchBtn = new PictureBox();
            Searchbar = new TextBox();
            OngoingLabs = new Label();
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
            Panel_SideNav.TabIndex = 3;
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
            // Button_AddUsers
            // 
            Button_AddUsers.BackColor = Color.FromArgb(7, 25, 82);
            Button_AddUsers.Cursor = Cursors.Hand;
            Button_AddUsers.FlatStyle = FlatStyle.Popup;
            Button_AddUsers.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_AddUsers.ForeColor = SystemColors.Control;
            Button_AddUsers.ImageAlign = ContentAlignment.MiddleRight;
            Button_AddUsers.Location = new Point(1085, 52);
            Button_AddUsers.Name = "Button_AddUsers";
            Button_AddUsers.Size = new Size(149, 39);
            Button_AddUsers.TabIndex = 8;
            Button_AddUsers.Text = "+ Add Users";
            Button_AddUsers.UseVisualStyleBackColor = false;
            Button_AddUsers.Click += Button_AddUsers_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Hand;
            dataGridView.Location = new Point(283, 125);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ShowCellToolTips = false;
            dataGridView.Size = new Size(951, 540);
            dataGridView.TabIndex = 9;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Label_AccountsManagement
            // 
            Label_AccountsManagement.AutoSize = true;
            Label_AccountsManagement.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label_AccountsManagement.ForeColor = Color.FromArgb(7, 25, 82);
            Label_AccountsManagement.Location = new Point(283, 39);
            Label_AccountsManagement.Name = "Label_AccountsManagement";
            Label_AccountsManagement.Size = new Size(405, 50);
            Label_AccountsManagement.TabIndex = 10;
            Label_AccountsManagement.Text = "Account Management";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(192, 0, 0);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.Image = Properties.Resources.search_icon2;
            SearchBtn.Location = new Point(1026, 56);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(36, 31);
            SearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchBtn.TabIndex = 22;
            SearchBtn.TabStop = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchbar
            // 
            Searchbar.Location = new Point(789, 60);
            Searchbar.Name = "Searchbar";
            Searchbar.PlaceholderText = "Search from Accounts";
            Searchbar.Size = new Size(232, 23);
            Searchbar.TabIndex = 21;
            Searchbar.KeyPress += Searchbar_KeyPress;
            // 
            // OngoingLabs
            // 
            OngoingLabs.BackColor = Color.FromArgb(192, 0, 0);
            OngoingLabs.BorderStyle = BorderStyle.FixedSingle;
            OngoingLabs.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OngoingLabs.ForeColor = Color.White;
            OngoingLabs.Location = new Point(774, 52);
            OngoingLabs.Name = "OngoingLabs";
            OngoingLabs.Size = new Size(299, 39);
            OngoingLabs.TabIndex = 20;
            // 
            // SuperAdmin_Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar);
            Controls.Add(OngoingLabs);
            Controls.Add(Label_AccountsManagement);
            Controls.Add(dataGridView);
            Controls.Add(Button_AddUsers);
            Controls.Add(Panel_SideNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SuperAdmin_Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin - Accounts";
            Load += SuperAdmin_Accounts_Load;
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
        private Button Button_AddUsers;
        private DataGridView dataGridView;
        private Label Label_AccountsManagement;
        private PictureBox SearchBtn;
        private TextBox Searchbar;
        private Label OngoingLabs;
    }
}