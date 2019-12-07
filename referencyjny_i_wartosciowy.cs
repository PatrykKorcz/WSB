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
            //tryb wartosciowy

            int a = 10;
            int b = a;

            a--;
            b++;

            Console.WriteLine(a);

            Console.WriteLine(b);

            //tryb referencyjny

            int[] tabA = { 1, 2, 3 };
            int[] tabB = tabA;

            tabA[0] = 100;
            tabB[1] = 200;
            

            Console.WriteLine("tabA");
            foreach (int item in tabA)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("tabB");
            foreach (int item in tabB)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            string text1 = "10";
            string text2 = text1;

            text1 += "janusz";
            Console.WriteLine(text1); //10janusz
            Console.WriteLine(text2); //10
;




            Console.ReadKey();
        }
    }
}
