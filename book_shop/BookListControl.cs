using book_shop.models;
using book_shop.provider;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace book_shop
{
    public partial class BookListControl : UserControl
    {
        private BookListForm productListForm;
        private BooksProvider booksProvider = new BooksProvider();
        private OrdersProvider ordersProvider = new OrdersProvider();

        public Books Books {  get; set; }

        public BookListControl(BookListForm form)
        {
            InitializeComponent();
            productListForm = form;
            this.BackColor = Color.White;
        }

        private void ProductListControl_Load(object sender, EventArgs e)
        {
            string imagePath;
            if (string.IsNullOrEmpty(Books.Image))
            {
                imagePath = Directory.GetCurrentDirectory() + "\\products\\picture.png";
            }
            else
            {
                imagePath = Directory.GetCurrentDirectory() + Books.Image;
            }

            productImage.Image = new Bitmap(imagePath);
            titleLbl.Text = Books.Title;
            authorLbl.Text += Books.Author;
            costLbl.Text += Books.Cost.ToString() + "руб.";

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            if (productListForm.currentUser.Role.Equals("Клиент"))
            {
                ToolStripMenuItem addItem = new ToolStripMenuItem("Добавить товар в корзину");
                addItem.Click += AddItem_Click;
                contextMenu.Items.Add(addItem);
            }
            else
            {
                ToolStripMenuItem deleteItem = new ToolStripMenuItem("Удалить товар");
                deleteItem.Click += DeleteItem_Click;
                contextMenu.Items.Add(deleteItem);
            }
            ContextMenuStrip = contextMenu;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            booksProvider.DeleteBook(Books.Id);
            productListForm.RefreshBooks();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            ordersProvider.AddProductToOrder(productListForm.currentUser.Id, Books.Id, 1);
        }
    }
}
