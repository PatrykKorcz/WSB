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
            Console.Title = "modyfikacja konsoli"; //zmiana tytułu konsoli
            Console.WriteLine("WSB");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WSB");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tWSB");
            Console.ResetColor();
            Console.WriteLine("WSB");
      

        



            Console.ReadKey();
        }
    }
}
