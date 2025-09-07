using System;
using System.Globalization;
using System.IO.Compression;
using System.Net.NetworkInformation;

namespace Programlama.AlgoritmaTasarimi
{
    class TemelProgramlamaDüzey1UygulamaClass
    {
        public static void TemelProgramlamaDüzey1UygulamaMainMethod()
        {

            //sabit İngilizce kültür kullan -> CultureInfo.InvariantCulture -> Bu durumda kullanıcı nokta . kullanmalı: 3.2
            System.Console.WriteLine("Daire alanı girin");
            double gelenDeger = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Daire alani = {0:F2}", Sayi.DaireAlani(gelenDeger, 60));
        }

        public class Sayi
        {

            #region Tek Mi?  | Çift Ni?

            /// <summary>
            /// Parametre olarak aldığı sayının tek mi çift mi olduğunu kontrol eder
            /// </summary>
            /// <param name="n">Sayi</param>
            /// <returns>Tek ise true aksi durumda false dönüş yapar</returns>
            public static bool TekMi(int n)
            {
                if (n % 2 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// Parametre olarak aldğımız sayının  çift olup olmadığını kontrol eder.
            /// </summary>
            /// <param name="n">Girilen sayi</param>
            /// <returns>Çift iste true aksi durumda false dönecek</returns>

            public static bool CiftMi(int n)
            {
                if (n % 2 == 0) return true; return false;


            }


            #endregion

            #region Mutlak Değer
            /*
                Mutlak değer
            - Bir sayının sıfıra olan uzaklığını ifade eder. Yani sayı pozitif de olsa negatif te olsa, mutlak değeri her zaman 0 veya pozitif çıkar

            ** Mantığı
            - Sayın pozitif veya 0 ise -> kendisini alır.
            - Sayı negetif ise -> işaretini değiştirerek pozitif yapar
            */

            /// <summary>
            /// Parametre olarak aldığı sayının mutlak değerini döner
            /// </summary>
            /// <param name="n"> Girilen sayıyı temsil eder</param>
            /// <returns>Girilen sayının mutlak değeri dönül ifadesi olacak</returns>
            public static int MutlakDeger(int n)
            {
                if (n > 0)
                {
                    return n;
                }
                else if (n < 0)
                {
                    return -1 * n;
                }
                else
                {
                    return 0;
                }


            }

            #endregion

            #region Asal Sayı

            /*
                Asal Sayı

            - Yanlızca 1'e ve kendisine tam bölünebilen, 1'den büyük doğal sayıdır.

                *Mantığı

            - Asal sayı kendisinden küçük hiçbir sayıya bölünemez (1 hariç)
            - Eğer bir sayı 1 ve kendisi dışında başka bir sayıya bölünüyorsa -> asal DEĞİLDİR , bileşik sayıdır.
            - 1 sayısı özel bir durumdur: asal değildir, çünkü sadece 1'e bölünebilir (Kendisi dışında böleni yok)

                *Özellikler
            - En küçük asal sayı 2'dir
            - 2 den sonraki tüm asal sayılar tektir
            - Asal sayıların çarpanları sadece 1 ve kendisidir.
            */

            /// <summary>
            /// Verilen sayının asal olup olmadığını kontrol eder.
            /// </summary>
            /// <param name="n">Kontrol edilecek sayı</param>
            /// <returns>
            /// Eğer sayı asal ise true, değilse false döner.
            /// </returns>
            public static bool AsalMi(int n)
            {
                if (n <= 1)
                {
                    System.Console.WriteLine("En küçük asal sayı 2'dir");
                    return false;
                }

                bool kontrol = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        kontrol = false;
                        break;
                    }

                }


                return kontrol;
            }

            #endregion

            #region Rakamlar Toplamı

            /// <summary>
            /// Parametre olarak aldığı sayının rakamları toplamını döner
            /// </summary>
            /// <param name="n">Sayi</param>
            /// <returns>Rakamlar toplamı</returns>
            public static int RakamlarTopla(int n)
            {

                int toplam = 0;
                /* 
                int rakam = 0;
                while (n > 0)// sayı 0 olana kadar devam et
                {
                    rakam = n % 10; // sayının son rakamını al

                    toplam += rakam; // topalama ekle
                    n = n / 10;// sondaki rakamı at (sayının küçülmesi)
                } 
                
                */

                /// FOR İLE YAPIMI
                for (; n > 0; n /= 10)//n'i her adında 10'a böl
                {
                    toplam += n % 10;// son rakamı ekle
                }

                return toplam; // toplamı döndür


            }
            #endregion


            #region Birden n'e kadar olan sayıların toplamı

            public static int NeKadarSayilarToplami(int n)
            {
                int toplam = 0;

                //1. Yol for ile
                for (int i = 1; i <= n; i++)
                {
                    toplam += i;
                }

                //2.yol Formül ile toplam
                /*  return (n * (n + 1)) / 2; */
                return toplam;
            }

