using System;
using System.Collections;

namespace KoleksiyonOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listem = new ArrayList();
            //Count : koleksiyonun eleman sayısını verir
            //Capacity : koleksiyonun alabileceği maximum eleman sayısı
            int elemanSayisi = listem.Count;
            int kapasite = listem.Capacity;
            Console.WriteLine($"Listemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");

            listem.Add(10);
            elemanSayisi = listem.Count;
            kapasite = listem.Capacity;
            Console.WriteLine($"\nListemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");

            listem.Add(20);
            elemanSayisi = listem.Count;
            kapasite = listem.Capacity;
            Console.WriteLine($"\nListemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");

            listem.Add(30);
            elemanSayisi = listem.Count;
            kapasite = listem.Capacity;
            Console.WriteLine($"\nListemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");

            listem.Add(40);
            elemanSayisi = listem.Count;
            kapasite = listem.Capacity;
            Console.WriteLine($"\nListemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");

            listem.Add(50);
            elemanSayisi = listem.Count;
            kapasite = listem.Capacity;
            Console.WriteLine($"\nListemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");

            int indeks = listem.Add(60);
            Console.WriteLine($"\nİndeks : {indeks}");

            listem.Remove(50);
            Console.WriteLine("\n****");
            foreach (var eleman in listem)
            {
                Console.WriteLine(eleman);
            }

            //listem.Remove(150);
            Console.WriteLine("****");
            listem.RemoveAt(2);
            foreach (var eleman in listem)
            {
                Console.WriteLine(eleman);
            }

            listem.Clear();
            elemanSayisi = listem.Count;
            kapasite = listem.Capacity;
            Console.WriteLine($"\nListemin eleman sayısı : {elemanSayisi}");
            Console.WriteLine($"Listemin kapasitesi : {kapasite}");
            //int toplam;
            //toplam =(int) listem[0] +(int) listem[1];
            //Console.WriteLine(toplam);



            Console.ReadKey();
        }
    }
}
