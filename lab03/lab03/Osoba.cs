using System;

namespace lab03
{
    public class Osoba : IOsoba
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }

        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
