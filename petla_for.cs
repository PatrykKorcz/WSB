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
            /*


             int suma = 0;
             for (int i = 1; i <= 10; i++)
             {
                 if (i % 2 != 0)
                 {


                     suma += i;

                 }
             }
                 Console.Write("suma wynosi: {0}", suma);
            */

            // napisz program ktory wyswietli od A do Z i od Z do A

            /*
            


            char znak = 'A';
                for (;znak <= 'Z'; znak++)
            {
                Console.Write("{0}, ", znak);
            }
            Console.WriteLine();
            char znak1 = 'Z';
            for (;znak1 >= 'A'; znak1--)
            {
                Console.Write("{0}, ", znak1);
            }

            */

            //napisz program ktroy za pomoca instrukcji while dla danych wartosci x zmieniajacych sie w przedziale
            //od 0 do 10 oblicza wartosc funkcji y = 4x




            /*
            int y = 0;
            int x = 0;

            while(x <= 10)
            {
                y = 4 * x;
                Console.WriteLine("y = {0}\t x = {1}", y, x);
                x++;
            }
            */


            //napisz program  ktory za pmooca instrukcji while dla danych wartosci x z przeczialu od 1 do 50 obliczy ich sume



            /*
            int suma = 0;
            int x = 1;
            while(x <= 50)
            {
                suma = suma + x;
                x++;

            }
            

            Console.WriteLine("suma {0}", suma);
            */


            //uzutkownik podaje swoj wiek z klawiatury przedzial zamienity od 1 do 120/ wykorzystaj do while do prawidlowego podania danych
            //




            /*
            string wiek;
            bool error = false;
            uint age;
            do
            {
                Console.WriteLine("Podaj swoj wiek");
                wiek = Console.ReadLine();
                if (uint.TryParse(wiek, out age) == false)
                {
                    error = true;
                }
                else
                {
                    error = false;
                }
            }
            while (age < 1 || age > 120);
            {
                Console.WriteLine("wiek: {0}", wiek);

            }
            */





            Console.ReadKey();    
        } 
    }

}
