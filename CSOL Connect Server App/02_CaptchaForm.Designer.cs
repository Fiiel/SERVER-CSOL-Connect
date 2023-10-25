namespace CSOL_Connect_Server_App
{
    partial class CaptchaForm
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

        private Label RetypeLabel;
        private Label captchalbl;
        private Label CaptchaLabel;
        private TextBox Captcha_TextBox;
        private PictureBox Captcha_RefreshPicBox;
        private Button Captcha_SubmitButton;
    }
}