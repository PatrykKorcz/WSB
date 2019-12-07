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
            uint number = 0;
            string x;

            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                x = Console.ReadLine();

                try
                {
                    number = uint.Parse(x);
                    break;
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error: {0}", e.Message);
                    Console.ResetColor();
                }


            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Liczba całkowita: {0}", number);


            Console.ReadKey();
        }
    }
}
