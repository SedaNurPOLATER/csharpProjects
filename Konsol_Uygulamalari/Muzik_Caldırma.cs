using System;
using System.Media;

namespace MüzikÇaldırma
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer soundPlayer = new SoundPlayer(); // SoundPlayer için 'using System.Media;' kütüphanesini çağırdık
            soundPlayer.SoundLocation = @""; //Dosya Yolunu tırnakların içine yapıştır.
            soundPlayer.Play();

            Console.ReadLine();
        }
    }
}
