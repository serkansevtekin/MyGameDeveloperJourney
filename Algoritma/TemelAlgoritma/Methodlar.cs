using System;

namespace Programlama.MethodlarNameSpace
{
    public class MethodlarClass
    {

        /*
            **METHOD**
            
        - Diğer adları -> Method / Fonksiyon / Yordam / Altyordam
        - Erişim Belirteci (Access Modifiers) -> public , internal , protected , private
        - Eğer static yazmazsan, metodu çağırmak için önce sınıftan nesne oluşturman gerekir.
        - Eğer static yazarsan, sınıf ismi üzerinden direkt çağırabilirsin (nesne oluşturmadan).   
        
        **Tanımlama**
        - [access modifier] static [return type] MetotAdi([parametreler])
        */

        public static void MethodlarMainMethod()
        {
            //   StaticVeNonStaticMethodOrnek();
            //  KareAlmaMethod();
            //  EsnekParametreliMethod();

            MetotlariAsiriYuklemek();

        }


        #region StaticVeNonStaticMethodOrnekMetotlar
        private static void StaticVeNonStaticMethodOrnek()
        {
            int buyuk = Karsilastir(3, 5);
            System.Console.WriteLine(buyuk);


            //Non-Static Method
            //Önce sınıfın bir örneğini (instance) oluşturuyorsun, sonra bu nesne üzerinden metodu çağırıyorsun.
            MethodlarClass mc = new MethodlarClass();// nesne oluştur
            int buyuk2 = mc.KarsilastirNonStatic(3, 5); // Nesene üzerinden çağır
            System.Console.WriteLine(buyuk2);
        }

        public static int Karsilastir(int A, int B)
        {

            return A > B ? A : B; //ternary if (üçlü koşul operatörü)

            /*  if (A > B)
                {
                    return A;
                }
                else
                {
                    return B;
                } */
        }

        // non-static method → nesne üzerinden çağrılır
        public int KarsilastirNonStatic(int A, int B)
        {
            return A > B ? A : B;
        }
        #endregion

        #region  Kare Alma
        private static void KareAlmaMethod()
        {
            var x = KareAl(3);
            double y = KareAl(x);
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
        }

        protected static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }

        #endregion

        #region Parametre Sayısını Esnek Hale Getirme (params)

        private static void EsnekParametreliMethod()
        {
            double toplam = SeriToplami(2, 5.5, 15.12, 25.54, 13.13);
            System.Console.WriteLine("{0,5:0.##}", toplam); //:0.## Noktadan sonra iki karakter gösteren format
        }


        //" params " sayesinde metodu çağırırken istediğin kadar double sayıyı ayrı ayrı gönderebilirsin veya bir dizi olarak gönderebilirsin.
        //" params " herzaman son parametre olmalı
        private static double SeriToplami(int carp, params double[] seri)
        {
            double toplam = 0;
            foreach (double item in seri)
            {
                toplam += item;
            }
            return toplam * 2;
        }



        #endregion

        #region Method Overloading (metot aşırı yükleme)
        private static void MetotlariAsiriYuklemek()
        {
            double odencekMiktar = SatisYap(100);
             System.Console.WriteLine("{0:0.##}",odencekMiktar);//:0.## Noktadan sonra iki karakter gösteren format

            double odencekMiktar2 = SatisYap(100, 0.1);
            System.Console.WriteLine("{0:0.##}",odencekMiktar2);//:0.## Noktadan sonra iki karakter gösteren format
        }

        /// <summary>
        /// Satış yapan fonsiyon.
        /// </summary>
        /// <param name="miktar">Alış - veriş tutarı.</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>

        //Method imzası -> double SatisYap(double)
        private static double SatisYap(double miktar = 0)//miktar = 0 -> varsayılan değeri 0 veriyoruz
        {
            return miktar * 1.18;
        }

        /// <summary>
        /// İndirimli satış yapan fonksion
        /// </summary>
        /// <param name="miktar">Alış - veriş tutarı</param>
        /// <param name="indirim">indirim oranı</param>
        /// <returns>KDV eklenmiş indirimli toplam ödenecek miktar.</returns>

        //Overloading yapan method  
        //Method imzası -> double SatisYap(double, double)
        private static double SatisYap(double miktar, double indirim)
        {
            return (miktar * (1.0 - indirim)) * 1.18;
        }



        #endregion


    }


}