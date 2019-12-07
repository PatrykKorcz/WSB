using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pusta
{
    class Program
    {
        static void Main(string[] args)
        {
            int delta;
            int pierwiastek1;
            int pierwiastek2;

            Console.Write("Podaj liczbe a: ");
            string a = Console.ReadLine();

            Console.Write("Podaj liczbe b: ");
            string b = Console.ReadLine();

            Console.Write("Podaj liczbe c: ");
            string c = Console.ReadLine();

            delta = int.Parse(b) * int.Parse(b) - 4 * int.Parse(a) * int.Parse(c);

            Console.WriteLine("Twoje równanie: {0}x^2 + {1}x + {2} = 0", a, b, c);
            
            Console.WriteLine("Delta = "+delta);

            if (delta < 0)
            {
                Console.WriteLine("Delta mniejsza od 0, nie ma rozwiązań");
            }

            else
            {
                if (delta == 0) {

                    pierwiastek1 = -int.Parse(b) / 2 * int.Parse(a);
                    Console.WriteLine("Delta równa 0, x1 = {0}", pierwiastek1);

                                }
                else
                {
                    pierwiastek1 = (-int.Parse(b) - delta) / 2 * int.Parse(a);
                    pierwiastek2 = (-int.Parse(b) + delta) / 2 * int.Parse(a);
                    Console.WriteLine("Delta większa od 0, x1 = {0}\t x2 = {1}", pierwiastek1, pierwiastek2);
                }

            }


            Console.ReadKey();
        }
    }
}
