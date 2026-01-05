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
            VypisTextu("Ahoj, tady vypisuji text přes proceduru.");

            int a = 5;
            int b = 10;
            int soucet = SectiCisla(a, b);
            Console.WriteLine($"Součet čísel {a} a {b} je {soucet}");

            int vek = 20;
            if (JePlnolety(vek))
            {
                Console.WriteLine($"Osoba, která má {vek} je plnoletá.");
            }
            else
            {
                Console.WriteLine($"Osoba, která má {vek} let není plnoletá.");
            }
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
        static bool JePlnolety(int vek)
        {
            if (vek >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
