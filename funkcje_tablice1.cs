using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("Wartosci tablicy przed wywołaniem funkcji: {0} {1}", tab[0], tab[1]);
            Tab(tab);
            Console.WriteLine("Wartosci tablicy po wywołaniu funkcji: {0} {1}", tab[0], tab[1]);
            ref ShowTab(tab);

            Console.ReadKey();
        }
        static void Tab(int[] tab)
        {
            tab = new int[2];
            tab[0] = 50;
            tab[1] = 100;

            Console.WriteLine("wartości wewnętrzne funkcji: {0} {1}", tab[0], tab[1]);

        }
        static void ShowTab(int[] tab)
        {
            Console.WriteLine("Elementy tablicy: ");
            foreach(int item in tab)
            {
                Console.WriteLine("{0} ",item);
            }
        }
    }
}
