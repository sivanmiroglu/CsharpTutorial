using System;

using CsharpTutorial.Tutorials;

namespace CsharpTutorial
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            AlanHesaplama alanHesaplama = new AlanHesaplama(); // instance aldık

            // Alan Hesaplama da static kullanırsak metodların ön tarfına AlanHesaplama(class ismi)

            Console.WriteLine("1 - Dikdörtgenin Alanını Hesaplama");
            Console.WriteLine("2 - Dikdörtgenin Çevresini Hesaplama");
            Console.WriteLine("3 - Üçgenin Alan ını Hesaplama");
            Console.WriteLine("4 - Dairenin Alanını Hesaplama");
            Console.WriteLine("5 - Karenin Alnını Hesaplama");
            Console.WriteLine("6 - Karenin Çevresini Hespalama");
            Console.WriteLine("7 - Çemberin Çevreesini Hesaplama");
            Console.WriteLine("8 - Silindirin Alanını Hesaplama");
            Console.WriteLine("9 - Silindirin Hacmini Hesaplama");

            Console.WriteLine();

            Console.Write("Seçiminizi Yapınız");
            char secim = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            if (secim == '1')
            {
                Console.WriteLine("Secim : 1 Dikdörtgenin Alanını Hesapalama");

                Console.WriteLine();

                Console.Write("Kısa Kenarı Giriniz : ");
                int kisakenar = Convert.ToInt32(Console.ReadLine());

                Console.Write("Uzun Kenarı Giriniz : ");
                int uzunkenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Dikdörtgenin Kenarı : " + alanHesaplama.dikdortgenAlanMetodu(kisakenar,uzunkenar));
            }
            else if (secim == '2')
            {
                Console.WriteLine("Secim : Dikdörtgenin Çevresini Hesaplama");

                Console.WriteLine();

                Console.Write("Kısa Kenarı Girin : ");
                int kisakenar = Convert.ToInt32(Console.ReadLine());

                Console.Write("Uzun Kenarı Girin : ");
                int uzunkenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Dikdörtgenin Çevresi : " + alanHesaplama.dikdortgenCevreMetodu(kisakenar, uzunkenar));

            }

            else if (secim == '3')
            {
                Console.WriteLine("Secim : Üçgenin Alanını Hesaplama");
                
                Console.WriteLine();
                Console.Write("Taban Uzunluğu Girin : ");
                int tabanuzunlugu = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yüksekliği Girin : ");
                int yukseklik = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Üçgenin Alanı : " + alanHesaplama.ucgenAlanMetodu(tabanuzunlugu, yukseklik));

            }
            else if (secim == '4')
            {
                Console.WriteLine("Secim : Dairenin Alnını Hesaplama");

                Console.WriteLine();
                Console.WriteLine("Yarıçap Değerini Girin : ");
                int yaricap = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dairenin Alanı : " + alanHesaplama.daireAlanMetodu(yaricap));

            }

            else if (secim == '5')
            {
                Console.WriteLine("Secim : Karenin Alanını Hesaplama ");

                Console.WriteLine();
                Console.WriteLine("Karenin Bir Kenarının Uzunluğunu Girin : ");
                int kare = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Karenin Alanı : " +  alanHesaplama.kareAlanMetodu(Kenar: kare));
            }
            else if (secim == '6')
            {
                Console.WriteLine("Secim : Karenin Çevresini Hesaplama ");

                Console.WriteLine();
                Console.WriteLine("Karenin Bir Kenarının Uzunluğunu Girin :");
                int kare = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Karenin Çevresinin Alanı : " + alanHesaplama.kareCevreHesaplama(kenar: kare));
            }
            else if (secim == '7')
            {
                Console.WriteLine("Secim : Çemberin Çevresini Hesaplama ");

                Console.WriteLine();
                Console.WriteLine("Çemberin Yarıçap Değerini Girin :");
                int Yaricap = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Çemberin Çevresinin Alanı : " + alanHesaplama.cemberCevreMetodu(Yaricap));
            }
            else if (secim == '8')
            {
                Console.WriteLine("Secim : Silindirin Alanını Hesaplama :");

                Console.WriteLine();
                Console.WriteLine("Silindirin Yarıçap Değerini Girin :");
                int yaricap = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Silindirin Yükseklik Değerini Girin :");
                int yukseklik = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Çemberin Çevresinin Alanı : " +  alanHesaplama.silindirAlanMetodu(yaricap, yukseklik));

            }
            else if (secim == '9')
            {
                Console.WriteLine("Secim : Silindirin Hacmini Hesaplama :");

                Console.WriteLine();
                Console.WriteLine("Silindirin Yarıçap Değerini Girin :");
                int yaricap = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Silindirin Yükseklik Değerini Girin :");
                int yukseklik = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Çemberin Çevresinin Alanı : " + alanHesaplama.silindirAlanMetodu(yaricap, yukseklik));

            }
            else
            {
                Console.WriteLine("Hatalı Seçim");
            }
            Console.ReadKey();
        }

        
    }
}
