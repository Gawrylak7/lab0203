using System;
using System.Collections.ObjectModel;

namespace lab2_z2
{
    public class Nauczyciel : Uczen
    {
        private string tytulNaukowy;
        private Collection<Uczen> podwladniUczniowie;
        public void whichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            foreach (Uczen uczniowie in podwladniUczniowie)
            {
                if (uczniowie.GetAge(dateToCheck) > 12 || uczniowie.CanGoAloneToHome())
                {
                    Console.WriteLine(uczniowie.GetFullName()); 
                }
            }
        }
    }
}
