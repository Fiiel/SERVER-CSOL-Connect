namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_AddPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_AddPC));
            Button_Back = new Button();
            Button_Clear = new Button();
            TextBox_PC = new TextBox();
            Label_PCName = new Label();
            Label_InputInfo = new Label();
            Button_Add = new Button();
            clncbox = new ComboBox();
            Label_CLno = new Label();
            SuspendLayout();
            // 
            // Button_Back
            // 
            Button_Back.BackColor = Color.FromArgb(7, 25, 82);
            Button_Back.Cursor = Cursors.Hand;
            Button_Back.FlatStyle = FlatStyle.Popup;
            Button_Back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Back.ForeColor = SystemColors.Control;
            Button_Back.Location = new Point(25, 185);
            Button_Back.Name = "Button_Back";
            Button_Back.Size = new Size(56, 23);
            Button_Back.TabIndex = 59;
            Button_Back.Text = "< Back";
            Button_Back.UseVisualStyleBackColor = false;
            Button_Back.Click += Button_Back_Click;
            // 
            // Button_Clear
            // 
            Button_Clear.BackColor = Color.FromArgb(255, 192, 192);
            Button_Clear.Cursor = Cursors.Hand;
            Button_Clear.FlatStyle = FlatStyle.Popup;
            Button_Clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Clear.ForeColor = Color.Black;
            Button_Clear.Location = new Point(102, 185);
            Button_Clear.Name = "Button_Clear";
            Button_Clear.Size = new Size(55, 24);
            Button_Clear.TabIndex = 58;
            Button_Clear.Text = "Clear";
            Button_Clear.UseVisualStyleBackColor = false;
            Button_Clear.Click += Button_Clear_Click;
            // 
            // TextBox_PC
            // 
            TextBox_PC.Cursor = Cursors.IBeam;
            TextBox_PC.Location = new Point(25, 76);
            TextBox_PC.MaxLength = 200;
            TextBox_PC.Name = "TextBox_PC";
            TextBox_PC.Size = new Size(193, 23);
            TextBox_PC.TabIndex = 53;
            TextBox_PC.TextChanged += TextBox_PC_TextChanged;
            // 
            // Label_PCName
            // 
            Label_PCName.AutoSize = true;
            Label_PCName.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_PCName.Location = new Point(25, 54);
            Label_PCName.Name = "Label_PCName";
            Label_PCName.Size = new Size(49, 19);
            Label_PCName.TabIndex = 52;
            Label_PCName.Text = "Name:";
            // 
            // Label_InputInfo
            // 
            Label_InputInfo.AutoSize = true;
            Label_InputInfo.BackColor = Color.Transparent;
            Label_InputInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_InputInfo.ForeColor = Color.FromArgb(7, 25, 82);
            Label_InputInfo.Location = new Point(25, 18);
            Label_InputInfo.Name = "Label_InputInfo";
            Label_InputInfo.Size = new Size(198, 25);
            Label_InputInfo.TabIndex = 51;
            Label_InputInfo.Text = "Input Computer Info";
            // 
            // Button_Add
            // 
            Button_Add.BackColor = Color.FromArgb(7, 25, 82);
            Button_Add.Cursor = Cursors.Hand;
            Button_Add.FlatStyle = FlatStyle.Popup;
            Button_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Add.ForeColor = Color.Snow;
            Button_Add.Location = new Point(163, 185);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(55, 24);
            Button_Add.TabIndex = 50;
            Button_Add.Text = "Add";
            Button_Add.UseVisualStyleBackColor = false;
            Button_Add.Click += Button_Add_Click;
            // 
            // clncbox
            // 
            clncbox.DropDownStyle = ComboBoxStyle.DropDownList;
            clncbox.FormattingEnabled = true;
            clncbox.Items.AddRange(new object[] { "1", "2", "3" });
            clncbox.Location = new Point(25, 136);
            clncbox.MaxLength = 50;
            clncbox.Name = "clncbox";
            clncbox.Size = new Size(97, 23);
            clncbox.TabIndex = 60;
            // 
            // Label_CLno
            // 
            Label_CLno.AutoSize = true;
            Label_CLno.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_CLno.Location = new Point(25, 114);
            Label_CLno.Name = "Label_CLno";
            Label_CLno.Size = new Size(40, 19);
            Label_CLno.TabIndex = 61;
            Label_CLno.Text = "CL #:";
            // 
            // SuperAdmin_AddPC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(246, 233);
            ControlBox = false;
            Controls.Add(Label_CLno);
            Controls.Add(clncbox);
            Controls.Add(Button_Back);
            Controls.Add(Button_Clear);
            Controls.Add(TextBox_PC);
            Controls.Add(Label_PCName);
            Controls.Add(Label_InputInfo);
            Controls.Add(Button_Add);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperAdmin_AddPC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add PC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button Button_Back;
        private Button Button_Clear;
        private TextBox TextBox_PC;
        private Label Label_PCName;
        private Label Label_InputInfo;
        private Button Button_Add;
        private ComboBox clncbox;
        private Label Label_CLno;
    }
}