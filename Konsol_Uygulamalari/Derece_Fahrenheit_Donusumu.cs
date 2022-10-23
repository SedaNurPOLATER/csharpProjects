using System;

namespace Derece_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double derece, fahrenheit; //Değişken tanımlama

            Console.Write("Derece cinsinden sıcaklık değerini girin:");
            derece = Convert.ToDouble(Console.ReadLine()); //Dereceyi al

            fahrenheit = derece * 1.8 + 32; // Dereceyi Fahrenheite çevir
            Console.WriteLine("Girdiğiniz derece = " + derece + "" +  " Fahrenheit değeri = " +  fahrenheit);

            Console.ReadLine();

        }
    }
}
