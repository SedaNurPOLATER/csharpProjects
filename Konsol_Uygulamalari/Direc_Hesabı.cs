using System;

namespace Direnc_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, r3, rt;
            int secim;
            Console.Write("R1 :");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R2 :");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R3 :");
            r3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("1- Seri");
            Console.WriteLine("2- Paralel");
            Console.Write("Seçimi Yapın : ");

            secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (secim == 1)
            {
                rt = r1 + r2 + r3;
            }
            else if (secim == 2)
            {
                rt = 1 / ((1 / r1) + (1 / r2) + (1 / r3));
            }
            else
            {
                rt = -1;
                Console.WriteLine("Yanlış Seçim Yaptınız");
            }

            Console.WriteLine("Eşdeğer Direnç : {0} Ohm", rt);
            Console.ReadKey();
        }
    }
}
