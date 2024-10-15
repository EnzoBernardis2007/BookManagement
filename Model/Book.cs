using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookManagement.Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime? ReleaseDate {  get; set; }
        public int Quantity { get; set; }

        public Book(string name, string author, DateTime? releaseDate, int quantity)
        {
            Name = name;
            Author = author;
            ReleaseDate = releaseDate;
            Quantity = quantity;
        }
    }
}
