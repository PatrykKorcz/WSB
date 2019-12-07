using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("WSB");

            first_name.namespace_1 ob = new first_name.namespace_1();  

            Console.ReadKey();
        }
    }
}

namespace first_name
{
    class namespace_1
    {
        public void Show() {

            Console.WriteLine("Pierwsza przestrzen nazw");
            }
    }
}

namespace second_name
{
    class namespace_1
    {
        public void Show()
        {

            Console.WriteLine("Pierwsza przestrzen nazw");
        }
    }
}
