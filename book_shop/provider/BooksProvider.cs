using book_shop.models;
using Npgsql;
using System.Collections.Generic;

namespace book_shop.provider
{
    public class BooksProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=books;User Id=postgres;Password=0987");

        public List<Books> GetAllBooks()
        {
            List<Books> list = new List<Books>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT b.id, a.author, b.title, b.cost, b.quantity, b.image from books b " +
                "INNER JOIN author a ON a.id = b.author_id;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Books book = new Books();
                book.Id = reader.GetInt32(0);
                book.Author = reader.GetString(1);
                book.Title = reader.GetString(2);
                book.Cost = reader.GetDouble(3);
                book.Quantity = reader.GetInt32(4);
                book.Image = reader.GetString(5);
                list.Add(book);
            }
            connection.Close();
            return list;
        }

        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT a.author FROM author a", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                authors.Add(reader.GetString(0));
            }

            connection.Close();
            return authors;
        }

        public void CreateBook(Books books)
        {
            connection.Open();
            var commandAuthor = new NpgsqlCommand($"SELECT a.id FROM author a WHERE a.author LIKE '%{books.Author}%' ", connection);
            var authorId = (int) commandAuthor.ExecuteScalar();

            var insertCommand = new NpgsqlCommand($"INSERT INTO books VALUES (default, {authorId}, '{books.Title}', {books.Cost}," +
                $" {books.Quantity}, '{books.Image}')", connection);
            insertCommand.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteBook(int bookId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM books WHERE id = {bookId}", connection); 
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
 