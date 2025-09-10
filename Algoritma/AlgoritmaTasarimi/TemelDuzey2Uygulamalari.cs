using System;

namespace Programlama.AlgoritmaTasarimi
{
    class TemelDüzey2UygulamaClass
    {
        public static void TemelDüzey2UygulamaMainMethod()
        {
            System.Console.WriteLine("Üst alma {0}", Matematik.UstAlma(2, 2));
            foreach (var item in Matematik.HashSetAsalCarpanBul(60))
            {
                System.Console.Write("{0} ", item);
            }

        }







    }



    class Matematik
    {

        #region Üst Alma

        /// <summary>
        /// Parametre olarak aldığı değerlere göre üst alma
        /// </summary>
        /// <param name="taban">Taban</param>
        /// <param name="kuvvet">Kuvvet</param>
        /// <returns>sonuc</returns>
        internal static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }
        #endregion

        /*     #region Asal Çarpanları Bulma (GEREKSİZ UZUN)

            /// <summary>
            /// Bir sayının asal çarpanını verir
            /// </summary>
            /// <param name="sayi">Sayiyi temsil eder</param>
            /// <returns>Asal Çarpan Dizisi</returns>
            internal static int[] AsalCarpanlariBul(int sayi)
            {
                string carpanListesi = "";
                int i = 2;
                while (sayi > 1)
                {
                    if (sayi % i == 0)
                    {
                        sayi = sayi / i;
                        carpanListesi += i.ToString() + ",";

                    }
                    else { i++; }
                }

                carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
                string[] carpanar = carpanListesi.Split(",");
                string s = carpanar[0];
                string y = s;
                for (i = 0; i < carpanar.Length; i++)
                {
                    if (!(s == carpanar[i]))
                    {
                        y = y + ',' + carpanar[i];
                        s = carpanar[i];
                    }
                }

                carpanar = y.Split(',');
                int[] asalCarpanlar = new int[carpanar.Length];
                for (i = 0; i < asalCarpanlar.Length; i++)
                {
                    asalCarpanlar[i] = Convert.ToInt32(carpanar[i]);
                }
                return asalCarpanlar;
            }
            #endregion */

        #region Asal Çarpanları Bulma [ 1. Yol En Verimsiz Performanssız Ve MaliyetLi Yol ]

        internal static int[] AsalCarpanlariBul(int sayi)
        {
            var asalCarpanlarList = new List<int>();// Asal çarpanları saklamak için boş Liste 
            int i = 2;// bölen adayını 2'den başlat (en küçük asal sayı)

            while (sayi > 1) //Sayı 1 olana kadar bölme işlemi yap
            {
                if (sayi % i == 0)// eğer i sayıyı tam bölüyorsa
                {
                    if (!(asalCarpanlarList.Contains(i))) // daha önce listede varmı? Var ise
                    {
                        asalCarpanlarList.Add(i);// Listeye ekle
                    }

                    sayi /= i;// Sayı i'ye bölerek Küçült 


                }
                else
                {
                    i++; // eğer i tam bölmüyor ise i'yi arttır
                }

            }
            return asalCarpanlarList.ToArray();// Listeyi diziye çevirip döndür
        }
        #endregion

        #region Asal Çarpanları BUlma [ 2. Yol HashSet(tekrarsız asal çarpanlar)]
        internal static HashSet<int> HashSetAsalCarpanBul(int sayi)
        {
            var asalHashSet = new HashSet<int>();
            int i = 2;

            while (sayi > 1)
            {

                if (sayi % i == 0)
                {
                    asalHashSet.Add(i);
                    sayi = sayi / i;
                }
                else
                {
                    i++;
                }
            }
            return asalHashSet;
        }
        #endregion
        
    }
}