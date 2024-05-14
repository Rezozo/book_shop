using book_shop.models;
using book_shop.provider;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace book_shop
{
    public partial class BookOrderControl : UserControl
    {
        private OrderForm orderForm;
        private OrdersProvider ordersProvider = new OrdersProvider();

        public BooksOrder Books { get; set; }

        public BookOrderControl(OrderForm order)
        {
            InitializeComponent();
            orderForm = order;
            BackColor = Color.White;
        }

        private void BookOrderControl_Load(object sender, System.EventArgs e)
        {
            string imagePath;
            if (string.IsNullOrEmpty(Books.Books.Image))
            {
                imagePath = Directory.GetCurrentDirectory() + "\\products\\picture.png";
            }
            else
            {
                imagePath = Directory.GetCurrentDirectory() + Books.Books.Image;
            }

            productImage.Image = new Bitmap(imagePath);
            titleLbl.Text = Books.Books.Title;
            costLbl.Text += Books.Books.Cost.ToString() + "руб.";
            countTxt.Text = Books.Quantity.ToString();

            if (orderForm != null)
            {
                if (!orderForm.Orders.Status.Equals("Новый"))
                {
                    minusBtn.Enabled = false;
                    plusBtn.Enabled = false;
                }
            } else
            {
                minusBtn.Enabled = false;
                plusBtn.Enabled = false;
            }
        }

        private void minusBtn_Click(object sender, System.EventArgs e)
        {
            var newCount = int.Parse(countTxt.Text) - 1;
            if (newCount == 0)
            {
                ordersProvider.DeleteBookFromOrder(orderForm.Orders.Id, Books.Books.Id);
                orderForm.RefreshOrderInfo();
                return;
            }
            ordersProvider.AddProductToOrder(orderForm.User.Id, Books.Books.Id, newCount);
            orderForm.RefreshOrderInfo();
        }

        private void plusBtn_Click(object sender, System.EventArgs e)
        {
            var newCount = int.Parse(countTxt.Text) + 1;
            ordersProvider.AddProductToOrder(orderForm.User.Id, Books.Books.Id, newCount);
            orderForm.RefreshOrderInfo();
        }
    }
}
