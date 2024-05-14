using book_shop.models;
using book_shop.provider;
using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace book_shop
{
    public partial class AdminEditForm : Form
    {
        private OrdersProvider ordersProvider = new OrdersProvider();
        private UserProvider userProvider = new UserProvider();

        public Orders Order { get; set; }
        public int UserId { get; set; } 

        public AdminEditForm()
        {
            InitializeComponent();
        }

        private void AdminEditForm_Load(object sender, EventArgs e)
        {
            RefreshOrderInfo();
        }

        public void RefreshOrderInfo()
        {
            flowLayoutPanelBooks.Controls.Clear();

            Order = ordersProvider.GetOrder(new User
            {
                Id = UserId,
            });
            addressTxt.Enabled = false;
            commentTxt.Enabled = true;
            if (Order.Comment != "")
            {
                commentTxt.Text = Order.Comment;
            }

            addressTxt.Text = Order.Address;

            double totalCost = 0;
            foreach (BooksOrder books in Order.Books)
            {
                totalCost += books.Quantity * books.Books.Cost;
            }
            totalCostLbl.Text = "Итоговая стоимость: " + totalCost.ToString();

            sortBox.SelectedItem = Order.Status;

            BookOrderControl[] bookOrderControls = new BookOrderControl[Order.Books.Count];
            for (int i = 0; i < Order.Books.Count; i++)
            {
                BookOrderControl bookList = new BookOrderControl(null);
                bookList.Books = Order.Books[i];
                bookOrderControls[i] = bookList;
            }
            flowLayoutPanelBooks.Controls.AddRange(bookOrderControls);
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Order.Comment = commentTxt.Text;
            Order.Status = sortBox.Text;
            ordersProvider.ChangeStatus(Order);

            if(Order.Status == "Подтвержден")
            {
                User user = userProvider.GetUser(UserId); if(user != null)
                {
                    MailMessage message = new MailMessage("kolya.hrenov2018@mail.ru", user.Email);

                    message.Subject = "Заказ!";
                    message.Body = "Ваш заказ подтвержен!";

                    SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 587);
                    smtpClient.Credentials = new NetworkCredential("kolya.hrenov2018@mail.ru", "KgttJpk6YaSJDCumReAT");

                    /*
                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch
                    {
                        MessageBox.Show("Служба mail недоступна");
                    }
                    */
                }
            }

            Close();
        }
    }
}
