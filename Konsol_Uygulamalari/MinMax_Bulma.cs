using System;

namespace EnBüyük_EnKüçük
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, buyuk, kucuk, toplam; //Değişken tanımı yapıldı

            Console.Write("Birinci sayıyı girin: "); // İlk sayı girilsin
            s1 = Convert.ToInt32(Console.ReadLine()); // İl sayıyı okur
            Console.Write("İkinci sayıyı girin: "); // İkinci sayı girilsin
            s2 = Convert.ToInt32(Console.ReadLine()); // İkinci sayıyı okur
            Console.Write("Üçüncü sayıyı girin: "); // Üçüncü sayı girilsin
            s3 = Convert.ToInt32(Console.ReadLine()); // Üçüncü sayıyı okur


            if (s1 > s2 && s1 > s3) // Eğer sayı1 büyük ise sayı2 ve sayı3 ten içeri gir
                buyuk = s1; // sayı1 büyük yazdır.
            else if (s2 > s3)
                buyuk = s2;
            else
                buyuk = s3;

            Console.WriteLine("Büyük Sayı= " + buyuk);

            if (s1 < s2 && s1 < s3)
                kucuk = s1;
            else if (s2 < s3)
                kucuk = s2;
            else
                kucuk = s3;

            Console.WriteLine("Küçük sayı= " + kucuk);

            toplam = buyuk + kucuk;
            Console.WriteLine("En büyük ile En küçük sayıların toplamı= " + toplam);
            Console.ReadLine();
        }
    }
}
