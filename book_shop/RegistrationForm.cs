using book_shop.provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_shop
{
    public partial class RegistrationForm : Form
    {
        private UserProvider userProvider = new UserProvider();
        private OrdersProvider ordersProvider = new OrdersProvider();
        public bool CaptchaResult = false;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AuthForm auth = new AuthForm();
            auth.FormClosed += (s, args) => Close();
            auth.Show();
            Hide();
        }

        private void passwordLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Требование к паролю: 11 символов (7 букв, 3 цифры, 1 специальный символ)");
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text.Trim();
            string email = emailTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();

            if (!isValidPassword(password))
            {
                MessageBox.Show("Требование к паролю: 11 символов (7 букв, 3 цифры, 1 специальный символ)");
                return;
            }

            if (string.IsNullOrEmpty(name) ||
                !email.Contains('@'))
            {
                MessageBox.Show("Укажите все данные корректно");
                return;
            }

            if (userProvider.ExistsUser(email))
            {
                MessageBox.Show("Такой пользователь уже существует");
                return;
            }

            CaptchaForm captcha = new CaptchaForm(this);
            captcha.ShowDialog();

            if (!CaptchaResult)
            {
                MessageBox.Show("Заполните капчу");
                return;
            }

            int userId = userProvider.CreateUser(name, email, password);
            ordersProvider.CreateOrder(userId);

            AuthForm auth = new AuthForm();
            auth.FormClosed += (s, args) => Close();
            auth.Show();
            Hide();
        }

        private bool isValidPassword(string password)
        {
            return password.Length == 11
                && password.Count(char.IsLetter) == 7
                && password.Count(char.IsDigit) == 3
                && password.IndexOfAny(new char[] { '@', '#', '%', ')', '(', '.', '<', '>', '«', '»' }) != -1; 
        }
    }
}
