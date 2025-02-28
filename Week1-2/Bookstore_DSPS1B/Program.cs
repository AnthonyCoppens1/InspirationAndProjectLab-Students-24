using System;

namespace Bookstore_DSPS1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book HPATSS = new Book("Harry Potter and the Sorcerer's Stone", "JK Rowling", 21.99, 2);
            HPATSS.AddGenre(Type.Horror);
            HPATSS.AddGenre(Type.Comedy);
            HPATSS.AddGenre(Type.Fantasy);
            HPATSS.AddGenre(Type.NonFiction);

            Console.WriteLine(HPATSS);

            Book TTT = new Book("Tutu the turtle", "Pascal", 8.99, 60);
            TTT.AddGenre(Type.Adventure);
            TTT.AddGenre(Type.Horror);

            Book LK = new Book("The Lion King", "Justine Korman", 11.99, 28);
            LK.AddGenre(Type.Romance);

            Customer Radish = new Customer("Radish shidar", new DateOnly(1988,03, 05), 
                "radishshidar@yahoo.be", "+324789241");
            Customer Brocoli = new Customer("Brocoli bob", new DateOnly(2001, 01, 01), "MRBB@hotmail.com", "/");
            Customer RiceBeans = new Customer("Rice Bean Soy Man", new DateOnly(2009, 11, 19), "/", "+324217890");

            Staff A = new Staff("A", new DateOnly(2017, 8, 19), Position.Concierge);
            Staff B = new Staff("B", new DateOnly(2005, 2, 19), Position.Sales);
            Staff C = new Staff("C", new DateOnly(2000, 5, 12), Position.CEO);

            Bookstore BestBook = new Bookstore("Best Books", "Mechelen");
            BestBook.AddPerson(Radish);
            BestBook.AddPerson(Brocoli);
            BestBook.AddPerson(RiceBeans);
            BestBook.AddPerson(A);
            BestBook.AddPerson(B);
            BestBook.AddPerson(C);

            BestBook.AddBook(TTT);
            BestBook.AddBook(LK);
            BestBook.AddBook(HPATSS);

            Console.WriteLine(BestBook);

        }
    }
}
