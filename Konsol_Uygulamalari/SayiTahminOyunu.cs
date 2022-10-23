using System;

namespace SayıTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                NumberGame();
            }

            catch (Exception)
            {

                NumberGame();
            }

            Console.ReadLine();
        }

        static void NumberGame()
        {
            int number = new Random().Next(1, 51); // number rastgele 1-51 değerleri arasında nir sayı olsun

            int kalanHak = 10; // 10 hak tanımlıyoruz

            Console.Write("İsminiz: ");
            string name = Console.ReadLine();

            Console.Write("Tahmininizi Giriniz: ");
            int userNumber = int.Parse(Console.ReadLine());

            while (userNumber != number) // Randomun ürettiği sayı ile bizim girdiğimiz sayı aynı değilsen döngüye gir
            {
                kalanHak--; // Hakkımızı 1 azalt
                if (Math.Abs(number - userNumber) < 10) // Kul. girdiği sayı ve random sayı arasındaki fark 10 dan küçük ise gir
                {
                    Console.WriteLine("Sıcak");
                }
                else // Sayılar arasındaki fark 10 dan büyük ise gir
                {
                    Console.WriteLine("Soğuk");
                }

                Console.Write("Tahmininizi giriniz: ");
                userNumber = int.Parse(Console.ReadLine());

                if (kalanHak == 0) // kalan hak 0 olduğunda döngüyü ve oyunu bitir.
                {
                    Console.Write("Hakkınız Bitti...  " +  name  + " Maalesef bulamadınız.  rakam: " + number);
                    break;
                }
            }

            if (userNumber == number) // eğer girilen sayı ve random aynı ise kazandınız yaz
            {
                Console.WriteLine("Tebrikler " +  name  + " Kazandın ");
            }
        }
    }
}
