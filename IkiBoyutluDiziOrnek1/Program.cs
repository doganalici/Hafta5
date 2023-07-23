using System;

namespace IkiBoyutluDiziOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] kisiler = new string[3, 4];
            //kisiler[0, 0] = "Adem";
            //kisiler[0, 1] = "Mühendis";
            //kisiler[0, 2] = "40";
            //kisiler[0, 3] = "Çorum";
            // kisiler[0, 4] = "15000";

            string[,] kisiler =
            {
                {"Adem AKKUŞ","Bilgisayar Mühendisi","40","Çorum"},
                {"Veciye CEYHAN","EEM","30","Yozgat"},
                {"Umut B. TER","Bilgisayar Mühendisi","22","Ankara"}
            };
            //Console.WriteLine(kisiler.Length);
            //iki boyutlu dizide
            //dizi.GetLength(0) : satır sayısını (birinci boyutu)
            //dizi.GetLength(1) : sütun sayısını (ikinci boyutu)
            Console.WriteLine($"Dizi birinci boyutu : {kisiler.GetLength(0)}");
            Console.WriteLine($"Dizi ikinci boyutu : {kisiler.GetLength(1)}");

            for (int i = 0; i < kisiler.GetLength(0); i++)
            {
                for (int j = 0; j < kisiler.GetLength(1); j++)
                {
                    Console.Write(kisiler[i,j]+" / ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n----- Bir kişi -----\n");
            for (int i = 0; i < kisiler.GetLength(1); i++)
            {
                Console.Write(kisiler[0,i]+" / ");
            }

            Console.ReadKey();
        }
    }
}
