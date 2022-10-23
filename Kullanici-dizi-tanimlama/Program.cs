using System;

namespace Kullanici_dizi_tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0,  enb, enk; 
            double ortalama = 0;
            int[] dizi = new int [5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i+1 + ". değeri giriniz= ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + dizi[i];
            }
            Console.WriteLine("Girilen Değerlerin Toplamı = " + toplam);

            ortalama = Convert.ToDouble(toplam) / 5;
            Console.WriteLine("Değerlerin ortalaması = " + ortalama);

            enb = dizi[0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (dizi[i] > enb)
                    {
                        enb = dizi[i];
                    }
                }
            }
            Console.WriteLine("Maximum değer = " + enb);

            enk = dizi[0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (dizi[i] < enk)
                    {
                        enk = dizi[i];
                    }
                }
            }
            Console.WriteLine("Minimum değer = " + enk);
        }
    }
}
