namespace CSOL_Connect_Server_App
{
    partial class Instructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructors));
            Instructor_Name = new TextBox();
            Instructor_Combobox = new ComboBox();
            Add_Instructor = new Button();
            Login_CSOLConnectLabel = new Label();
            label1 = new Label();
            Delete_Instructor = new Button();
            SuspendLayout();
            // 
            // Instructor_Name
            // 
            Instructor_Name.Location = new Point(146, 32);
            Instructor_Name.MaxLength = 50;
            Instructor_Name.Name = "Instructor_Name";
            Instructor_Name.PlaceholderText = "Input the Instructor's name to add.";
            Instructor_Name.Size = new Size(228, 23);
            Instructor_Name.TabIndex = 0;
            // 
            // Instructor_Combobox
            // 
            Instructor_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Instructor_Combobox.FormattingEnabled = true;
            Instructor_Combobox.Location = new Point(146, 90);
            Instructor_Combobox.Name = "Instructor_Combobox";
            Instructor_Combobox.Size = new Size(228, 23);
            Instructor_Combobox.TabIndex = 1;
            Instructor_Combobox.SelectedIndexChanged += Instructor_Combobox_SelectedIndexChanged;
            // 
            // Add_Instructor
            // 
            Add_Instructor.BackColor = Color.FromArgb(7, 25, 82);
            Add_Instructor.Cursor = Cursors.Hand;
            Add_Instructor.FlatStyle = FlatStyle.Popup;
            Add_Instructor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Add_Instructor.ForeColor = Color.White;
            Add_Instructor.Location = new Point(391, 32);
            Add_Instructor.Name = "Add_Instructor";
            Add_Instructor.Size = new Size(75, 23);
            Add_Instructor.TabIndex = 2;
            Add_Instructor.Text = "ADD";
            Add_Instructor.UseVisualStyleBackColor = false;
            Add_Instructor.Click += Add_Instructor_Click;
            // 
            // Login_CSOLConnectLabel
            // 
            Login_CSOLConnectLabel.AutoSize = true;
            Login_CSOLConnectLabel.BackColor = Color.Transparent;
            Login_CSOLConnectLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Login_CSOLConnectLabel.ForeColor = Color.FromArgb(7, 25, 82);
            Login_CSOLConnectLabel.ImageAlign = ContentAlignment.BottomRight;
            Login_CSOLConnectLabel.Location = new Point(67, 26);
            Login_CSOLConnectLabel.Name = "Login_CSOLConnectLabel";
            Login_CSOLConnectLabel.Size = new Size(77, 30);
            Login_CSOLConnectLabel.TabIndex = 4;
            Login_CSOLConnectLabel.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(7, 25, 82);
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(19, 83);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 5;
            label1.Text = "Instructors:";
            // 
            // Delete_Instructor
            // 
            Delete_Instructor.BackColor = Color.Firebrick;
            Delete_Instructor.Cursor = Cursors.Hand;
            Delete_Instructor.FlatStyle = FlatStyle.Popup;
            Delete_Instructor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Delete_Instructor.ForeColor = Color.White;
            Delete_Instructor.Location = new Point(391, 90);
            Delete_Instructor.Name = "Delete_Instructor";
            Delete_Instructor.Size = new Size(75, 23);
            Delete_Instructor.TabIndex = 6;
            Delete_Instructor.Text = "DELETE";
            Delete_Instructor.UseVisualStyleBackColor = false;
            Delete_Instructor.Click += Delete_Instructor_Click;
            // 
            // Instructors
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(489, 144);
            Controls.Add(Delete_Instructor);
            Controls.Add(label1);
            Controls.Add(Login_CSOLConnectLabel);
            Controls.Add(Add_Instructor);
            Controls.Add(Instructor_Combobox);
            Controls.Add(Instructor_Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Instructors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructors";
            Load += Instructors_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Instructor_Name;
        private ComboBox Instructor_Combobox;
        private Button Add_Instructor;
        private Label Login_CSOLConnectLabel;
        private Label label1;
        private Button Delete_Instructor;
    }
}