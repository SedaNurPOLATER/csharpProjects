using System;

namespace Dizi_Örnegi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mevcut = 0;
            Console.Write("Proje mevcudunu Girin : ");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] eleman = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write("Proje elemanlarının adını girin : ");
                eleman[i] = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
