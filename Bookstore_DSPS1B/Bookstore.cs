using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1B
{
    public class Bookstore
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Book> Inventory { get; set; }
        private List<Person> People { get; set; }

        public Bookstore(string name, string address)
        {
            Name = name;
            Address = address;
            Inventory = new List<Book>();
            People = new List<Person>();
        }

        /*second constructor because the first one only allows us to create a brand new bookstore
         * with no existing customers or staffmembers yet.
         * Second one is of an existing bookstore that would for example merge, with
         * existing inventory, customers and staffmembers*/
        public Bookstore(string name, string address, List<Book> inventory, List<Person> people)
        {
            Name = name;
            Address = address;
            Inventory = inventory;
            People = people;
        }

        public void AddBook(Book book)
        {
            Inventory.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Inventory.Remove(book);
        }

        public List<Staff> GetStaff()
        {
            List<Staff> staffMembers = new List<Staff>();
            foreach (Person p in People)
            {
                if (p is Staff)
                {
                    staffMembers.Add((Staff)p);
                }
            }
            return staffMembers;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> clients = new List<Customer>();
            foreach (Person p in People)
            {
                if (p is Customer)
                {
                    clients.Add((Customer)p);
                }
            }
            return clients;
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public override string ToString()
        {
            string s = $"Bookstore {Name} at {Address}\n";
            s += $"Amount of different books: {Inventory.Count}\n";
            foreach (Book book in Inventory)
            {
                s += $"{book}\n";
            }

            s += $"{GetCustomers().Count}\n";
            foreach (Customer c in GetCustomers())
            {
                s += $"{c}\n";
            }

            s += $"{GetStaff().Count}\n";
            foreach (Staff staff in GetStaff())
            {
                s += $"{staff}\n";
            }

            return s;

        }



    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public List<Type> Genres { get; set; }

        public Book(string title, string author, double price, int stock)
        {
            Title = title;
            Author = author;
            Price = price;
            Stock = stock;
            Genres = new List<Type>();
        }

        public void AddGenre(Type selectedGenre)
        {
            Genres.Add(selectedGenre);
        }

        public override string ToString()
        {
            string output = $"Book:\n- {Title}\n- {Author}\n- {Price}\n- {Stock}\n- ";
            foreach (Type T in Genres)
            {
                output = output + T + " ";
            }
            return output;
        }

    }

    public enum Type
    {
        Fantasy,
        Thriller,
        Fiction,
        NonFiction,
        Adventure,
        Romance,
        Horror,
        Comedy,
        Poetry,
        Detective,
        ShortStory,
        SelfHelp
    }
}
