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
        public List<Type> Genres { get; set; }
        public int Stock { get; set; }

        public Book(string name, string author, double price, int stock)
        {
            Name = name;
            Author = author;
            Price = price;
            Genres = new List<Type>();
            Stock = stock;
        }

        public void AddGenre(Type t)
        {
            Genres.Add(t);
        }

        public override string ToString()
        {
            string s = $"{Name} - {Author} - {Price} - ";
            foreach (Type t in Genres)
            {
                s += $"{t} ";
            }

            return s;
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
