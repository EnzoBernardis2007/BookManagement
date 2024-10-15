using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfBookManagement.Model;
using WpfBookManagement.Prefab;

namespace WpfBookManagement.Tabs.Books
{
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book(NameField.Text, 
                AuthorField.Text, 
                ReleaseDateField.SelectedDate, 
                int.Parse(QuantityField.Text));

            DatabaseManagement.AddBook(newBook);
        }
    }
}
