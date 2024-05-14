using book_shop.models;
using book_shop.provider;
using System;
using System.Windows.Forms;

namespace book_shop
{
    public partial class OrderForm : Form
    {
        private OrdersProvider ordersProvider = new OrdersProvider();
        public User User { get; set; }
        public Orders Orders { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            RefreshOrderInfo();
        }

        public void RefreshOrderInfo()
        {
            flowLayoutPanelBooks.Controls.Clear();
            comment.Visible = false;
            commentTxt.Visible = false;

            Orders = ordersProvider.GetOrder(User);
            if (!Orders.Status.Equals("Новый"))
            {
                addressTxt.Enabled = false;
                finishBtn.Enabled = false;
                comment.Visible = true;
                commentTxt.Visible = true;
            }

            addressTxt.Text = Orders.Address;
            double totalCost = 0;
            foreach (BooksOrder books in Orders.Books)
            {
                totalCost += books.Quantity * books.Books.Cost;
            }
            totalCostLbl.Text = "Итоговая стоимость: " + totalCost.ToString();

            BookOrderControl[] bookOrderControls = new BookOrderControl[Orders.Books.Count];
            for (int i = 0; i < Orders.Books.Count; i++)
            {
                BookOrderControl bookList = new BookOrderControl(this);
                bookList.Books = Orders.Books[i];
                bookOrderControls[i] = bookList;
            }

            if (Orders.Comment != "")
            {
                commentTxt.Text = Orders.Comment;
                comment.Visible = true;
                commentTxt.Visible = true;
            }
            flowLayoutPanelBooks.Controls.AddRange(bookOrderControls);
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text) || Orders.Books.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один товар и укажите адрес");
                return;
            }

            Orders.Address = addressTxt.Text;
            Orders.Status = "Сформирован";
            ordersProvider.ChangeStatus(Orders);
            MessageBox.Show("Ваш заказ сформирован");
            Close();
        }
    }
}
