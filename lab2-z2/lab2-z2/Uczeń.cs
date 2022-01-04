namespace lab2_z2
{
    public class Uczen : Osoba
    {
        private string szkola;
        private bool mozeSamWracacDoDomu;

        public void SetSchool(string szkola2)
        {
            this.szkola = szkola2;
        }
        public void ChangeSchool(string szkola2)
        {
            SetSchool(szkola2);  
        }
        public void SetCanGoHomeAlone(bool moze)
        {
            mozeSamWracacDoDomu = moze;
        }
        public override string GetEducationInfo()
        {
            return szkola;
        }
        public override bool CanGoAloneToHome()
        {
            return mozeSamWracacDoDomu;
        }
    }
}
