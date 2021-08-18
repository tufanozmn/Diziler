using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi boyutunu giriniz;");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];

            var r = new Random();

            for (int i = 0; i <sayilar.Length; i++)
                 sayilar[i] = r.Next(1, 10);

            foreach (var s in sayilar)
            {
                Console.WriteLine($"{s,5} {s*s,5}");
            }
            
            Console.ReadKey();
        }
    }
}
