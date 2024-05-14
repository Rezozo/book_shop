using book_shop.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_shop.provider
{
    public class OrdersProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=books;User Id=postgres;Password=0987");

        public void CreateOrder(int userId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO orders VALUES (default, 1, {userId}, '{DateTime.Now}', '')", connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public void AddProductToOrder(int userId, int productId, int count)
        {
            connection.Open();
            var ordersCommand = new NpgsqlCommand($"SELECT id FROM orders WHERE client_id = {userId}", connection);
            var orderId = ordersCommand.ExecuteScalar();

            var validateCountCommand = new NpgsqlCommand($"SELECT quantity from books WHERE id = {productId}", connection);
            int quantity = (int) validateCountCommand.ExecuteScalar();
            if (quantity < count)
            {
                MessageBox.Show("Недостаточно товара на складе");
                return;
            }

            var existsCommand = new NpgsqlCommand($"SELECT COUNT(*) From books_orders WHERE book_id = {productId} AND order_id = {orderId}", connection);
            var countOfRows = (long) existsCommand.ExecuteScalar();
            if (countOfRows > 0)
            {
                var command = new NpgsqlCommand($"UPDATE books_orders SET quantity = {count} WHERE book_id = {productId} AND order_id = {orderId}", connection);
                command.ExecuteNonQuery();
            } else
            {
                var command = new NpgsqlCommand($"INSERT INTO books_orders VALUES({productId}, {orderId}, {count})", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteBookFromOrder(int orderId, int bookId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM books_orders WHERE book_id = {bookId} AND order_id = {orderId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void ChangeStatus(Orders orders)
        {
            connection.Open();
            var statusCommand = new NpgsqlCommand($"SELECT id FROM order_status WHERE status LIKE '%{orders.Status}%'", connection);
            var status = (int) statusCommand.ExecuteScalar();

            var command = new NpgsqlCommand($"UPDATE orders SET status_id = {status}, address = '{orders.Address}', " +
                $"comment = '{orders.Comment}' WHERE id = {orders.Id}", connection); 
            command.ExecuteNonQuery();

            connection.Close();
        }

        public List<Orders> GetAllOrders()
        {
            List<Orders> ordersList = new List<Orders>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT o.id, os.status, o.created_date, o.address, u.id, u.full_name, o.comment FROM orders o " +
                "INNER JOIN order_status os ON os.id = o.status_id " +
                "INNER JOIN users u ON o.client_id = u.id", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Orders orders = new Orders();
                orders.Id = reader.GetInt32(0);
                orders.Status = reader.GetString(1);
                orders.CreatedDate = reader.GetDateTime(2);
                if (reader[3] != DBNull.Value)
                {
                    orders.Address = reader[3].ToString();
                }
                orders.user = new User
                {
                    Id = reader.GetInt32(4),
                    Name = reader.GetString(5),
                };
                if (reader[6] != DBNull.Value)
                {
                    orders.Comment = reader.GetString(6);
                }
                ordersList.Add(orders);
            }
            reader.Close();

            foreach (var order in ordersList)
            {
                List<BooksOrder> booksOrders = new List<BooksOrder>();
                var bookCommand = new NpgsqlCommand("SELECT bo.quantity, b.title, b.cost, b.image, b.id from books_orders bo " +
                    $"INNER JOIN books b ON b.id = bo.book_id WHERE bo.order_id = {order.Id}", connection);
                var reader1 = bookCommand.ExecuteReader();
                while (reader1.Read())
                {
                    BooksOrder booksOrder = new BooksOrder();
                    booksOrder.Quantity = reader.GetInt32(0);
                    booksOrder.Books = new Books
                    {
                        Title = reader.GetString(1),
                        Cost = reader.GetDouble(2),
                        Image = reader.GetString(3),
                        Id = reader.GetInt32(4)
                    };
                    booksOrders.Add(booksOrder);
                }
                order.Books = booksOrders;
                reader1.Close();
            }
            
            connection.Close();

            return ordersList;
        }

        public Orders GetOrder(User user) 
        {
            Orders orders = new Orders();
            connection.Open();
            var command = new NpgsqlCommand($"SELECT o.id, os.status, o.created_date, o.address, o.comment FROM orders o " +
                $"INNER JOIN order_status os ON os.id = o.status_id WHERE o.client_id = {user.Id}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                orders.Id = reader.GetInt32(0);
                orders.Status = reader.GetString(1);
                orders.CreatedDate = reader.GetDateTime(2);
                if (reader[3] != DBNull.Value)
                {
                    orders.Address = reader[3].ToString();
                }
                if (reader[4] != DBNull.Value)
                {
                    orders.Comment = reader.GetString(4);
                }
            }
            reader.Close();
            orders.user = user;

            List<BooksOrder> booksOrders = new List<BooksOrder>();
            var bookCommand = new NpgsqlCommand("SELECT bo.quantity, b.title, b.cost, b.image, b.id from books_orders bo " +
                $"INNER JOIN books b ON b.id = bo.book_id WHERE bo.order_id = {orders.Id}", connection);
            var reader1 = bookCommand.ExecuteReader();
            while (reader1.Read())
            {
                BooksOrder booksOrder = new BooksOrder();
                booksOrder.Quantity = reader.GetInt32(0);
                booksOrder.Books = new Books
                {
                    Title = reader.GetString(1),
                    Cost = reader.GetDouble(2),
                    Image = reader.GetString(3),
                    Id = reader.GetInt32(4)
                };
                booksOrders.Add(booksOrder);
            }
            orders.Books = booksOrders;
            reader1.Close();

            connection.Close();
            return orders;
        }
    }
}
