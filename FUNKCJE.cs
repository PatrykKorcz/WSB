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
            //add(2, 3);

            int c = 5;
            int d = 10;

            Add(c, d);
            Add(c, d, 5);
            Console.WriteLine("Pole kwadratu wynosi: {0}", SquareArea(10));
            Console.WriteLine("wynik: {0}", Add(1, 2, c = 1, d = 2));
            Data("Janusz");
           

            Console.ReadKey();

        }
        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("wynik dodawania: {0} ", result);

        }

        static void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("wynik dodawania: {0}", result);
        }

        static int SquareArea(int a)
        {
            return a * a;
        }

        static int Add(int c, int d, int a = 5, int b = 10)
        {
            return a + b + c + d;
        }

        static void Data(string name, string surname="Nowak", int age = 30)
        {
            Console.WriteLine("Imie {0}, nazwisko {1}, wiek {2} ", name, surname, age);
        }
    }
}
