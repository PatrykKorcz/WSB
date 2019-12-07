using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // NAPISZ PROGRAM KTORY SPRAWDZA CZY LICZBA CAŁKOWITA PODANA PRZEZ UZYTKOWNIKA JEST PARZYSTA / NIEPARZYSTA, 
            //NAPISZ FUNKCJE KTORA PRZYJMUJE JAKO ARGUMENT LICZBE PODANA PRZEZ UZYTKOWNIKA
            string liczba;
            int x;
            Console.WriteLine("Podaj Liczbe");
            liczba = Console.ReadLine();
            x = int.Parse(liczba);
            Console.WriteLine("{0}",Check(x));


            Console.ReadKey();
        }
        static string Check(int x)
        {
            if (x % 2 == 0)
            {
                return "Liczba parzysta";
            }
            else
            {
                return "Liczba nieparzysta";
            }

        }

    } 
}