            #endregion


            #region Birden n'e kadar olan TEK sayıların toplamı
            public static int NeKadarTekSayilarToplami(int n)
            {
                int toplam = 0;
                //1.yol
                /*    

                for (int i = 0; i <= n; i++)
                   {
                       if (i % 2 == 1)
                       {
                           toplam += i;
                       }


                   } 
                   */

                //2.Yol
                /* 
                for (int i = 0; i <=n; i+=2)
                {
                    toplam += i;
                }
                 */



                //3.Yol Formül ile EN HIZILISI

                /*
                   n = n + 1; // n'i 1 arttır
                    n = n/ 2; // artırılmış n'i 2'ye böli sonucu tekrar n'e ata
                    toplam = n*n; // yeni n'in karesini toplam'a ata

                📌 Örnek: n = 5 olsun.

                        n = n + 1; → n = 6

                        n = n / 2; → n = 3

                        toplam = n * n; → toplam = 9

                        Sonuç: toplam = 9
                */

                //4.yol Math

                toplam = (int)Math.Pow((n + 1) / 2, 2);

                /*
                
                📌 Math.Pow Nedir?

                    C#’ta Math.Pow(double x, double y) metodu, x’in y. kuvvetini (üsünü) hesaplar.

                    x → taban

                    y → üs

                    📌 Dönüş tipi: double (her zaman ondalıklı sayı döner, tam sayı olsa bile).
                
                */


                return toplam;
            }



            /*
            Maliyetler ve Perofmans
            1. Yol → Döngü ile if (i % 2 == 1)
                Maliyet: O(n)
                Dezavantaj: Her adımda mod alma işlemi var (%), bu da biraz maliyetli.
                Avantaj: Çok okunabilir, mantığı net.
            
            2. Yol -> Döngü ama sadece tek sayı
                Maliyet:O(n/2) ≈ O(n)
                Avantaj: Mod almaya gerek yok, %1.5-2 kat daha hızlı olabilir.
                Dezavantaj: Hala lineer (n büyükse uzun sürer)
            
            3. Yol -> Formül ile (Matematiksel)
                Malitet: O(1) (sabit zaman) ✅
                En hızlı yöntem: sadece birkaç basit aritmetik işlem var
                Avantaj: Çok hızlı, büyük n değerlerinde bile anında hesaplar
                Dezavantaj: Formül bilmek gerekiyor, döngü kadar sezgisel değil

            4. Yol - Math.Pow ile
                Malitet = O(1) ama içerde karmaşık hesaplar yapılıyor
                Dezavantajı: Math.Pow double döner, cast maliyeti var, ayrıca aritmetik işlmelere göre çok yavaş
                Not: Math.Pow(x, 2) aslında x * x’ten çok daha yavaş çalışır (10–50 kat fark olabilir).


            Performans Sıralaması

                Büyük n değerleri için (ör. 100 milyon):

                    3. Yol (Formül) → en hızlı ✅

                    2. Yol (i+=2 döngüsü) → döngü ama mod yok, orta hızda

                    1. Yol (if ve mod kontrolü) → döngü + mod → en yavaş döngü yöntemi

                    4. Yol (Math.Pow) → O(1) ama n*n’e göre gereksiz pahalı
                            */
            #endregion

            #region Birden n'e kadar olan TEK sayıların toplamı
            public static int NeKadarCiftSayilarToplami(int n)
            {

                int t = 0;
                //1. Yol
                /*  for (int i = 2; i <= n; i++)
                 {
                     if (i % 2 == 0)
                     {
                         t += i;
                     }
                 } */



                //2. Yol

                /*  for (int i = 0; i <=n; i+=2)
                 {
                     t += i;
                 } */

                //3. Yol - Formül

                n = n / 2;
                n = n + 1;
                t = n * n;


                return t;




            }



            #endregion


            #region Çember Çevresi
            //Çevre = 2*PI*r


            public static double CemberinCevresi(double r)
            {
                const double pi = Math.PI;
                return 2 * pi * r;
            }

            #endregion


            #region Dairede Alan
            //Formül => pi * r*r
            public static double DaireAlani(double r)
            {
                const double pi = Math.PI;
                return pi * (r * r);
            }

            #endregion

            #region Dilimli Daire Alan Hesaplama
            // (pi * (r*r))* parçaDerecesi/360

            /// <summary>
            /// Daire alanını hesaplar
            /// </summary>
            /// <param name="r">Yarı çap</param>
            /// <param name="daireParcaAcisi">Gördüğü açı</param>
            /// <returns>Alan değeri</returns>
            public static double DaireAlani(double r, double daireParcaAcisi)
            {
                const double pi = Math.PI;
                return (pi * (r * r)) * daireParcaAcisi / 360;
            }

            #endregion
        }
    }
}