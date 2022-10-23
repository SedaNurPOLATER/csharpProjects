using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static int sonuc;
        static bool cikisYapilsinmi = false;
        static List<int> kullaniciSayilari = new List<int>();

        static void Main(string[] args)
        {
            while (!cikisYapilsinmi)
            {
                MenuGoster();

                Console.Write("Seçiminizi Belirtiniz : ");
                int kullaniciSecimi = int.Parse(Console.ReadLine());

                switch (kullaniciSecimi)
                {
                    case 1:
                        if (!IslemYapilabilinirmi())
                        {
                            break;
                        }
                        Console.WriteLine("Toplama Sonucunuz : " + Topla(kullaniciSayilari));
                        break;
                    case 2:
                        if (!IslemYapilabilinirmi())
                        {
                            break;
                        }
                        Console.WriteLine("Çıkarma İşlemi Sonucunuz : " + Cikar(kullaniciSayilari));
                        break;
                    case 3:
                        if (!IslemYapilabilinirmi())
                        {
                            break;
                        }
                        Console.WriteLine("Çarpma İşlemi Sonucunuz : " + Carp(kullaniciSayilari));
                        break;
                    case 4:
                        if (!IslemYapilabilinirmi())
                        {
                            break;
                        }
                        Console.WriteLine("Bölme İşlemi Sonucunuz : " + Bol(kullaniciSayilari));
                        break;
                    case 5:
                        if (!IslemYapilabilinirmi())
                        {
                            break;
                        }
                        Console.WriteLine("Ortalama : " + Ortalama(kullaniciSayilari));
                        break;
                    case 6:
                        kullaniciSayilari.Clear();
                        KullanicidanDegerleriAl();
                        break;
                    case 0:
                        cikisYapilsinmi = true;
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;
                }
            }

            Console.ReadLine();
        }

        private static void KullanicidanDegerleriAl()
        {
            // 5,3,78,45.
            string girisDegeri = "";

            while (girisDegeri != ".")
            {
                try
                {
                    girisDegeri = Console.ReadLine();
                    kullaniciSayilari.Add(girisDegeri.ConInt());
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayısal Değer Giriniz");
                }
            }
        }

        static void MenuGoster()
        {
            Console.WriteLine();
            Console.WriteLine("------  Menu  ---------");
            Console.WriteLine("1 - Toplama İşlemi Yap");
            Console.WriteLine("2 - Çıkarma İşlemi Yap");
            Console.WriteLine("3 - Çarpma İşlemi Yap");
            Console.WriteLine("4 - Bölme İşlemi Yap");
            Console.WriteLine("5 - Ortalama Hesapla");
            Console.WriteLine("6 - Yeni Sayılar Gir");
            Console.WriteLine();
            Console.WriteLine("0 - Menüden Çık");
        }

        static int Topla(List<int> sayilar)
        {
            sonuc = 0;
            foreach (int item in sayilar)
            {
                sonuc += item;
            }
            return sonuc;
        }
        static int Cikar(List<int> sayilar)
        {
            sonuc = 0;
            foreach (int item in sayilar)
            {
                sonuc -= item;
            }
            return sonuc;
        }

        static int Carp(List<int> sayilar)
        {
            sonuc = 1;
            foreach (int item in sayilar)
            {
                sonuc *= item;
            }
            return sonuc;
        }
        static int Bol(List<int> sayilar)
        {
            sonuc = sayilar[0];
            for (int i = 1; i < sayilar.Count; i++)
            {
                sonuc /= sayilar[i];
            }
            return sonuc;
        }

        static int Ortalama(List<int> sayilar)
        {
            sonuc = Topla(sayilar);
            sonuc = sonuc / sayilar.Count;
            return sonuc;
        }

        static bool IslemYapilabilinirmi()
        {
            if (kullaniciSayilari == null)
            {
                Console.WriteLine("Listeye Eleman Ekleyeniz");
                kullaniciSayilari = new List<int>();
                return false;
            }
            if (kullaniciSayilari.Count == 0)
            {
                Console.WriteLine("Listeye Eleman Ekleyeniz");
                return false;
            }
            return true;
        }
    }
    static class Helper
    {
        public static int ConInt(this object param)
        {
            return Convert.ToInt32(param);
        }
    }
}