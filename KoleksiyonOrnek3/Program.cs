using System;
using System.Collections;

namespace KoleksiyonOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add(20);
            arrayList.Add("Adem");
            arrayList.Add("Mehmet");
            arrayList.Add("Veciye");
            arrayList.Add("Tuğçe");
            arrayList.Add("Doğan");
            arrayList.Add("Zehra");
            arrayList.Add("Umut");

            bool varMi=arrayList.Contains("tuğçe");
            if (varMi==true)
            {
                Console.WriteLine("Aradığınız isim listede VAR");
            }
            else
            {
                Console.WriteLine("Aradığınız isim listede YOK");
            }

            string[] copyList=new string[7];
            arrayList.CopyTo(copyList);

            int indeks = arrayList.IndexOf("Umut");
            Console.WriteLine(indeks);
            Console.WriteLine("---------");
            //Insert : koleksiyonda araya ekleme işlemi yapar
            arrayList.Insert(3, "Cemal");
            foreach (var eleman in arrayList)
            {
                Console.WriteLine(eleman);
            }

            object[] dizi = arrayList.ToArray();
            string[] ddizi = (string[])dizi;
            Console.ReadKey();
        }
    }
}
