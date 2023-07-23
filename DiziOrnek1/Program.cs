using System;

namespace DiziOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımalama,
            // tip[] diziismi=new tip[elemansayisi];

            //1. yol
            string[] isimler = new string[5];
            int[] sayilar = new int[5];
            bool[] durumlar = new bool[5];
            double[] katsayilar = new double[5];

            //2. yol
            string[] sehirler = new string[] { "Ankara", "İzmir" };
            int[] degerler = new int[] { 12, 23, 45, 56 };
            bool[] secenekler = new bool[] { false, true, true };

            //3. yol
            string[] gunler = { "Pazartesi", "Salı" };
            short[] numaralar = { 100, 200, 300 };

            Console.ReadKey();
        }
    }
}
