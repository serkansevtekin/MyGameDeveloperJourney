using System;

namespace Programlama.AlgoritmaTasarimi
{
    class DizilerClass
    {
        public static void DizilerMainMethod()
        {
            System.Console.WriteLine("n Değerini giriniz:");
            var limit = Convert.ToInt32(Console.ReadLine());
            int[] x = Dizilers.Olustur(limit);


            System.Console.WriteLine("Dizinin Sıtandart sapması : {0:F2}", Dizilers.StandartSapma(x));


            // ValueTurple ile Tek ve Çift Sayılar
            var (tekListe, ciftListe) = Dizilers.TekCiftSayilar(x);
            System.Console.Write("\nTek Sayilar : ");
            foreach (var item in tekListe)
            {
                System.Console.Write("{0,-5}", item);
            }
            System.Console.WriteLine("\nTek sayıların sayısı: {0}", tekListe.Length);

            System.Console.Write("\n Çift Sayılar :");
            foreach (var item in ciftListe)
            {
                System.Console.Write("{0,-5}", item);
            }

            System.Console.WriteLine("\nÇift sayıların sayısı: {0}", ciftListe.Length);


        }



    }

    #region  Dizilers Class


    public class Dizilers
    {
        public static int[] Olustur(int limit)
        {
            var sayilar = new int[limit];
            System.Console.WriteLine();
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(0, 100);
                System.Console.Write(" {0,3} ", sayilar[i]);
            }
            System.Console.WriteLine();
            return sayilar;
        }

        #region En Büyük ve En Küçük ELemanı bulma | ValueTurple Ekstra
        private static void EnBuyukveEnKucukElemaniBul()
        {
            System.Console.WriteLine("n değerini girizi:");
            //Kullanıdan aldığımız string değeri int32 ye çevirip limit değişkenine aktarma
            int limit = Convert.ToInt32(Console.ReadLine());

            //sayilar isminde bir dizi değişkeni 
            int[] sayilar = new int[limit];


            for (int i = 0; i < limit; i++)//Verilem limit değeri kadar döngü dönmesi
            {
                //sayilar dizimizin herbir [i] 'inci elemanına 1 ile 100 arasında rasgele değerleri aktar
                sayilar[i] = new Random().Next(1, 100);

                System.Console.WriteLine("{0}'inci eleman: {1}", i, sayilar[i]);
            }

            System.Console.WriteLine($"\nEn Küçük eleman: {EnKucukVeEnBuyuk(sayilar).enKucuk}");
            System.Console.WriteLine($"\nEn Büyük eleman: {EnKucukVeEnBuyuk(sayilar).enBuyuk}");

        }
        /* Maliyet -> enBuyuk ve enKucuk fonksiyonlarını ayrı ayrı çağırıyorsun → diziyi iki kez dolaşıyorsun.

          public static int enBuyuk(int[] sayilarDizi)
         {
             int eb = sayilarDizi[0];
             for (int i = 0; i < sayilarDizi.Length; i++)
             {
                 if (sayilarDizi[i] > eb)
                 {
                     eb = sayilarDizi[i];
                 }
             }
             return eb;
         }
           public static int EnKucuk(int[] sayilarDizi)
         {
             int ek = sayilarDizi[0];
             for (int i = 0; i < sayilarDizi.Length; i++)
             {
                 if (sayilarDizi[i] < ek)
                 {
                     ek = sayilarDizi[i];
                 }
             }
             return ek;
         } 
         */

        //En hızlı ver perfromanslı yol ->>>>> ValueTurple
        //Bunu tek döngü ile yaparsan maliyet O(n) kalır ama 2n yerine sadece n adım çalışır → pratikte 2 kat hızlanır.
        public static (int enKucuk, int enBuyuk) EnKucukVeEnBuyuk(int[] sayilarDizi)
        {
            int enKucuk = sayilarDizi[0];
            int enBuyuk = sayilarDizi[0];

            for (int i = 0; i < sayilarDizi.Length; i++)
            {
                if (sayilarDizi[i] < enKucuk)
                    enKucuk = sayilarDizi[i];

                if (sayilarDizi[i] > enBuyuk)
                    enBuyuk = sayilarDizi[i];
            }
            return (enKucuk, enBuyuk);
        }


        #endregion

        #region AritmetikOrtalama

        /// <summary>
        /// Parametresini aldığı dizinin aritmetik ortalamasını döner
        /// </summary>
        /// <param name="sayilar">Dizi</param>
        /// <returns>Aritmetik Ortalama</returns>
        public static double AritmetikOrtalama(int[] sayilar)
        {
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam / sayilar.Length;
        }
        #endregion

        #region Standart Sapma Hesaplama

        /// <summary>
        /// Parametre olarak aldiği dizinin standart sapmasini hesaplar
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Standart Sapma</returns>

        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);

            double t = 0;

            for (int i = 0; i < X.Length; i++)
            {

                t += Math.Pow(X[i] - aritmetikOrtalama, 2);
            }


            return Math.Sqrt(t / (X.Length - 1));
        }
        #endregion

        #region Tek ve Çift Sayılar

        public static (int[] tekList, int[] ciftList) TekCiftSayilar(int[] sayilarDizi)
        {
            int tekCount = 0, ciftCount = 0;//Tek ve çift sayı sayacı

            // Döngü: Dizideki tek ve çift sayıları say
            for (int i = 0; i < sayilarDizi.Length; i++)
            {
                if (sayilarDizi[i] % 2 == 0)// Çift sayı mı?
                {
                    ciftCount++; // Çift sayacı arttır
                }
                else
                {
                    tekCount++; // Tek sayacı arttır

                }

            }
            // Döngü önce array'leri oluştur 
            int[] tekList = new int[tekCount]; // Tek sayılar için sabit boyutlu array
            int[] ciftList = new int[ciftCount]; // Çift sayılar için sabit boyutlu array

            int ti = 0, ci = 0;// Tek ve cift Listeleri indexleri

            // Döngü öncesi Diziyi tekrar tar ve array'leri doldur
            for (int i = 0; i < sayilarDizi.Length; i++)
            {
                if (sayilarDizi[i] % 2 == 0)// Çift Sayı mı?
                {
                    ciftList[ci++] = sayilarDizi[i]; // Çift array'e ekle ve indexi artır
                }
                else
                {
                    tekList[ti++] = sayilarDizi[i]; // Tek array'e ekle ve indexi artır
                }
            }

            // Array'leri ValueTuple olarak döndür
            return (tekList, ciftList);
        }
        #endregion



    }

    #endregion

}