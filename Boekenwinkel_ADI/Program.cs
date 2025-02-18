using System;

namespace Boekenwinkel_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Klant Pommelien = new Klant("Pommelien Thijs", new DateOnly(2000, 08, 23),
                "pommeliendezange@yahoo.be", "+324789314");
            Klant Trump = new Klant("Donald Trump", new DateOnly(1955, 01, 09),
                "MakeAmericaGreatAgain@starlink.com", "616-7834-5289");
            Klant Elon = new Klant("Elon Musk", new DateOnly(1978, 03, 22),
                "PresidentInDisguise@space.gov", "can't reach me LOL");

            Personeel Anthony = new Personeel("Anthony", new DateOnly(1987, 11, 16), Job.Concierge);
            Personeel Celine = new Personeel("Celine c", new DateOnly(1999, 12, 12), Job.CEO);

            Boek TTT = new Boek("Timmy the Turtle", "Ikzelf", 9.99, 603);
            TTT.VoegGenreToe(Type.Horror);
            TTT.VoegGenreToe(Type.Avontuur);

            Boek HPEDSDW = new Boek("Harry Potter en die ene steen", "Die ene britse", 2.35, 10);
            HPEDSDW.VoegGenreToe(Type.Romantiek);

            Boekenwinkel BadBoyBooks = new Boekenwinkel("Bad Boy Books", "Mechelen");
            BadBoyBooks.VoegPersoonToe(Pommelien);
            BadBoyBooks.VoegPersoonToe(Trump);
            BadBoyBooks.VoegPersoonToe(Elon);
            BadBoyBooks.VoegPersoonToe(Anthony);
            BadBoyBooks.VoegPersoonToe(Celine);
            BadBoyBooks.VoegBoekToe(TTT);
            BadBoyBooks.VoegBoekToe(HPEDSDW);

            Console.WriteLine(BadBoyBooks);
        }
    }
}
