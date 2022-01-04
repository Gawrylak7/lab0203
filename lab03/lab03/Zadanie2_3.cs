using System;
using System.Collections.Generic;

namespace lab03
{
    public class Zadanie2_3 : IZadanie2_3
    {
        public  List<IOsoba> List;

        public void wypiszOsoby()
        {
            foreach (IOsoba osoba in List)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }
        public void PosortujOsobyPoNazwisku()
        {
            List.Sort((nr1, nr2) => String.CompareOrdinal(nr1.nazwisko, nr2.nazwisko));
        }
      

    }
}
