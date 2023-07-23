using System;

namespace DiziMetotlariOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dizi = Array.CreateInstance(typeof(string), 10);
            Array dizi2 = Array.CreateInstance(typeof(string), 10);
            string[] dizi3 = (string[])Array.CreateInstance(typeof(string), 10);
            int[] dizi4 = (int[])Array.CreateInstance(typeof(int), 10);
            char[] dizi5 = (char[])Array.CreateInstance(typeof(char), 10);

            Console.ReadKey();
        }
    }
}
