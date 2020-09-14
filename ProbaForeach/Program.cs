using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int szum = 0;
            foreach (var t in tomb)//A megadott szerezeten végig megy és folyamatosan hozzáadja a tömb elemeit a t-hez.
            {
                szum += t;
                Console.WriteLine(t.ToString());//Egymás alá kiírjuk a tömb elemeit.
            }
            Console.WriteLine("Az összegük: {0} ", szum);

            Console.ReadKey();
        }
    }
}
