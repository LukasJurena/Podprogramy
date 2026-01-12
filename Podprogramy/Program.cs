using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podprogramy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pass by value - předávání hodnotou
            VypisTextu("Ahoj, tady vypisuji text přes proceduru.");

            //pass by value - předávání hodnotou
            int a = 5;
            int b = 10;
            int soucet = SectiCisla(a, b);
            Console.WriteLine($"Součet čísel {a} a {b} je {soucet}");

            //pass by reference - předávání odkazem
            int vek = 16;
            if (JePlnolety(ref vek))
            {
                Console.WriteLine($"Osoba je plnoletá. Aktuální věk: {vek}");
            }
            else
            {
                Console.WriteLine($"Osoba není plnoletá. Aktuální věk: {vek}");
            }

            Console.ReadLine();
            Console.ReadLine();
        }
        //procedura - nevrací hodnotu
        static void VypisTextu(string text)
        {
            Console.WriteLine(text);
        }
        //funkce - vrací hodnotu
        static int SectiCisla(int a, int b)
        {
            return a + b;
        }
        //funkce - vrací hodnotu
        static bool JePlnolety(ref int vek)
        {
            if (vek < 18)
            {
                return false;
            }
            return true;
        }
    }
}
