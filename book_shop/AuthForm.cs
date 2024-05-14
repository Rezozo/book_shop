using book_shop.models;
using book_shop.provider;
using System;
using System.Windows.Forms;

namespace book_shop
{
    public partial class AuthForm : Form
    {
        private UserProvider userProvider = new UserProvider();

        public AuthForm()
        {
            InitializeComponent();
        }

        private void regLbl_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.FormClosed += (s, args) => Close();
            registration.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = emailTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Укажите логин и пароль");
                return;
            }

            User user = userProvider.GetUser(login, password); 

            if (user == null)
            {
                MessageBox.Show("Укажите логин и пароль");
                return;
            }

            BookListForm bookListForm = new BookListForm();
            bookListForm.currentUser = user;
            bookListForm.FormClosed += (s, args) => Close();
            bookListForm.Show();
            Hide();
        }
    }
}
