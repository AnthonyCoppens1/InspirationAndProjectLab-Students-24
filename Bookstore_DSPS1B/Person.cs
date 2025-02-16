using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1B
{
    public class Person
    {
        public string Name { get; set; }
        protected DateOnly Birthday { get; set; }

        public Person(string name, DateOnly birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{Name} - {Birthday}";
        }
    }

    public class Customer: Person
    {
        public string Email { get; set; }
        protected string Phonenumber { get; set; }

        public Customer(string name, DateOnly birthday, string email, string phone): base(name, birthday)
        {
            Email = email;
            Phonenumber = phone;
        }

        public override string ToString()
        {
            return $"Customer: {Name} - {Birthday}";
        }
    }

    public class Staff: Person
    {
        public Position Job { get; set; }

        public Staff(string name, DateOnly birthday, Position job) : base(name, birthday)
        {
            Job = job;
        }

        public override string ToString()
        {
            return $"Staff: {Name} - {Birthday} - {Job}";
        }
    }

    public enum Position
    {
        Sales,
        Manager,
        StoreManager,
        CEO,
        Concierge
    }
}
