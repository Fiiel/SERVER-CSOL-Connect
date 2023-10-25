namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_EditSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_EditSchedule));
            SubmitButton = new Button();
            label8 = new Label();
            label7 = new Label();
            instructortxt = new TextBox();
            label6 = new Label();
            gnstxtbox = new TextBox();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dayComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            clncbox = new ComboBox();
            Button_GoBack = new Button();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(7, 25, 82);
            SubmitButton.FlatStyle = FlatStyle.Popup;
            SubmitButton.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.ForeColor = Color.Snow;
            SubmitButton.Location = new Point(495, 418);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(111, 45);
            SubmitButton.TabIndex = 49;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(31, 332);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 48;
            label8.Text = "CL #";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 258);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 46;
            label7.Text = "Instructor";
            // 
            // instructortxt
            // 
            instructortxt.Cursor = Cursors.IBeam;
            instructortxt.Location = new Point(32, 286);
            instructortxt.MaxLength = 200;
            instructortxt.Name = "instructortxt";
            instructortxt.Size = new Size(576, 23);
            instructortxt.TabIndex = 45;
            toolTip1.SetToolTip(instructortxt, "Input who's the one in charge of the class.");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 183);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 44;
            label6.Text = "Grade and Section";
            // 
            // gnstxtbox
            // 
            gnstxtbox.Cursor = Cursors.IBeam;
            gnstxtbox.Location = new Point(31, 211);
            gnstxtbox.MaxLength = 100;
            gnstxtbox.Name = "gnstxtbox";
            gnstxtbox.Size = new Size(576, 23);
            gnstxtbox.TabIndex = 43;
            toolTip1.SetToolTip(gnstxtbox, "Input here the grade and section of the class who will use the lab.");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(473, 132);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 42;
            label5.Text = "End:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(528, 135);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(79, 23);
            dateTimePicker2.TabIndex = 41;
            toolTip1.SetToolTip(dateTimePicker2, "This is in 24 Hour format. ");
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(326, 132);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 40;
            label4.Text = "Start:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(388, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(79, 23);
            dateTimePicker1.TabIndex = 39;
            toolTip1.SetToolTip(dateTimePicker1, "This is in 24 Hour format. ");
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dayComboBox
            // 
            dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            dayComboBox.Location = new Point(31, 135);
            dayComboBox.MaxLength = 50;
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(246, 23);
            dayComboBox.TabIndex = 38;
            toolTip1.SetToolTip(dayComboBox, "Pick the day");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(326, 107);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 37;
            label3.Text = "Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 107);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 36;
            label2.Text = "Day";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 43);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 35;
            label1.Text = "Edit Lab Schedule ";
            // 
            // clncbox
            // 
            clncbox.DropDownStyle = ComboBoxStyle.DropDownList;
            clncbox.FormattingEnabled = true;
            clncbox.Items.AddRange(new object[] { "1", "2", "3" });
            clncbox.Location = new Point(32, 360);
            clncbox.MaxLength = 50;
            clncbox.Name = "clncbox";
            clncbox.Size = new Size(97, 23);
            clncbox.TabIndex = 51;
            toolTip1.SetToolTip(clncbox, "Pick the day");
            // 
            // Button_GoBack
            // 
            Button_GoBack.BackColor = Color.FromArgb(7, 25, 82);
            Button_GoBack.Cursor = Cursors.Hand;
            Button_GoBack.FlatStyle = FlatStyle.Popup;
            Button_GoBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_GoBack.ForeColor = SystemColors.Control;
            Button_GoBack.Location = new Point(31, 22);
            Button_GoBack.Name = "Button_GoBack";
            Button_GoBack.Size = new Size(75, 23);
            Button_GoBack.TabIndex = 50;
            Button_GoBack.Text = "< Go back";
            Button_GoBack.UseVisualStyleBackColor = false;
            Button_GoBack.Click += Button_GoBack_Click;
            // 
            // SuperAdmin_EditSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(638, 507);
            Controls.Add(clncbox);
            Controls.Add(Button_GoBack);
            Controls.Add(SubmitButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(instructortxt);
            Controls.Add(label6);
            Controls.Add(gnstxtbox);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(dayComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SuperAdmin_EditSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin - Edit Schedule";
            Load += SuperAdmin_EditSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Label label8;
        private TextBox clntxt;
        private ToolTip toolTip1;
        private Label label7;
        private TextBox instructortxt;
        private Label label6;
        private TextBox gnstxtbox;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox dayComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Button_GoBack;
        private ComboBox clncbox;
    }
}