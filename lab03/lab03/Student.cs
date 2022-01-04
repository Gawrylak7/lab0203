namespace lab03
{
    public  class Student : IStudent
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string ZwrocPelnaNazwe()
        {
            return this.imie + " " + this.nazwisko;
        }

        public string uczelnia { get; set; }
        public string kierunek { get; set; }
        public int rok { get; set; }
        public int semestr { get; set; }

        public virtual string WypiszPelnaNazweOUczelni()
        {
            return ZwrocPelnaNazwe() + " - "  + kierunek +" "+ rok +" "+ uczelnia + semestr + "  ";
        }

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.uczelnia = uczelnia;
            this.kierunek = kierunek;
            this.rok = rok;
            this.semestr = semestr;
        }
    }
}
