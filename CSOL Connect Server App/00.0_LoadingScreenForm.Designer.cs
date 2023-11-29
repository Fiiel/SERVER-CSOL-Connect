namespace CSOL_Connect_Server_App
{
    partial class LoadingScreenForm
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
            pictureBox1 = new PictureBox();
            Label_CSOLConnect = new Label();
            PictureBox_CSOLbldg = new PictureBox();
            Label_Initializing = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_CSOLbldg).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.csol_logo;
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Label_CSOLConnect
            // 
            Label_CSOLConnect.AutoSize = true;
            Label_CSOLConnect.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label_CSOLConnect.ForeColor = Color.FromArgb(7, 25, 82);
            Label_CSOLConnect.Location = new Point(73, 25);
            Label_CSOLConnect.Name = "Label_CSOLConnect";
            Label_CSOLConnect.Size = new Size(152, 30);
            Label_CSOLConnect.TabIndex = 21;
            Label_CSOLConnect.Text = "CSOL Connect";
            // 
            // PictureBox_CSOLbldg
            // 
            PictureBox_CSOLbldg.BorderStyle = BorderStyle.FixedSingle;
            PictureBox_CSOLbldg.Image = Properties.Resources.main_dasma;
            PictureBox_CSOLbldg.InitialImage = Properties.Resources.main_dasma;
            PictureBox_CSOLbldg.Location = new Point(243, 12);
            PictureBox_CSOLbldg.Name = "PictureBox_CSOLbldg";
            PictureBox_CSOLbldg.Size = new Size(160, 145);
            PictureBox_CSOLbldg.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_CSOLbldg.TabIndex = 22;
            PictureBox_CSOLbldg.TabStop = false;
            // 
            // Label_Initializing
            // 
            Label_Initializing.AutoSize = true;
            Label_Initializing.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Label_Initializing.ForeColor = Color.FromArgb(7, 25, 82);
            Label_Initializing.Location = new Point(12, 136);
            Label_Initializing.Name = "Label_Initializing";
            Label_Initializing.Size = new Size(91, 21);
            Label_Initializing.TabIndex = 23;
            Label_Initializing.Text = "Initializing...";
            // 
            // LoadingScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(420, 175);
            ControlBox = false;
            Controls.Add(Label_Initializing);
            Controls.Add(PictureBox_CSOLbldg);
            Controls.Add(Label_CSOLConnect);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "LoadingScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_CSOLbldg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label Label_CSOLConnect;
        private PictureBox PictureBox_CSOLbldg;
        private Label Label_Initializing;
    }
}