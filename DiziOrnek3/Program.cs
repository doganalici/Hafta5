using System;

namespace DiziOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            Console.WriteLine("---- varsayılan değerler ----");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("---- elemanlara değer atayalım ----");
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 50;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("\n\n---- klavyeden okuyarak değer atama ----");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Bir sayı giriniz : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n---- değer atamadan sonra ----");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.Read();
        }
    }
}
