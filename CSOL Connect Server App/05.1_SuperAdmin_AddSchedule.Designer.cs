namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_AddSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_AddSchedule));
            toolTip1 = new ToolTip(components);
            instructortxt = new TextBox();
            gnstxtbox = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dayComboBox = new ComboBox();
            clncbox = new ComboBox();
            Submit = new Button();
            Clear = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BackButton = new Button();
            schedtimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Hint";
            // 
            // instructortxt
            // 
            instructortxt.Cursor = Cursors.IBeam;
            instructortxt.Location = new Point(41, 303);
            instructortxt.MaxLength = 200;
            instructortxt.Name = "instructortxt";
            instructortxt.Size = new Size(576, 23);
            instructortxt.TabIndex = 40;
            toolTip1.SetToolTip(instructortxt, "Input who's the one in charge of the class.");
            // 
            // gnstxtbox
            // 
            gnstxtbox.Cursor = Cursors.IBeam;
            gnstxtbox.Location = new Point(40, 228);
            gnstxtbox.MaxLength = 100;
            gnstxtbox.Name = "gnstxtbox";
            gnstxtbox.Size = new Size(576, 23);
            gnstxtbox.TabIndex = 38;
            toolTip1.SetToolTip(gnstxtbox, "Input here the grade and section of the class who will use the lab.");
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(537, 153);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(79, 23);
            dateTimePicker2.TabIndex = 36;
            toolTip1.SetToolTip(dateTimePicker2, "This is in 24 Hour format. ");
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(397, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(79, 23);
            dateTimePicker1.TabIndex = 34;
            toolTip1.SetToolTip(dateTimePicker1, "This is in 24 Hour format. ");
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dayComboBox
            // 
            dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            dayComboBox.Location = new Point(40, 153);
            dayComboBox.MaxLength = 50;
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(246, 23);
            dayComboBox.TabIndex = 33;
            toolTip1.SetToolTip(dayComboBox, "Pick the day");
            // 
            // clncbox
            // 
            clncbox.DropDownStyle = ComboBoxStyle.DropDownList;
            clncbox.FormattingEnabled = true;
            clncbox.Items.AddRange(new object[] { "1", "2", "3" });
            clncbox.Location = new Point(41, 377);
            clncbox.MaxLength = 50;
            clncbox.Name = "clncbox";
            clncbox.Size = new Size(97, 23);
            clncbox.TabIndex = 46;
            toolTip1.SetToolTip(clncbox, "Pick the day");
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(7, 25, 82);
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Submit.ForeColor = Color.Snow;
            Submit.Location = new Point(505, 439);
            Submit.Name = "Submit";
            Submit.Size = new Size(111, 45);
            Submit.TabIndex = 45;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Firebrick;
            Clear.FlatStyle = FlatStyle.Popup;
            Clear.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = Color.Snow;
            Clear.Location = new Point(351, 439);
            Clear.Name = "Clear";
            Clear.Size = new Size(111, 45);
            Clear.TabIndex = 44;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(40, 349);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 43;
            label8.Text = "CL #";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(41, 275);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 41;
            label7.Text = "Instructor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 200);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 39;
            label6.Text = "Grade and Section";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(482, 150);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 37;
            label5.Text = "End:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(335, 150);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 35;
            label4.Text = "Start:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, 125);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 32;
            label3.Text = "Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 31;
            label2.Text = "Day";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(201, 64);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 30;
            label1.Text = "New Lab Schedule ";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(7, 25, 82);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.Control;
            BackButton.Location = new Point(22, 23);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 29;
            BackButton.Text = "< Go back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // schedtimer
            // 
            schedtimer.Tick += schedtimer_Tick_1;
            // 
            // SuperAdmin_AddSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(638, 507);
            Controls.Add(clncbox);
            Controls.Add(Submit);
            Controls.Add(Clear);
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
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperAdmin_AddSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin - Add Schedule";
            Load += SuperAdmin_AddSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private TextBox instructortxt;
        private TextBox gnstxtbox;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox dayComboBox;
        private Button Submit;
        private Button Clear;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BackButton;
        private System.Windows.Forms.Timer schedtimer;
        private ComboBox clncbox;
    }
}