namespace CSOL_Connect_Server_App
{
    partial class ChangePW_Required
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePW_Required));
            Login_CSOLConnectLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pwReq5 = new Label();
            pwReq4 = new Label();
            pwReq3 = new Label();
            label8 = new Label();
            pwReq2 = new Label();
            pwReq1 = new Label();
            label7 = new Label();
            ConfirmPass = new TextBox();
            label5 = new Label();
            Password = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Submit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Login_CSOLConnectLabel
            // 
            Login_CSOLConnectLabel.AutoSize = true;
            Login_CSOLConnectLabel.BackColor = Color.Transparent;
            Login_CSOLConnectLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Login_CSOLConnectLabel.ForeColor = Color.FromArgb(7, 25, 82);
            Login_CSOLConnectLabel.ImageAlign = ContentAlignment.BottomRight;
            Login_CSOLConnectLabel.Location = new Point(176, 9);
            Login_CSOLConnectLabel.Name = "Login_CSOLConnectLabel";
            Login_CSOLConnectLabel.Size = new Size(284, 45);
            Login_CSOLConnectLabel.TabIndex = 2;
            Login_CSOLConnectLabel.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.eyeSymbol2;
            pictureBox1.Location = new Point(564, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.eyeSymbol1;
            pictureBox4.Location = new Point(564, 285);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 58;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pwReq5
            // 
            pwReq5.AutoSize = true;
            pwReq5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq5.ForeColor = SystemColors.ControlDarkDark;
            pwReq5.Location = new Point(24, 216);
            pwReq5.Name = "pwReq5";
            pwReq5.Size = new Size(361, 20);
            pwReq5.TabIndex = 57;
            pwReq5.Text = "Has high entropy value (character variation/length)";
            // 
            // pwReq4
            // 
            pwReq4.AutoSize = true;
            pwReq4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq4.ForeColor = SystemColors.ControlDarkDark;
            pwReq4.Location = new Point(24, 194);
            pwReq4.Name = "pwReq4";
            pwReq4.Size = new Size(322, 20);
            pwReq4.TabIndex = 56;
            pwReq4.Text = "Has symbol/s (!@#$%^&*\\-_=+{}[\\]|\\\\:;\"\",.<>/?)";
            // 
            // pwReq3
            // 
            pwReq3.AutoSize = true;
            pwReq3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq3.ForeColor = SystemColors.ControlDarkDark;
            pwReq3.Location = new Point(24, 172);
            pwReq3.Name = "pwReq3";
            pwReq3.Size = new Size(210, 20);
            pwReq3.TabIndex = 55;
            pwReq3.Text = "Has numeric character/s (0-9)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(-57, 236);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 54;
            // 
            // pwReq2
            // 
            pwReq2.AutoSize = true;
            pwReq2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq2.ForeColor = SystemColors.ControlDarkDark;
            pwReq2.Location = new Point(24, 150);
            pwReq2.Name = "pwReq2";
            pwReq2.Size = new Size(329, 20);
            pwReq2.TabIndex = 53;
            pwReq2.Text = "Has uppercase and lowercase letter/s (a-z, A-Z)";
            // 
            // pwReq1
            // 
            pwReq1.AutoSize = true;
            pwReq1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq1.ForeColor = SystemColors.ControlDarkDark;
            pwReq1.Location = new Point(24, 129);
            pwReq1.Name = "pwReq1";
            pwReq1.Size = new Size(178, 20);
            pwReq1.TabIndex = 52;
            pwReq1.Text = "Has at least 12 characters";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 255);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 51;
            label7.Text = "Confirm Password";
            // 
            // ConfirmPass
            // 
            ConfirmPass.Cursor = Cursors.IBeam;
            ConfirmPass.Location = new Point(24, 283);
            ConfirmPass.MaxLength = 100;
            ConfirmPass.Name = "ConfirmPass";
            ConfirmPass.PasswordChar = '●';
            ConfirmPass.Size = new Size(576, 23);
            ConfirmPass.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 64);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 49;
            label5.Text = "Password";
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Location = new Point(25, 92);
            Password.MaxLength = 100;
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.Size = new Size(576, 23);
            Password.TabIndex = 48;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(7, 25, 82);
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Submit.ForeColor = Color.Snow;
            Submit.Location = new Point(490, 335);
            Submit.Name = "Submit";
            Submit.Size = new Size(111, 45);
            Submit.TabIndex = 60;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // ChangePW_Required
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(628, 397);
            Controls.Add(Submit);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pwReq5);
            Controls.Add(pwReq4);
            Controls.Add(pwReq3);
            Controls.Add(label8);
            Controls.Add(pwReq2);
            Controls.Add(pwReq1);
            Controls.Add(label7);
            Controls.Add(ConfirmPass);
            Controls.Add(label5);
            Controls.Add(Password);
            Controls.Add(Login_CSOLConnectLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePW_Required";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            FormClosing += ChangePW_Required_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login_CSOLConnectLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label pwReq5;
        private Label pwReq4;
        private Label pwReq3;
        private Label label8;
        private Label pwReq2;
        private Label pwReq1;
        private Label label7;
        private TextBox ConfirmPass;
        private Label label5;
        private TextBox Password;
        private System.Windows.Forms.Timer timer1;
        private Button Submit;
    }
}