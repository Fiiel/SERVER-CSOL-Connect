namespace CSOL_Connect_Server_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Login_CSOLConnectLabel = new Label();
            Login_UserIDPicBox = new PictureBox();
            Login_PasswordPicBox = new PictureBox();
            TextBox_UserID = new TextBox();
            TextBox_Password = new TextBox();
            ClearButton = new Button();
            LoginButton = new Button();
            Login_EyeRevealPicBox = new PictureBox();
            panel1 = new Panel();
            Button_ForgotPassword = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)Login_UserIDPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Login_PasswordPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Login_EyeRevealPicBox).BeginInit();
            SuspendLayout();
            // 
            // Login_CSOLConnectLabel
            // 
            Login_CSOLConnectLabel.AutoSize = true;
            Login_CSOLConnectLabel.BackColor = Color.Transparent;
            Login_CSOLConnectLabel.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            Login_CSOLConnectLabel.ForeColor = Color.FromArgb(7, 25, 82);
            Login_CSOLConnectLabel.ImageAlign = ContentAlignment.BottomRight;
            Login_CSOLConnectLabel.Location = new Point(20, 15);
            Login_CSOLConnectLabel.Name = "Login_CSOLConnectLabel";
            Login_CSOLConnectLabel.Size = new Size(379, 71);
            Login_CSOLConnectLabel.TabIndex = 1;
            Login_CSOLConnectLabel.Text = "CSOL Connect";
            // 
            // Login_UserIDPicBox
            // 
            Login_UserIDPicBox.BackColor = Color.Transparent;
            Login_UserIDPicBox.Image = Properties.Resources.userSymbol1;
            Login_UserIDPicBox.Location = new Point(25, 106);
            Login_UserIDPicBox.Name = "Login_UserIDPicBox";
            Login_UserIDPicBox.Size = new Size(45, 33);
            Login_UserIDPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Login_UserIDPicBox.TabIndex = 2;
            Login_UserIDPicBox.TabStop = false;
            // 
            // Login_PasswordPicBox
            // 
            Login_PasswordPicBox.BackColor = Color.Transparent;
            Login_PasswordPicBox.Image = Properties.Resources.pwSymbol2;
            Login_PasswordPicBox.Location = new Point(23, 159);
            Login_PasswordPicBox.Name = "Login_PasswordPicBox";
            Login_PasswordPicBox.Size = new Size(50, 38);
            Login_PasswordPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Login_PasswordPicBox.TabIndex = 3;
            Login_PasswordPicBox.TabStop = false;
            // 
            // TextBox_UserID
            // 
            TextBox_UserID.Cursor = Cursors.IBeam;
            TextBox_UserID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_UserID.Location = new Point(76, 106);
            TextBox_UserID.Name = "TextBox_UserID";
            TextBox_UserID.PlaceholderText = " USER ID";
            TextBox_UserID.Size = new Size(308, 33);
            TextBox_UserID.TabIndex = 4;
            TextBox_UserID.TextChanged += UserIDTextBox_TextChanged;
            // 
            // TextBox_Password
            // 
            TextBox_Password.Cursor = Cursors.IBeam;
            TextBox_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Password.Location = new Point(76, 162);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '●';
            TextBox_Password.PlaceholderText = " PASSWORD";
            TextBox_Password.Size = new Size(308, 33);
            TextBox_Password.TabIndex = 3;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ActiveBorder;
            ClearButton.FlatStyle = FlatStyle.System;
            ClearButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.Location = new Point(220, 217);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(62, 33);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.MouseClick += ClearButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(128, 255, 128);
            LoginButton.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            LoginButton.FlatStyle = FlatStyle.System;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(290, 217);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 33);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.MouseClick += LoginButton_Click;
            // 
            // Login_EyeRevealPicBox
            // 
            Login_EyeRevealPicBox.BackColor = Color.White;
            Login_EyeRevealPicBox.Cursor = Cursors.Hand;
            Login_EyeRevealPicBox.Image = Properties.Resources.eyeSymbol;
            Login_EyeRevealPicBox.Location = new Point(345, 164);
            Login_EyeRevealPicBox.Name = "Login_EyeRevealPicBox";
            Login_EyeRevealPicBox.Size = new Size(36, 29);
            Login_EyeRevealPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Login_EyeRevealPicBox.TabIndex = 8;
            Login_EyeRevealPicBox.TabStop = false;
            Login_EyeRevealPicBox.Click += Login_EyeRevealPicBox_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 25, 82);
            panel1.Location = new Point(-4, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 282);
            panel1.TabIndex = 9;
            // 
            // Button_ForgotPassword
            // 
            Button_ForgotPassword.BackColor = Color.Transparent;
            Button_ForgotPassword.Cursor = Cursors.Hand;
            Button_ForgotPassword.FlatAppearance.BorderSize = 0;
            Button_ForgotPassword.FlatStyle = FlatStyle.Flat;
            Button_ForgotPassword.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_ForgotPassword.ForeColor = Color.DodgerBlue;
            Button_ForgotPassword.Location = new Point(25, 222);
            Button_ForgotPassword.Name = "Button_ForgotPassword";
            Button_ForgotPassword.Size = new Size(138, 27);
            Button_ForgotPassword.TabIndex = 35;
            Button_ForgotPassword.Text = "Forgot Password";
            Button_ForgotPassword.UseVisualStyleBackColor = false;
            Button_ForgotPassword.Visible = false;
            Button_ForgotPassword.Click += Button_ForgotPassword_Click;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 10;
            Timer.Tick += Timer_Tick;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Hint";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(400, 268);
            Controls.Add(Button_ForgotPassword);
            Controls.Add(panel1);
            Controls.Add(Login_EyeRevealPicBox);
            Controls.Add(LoginButton);
            Controls.Add(ClearButton);
            Controls.Add(TextBox_Password);
            Controls.Add(TextBox_UserID);
            Controls.Add(Login_PasswordPicBox);
            Controls.Add(Login_UserIDPicBox);
            Controls.Add(Login_CSOLConnectLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Login_UserIDPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Login_PasswordPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Login_EyeRevealPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Login_CSOLConnectLabel;
        private PictureBox Login_UserIDPicBox;
        private PictureBox Login_PasswordPicBox;
        private TextBox TextBox_UserID;
        private TextBox TextBox_Password;
        private Button ClearButton;
        private Button LoginButton;
        private PictureBox Login_EyeRevealPicBox;
        private Panel panel1;
        private Button Button_ForgotPassword;
        private System.Windows.Forms.Timer Timer;
        private ToolTip toolTip1;
    }
}