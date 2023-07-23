using System;

namespace DiziOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler referans türdür
            //referans varsayılan değerleri alır
            //byte, short, int, long, float, double, decimal : 0
            //bool --> false
            //string --> null

            string[] sehirler = new string[3];
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[1]);
            }


            Console.WriteLine("----- int dizisi -----");
            int[] sayilar = new int[5];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("\n\n----- bool dizisi -----");
            bool[] durumlar = new bool[5];
            for (int i = 0; i < durumlar.Length; i++)
            {
                Console.WriteLine(durumlar[i]);
            }


            Console.WriteLine("\n\n----- char dizisi -----");
            char[] karakter = new char[5];
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }


            Console.ReadKey();
        }
    }
}
