namespace lab03
{
    public class StudentUR : Student
    {
        public StudentUR(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr) : base(imie, nazwisko, uczelnia, kierunek, rok, semestr)
        {
        }

        public override string WypiszPelnaNazweOUczelni()
        {
            return base.WypiszPelnaNazweOUczelni();
        }
    }
}
