using System;

namespace Bookstore_DSPSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book TTT = new Book("Tutu the turtle", "Anthony Coppens", 5.99, 2);
            TTT.AddGenre(Type.Adventure);
            TTT.AddGenre(Type.Horror);

            Customer Denzel = new Customer("Denzel Washington", new DateOnly(1958, 02, 12),
                "denzelthebeast@yahoor.us", "616-2347-897");
            Customer Kendrick = new Customer("Kendrick Lamar", new DateOnly(1987, 06, 17),
                "drakelover@hotmail.com", "+326789471");

            Staff Vladimir = new Staff("Vladimir Putin", new DateOnly(1952, 12, 13), Position.StoreManager);
            Staff Selena = new Staff("Selena Gomez", new DateOnly(1992, 11, 02), Position.BookCoverPainter);

            Book HPATSS = new Book("Harry Potter and the Sorcerer's Stone", "JK Rowling", 21.99, 205);
            HPATSS.AddGenre(Type.Fantasy);
            HPATSS.AddGenre(Type.Fiction);

            Book FinanceIsFun = new Book("Finance is fun!", "Vera Smets", 35.01, 14);
            FinanceIsFun.AddGenre(Type.Horror);

            Bookstore BadBoyBooks = new Bookstore("Bad Boy Books", "Mechelen");
            BadBoyBooks.AddPerson(Denzel);
            BadBoyBooks.AddPerson(Kendrick);
            BadBoyBooks.AddPerson(Vladimir);
            BadBoyBooks.AddPerson(Selena);

            BadBoyBooks.AddBook(TTT);
            BadBoyBooks.AddBook(HPATSS);
            BadBoyBooks.AddBook(FinanceIsFun);

            Console.WriteLine(BadBoyBooks);




        }
    }
}
