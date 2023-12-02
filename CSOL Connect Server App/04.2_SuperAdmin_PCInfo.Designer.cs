namespace CSOL_Connect_Server_App
{
    partial class SuperAdmin_PCInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_PCInfo));
            Button_Back = new Button();
            PictureBox_DeletePC = new PictureBox();
            Panel_PCInfo = new Panel();
            Label_Keyboard = new Label();
            PictureBox_EthernetRead = new PictureBox();
            PictureBox_KeyboardRead = new PictureBox();
            PictureBox_MouseRead = new PictureBox();
            Label_LAN = new Label();
            Label_Mouse = new Label();
            Label_DeviceConnection = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox_DeletePC).BeginInit();
            Panel_PCInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_EthernetRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_KeyboardRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_MouseRead).BeginInit();
            SuspendLayout();
            // 
            // Button_Back
            // 
            Button_Back.BackColor = Color.FromArgb(7, 25, 82);
            Button_Back.Cursor = Cursors.Hand;
            Button_Back.FlatStyle = FlatStyle.Popup;
            Button_Back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Back.ForeColor = SystemColors.Control;
            Button_Back.Location = new Point(30, 231);
            Button_Back.Name = "Button_Back";
            Button_Back.Size = new Size(56, 23);
            Button_Back.TabIndex = 55;
            Button_Back.Text = "< Back";
            Button_Back.UseVisualStyleBackColor = false;
            Button_Back.Click += Button_Back_Click;
            // 
            // PictureBox_DeletePC
            // 
            PictureBox_DeletePC.BackColor = Color.Transparent;
            PictureBox_DeletePC.Cursor = Cursors.Hand;
            PictureBox_DeletePC.Image = Properties.Resources.icons8_remove_66px_1;
            PictureBox_DeletePC.Location = new Point(236, 224);
            PictureBox_DeletePC.Name = "PictureBox_DeletePC";
            PictureBox_DeletePC.Size = new Size(33, 37);
            PictureBox_DeletePC.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_DeletePC.TabIndex = 54;
            PictureBox_DeletePC.TabStop = false;
            PictureBox_DeletePC.Click += PictureBox_DeletePC_Click;
            // 
            // Panel_PCInfo
            // 
            Panel_PCInfo.BackColor = Color.White;
            Panel_PCInfo.Controls.Add(Label_Keyboard);
            Panel_PCInfo.Controls.Add(PictureBox_EthernetRead);
            Panel_PCInfo.Controls.Add(PictureBox_KeyboardRead);
            Panel_PCInfo.Controls.Add(PictureBox_MouseRead);
            Panel_PCInfo.Controls.Add(Label_LAN);
            Panel_PCInfo.Controls.Add(Label_Mouse);
            Panel_PCInfo.Location = new Point(30, 72);
            Panel_PCInfo.Name = "Panel_PCInfo";
            Panel_PCInfo.Size = new Size(239, 144);
            Panel_PCInfo.TabIndex = 51;
            // 
            // Label_Keyboard
            // 
            Label_Keyboard.AutoSize = true;
            Label_Keyboard.BackColor = Color.Transparent;
            Label_Keyboard.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Keyboard.ForeColor = Color.Black;
            Label_Keyboard.Image = Properties.Resources.icons8_keyboard_50px;
            Label_Keyboard.ImageAlign = ContentAlignment.MiddleLeft;
            Label_Keyboard.Location = new Point(4, 53);
            Label_Keyboard.Name = "Label_Keyboard";
            Label_Keyboard.Size = new Size(172, 35);
            Label_Keyboard.TabIndex = 43;
            Label_Keyboard.Text = "       Keyboard";
            // 
            // PictureBox_EthernetRead
            // 
            PictureBox_EthernetRead.BackColor = Color.Transparent;
            PictureBox_EthernetRead.Image = Properties.Resources.circle_grey3;
            PictureBox_EthernetRead.Location = new Point(181, 98);
            PictureBox_EthernetRead.Name = "PictureBox_EthernetRead";
            PictureBox_EthernetRead.Size = new Size(42, 35);
            PictureBox_EthernetRead.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_EthernetRead.TabIndex = 42;
            PictureBox_EthernetRead.TabStop = false;
            // 
            // PictureBox_KeyboardRead
            // 
            PictureBox_KeyboardRead.BackColor = Color.Transparent;
            PictureBox_KeyboardRead.Image = Properties.Resources.circle_grey2;
            PictureBox_KeyboardRead.Location = new Point(181, 53);
            PictureBox_KeyboardRead.Name = "PictureBox_KeyboardRead";
            PictureBox_KeyboardRead.Size = new Size(42, 35);
            PictureBox_KeyboardRead.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_KeyboardRead.TabIndex = 41;
            PictureBox_KeyboardRead.TabStop = false;
            // 
            // PictureBox_MouseRead
            // 
            PictureBox_MouseRead.BackColor = Color.Transparent;
            PictureBox_MouseRead.Image = Properties.Resources.circle_grey1;
            PictureBox_MouseRead.Location = new Point(181, 12);
            PictureBox_MouseRead.Name = "PictureBox_MouseRead";
            PictureBox_MouseRead.Size = new Size(42, 35);
            PictureBox_MouseRead.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_MouseRead.TabIndex = 40;
            PictureBox_MouseRead.TabStop = false;
            // 
            // Label_LAN
            // 
            Label_LAN.AutoSize = true;
            Label_LAN.BackColor = Color.Transparent;
            Label_LAN.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_LAN.ForeColor = Color.Black;
            Label_LAN.Image = Properties.Resources.icons8_ethernet_on_50px1;
            Label_LAN.ImageAlign = ContentAlignment.MiddleLeft;
            Label_LAN.Location = new Point(4, 98);
            Label_LAN.Name = "Label_LAN";
            Label_LAN.Size = new Size(113, 35);
            Label_LAN.TabIndex = 40;
            Label_LAN.Text = "       LAN";
            // 
            // Label_Mouse
            // 
            Label_Mouse.AutoSize = true;
            Label_Mouse.BackColor = Color.Transparent;
            Label_Mouse.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Mouse.ForeColor = Color.Black;
            Label_Mouse.Image = Properties.Resources.icons8_mouse_50px_21;
            Label_Mouse.ImageAlign = ContentAlignment.MiddleLeft;
            Label_Mouse.Location = new Point(4, 12);
            Label_Mouse.Name = "Label_Mouse";
            Label_Mouse.Size = new Size(141, 35);
            Label_Mouse.TabIndex = 39;
            Label_Mouse.Text = "       Mouse";
            // 
            // Label_DeviceConnection
            // 
            Label_DeviceConnection.AutoSize = true;
            Label_DeviceConnection.BackColor = Color.Transparent;
            Label_DeviceConnection.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label_DeviceConnection.ForeColor = Color.FromArgb(7, 25, 82);
            Label_DeviceConnection.Location = new Point(22, 22);
            Label_DeviceConnection.Name = "Label_DeviceConnection";
            Label_DeviceConnection.Size = new Size(256, 37);
            Label_DeviceConnection.TabIndex = 52;
            Label_DeviceConnection.Text = "Device Connection";
            // 
            // SuperAdmin_PCInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(301, 277);
            Controls.Add(Button_Back);
            Controls.Add(PictureBox_DeletePC);
            Controls.Add(Panel_PCInfo);
            Controls.Add(Label_DeviceConnection);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperAdmin_PCInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computer Information";
            FormClosing += SuperAdmin_PCInfo_FormClosing;
            ((System.ComponentModel.ISupportInitialize)PictureBox_DeletePC).EndInit();
            Panel_PCInfo.ResumeLayout(false);
            Panel_PCInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_EthernetRead).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_KeyboardRead).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_MouseRead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Back;
        private PictureBox PictureBox_DeletePC;
        private Panel Panel_PCInfo;
        private Label Label_Keyboard;
        private PictureBox PictureBox_EthernetRead;
        private PictureBox PictureBox_KeyboardRead;
        private PictureBox PictureBox_MouseRead;
        private Label Label_LAN;
        private Label Label_Mouse;
        private Label Label_DeviceConnection;
    }
}