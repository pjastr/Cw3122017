using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figury = new List<Figura>();
            figury.Add(new Trojkat(3, 4, 5));
            figury.Add(new Kwadrat(5));
            foreach(var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
