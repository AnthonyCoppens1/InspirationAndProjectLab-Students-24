using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPSA
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

        public Bookstore(string name, string address, List<Book> inventory, List<Person> people)
        {
            Name = name;
            Address = address;
            Inventory = inventory;
            People = people;
        }

        public void AddBook(Book b)
        {
            Inventory.Add(b);
        }

        public void RemoveBook(Book b)
        {
            Inventory.Remove(b);
        }

        public void AddPerson(Person p)
        {
            People.Add(p);
        }

        public List<Staff> GetStaff()
        {
            List<Staff> staffmembers = new List<Staff>();
            foreach (Person p in People)
            {
                if (p is Staff)
                {
                    staffmembers.Add((Staff)p);
                }
            }
            return staffmembers;
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


        public override string ToString()
        {
            string s = $"Bookstore {Name} in {Address}\n";
            s += $"Inventory count: {Inventory.Count}\n";
            foreach (Book b in Inventory)
            {
                s += $"{b}\n";
            }

            s += $"You have this amount of customers: {GetCustomers().Count} and they are:\n";
            foreach (Customer c in GetCustomers())
            {
                s += $"{c}\n";
            }

            s += $"These are the staff members:\n";
            foreach (Staff st in GetStaff())
            {
                s += $"{st}\n";
            }

            return s;
        }

    }
}
