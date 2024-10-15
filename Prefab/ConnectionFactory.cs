using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBookManagement.Prefab
{
    internal class ConnectionFactory
    {
        static readonly string path = "Server=localhost;Database=BookManagementDatabase;User Id=root;Password=";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(path);
                connection.Open();
                return connection;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro ao conectar com o banco de dados: {ex.Message}");
                return null;
            }
        }
    }
}
