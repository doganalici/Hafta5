using System;

namespace IkiBoyutluDiziOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dersler =
            {
                {"BİL444","Programlama","4","Bilgisayar"},
                {"MAT333","Ayrık Matematik","3","Genel"}
            };

            Console.WriteLine("Kodu\tDers Adı\tKredi\tBölüm");
            for (int i = 0; i < dersler.GetLength(0); i++)
            {
                for (int j = 0; j < dersler.GetLength(1); j++)
                {
                    Console.Write(dersler[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
