using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            int wybor = 0;
            string wyborString;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Wybierz opcje:");
                Console.WriteLine("1. czy podzielna przez 3");
                Console.WriteLine("2. czy pełnoletni");
                Console.WriteLine("3. Pole trójkąta");
                Console.WriteLine("4. Imie i wiek");
                Console.WriteLine("5. Wyjśćie");
                wyborString = Console.ReadLine();
                try
                {
                    wybor = int.Parse(wyborString);

                    switch (wybor)
                    {
                        case 1:
                            DivBy3();
                            break;
                        case 2:
                            
                            Pelnoletniosc();
                            break;
                        case 3:
                            TrojkatPole();
                            break;
                        case 4:
                            ImieWiek();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                            
 
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: {0}", e.Message);
                    Console.ResetColor();
                }
            }
        }
        static int DivBy3()
        {
            int liczba = 0;
            string liczbaString;
            while (true)
            {
                Console.WriteLine("Podaj Liczbe:");
                liczbaString = Console.ReadLine();
                try
                {
                    liczba = int.Parse(liczbaString);
                    if (liczba % 3 == 0)
                    {
                        Console.WriteLine("liczba podzielna przez 3");
                    }
                    else
                    {
                        Console.WriteLine("Libcza niepodzielna przez 3");
                    }
                    return liczba;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: {0}", e.Message);
                    Console.ResetColor();
                }
            }
        }
        static int Pelnoletniosc()
        {
            int wiek1 = 0;
            string wiek1String;

            while (true)
            {
                Console.WriteLine("Podaj swój wiek: ");
                wiek1String = Console.ReadLine();
                try
                {
                    wiek1 = int.Parse(wiek1String);
                    if (wiek1 >= 18)
                    {
                        Console.WriteLine("Jesteś pełnoletni!");
                    }
                    else
                    {
                        Console.WriteLine("Nie jesteś pełnoletni!");
                    }
                    return wiek1;

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: {0}", e.Message);
                    Console.ResetColor();

                }

            }

        }
        static int TrojkatPole()
        {
            int wysokosc = 0;
            string stringwysokosc;
            int bok = 0;
            string stringbok;
            int pole = 0;
            while (true)
            {
                Console.WriteLine("Podaj wysokość trójkąta: ");
                stringwysokosc = Console.ReadLine();
                Console.WriteLine("Podaj bok trójkąta: ");
                stringbok = Console.ReadLine();
                try
                {
                    wysokosc = int.Parse(stringwysokosc);
                    bok = int.Parse(stringbok);

                    if (wysokosc <= 0 || bok <= 0)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wartość nie może być równa lub mniejsza 0");
                        Console.ResetColor();

                    }
                    else
                    {
                        pole = (bok * wysokosc) / 2;
                        Console.WriteLine("Pole wynosi: {0}", pole);
                        return pole;
                    }
                            

                }catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: {0}", e.Message);
                    Console.ResetColor();

                }
                    
            }

        }
        
        static void ImieWiek()
        {


        }
        
    }
}


