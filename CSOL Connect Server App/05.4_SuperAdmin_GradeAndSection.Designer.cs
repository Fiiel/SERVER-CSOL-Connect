namespace CSOL_Connect_Server_App
{
    partial class GradeAndSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeAndSection));
            Delete_GraSec = new Button();
            label1 = new Label();
            Login_CSOLConnectLabel = new Label();
            Add_GraSec = new Button();
            Classes_Combobox = new ComboBox();
            GraSec_Name = new TextBox();
            SuspendLayout();
            // 
            // Delete_GraSec
            // 
            Delete_GraSec.BackColor = Color.Firebrick;
            Delete_GraSec.Cursor = Cursors.Hand;
            Delete_GraSec.FlatStyle = FlatStyle.Popup;
            Delete_GraSec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Delete_GraSec.ForeColor = Color.White;
            Delete_GraSec.Location = new Point(468, 92);
            Delete_GraSec.Name = "Delete_GraSec";
            Delete_GraSec.Size = new Size(75, 23);
            Delete_GraSec.TabIndex = 12;
            Delete_GraSec.Text = "DELETE";
            Delete_GraSec.UseVisualStyleBackColor = false;
            Delete_GraSec.Click += Delete_GraSec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(7, 25, 82);
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(130, 85);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 11;
            label1.Text = "Classes:";
            // 
            // Login_CSOLConnectLabel
            // 
            Login_CSOLConnectLabel.AutoSize = true;
            Login_CSOLConnectLabel.BackColor = Color.Transparent;
            Login_CSOLConnectLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Login_CSOLConnectLabel.ForeColor = Color.FromArgb(7, 25, 82);
            Login_CSOLConnectLabel.ImageAlign = ContentAlignment.BottomRight;
            Login_CSOLConnectLabel.Location = new Point(21, 27);
            Login_CSOLConnectLabel.Name = "Login_CSOLConnectLabel";
            Login_CSOLConnectLabel.Size = new Size(199, 30);
            Login_CSOLConnectLabel.TabIndex = 10;
            Login_CSOLConnectLabel.Text = "Grade and Section:";
            // 
            // Add_GraSec
            // 
            Add_GraSec.BackColor = Color.FromArgb(7, 25, 82);
            Add_GraSec.Cursor = Cursors.Hand;
            Add_GraSec.FlatStyle = FlatStyle.Popup;
            Add_GraSec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Add_GraSec.ForeColor = Color.White;
            Add_GraSec.Location = new Point(468, 34);
            Add_GraSec.Name = "Add_GraSec";
            Add_GraSec.Size = new Size(75, 23);
            Add_GraSec.TabIndex = 9;
            Add_GraSec.Text = "ADD";
            Add_GraSec.UseVisualStyleBackColor = false;
            Add_GraSec.Click += Add_GraSec_Click;
            // 
            // Classes_Combobox
            // 
            Classes_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Classes_Combobox.FormattingEnabled = true;
            Classes_Combobox.Location = new Point(223, 92);
            Classes_Combobox.Name = "Classes_Combobox";
            Classes_Combobox.Size = new Size(228, 23);
            Classes_Combobox.TabIndex = 8;
            // 
            // GraSec_Name
            // 
            GraSec_Name.Location = new Point(223, 34);
            GraSec_Name.MaxLength = 50;
            GraSec_Name.Name = "GraSec_Name";
            GraSec_Name.PlaceholderText = "Input a grade and section to add.";
            GraSec_Name.Size = new Size(228, 23);
            GraSec_Name.TabIndex = 7;
            // 
            // GradeAndSection
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(568, 144);
            Controls.Add(Delete_GraSec);
            Controls.Add(label1);
            Controls.Add(Login_CSOLConnectLabel);
            Controls.Add(Add_GraSec);
            Controls.Add(Classes_Combobox);
            Controls.Add(GraSec_Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GradeAndSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade and Section";
            FormClosing += GradeAndSection_FormClosing;
            Load += GradeAndSection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete_GraSec;
        private Label label1;
        private Label Login_CSOLConnectLabel;
        private Button Add_GraSec;
        private ComboBox Classes_Combobox;
        private TextBox GraSec_Name;
    }
}