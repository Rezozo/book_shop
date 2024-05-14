namespace book_shop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.captchaBox = new System.Windows.Forms.PictureBox();
            this.CaptchaTxtB = new System.Windows.Forms.TextBox();
            this.checkCaptcha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captchaBox
            // 
            this.captchaBox.Location = new System.Drawing.Point(106, 32);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(150, 50);
            this.captchaBox.TabIndex = 16;
            this.captchaBox.TabStop = false;
            // 
            // CaptchaTxtB
            // 
            this.CaptchaTxtB.Location = new System.Drawing.Point(94, 101);
            this.CaptchaTxtB.MaxLength = 6;
            this.CaptchaTxtB.Multiline = true;
            this.CaptchaTxtB.Name = "CaptchaTxtB";
            this.CaptchaTxtB.Size = new System.Drawing.Size(178, 39);
            this.CaptchaTxtB.TabIndex = 15;
            // 
            // checkCaptcha
            // 
            this.checkCaptcha.Location = new System.Drawing.Point(106, 164);
            this.checkCaptcha.Name = "checkCaptcha";
            this.checkCaptcha.Size = new System.Drawing.Size(150, 39);
            this.checkCaptcha.TabIndex = 17;
            this.checkCaptcha.Text = "Проверить";
            this.checkCaptcha.UseVisualStyleBackColor = true;
            this.checkCaptcha.Click += new System.EventHandler(this.checkCaptcha_Click);
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 200);
            this.Controls.Add(this.checkCaptcha);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.CaptchaTxtB);
            this.MaximumSize = new System.Drawing.Size(387, 297);
            this.MinimumSize = new System.Drawing.Size(387, 297);
            this.Name = "CaptchaForm";
            this.Text = "Капча";
            this.Load += new System.EventHandler(this.CaptchaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox captchaBox;
        private System.Windows.Forms.TextBox CaptchaTxtB;
        private System.Windows.Forms.Button checkCaptcha;
    }
}