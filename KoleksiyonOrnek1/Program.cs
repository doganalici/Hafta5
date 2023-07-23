using System;
using System.Collections;

namespace KoleksiyonOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Adem");
            liste.Add(40);
            liste.Add(true);
            liste.Add(1500.12);
            liste.Add("E");

            // int yas = (int)liste[1]; //object --> türe : unboxing /  tür --> object : boxing
            int yas = Convert.ToInt32(liste[1]);
            Console.WriteLine(liste[1]);
            Console.WriteLine("\n\n----- elemanları yazdıralım -----");
            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadKey();
        }
    }
}
