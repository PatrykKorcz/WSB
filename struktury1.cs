using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUKTURY1
{
    class Program
    {

        public struct Punkt
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();
            Punkt punkt2;


            punkt1.x = 100;
            punkt1.y = 200;

            Console.WriteLine("Punkt x wynosi: {0}",punkt1.x);
            Console.WriteLine("Punkt y wynosi: {0}",punkt1.y);

        


            Console.ReadKey();
        }
    }
}
