using System;
using System.Numerics;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Person Anthony = new Person();
            Console.WriteLine(Anthony.Name + " " + Anthony.Role);*/

            /*Person Bert = new Person("Bert", new DateOnly(2001, 02, 25), "Doctor");
            Console.WriteLine(Bert.Name + " " + Bert.Birth + " " + Bert.Role);

            Person Anthony = new Person("Anthony", new DateOnly(1995, 7, 31), "Patient");
            Person Collin = new Person("Collin", new DateOnly(1991, 4, 16), "Patient");
            Person Elke = new Person("Elke", new DateOnly(1980, 4, 23), "Patient");
            Person Jenny = new Person("Jenny", new DateOnly(1970, 1, 1), "Doctor");
            Person Josh = new Person("Josh", new DateOnly(2000, 1, 1), "Nurse");
            Person John = new Person();

            Console.WriteLine(Anthony.Name);
            Console.WriteLine($"{Jenny.Name}: {Jenny.Role}");
            Console.WriteLine(Collin.Role);
            Console.WriteLine(Josh.Name + " " + Josh.Role); //JOSH

            Console.WriteLine(John.Name + " " + John.Role);//JOHN
            John.Name = "Johanna";
            John.Role = "Doctor";
            Console.WriteLine(John.Name + " " + John.Role);

            //Anthony.Print();
            Console.WriteLine(Anthony.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Collin);
            Console.WriteLine(Elke);*/


            Patient Anthony = new Patient("Anthony", new DateOnly(1995, 07, 31), "Teacher Syndrome");
            //Doctor Jenny = new Doctor("Jenny", new DateOnly(1970, 1, 1), "Heart");
            Patient Elke = new Patient("Elke", new DateOnly(1980, 4, 23), "Teacher Syndrome");
            Patient Collin = new Patient("Collin", new DateOnly(1991, 3, 16), "FullStackDev Syndrome");
            //Nurse Josh = new Nurse("Josh", new DateOnly(2000, 1, 1), Area.Emergency);
            //Person John = new Person();

            Console.WriteLine(Anthony);
            Console.WriteLine(Elke);
            Console.WriteLine(Collin);

            /*Console.WriteLine(Anthony);
            Console.WriteLine(Jenny);
            Console.WriteLine(Elke);
            Console.WriteLine(Collin);
            Console.WriteLine(Josh);
            Console.WriteLine(John);*/

            /*List<Person> people = new List<Person>();
            people.Add(Anthony);
            people.Add(Elke);
            people.Add(Collin);
            people.Add(John);
            people.Add(Jenny);
            people.Add(Josh);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }*/

            /*Hospital hospital = new Hospital("AZ Sint-Maarten", people);
            Doctor bea = new Doctor("Bea", new DateOnly(1960, 1, 1), "Dermatology");
            hospital.AddPerson(bea);
            Console.WriteLine(hospital);*/


        }
    }
}