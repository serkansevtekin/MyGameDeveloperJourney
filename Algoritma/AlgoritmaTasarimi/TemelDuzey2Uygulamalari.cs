using System;

namespace Programlama.AlgoritmaTasarimi
{
    class TemelDüzey2UygulamaClass
    {
        public static void TemelDüzey2UygulamaMainMethod()
        {

            int sayi = 180;
            System.Console.WriteLine("Üst alma {0}", Matematik.UstAlma(2, 2));
            foreach (var item in Matematik.HashSetAsalCarpanBul(sayi))
            {
                System.Console.Write("{0} ", item);
            }

            System.Console.WriteLine("\n{0} Sayısının Asal Çarpanlarının Sayıların toplamları : {1}", sayi, Matematik.AsalÇarpanlarinToplamlariBul(sayi));

            System.Console.WriteLine("\n{0} Sayısının Asal Çarpanlarının Sayıların çarpımı : {1}", sayi, Matematik.AsalCarpanlarinCarpimi(sayi));

            System.Console.WriteLine("Okek: {0}", Matematik.Okek(15, 20));
            System.Console.WriteLine("Obeb: {0}", Matematik.Obebs(15, 20));

            int factori = 5;
            System.Console.WriteLine("{0}! Faktoriyel: {1}", factori, Matematik.Faktoriyel(5));
            System.Console.WriteLine("Ortalama = {0:F2}", (double)Matematik.AralikliFaktoriyel() / 7); ;

            int[] dizi = Matematik.StringIntDiziAktarimi("2,3,4,5,67");

            Matematik.IkilikSayiOnluk("101");

            System.Console.WriteLine("Köpek ifadesinde {1} adet sesli harf tespit edildi", Matematik.SesliHarfSayisiBelirleme("Köpek"));


            System.Console.WriteLine();
            Matematik.RenkDegistir("Renk Değişti");
            

            
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

        #region Asal Çarpanların Toplamını Bul [UZUN YOL]
        /// <summary>
        /// Bir sayının asal çarpanlarının toplamını verir
        /// </summary>
        /// <param name="sayi">sayi</param>
        /// <returns>Toplam</returns>
        internal static int AsalÇarpanlarinToplamlariBul(int sayi)
        {
            int toplam = 0;
            foreach (var item in HashSetAsalCarpanBul(sayi))
            {
                toplam += item;
            }

            return toplam;

        }
        #endregion

        #region Asal Çarpanların Toplamını Bul [KISA YOL]
        /// <summary>
        /// Bir sayının asal çarpanlarının toplamını verir
        /// </summary>
        /// <param name="sayi">sayi</param>
        /// <returns>Toplam</returns>
        internal static int AsalCarpanlarinToplamlariBulKisa(int sayi)
        {
            return HashSetAsalCarpanBul(sayi).Sum();
        }
        #endregion

        #region Asal Sayıların Çarpımı

        /// <summary>
        /// Bir sayının asal çarpanlarının çarpımını hesaplar
        /// </summary>
        /// <param name="sayi">sayı</param>
        /// <returns>çarpım sonucu</returns>
        internal static int AsalCarpanlarinCarpimi(int sayi)
        {
            int carpim = 1;
            var asalCarpanDizi = AsalCarpanlariBul(sayi);
            for (int i = 0; i < asalCarpanDizi.Length; i++)
            {
                carpim *= asalCarpanDizi[i];
            }
            return carpim;
        }
        #endregion

        #region OKEK
        internal static int Okek(int s1, int s2)
        {
            int okek = 1, bol = 2;
            while (s1 > 1 || s2 > 1)
            {
                bool boldur = false;
                if (s1 % bol == 0 || s2 % bol == 0)
                {
                    okek *= bol;
                    boldur = true;
                    if (s1 % bol == 0)
                        s1 /= bol;
                    if (s2 % bol == 0)
                        s2 /= bol;
                }
                if (!boldur) bol++;
            }
            return okek;
        }
        #endregion

        #region OBEB

        internal static int Obebs(int s1, int s2)
        {
            int obeb = 1;
            int bolen = 2;

            while (s1 != 1 && s2 != 1)
            {
                for (int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {

                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0) obeb *= bolen;
                        if (s1 % bolen == 0) s1 /= bolen;
                        if (s2 % bolen == 0) s2 /= bolen;

                    }
                    else bolen++;
                }

            }
            return obeb;
        }
        #endregion

        #region Faktoriyel Hesabı
        internal static int Faktoriyel(int n)
        {
            if (n <= 1) return 1;

            int f = 1;
            for (int i = 2; i <= n; i++) f *= i;

            return f;

        }
        #endregion

        #region Aralıklı Hesabı
        internal static int AralikliFaktoriyel()
        {
            int t = 0;

            for (int i = 2; i < 9; i++)
            {
                t += Matematik.Faktoriyel(i);
                System.Console.WriteLine("{0}! = {1}", i, Matematik.Faktoriyel(i));
            }


            return t;

        }
        #endregion

        #region Virgül ile ayrılmış stringi int diziye çevirme
        internal static int[] StringIntDiziAktarimi(string? ifade)
        {


            string[] bolunmusIfade = ifade!.Split(',');
            int n = bolunmusIfade.Length;

            int[] sayisalDizi = new int[n];

            //Ayristirma
            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                System.Console.WriteLine("Dizi[{0}] = {1}", i + 1, sayisalDizi[i]);
            }
            return sayisalDizi;
        }
        #endregion

        #region İkilik sayı ifadesini onluk sisteme çevirme
        internal static int IkilikSayiOnluk(string? sayi)
        {
            // uzunluk
            int n = sayi!.Length;

            //her bir basamğın dizide tutulmasi
            int[] basamaklar = new int[n];
            //Onluk karsiliği
            int onlukSayi = 0;
            bool kontrol = true;

            for (int i = 0; i < n; i++)
            {
                if (!(sayi[i] == '0' || sayi[i] == '1'))
                {
                    System.Console.WriteLine("Hatalı Giriş");
                    kontrol = false;
                    break;
                }

                basamaklar[i] = (int)(sayi[i] - '0');
            }

            // 2'lik sistemden 10'luk sisteme geçiş

            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                {
                    onlukSayi += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];

                }
                Console.Write("({0}) ikilik sayı = {1}", sayi, onlukSayi);
            }
            return onlukSayi;
        }
        #endregion

        #region Sesli Harf Sayısını Belirleme
        internal static int SesliHarfSayisiBelirleme(string kelime)
        {
            var sesliHarfDizi = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            int sesliSayisi = 0;
            for (int j = 0; j < sesliHarfDizi.Length; j++)
            {
                for (int i = 0; i < kelime.Length; i++)
                {

                    if (sesliHarfDizi[j] == kelime[i]) sesliSayisi++;
                }

            }

            return sesliSayisi;
        }
        #endregion

        #region Console Rengini Değiştir
        internal static void RenkDegistir(string? mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine(mesaj);
            Console.ResetColor();
            }
        #endregion
   
    }
}