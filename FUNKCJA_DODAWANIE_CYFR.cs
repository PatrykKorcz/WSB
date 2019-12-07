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
            // FUNKCJA KTORA DODAJE CYFRY W LICZBIE


            Console.WriteLine("wynik: {0}",Sum(324));
            Console.ReadKey();
        }
        static int Sum(int x)
        {
            int result = 0;
            do
            {
                result = result + x % 10;
                x = x / 10;

            }
            while (x != 0);
            return result;
        }

    } 
}

