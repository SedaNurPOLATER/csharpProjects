using System;

namespace Baslangic_Bitis_Artim
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangic, bitis, artis; // Değişkenler tanımlanır
            Console.Write("Başlangıç : ");
            baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş : ");
            bitis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Artış : ");
            artis = Convert.ToInt32(Console.ReadLine());
            for (int i = baslangic; i <= bitis; i += artis)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
