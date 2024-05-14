using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace book_shop
{
    public partial class CaptchaForm : Form
    {
        private const string CaptchaChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private string captcha;
        public bool CaptchaEnteredSuccessfully { get; private set; }
        private RegistrationForm registrationForm;

        public CaptchaForm(RegistrationForm form)
        {
            InitializeComponent();
            registrationForm = form;
        }

        private void checkCaptcha_Click(object sender, EventArgs e)
        {
            string enteredCaptcha = CaptchaTxtB.Text;

            if (string.Equals(enteredCaptcha, captcha))
            {
                CaptchaEnteredSuccessfully = true;
                registrationForm.CaptchaResult = true;
                Hide();
            }
            else
            {
                MessageBox.Show("Неверно введена капча.");
                GenerateCaptcha();
            }
        }

        private void CaptchaForm_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            Random random = new Random();
            captcha = "";
            for (int i = 0; i < 6; i++)
            {
                captcha += CaptchaChars[random.Next(CaptchaChars.Length)];
            }

            using (Bitmap bitmap = new Bitmap(150, 50))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                using (Font font = new Font("Arial", 20))
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    int spacing = 17;

                    for (int i = 0; i < captcha.Length; i++)
                    {
                        g.TranslateTransform(i * spacing, random.Next(10, 15));
                        g.RotateTransform(random.Next(-20, 20));
                        g.DrawString(captcha[i].ToString(), font, brush, 0, 0);
                        g.ResetTransform();
                    }
                    int y = random.Next(20, 30);
                    g.DrawLine(Pens.Black, 5, y, 145, y);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    captchaBox.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
