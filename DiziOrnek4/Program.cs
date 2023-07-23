using System;

namespace DiziOrnek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //eleman sayısı kullanıcı tarafından girilen dizi

            int boyut;
            Console.Write("Dizinin eleman sayısını giriniz  : ");
            boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                sayilar[i] = i * i;
            }
            Console.WriteLine("---- diziyi yazdıralım ----");
            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine($"sayilar[{i}] -> "+sayilar[i]);
            }

            Console.ReadKey();
        }
    }
}
