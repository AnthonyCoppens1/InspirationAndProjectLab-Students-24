using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPSA
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Type Genre { get; set; }
        public int Stock { get; set; }

        public Book(string name, string author, double price, Type genre, int stock)
        {
            Name = name;
            Author = author;
            Price = price;
            Genre = genre;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Name} - {Author} - {Price}";
        }

    }

    public enum Type
    {
        Fiction,
        Fantasy,
        Thriller,
        Adventure,
        Horror,
        Romance
    }
}
