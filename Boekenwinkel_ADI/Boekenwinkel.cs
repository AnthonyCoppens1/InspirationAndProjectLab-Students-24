using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel_ADI
{
    public class Boek
    {
        public string Auteur { get; set; }
        public Type Genre { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int Stock { get; set; }

        public Boek(string naam, string auteur, Type genre, double prijs, int stock)
        {
            Naam = naam;
            Auteur = auteur;
            Genre = genre;
            Prijs = prijs;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Boek: {Naam} - {Auteur} - {Prijs}";
        }
    }

    public enum Type
    {
        Misdaad,
        Avontuur,
        Romantiek,
        Horror,
        Thriller,
        Fictie
    }
}
