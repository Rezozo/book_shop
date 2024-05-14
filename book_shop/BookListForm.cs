using book_shop.models;
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
    public partial class BookListForm : Form
    {
        public User currentUser { get; set; }
        private BooksProvider booksProvider = new BooksProvider();
        private List<Books> booksList = new List<Books>();
        private const int itemsPerPage = 20;
        private int currentPage = 1;
        private int offset;
        private int limit;
        private int totalPages;
        public BookListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            if (currentUser.Role.Equals("Администратор"))
            {
                orderBtn.Visible = false;
            } else
            {
                allOrdersBtn.Visible = false;
                newBookBtn.Visible = false;
            }

            booksList = booksProvider.GetAllBooks();
            DisplayPage(currentPage, null, null);
        }

        public void RefreshBooks()
        {
            booksList = booksProvider.GetAllBooks();
            DisplayPage(1, null, null);
        }

        private void DisplayPage(int page, string text, string sorter)
        {
            flowLayoutPanelBooks.Controls.Clear();
            flowLayoutPanelPagination.Controls.Clear();

            offset = (page - 1) * itemsPerPage;
            limit = itemsPerPage;

            var filteredBooks = booksList;

            if (!string.IsNullOrEmpty(text) && !text.Equals("Введите для поиска"))
            {
                filteredBooks = filteredBooks
                    .Where(book => 
                    book.Title.ToLower()
                        .Contains(text
                                .ToLower()) || 
                    book.Author.ToLower()
                        .Contains(text
                                .ToLower()))
                   .ToList();
            }

            switch (sorter)
            {
                case "По автору(А-Я)":
                    filteredBooks = filteredBooks
                        .OrderBy(book => book.Author)
                        .ToList();
                    break;
                case "По автору(Я-А)":
                    filteredBooks = filteredBooks
                        .OrderByDescending(book => book.Author)
                        .ToList();
                    break;
                case "По стоимости (по возрастанию)":
                    filteredBooks = filteredBooks
                        .OrderBy(book => book.Cost)
                        .ToList();
                    break;
                case "По стоимости (по убыванию)":
                    filteredBooks = filteredBooks
                        .OrderByDescending(book => book.Cost)
                        .ToList();
                    break;
                default: 
                    break;
            }

            filteredBooks = filteredBooks
                .Skip(offset)
                .Take(limit)
                .ToList();

            DisplayBooks(filteredBooks);
        }

        private void DisplayBooks(List<Books> books) 
        {
            BookListControl[] bookListControls = new BookListControl[books.Count];
            for (int i = 0;  i < books.Count; i++)
            {
                BookListControl bookList = new BookListControl(this);
                bookList.Books = books[i];
                bookListControls[i] = bookList;
            }
            flowLayoutPanelBooks.Controls.AddRange(bookListControls);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Введите для поиска"))
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Введите для поиска";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentPage = 1;
            DisplayPage(currentPage, textBox1.Text, sortBox.Text);
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayPage(currentPage, textBox1.Text, sortBox.Text);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.User = currentUser;
            orderForm.ShowDialog();
        }

        private void newBookBtn_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new NewProductForm(this);
            newProductForm.ShowDialog();
        }

        private void allOrdersBtn_Click(object sender, EventArgs e)
        {
            AdminOrdersForm ordersForm = new AdminOrdersForm();
            ordersForm.ShowDialog();
        }
    }
}
