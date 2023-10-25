namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_AddUsers));
            pwReq5 = new Label();
            PWtooltip = new ToolTip(components);
            userlevelComboBox = new ComboBox();
            ConfirmPass = new TextBox();
            Password = new TextBox();
            email = new TextBox();
            ln = new TextBox();
            fn = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pwReq4 = new Label();
            pwReq3 = new Label();
            label8 = new Label();
            pwReq2 = new Label();
            Submit = new Button();
            ClearButton = new Button();
            pwReq1 = new Label();
            nameTimer = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BackButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pwReq5
            // 
            pwReq5.AutoSize = true;
            pwReq5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq5.ForeColor = SystemColors.ControlDarkDark;
            pwReq5.Location = new Point(40, 425);
            pwReq5.Name = "pwReq5";
            pwReq5.Size = new Size(361, 20);
            pwReq5.TabIndex = 45;
            pwReq5.Text = "Has high entropy value (character variation/length)";
            // 
            // PWtooltip
            // 
            PWtooltip.IsBalloon = true;
            PWtooltip.Tag = "";
            PWtooltip.ToolTipIcon = ToolTipIcon.Info;
            PWtooltip.ToolTipTitle = "Hint";
            PWtooltip.Popup += PWtooltip_Popup;
            // 
            // userlevelComboBox
            // 
            userlevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userlevelComboBox.FormattingEnabled = true;
            userlevelComboBox.Items.AddRange(new object[] { "Admin", "Super Admin" });
            userlevelComboBox.Location = new Point(40, 564);
            userlevelComboBox.Name = "userlevelComboBox";
            userlevelComboBox.Size = new Size(246, 23);
            userlevelComboBox.TabIndex = 37;
            PWtooltip.SetToolTip(userlevelComboBox, "Define the User Level of this User.");
            // 
            // ConfirmPass
            // 
            ConfirmPass.Cursor = Cursors.IBeam;
            ConfirmPass.Location = new Point(40, 492);
            ConfirmPass.MaxLength = 100;
            ConfirmPass.Name = "ConfirmPass";
            ConfirmPass.PasswordChar = '●';
            ConfirmPass.Size = new Size(576, 23);
            ConfirmPass.TabIndex = 34;
            PWtooltip.SetToolTip(ConfirmPass, "Please repeat your password in this field.");
            ConfirmPass.TextChanged += ConfirmPass_TextChanged;
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Location = new Point(41, 301);
            Password.MaxLength = 100;
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.Size = new Size(576, 23);
            Password.TabIndex = 32;
            PWtooltip.SetToolTip(Password, "Password must satisfy the requirements to make sure that the password is strong.");
            Password.TextChanged += Password_TextChanged;
            // 
            // email
            // 
            email.Cursor = Cursors.IBeam;
            email.Location = new Point(40, 226);
            email.MaxLength = 100;
            email.Name = "email";
            email.Size = new Size(576, 23);
            email.TabIndex = 30;
            PWtooltip.SetToolTip(email, "Please input the email address of the new user.");
            email.TextChanged += email_TextChanged;
            // 
            // ln
            // 
            ln.Cursor = Cursors.IBeam;
            ln.Location = new Point(335, 151);
            ln.MaxLength = 50;
            ln.Name = "ln";
            ln.Size = new Size(281, 23);
            ln.TabIndex = 28;
            PWtooltip.SetToolTip(ln, "Please input letters only in this field.");
            // 
            // fn
            // 
            fn.Cursor = Cursors.IBeam;
            fn.Location = new Point(40, 151);
            fn.MaxLength = 200;
            fn.Name = "fn";
            fn.Size = new Size(281, 23);
            fn.TabIndex = 26;
            PWtooltip.SetToolTip(fn, "Please input letters only in this field.");
            fn.TextChanged += fn_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pwReq4
            // 
            pwReq4.AutoSize = true;
            pwReq4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq4.ForeColor = SystemColors.ControlDarkDark;
            pwReq4.Location = new Point(40, 403);
            pwReq4.Name = "pwReq4";
            pwReq4.Size = new Size(322, 20);
            pwReq4.TabIndex = 44;
            pwReq4.Text = "Has symbol/s (!@#$%^&*\\-_=+{}[\\]|\\\\:;\"\",.<>/?)";
            pwReq4.Click += pwReq4_Click;
            // 
            // pwReq3
            // 
            pwReq3.AutoSize = true;
            pwReq3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq3.ForeColor = SystemColors.ControlDarkDark;
            pwReq3.Location = new Point(40, 381);
            pwReq3.Name = "pwReq3";
            pwReq3.Size = new Size(210, 20);
            pwReq3.TabIndex = 43;
            pwReq3.Text = "Has numeric character/s (0-9)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(40, 405);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 42;
            // 
            // pwReq2
            // 
            pwReq2.AutoSize = true;
            pwReq2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq2.ForeColor = SystemColors.ControlDarkDark;
            pwReq2.Location = new Point(40, 359);
            pwReq2.Name = "pwReq2";
            pwReq2.Size = new Size(329, 20);
            pwReq2.TabIndex = 41;
            pwReq2.Text = "Has uppercase and lowercase letter/s (a-z, A-Z)";
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(7, 25, 82);
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Submit.ForeColor = Color.Snow;
            Submit.Location = new Point(505, 564);
            Submit.Name = "Submit";
            Submit.Size = new Size(111, 45);
            Submit.TabIndex = 40;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.IndianRed;
            ClearButton.FlatStyle = FlatStyle.Popup;
            ClearButton.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.Snow;
            ClearButton.Location = new Point(370, 564);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(111, 45);
            ClearButton.TabIndex = 39;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // pwReq1
            // 
            pwReq1.AutoSize = true;
            pwReq1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwReq1.ForeColor = SystemColors.ControlDarkDark;
            pwReq1.Location = new Point(40, 338);
            pwReq1.Name = "pwReq1";
            pwReq1.Size = new Size(178, 20);
            pwReq1.TabIndex = 38;
            pwReq1.Text = "Has at least 12 characters";
            pwReq1.Click += pwReq1_Click;
            // 
            // nameTimer
            // 
            nameTimer.Enabled = true;
            nameTimer.Interval = 1000;
            nameTimer.Tick += nameTimer_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 536);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 36;
            label6.Text = "User Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(40, 464);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 35;
            label7.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 273);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 33;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 198);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 31;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, 123);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 29;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 123);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 27;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 66);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 25;
            label1.Text = "Account Registration";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(7, 25, 82);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.Control;
            BackButton.Location = new Point(22, 21);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 24;
            BackButton.Text = "< Go back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.eyeSymbol2;
            pictureBox1.Location = new Point(580, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.eyeSymbol1;
            pictureBox4.Location = new Point(580, 494);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // SuperAdmin_AddUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(638, 630);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pwReq5);
            Controls.Add(pwReq4);
            Controls.Add(pwReq3);
            Controls.Add(label8);
            Controls.Add(pwReq2);
            Controls.Add(Submit);
            Controls.Add(ClearButton);
            Controls.Add(pwReq1);
            Controls.Add(userlevelComboBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(ConfirmPass);
            Controls.Add(label5);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(email);
            Controls.Add(label3);
            Controls.Add(ln);
            Controls.Add(label2);
            Controls.Add(fn);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SuperAdmin_AddUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperAdmin - Add Users";
            Load += addUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pwReq5;
        private ToolTip PWtooltip;
        private ComboBox userlevelComboBox;
        private TextBox ConfirmPass;
        private TextBox Password;
        private TextBox email;
        private TextBox ln;
        private TextBox fn;
        private System.Windows.Forms.Timer timer1;
        private Label pwReq4;
        private Label pwReq3;
        private Label label8;
        private Label pwReq2;
        private Button Submit;
        private Button ClearButton;
        private Label pwReq1;
        private System.Windows.Forms.Timer nameTimer;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BackButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}