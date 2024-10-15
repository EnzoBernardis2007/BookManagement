using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfBookManagement.Model;

namespace WpfBookManagement.Prefab
{
    internal class DatabaseManagement
    {
        public static void AddBook(Book book)
        {
            using (MySqlConnection connection = ConnectionFactory.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Book (BookName, Author, ReleaseDate, Quantity) " +
                        "VALUES (@BookName, @Author, @ReleaseDate, @Quantity)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", book.Name);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@ReleaseDate", book.ReleaseDate.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Quantity", book.Quantity);

                        int result = command.ExecuteNonQuery();

                        if (result == 0) MessageBox.Show($"Erro no banco de dados ao inserir o novo livro no banco de dados.");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Erro no código ao inserir o novo livro no banco de dados: {ex.Message}");
                }
            }
        }
    }
}