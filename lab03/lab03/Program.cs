using System;
using System.Collections.Generic;

namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> list = new List<Osoba>();
            Osoba nr1 = new Osoba("Janina","Farelka");
            Osoba nr2 = new Osoba("Karol", "Bomba");
            Osoba nr3 = new Osoba("Jan", "Kowalski");
            list.Add(nr1);
            list.Add(nr2);  
            list.Add(nr3); 
            Console.WriteLine(list[0].ZwrocPelnaNazwe() + "\n " + list[1].ZwrocPelnaNazwe() + "\n " + list[2].ZwrocPelnaNazwe());

            List<StudentUR>list2=new List<StudentUR>();
            StudentUR urz1 = new StudentUR("Rafał", "Gawlak", "Uniwersytet Rzeszowski", "Informatyka", 2021, 3);
            list2.Add(urz1);
            Console.WriteLine(list2[0].WypiszPelnaNazweOUczelni());
        }
    }
}
