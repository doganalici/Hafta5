using System;

namespace ForeachOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 4, 9, 16, 25, 36 };
            int[] sayilar2 = new int[6];
            foreach (var eleman in sayilar)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine("\n\n----- diziyi kopyalama -----");
            for (int i = 0; i < 6; i++)
            {
                sayilar2[i] = sayilar[i];
            }

            Console.ReadKey();
        }
    }
}
