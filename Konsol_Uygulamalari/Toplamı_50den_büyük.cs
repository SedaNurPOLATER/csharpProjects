using System;

namespace Toplam_50den_kücük
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayi, sayac = 0;
            while (toplam < 50)
            {
                Console.Write("Sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                sayac++;
            }

            Console.WriteLine("{0} adet sayı girişi yaptınız. Girilen sayıların toplamı={1}", sayac, toplam);
            Console.ReadKey();
        }
    }
}
