using book_shop.models;
using book_shop.provider;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace book_shop
{
    public partial class NewProductForm : Form
    {
        private BooksProvider booksProvider = new BooksProvider();
        private string savedImageTitle = Application.StartupPath + "\\books\\basebook.png";
        private BookListForm bookListForm;


        public NewProductForm(BookListForm bookListForm)
        {
            InitializeComponent();
            this.bookListForm = bookListForm;
            List<string> authors = booksProvider.GetAuthors();
            string[] authorArray = new string[authors.Count];
            authors.CopyTo(authorArray, 0);
            authorBox.Items.AddRange(authorArray);
        }

        private void productImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    savedImageTitle = fileName;

                    productImage.Image = new Bitmap(fileName);
                }
            }
            catch
            {
                MessageBox.Show("Укажите файл из папки Resources");
            }
        }

        private void newBookBtn_Click(object sender, EventArgs e)
        {
                string title = titleTxt.Text;
                string cost = costTxt.Text;
                string quantity = quantityTxt.Text;
                string author = authorBox.Text;
                savedImageTitle = "\\books\\" + savedImageTitle.Split('\\').Last();


                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(cost) 
                    || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(author)) 
                {
                    MessageBox.Show("Корректно заполните данные");
                    return;
                }

                try
                {
                    double.Parse(cost);
                    int.Parse(quantity);
                } catch
                {
                    MessageBox.Show("Корректно укажите стоимость и количество");
                    return;
                }

                Books book = new Books
                {
                    Title = title,
                    Cost = double.Parse(cost),
                    Author = authorBox.Text,
                    Image = savedImageTitle,
                    Quantity = int.Parse(quantity),
                };

                booksProvider.CreateBook(book);

                MessageBox.Show("Сохранение выполнено успешно!");
                bookListForm.RefreshBooks();
                Hide();

        }
    }
}
