using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class Operatorler
    {
        public static void OperatorlerRunMet()
        {
            //AritmetikOperatorler();
            //AtamaOperatorleri();
            //KarsilastirmaOperatorleri();
           // MantiksalOperatorler();
            RandomMetodu();

        }

        private static void RandomMetodu()
        {
            Random rnd = new Random();
            System.Console.WriteLine(rnd.Next(1, 10));

            string[] takimlar = { "bjk", "fb", "gs", "ts" };
            System.Console.WriteLine(takimlar[rnd.Next(0,takimlar.Length)]);
        }

        private static void MantiksalOperatorler()
        {
            /* 
                        int yas = 17;
                        bool veli_izni = false;
                        string sonuc = (yas >= 18 || veli_izni) ? "Çalışabilir" : " çalışamaz";
                        System.Console.WriteLine(sonuc);

            int not = 51;
            var sonuc = (not >= 50) && (not <= 100);
            System.Console.WriteLine(sonuc ? "Geçti":"Kaldı" );
         

            int ders1 = 60  , ders2 = 70, ders3 = 70;
            var sonuc = (ders1 + ders2 + ders3) / 3  >= 70 ? "Teşekkür alır":"Teşekkür alamaz";
                System.Console.WriteLine(sonuc);
             

            string egitimDurumu = "lisans";
            bool sigaraKullanimi = false;

            var sonuc = (egitimDurumu == "lisans" || egitimDurumu == "önlisans") && (!sigaraKullanimi);
            System.Console.WriteLine(sonuc ? "işe gire bilir": "işe giremez");
               */

            string username = "ser";
            string email = "ser@gmail.com";
            string paswword = "123";

            System.Console.WriteLine(((username == "ser" || email == "ser@gmail.com") && paswword == "123") ? "Giriş BAŞARILI" : "Giriş Başarısız");


        }

        private static void KarsilastirmaOperatorleri()
        {
            int a = 5, b = 5, c = 10, d = 3;
            string username = "serkan";
            string paswword = "123";
            var sonuc = (a == b); // true
            sonuc = (c == d); // false
            sonuc = (username == "serkan");
            sonuc = (paswword == "123");
            sonuc = (a != b); //false;
            sonuc = (a > c); //false;
            sonuc = (a < c); //true;
            sonuc = (a >= b); //true;

            var sonuc2 = (a > b) ? "a büyük" : (a == b) ? "a b eşit" : "b büyül";



            System.Console.WriteLine(sonuc2);
        }

        private static void AtamaOperatorleri()
        {
            var a = 5;
            var b = 10;

            a += b;
            a += 5;
            a -= b;
            a *= b;
            a /= b;
            a %= b;

            //Math

            double sonuc;

            sonuc = Math.Pow(2, 3);     // 2 üzeri 3
            sonuc = Math.Sqrt(25);      // Karekök 25 kökü = 5
            sonuc = Math.Abs(-10);      // Mutlak değer -> herzaman pozitif gönderir -> |-10| = 10
            sonuc = Math.Round(4.5);    //  yuvarlama
            sonuc = Math.Ceiling(4.4);  // yukarı yuvarlama
            sonuc = Math.Floor(4.4);    // aşağı yuvarlama
            sonuc = Math.Max(10, 20);   // en yüksek değeri alır
            sonuc = Math.Min(10, 20);   // en küçük değeri alır


            System.Console.WriteLine(sonuc);

        }

        private static void AritmetikOperatorler()
        {
            /*   int a = 2;
             int b = a++;//önce b değişkenine a değişkeninin ilk değerini yazar daha sonra a'yı artırır
             System.Console.WriteLine(a);
             System.Console.WriteLine(b);

             System.Console.WriteLine();

              int c = 2;
             int d = ++c; //önce b değişkeinin artırır daha sonra c değişkeninni de artırır
             System.Console.WriteLine(c);
             System.Console.WriteLine(d);

           int a = 10;
           int b = 5;
           int c = 20;
           var sonuc = (c - a) * b;


           int? a = null;
           int b = 20;
           var sonuc = (a ?? 0) + b; // a null ise 0 yaz
           Console.WriteLine(sonuc);


           int a = 10;
           int b = 20;
           a = b--;//b'nin değerini a ya ata ve b'yi azalt
           System.Console.WriteLine(a);
           System.Console.WriteLine(b);



           Console.Write("Sayı: ");
           int sayi = int.Parse(Console.ReadLine() ?? "0");
           var sonuc = sayi % 2;//mod alma
           System.Console.WriteLine(sonuc); // 1 ise sayı tek, 0 ise sayı çift
*/
        }
    }
}