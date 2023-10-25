namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_Notifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_Notifications));
            Label_PasswordResetRequest = new Label();
            DataGridView_PasswordRequest = new DataGridView();
            Button_GoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_PasswordRequest).BeginInit();
            SuspendLayout();
            // 
            // Label_PasswordResetRequest
            // 
            Label_PasswordResetRequest.AutoSize = true;
            Label_PasswordResetRequest.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Label_PasswordResetRequest.ForeColor = Color.FromArgb(7, 25, 82);
            Label_PasswordResetRequest.Location = new Point(28, 74);
            Label_PasswordResetRequest.Name = "Label_PasswordResetRequest";
            Label_PasswordResetRequest.Size = new Size(411, 39);
            Label_PasswordResetRequest.TabIndex = 48;
            Label_PasswordResetRequest.Text = "Password Reset Requests";
            // 
            // DataGridView_PasswordRequest
            // 
            DataGridView_PasswordRequest.AllowUserToAddRows = false;
            DataGridView_PasswordRequest.AllowUserToDeleteRows = false;
            DataGridView_PasswordRequest.AllowUserToResizeColumns = false;
            DataGridView_PasswordRequest.AllowUserToResizeRows = false;
            DataGridView_PasswordRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridView_PasswordRequest.BackgroundColor = SystemColors.ActiveCaption;
            DataGridView_PasswordRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_PasswordRequest.Cursor = Cursors.Hand;
            DataGridView_PasswordRequest.Location = new Point(28, 127);
            DataGridView_PasswordRequest.Name = "DataGridView_PasswordRequest";
            DataGridView_PasswordRequest.ReadOnly = true;
            DataGridView_PasswordRequest.RowHeadersVisible = false;
            DataGridView_PasswordRequest.RowTemplate.Height = 25;
            DataGridView_PasswordRequest.ShowCellToolTips = false;
            DataGridView_PasswordRequest.Size = new Size(494, 190);
            DataGridView_PasswordRequest.TabIndex = 46;
            DataGridView_PasswordRequest.CellContentClick += DataGridView_PasswordRequest_CellContentClick;
            // 
            // Button_GoBack
            // 
            Button_GoBack.BackColor = Color.FromArgb(7, 25, 82);
            Button_GoBack.Cursor = Cursors.Hand;
            Button_GoBack.FlatStyle = FlatStyle.Popup;
            Button_GoBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_GoBack.ForeColor = SystemColors.Control;
            Button_GoBack.Location = new Point(18, 16);
            Button_GoBack.Name = "Button_GoBack";
            Button_GoBack.Size = new Size(75, 23);
            Button_GoBack.TabIndex = 47;
            Button_GoBack.Text = "< Go back";
            Button_GoBack.UseVisualStyleBackColor = false;
            Button_GoBack.Click += Button_GoBack_Click;
            // 
            // SuperAdmin_Notifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(555, 378);
            ControlBox = false;
            Controls.Add(Label_PasswordResetRequest);
            Controls.Add(DataGridView_PasswordRequest);
            Controls.Add(Button_GoBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperAdmin_Notifications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin - Notifications";
            Load += SuperAdmin_Notifications_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_PasswordRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_PasswordResetRequest;
        private DataGridView DataGridView_PasswordRequest;
        private Button Button_GoBack;
    }
}