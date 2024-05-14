using book_shop.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_shop.provider
{
    public class UserProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=books;User Id=postgres;Password=0987");

        public bool ExistsUser(string login)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT u.id, r.title, u.full_name, u.email, u.password " +
                $"FROM users u " +
                $"INNER JOIN role r ON r.id = u.role_id WHERE u.email = '${login}'", connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;
            }
            else
            {
                reader.Close();
                connection.Close();
                return false;
            }
        }


        public User GetUser(string login, string password)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT u.id, r.title, u.full_name, u.email, u.password " +
                $"FROM users u " +
                $"INNER JOIN role r ON r.id = u.role_id WHERE u.email = '{login}' AND u.password = '{password}'", connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32(0),
                    Role = reader.GetString(1),
                    Name = reader.GetString(2),
                    Email = reader.GetString(3),
                    Password = reader.GetString(4),
                };
                reader.Close();
                connection.Close();
                return user;
            } else
            {
                reader.Close();
                connection.Close();
                return null;
            }
        }

        public User GetUser(int id)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT u.id, r.title, u.full_name, u.email, u.password " +
                $"FROM users u " +
                $"INNER JOIN role r ON r.id = u.role_id WHERE u.id = {id}", connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32(0),
                    Role = reader.GetString(1),
                    Name = reader.GetString(2),
                    Email = reader.GetString(3),
                    Password = reader.GetString(4),
                };
                reader.Close();
                connection.Close();
                return user;
            }
            else
            {
                reader.Close();
                connection.Close();
                return null;
            }
        }

        public int CreateUser(string name, string email, string password)
        {
            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO users VALUES (default, 1, '{name}', '{email}', '{password}') RETURNING id", connection);
            int id = (int) command.ExecuteScalar();
            connection.Close();
            return id;
        }
    }
}
