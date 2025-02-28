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
        public List<Type> Genres { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int Stock { get; set; }

        public Boek(string naam, string auteur, double prijs, int stock)
        {
            Naam = naam;
            Auteur = auteur;
            Genres = new List<Type>();
            Prijs = prijs;
            Stock = stock;
        }

        public void VoegGenreToe(Type t)
        {
            Genres.Add(t);
        }

        public override string ToString()
        {
            string s = $"Boek: {Naam} - {Auteur} - {Prijs} - ";
            foreach (Type t in Genres)
            {
                s += $"{t} ";
            }
            return s;
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


    public class Boekenwinkel
    {
        public string Naam { get; set; }
        public string Adres { get; set; }
        private List<Boek> Boeken { get; set; }
        private List<Persoon> Mensen { get; set; }

        public Boekenwinkel(string naam, string adres)
        {
            Naam = naam;
            Adres = adres;
            Boeken = new List<Boek>();
            Mensen = new List<Persoon>();
        }

        public Boekenwinkel(string naam, string adres, List<Boek> boeken, List<Persoon> mensen)
        {
            Naam = naam;
            Adres = adres;
            Boeken = boeken;
            Mensen = mensen;
        }

        public void VoegBoekToe(Boek b)
        {
            Boeken.Add(b);
        }

        public void VerwijderBoek(Boek b)
        {
            Boeken.Remove(b);
        }

        public void VoegPersoonToe(Persoon t)
        {
            Mensen.Add(t);
        }

        public List<Klant> ZoekKlanten()
        {
            List<Klant> klanten = new List<Klant>();
            foreach (Persoon p in Mensen)
            {
                if (p is Klant)
                {
                    klanten.Add((Klant)p);
                }
            }
            return klanten;
        }

        public List<Personeel> ZoekPersoneel()
        {
            List<Personeel> werkers = new List<Personeel>();
            foreach (Persoon p in Mensen)
            {
                if (p is Personeel)
                {
                    werkers.Add((Personeel)p);
                }
            }
            return werkers;
        }

        public override string ToString()
        {
            string s = $"Boekenwinkel {Naam} in {Adres}\n\n";
            s += $"Hoeveelheid unieke boeken: {Boeken.Count}\n";
            foreach (Boek b in Boeken)
            {
                s += $"{b}\n";
            }

            s += $"Aantal klanten: {ZoekKlanten().Count} en dit zijn:\n";
            foreach (Klant k in ZoekKlanten())
            {
                s += $"{k}\n";
            }
            
            foreach (Personeel p in ZoekPersoneel())
            {
                s += $"{p}\n";
            }

            return s;
        }

    }


}
