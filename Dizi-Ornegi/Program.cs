using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayaç = 0;
            int[] dizi = new int[10];
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i+1 + ". elemanı giriniz");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i <10; i++)
            {
                if (dizi[i] % 3 == 0)
                {
                    toplam = toplam + dizi[i];
                    sayaç++;
                }   
            }
            Console.WriteLine("toplam= " + toplam);
            Console.WriteLine("ortalama= " + toplam / sayaç);
        }
    }
}
