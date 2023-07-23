using System;

namespace DiziMetotlariOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array.Copy(source,destination)
            string[] kaynak = { "Ankara", "İstanbul", "İzmir", "Çorum", "Yozgat", "Çorum" };
            //array.Length özelliği dizinin eleman sayısını döndürür.
            string[] hedef = new string[kaynak.Length];

            Array.Copy(kaynak, hedef, 5);
            Console.WriteLine("---- Array.Copy ile ----");
            for (int i = 0; i < hedef.Length; i++)
            {
                Console.WriteLine(hedef[i]);
            }

            //extension metot : genişletme metodu
            kaynak.CopyTo(hedef, 0);

            Array.Reverse(kaynak);
            Console.WriteLine("\n\n---- Array.Reverse den sonra ----");
            for (int i = 0; i < kaynak.Length; i++)
            {
                Console.WriteLine(kaynak[i]);
            }

            Console.WriteLine("\n\n---- Array.Sort() dan sonra ----");
            Array.Sort(kaynak);
            for (int i = 0; i < kaynak.Length; i++)
            {
                Console.WriteLine(kaynak[i]);
            }

            // Rank : dizinin kaç boyutlu olduğunu döndürür
            int boyutSayisi = kaynak.Rank;
            Console.WriteLine($"\n\nKaynak dizisinin eleman sayısı : {kaynak.Length}");
            Console.WriteLine($"Kaynak dizisinin boyut sayısı : {kaynak.Rank}");

            int[,,] cokboyutlu = new int[2, 3, 4];
            Console.WriteLine($"\n\nKaynak dizisinin eleman sayısı : {cokboyutlu.Length}");
            Console.WriteLine($"Kaynak dizisinin boyut sayısı : {cokboyutlu.Rank}");

            //Array.IndexOf(eleman) : elemanın  indeks numarasını verir.
            int indeks = Array.IndexOf(kaynak, "Ankara");
            Console.WriteLine($"\n\nAnkara indeks numarası : {indeks}");

            int indexCorum = Array.IndexOf(kaynak, "Çorum");
            int indexSonCorum = Array.LastIndexOf(kaynak, "Çorum");
            Console.WriteLine($"Çorum indeks numarası : {indexCorum}");
            Console.WriteLine($"Çorum son indeks numarası : {indexSonCorum}");
            Console.WriteLine("\n------------------------------------\n");

            int indexKonya = Array.IndexOf(kaynak, "Konya");
            int indexSonKonya = Array.LastIndexOf(kaynak, "Konya");
            if (indexKonya == -1)
            {
                Console.WriteLine("Konya dizide yok");
            }
            else
            {
                Console.WriteLine($"Konya indeks numarası : {indexKonya}");
            }
            Console.WriteLine($"Konya son indeks numarası : {indexSonKonya}");
            //Array.Clear(kaynak);
            //for (int i = 0; i < kaynak.Length; i++)
            //{
            //    Console.WriteLine(kaynak[i]);
            //}

            Console.ReadKey();
        }
    }
}
