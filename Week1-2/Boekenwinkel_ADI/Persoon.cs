using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel_ADI
{
    public class Persoon
    {
        public string Naam { get; set; }
        public DateOnly Geboortedatum { get; set; }

        public Persoon(string naam, DateOnly geboortedatum)
        {
            Naam = naam;
            Geboortedatum = geboortedatum;
        }

        public override string ToString()
        {
            return $"{Naam}";
        }
    }

    public class Klant: Persoon
    {
        public string Email { get; set; }
        public string Telefoon { get; set; }

        public Klant(string naam, DateOnly geboortedatum, string email, string telefoon) : base(naam, geboortedatum)
        {
            Email = email;
            Telefoon = telefoon;
        }

        public override string ToString()
        {
            return $"Klant: {Naam} - {Geboortedatum} - {Email} - {Telefoon}";
        }
    }

    public class Personeel: Persoon
    {
        public Job Functie { get; set; }

        public Personeel(string naam, DateOnly geboortedatum, Job functie): base(naam, geboortedatum)
        {
            Functie = functie;
        }

        public override string ToString()
        {
            return $"Personeel: {Naam} - {Functie}";
        }

    }

    public enum Job
    {
        StoreManager,
        Stagiair,
        Verkoper,
        Interim,
        Concierge,
        CEO
    }

}
