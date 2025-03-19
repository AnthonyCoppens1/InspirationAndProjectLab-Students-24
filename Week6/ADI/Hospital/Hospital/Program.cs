using System;
using System.Numerics;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Patient Anthony = new Patient("Anthony", new DateOnly(1995, 07, 31), "Teacher Syndrome");
            Doctor Jenny = new Doctor("Jenny", new DateOnly(1970, 1, 1), "Heart");
            Patient Elke = new Patient("Elke", new DateOnly(1980, 4, 23), "Teacher Syndrome");
            Patient Collin = new Patient("Collin", new DateOnly(1991, 3, 16), "FullStackDev Syndrome");
            Nurse Josh = new Nurse("Josh", new DateOnly(2000, 1, 1), Area.Emergency);
            Doctor Jacob = new Doctor("Jacob", new DateOnly(1967, 11, 18), "HULP");
            Nurse N = new Nurse("N", new DateOnly(1999, 10, 5), Area.Surgery);

            List<Person> people = new List<Person>();
            people.Add(Anthony);
            people.Add(Elke);
            people.Add(Collin);
            people.Add(Jenny);
            people.Add(Josh);
            people.Add(Jacob);
            people.Add(N);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Hospital hospital = new Hospital("AZ Sint-Maarten", people);
            Doctor bea = new Doctor("Bea", new DateOnly(1960, 1, 1), "Dermatology");
            hospital.AddPerson(bea);
            Console.WriteLine(hospital);


        }
    }
}