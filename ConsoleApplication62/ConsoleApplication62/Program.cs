using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication62
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba student1 = new Student();
            //student1.WypiszInfo();

            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba("Jan", "Kowalski"));
            osoby.Add(new Student("Zygmunt", "Nowak", 1, 2, 12345));

            foreach(var element in osoby)
            {
                Console.WriteLine(element.ToString());
            }

            Console.ReadKey();
        }
    }
}
