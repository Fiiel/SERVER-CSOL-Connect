using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOL_Connect_Server_App
{
    public partial class CaptchaForm : Form
    {
        public CaptchaForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CaptchaForm));
            RetypeLabel = new Label();
            captchalbl = new Label();
            CaptchaLabel = new Label();
            Captcha_TextBox = new TextBox();
            Captcha_RefreshPicBox = new PictureBox();
            Captcha_SubmitButton = new Button();
            ((ISupportInitialize)Captcha_RefreshPicBox).BeginInit();
            SuspendLayout();
            // 
            // RetypeLabel
            // 
            RetypeLabel.AutoSize = true;
            RetypeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RetypeLabel.ForeColor = Color.Red;
            RetypeLabel.Location = new Point(17, 26);
            RetypeLabel.Name = "RetypeLabel";
            RetypeLabel.Size = new Size(284, 20);
            RetypeLabel.TabIndex = 0;
            RetypeLabel.Text = "Retype the characters from the picture:";
            // 
            // captchalbl
            // 
            captchalbl.AutoSize = true;
            captchalbl.BackColor = Color.White;
            captchalbl.BorderStyle = BorderStyle.FixedSingle;
            captchalbl.Font = new Font("Matura MT Script Capitals", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            captchalbl.Location = new Point(48, 66);
            captchalbl.Name = "captchalbl";
            captchalbl.Size = new Size(2, 46);
            captchalbl.TabIndex = 1;
            // 
            // CaptchaLabel
            // 
            CaptchaLabel.AutoSize = true;
            CaptchaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CaptchaLabel.ForeColor = Color.Black;
            CaptchaLabel.Location = new Point(26, 164);
            CaptchaLabel.Name = "CaptchaLabel";
            CaptchaLabel.Size = new Size(88, 25);
            CaptchaLabel.TabIndex = 3;
            CaptchaLabel.Text = "Captcha:";
            // 
            // Captcha_TextBox
            // 
            Captcha_TextBox.Cursor = Cursors.IBeam;
            Captcha_TextBox.Location = new Point(120, 166);
            Captcha_TextBox.Name = "Captcha_TextBox";
            Captcha_TextBox.Size = new Size(154, 23);
            Captcha_TextBox.TabIndex = 4;
            // 
            // Captcha_RefreshPicBox
            // 
            Captcha_RefreshPicBox.BackColor = Color.White;
            Captcha_RefreshPicBox.BackgroundImage = Properties.Resources.refreshSymbol;
            Captcha_RefreshPicBox.BorderStyle = BorderStyle.FixedSingle;
            Captcha_RefreshPicBox.Cursor = Cursors.Hand;
            Captcha_RefreshPicBox.Image = Properties.Resources.refreshSymbol;
            Captcha_RefreshPicBox.Location = new Point(228, 128);
            Captcha_RefreshPicBox.Name = "Captcha_RefreshPicBox";
            Captcha_RefreshPicBox.Size = new Size(47, 24);
            Captcha_RefreshPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Captcha_RefreshPicBox.TabIndex = 5;
            Captcha_RefreshPicBox.TabStop = false;
            Captcha_RefreshPicBox.Click += Captcha_RefreshPicBox_Click;
            // 
            // Captcha_SubmitButton
            // 
            Captcha_SubmitButton.Cursor = Cursors.Hand;
            Captcha_SubmitButton.FlatStyle = FlatStyle.System;
            Captcha_SubmitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Captcha_SubmitButton.Location = new Point(181, 206);
            Captcha_SubmitButton.Name = "Captcha_SubmitButton";
            Captcha_SubmitButton.Size = new Size(94, 33);
            Captcha_SubmitButton.TabIndex = 6;
            Captcha_SubmitButton.Text = "Submit";
            Captcha_SubmitButton.UseVisualStyleBackColor = true;
            Captcha_SubmitButton.Click += Captcha_SubmitButton_Click;
            // 
            // CaptchaForm
            // 
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(319, 255);
            Controls.Add(Captcha_SubmitButton);
            Controls.Add(Captcha_RefreshPicBox);
            Controls.Add(Captcha_TextBox);
            Controls.Add(CaptchaLabel);
            Controls.Add(captchalbl);
            Controls.Add(RetypeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CaptchaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Captcha Form";
            Load += CaptchaForm_Load;
            ((ISupportInitialize)Captcha_RefreshPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private string GenerateCaptcha()
        {
            Random gen = new Random();
            int charLength = gen.Next(5, 7);
            string[] captchaWord = new string[charLength];
            char[] chars = {
                    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                    'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                    'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
                    'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                    'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                    'Y', 'Z'
            };

            for (int x = 0; x < charLength; x++)
            {
                int num = gen.Next(0, chars.Length);
                captchaWord[x] = chars[num].ToString();
            }

            string randomCaptchaText = string.Concat(captchaWord);

            int fontNum = gen.Next(1, 6);
            Font font;
            switch (fontNum)
            {
                case 1:
                    font = new Font("Matura MT Script Capitals", 24, FontStyle.Bold);
                    break;
                case 2:
                    font = new Font("Bauhaus 93", 27.75f, FontStyle.Bold);
                    break;
                case 3:
                    font = new Font("Chiller", 36, FontStyle.Bold);
                    break;
                case 4:
                    font = new Font("Ravie", 20.25f, FontStyle.Bold);
                    break;
                case 5:
                    font = new Font("Gigi", 24, FontStyle.Bold);
                    break;
                default:
                    font = captchalbl.Font;
                    break;
            }

            captchalbl.Font = font;
            captchalbl.Text = randomCaptchaText;

            Color[] backgroundColors = { Color.Pink, Color.Red, Color.Black, Color.Blue, Color.Yellow, Color.Green, Color.Orange, Color.Brown };
            Color[] foregroundColors = { Color.White, Color.White, Color.White, Color.White, Color.Black, Color.White, Color.Black, Color.White };

            int colorIndex = gen.Next(backgroundColors.Length);
            captchalbl.BackColor = backgroundColors[colorIndex];
            captchalbl.ForeColor = foregroundColors[colorIndex];

            return randomCaptchaText;
        }

        private void Captcha_RefreshPicBox_Click(object sender, EventArgs e)
        {
            string Captcha_TextBox = GenerateCaptcha();
            captchalbl.Text = Captcha_TextBox;
        }

        private void Captcha_SubmitButton_Click(object sender, EventArgs e)
        {
            if (Captcha_TextBox.Text == captchalbl.Text)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (Captcha_TextBox.Text != captchalbl.Text)
            {
                MessageBox.Show("Input doesn't match.", "Captcha Error");
            }
            else if (Captcha_TextBox.Text.Length == 0)
            {
                MessageBox.Show("Please complete the captcha first.", "Captcha Error");
            }
            else
            {
                MessageBox.Show("Invalid Input.", "Captcha Error");
            }
        }

        private void CaptchaForm_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
    }
}
