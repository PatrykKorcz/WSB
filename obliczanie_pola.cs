using System;


namespace _1_first
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: ");
            Console.WriteLine("Patryk");
            Console.WriteLine();
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");

            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "janusz";

            Console.WriteLine("\nMasz na imię: " + name);
            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię: {1}, wiek: {0}", age, name);

            sbyte age1 = 127;
            Console.WriteLine("Masz na imię: {1}, wiek1: {0}", age1, name);


            Console.Clear();
            /*
             * uzytkownik podaje dlugosc boku. oblicz pole kwadratu
             */

            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            //uzytkownik podaje liczbe z klawiatury

            string str;
            int liczba;

            Console.WriteLine("podaj liczbe:");
            str = Console.ReadLine();
            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("podales bledna liczba");

            }
            else
            {
                Console.WriteLine("liczba wynosi {0}", liczba);
            }



            /*
             * sprawdz czy dane podane z klawiatury sa liczba calkowita dodatnia
             * sprawdz czy liczba jest nieparzysta
             */

            Console.Clear();

            string str1;
            uint liczba1;

            Console.Write("Podaj liczbe calkowita dodatnia:");
            str1 = Console.ReadLine();

            if (uint.TryParse(str1, out liczba1) == true)
            {
                if (liczba1 % 2 != 0)
                {
                    Console.Write("Liczba {0} jest nieparzysta", liczba1);
                }
                else
                {
                    Console.Write("liczba {0} jest parzysta", liczba1);
                }
            }
            else
            {

                Console.WriteLine("podales bledna liczba: {0}", str1);
            }
            Console.Clear();


            byte age2 = 18;

            if (age2 == 18)
            {
                Console.WriteLine("Masz 18 lat");
            }
            else if (age2 < 18)
            {
                Console.WriteLine("jestes niepelnoletni");
            }
            else
            {
                Console.WriteLine("Jestes pelnoletni");
                Console.WriteLine("masz {0} lat\n", age2);

            }

            //switch

            liczba = 21;
            switch (liczba)
            {
                case 10:
                    Console.WriteLine("liczba = 10 ");
                    break;
                case 20:
                    Console.WriteLine("liczba = 20 ");
                    break;
                default:
                    Console.WriteLine("liczbaw wynosi: {0} ", liczba);
                    break;
            }

            Console.Clear();

            /*
             * napisz program ktory ma nastepujace menu
             * a - pole kwadratu
             * b - pole prostokata
             *
             * wykorzystaj instrukcje switch
             * zabezpiecz dane przed podaniem blednych wartosci do obliczen
             *
             */

            Console.WriteLine("a - pole kwadratu \nb - pole prostokata ");
            Console.WriteLine("Wybierz jedna z opcji");
            string znak = Console.ReadLine();
            string boka = Console.ReadLine();
            string bokb = Console.ReadLine();
            double pole;
            double pole1;
            double a1;
            double b1;

            switch (znak)
            {
                case "a":
                    Console.WriteLine("obliczanie pola kwadratu");
                    Console.Write("Podaj bok a:");
                    boka = Console.ReadLine();
                    if (double.TryParse(boka, out a1))
                    {
                        pole = a1 * a1;
                        Console.WriteLine("Pole kwadratu wynosi {0}", pole);
                    }
                    else
                    {
                        Console.WriteLine("podales bledne dane");
                    }



                        break;
                case "b":
                    Console.WriteLine("obliczanie pola prostokata");
                    Console.Write("Podaj bok a:");
                    boka = Console.ReadLine();
                    Console.Write("Podaj bok b:");
                    bokb = Console.ReadLine();
                    if (double.TryParse(bokb, out b1) && double.TryParse(boka, out a1))
                    {
                        pole1 = a1 * b1;
                        Console.WriteLine("Pole prostokata wynosi {0}", pole1);
                    }
                    else
                    {
                        Console.WriteLine("podales bledne dane");
                    }
                    break;

            }

            Console.Clear();

            //wyswietl liczby z przedzialu zamknietego od 1 do 15
            int i, j;

            for (i = 1; i<= 15; i++)
            {
                for (j = 10; j >= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
