using System;

namespace DelegateOrnek1
{
    public class DelegateOrnek1Class
    {
        public static void DelegateOrnek1RunMain()
        {
            //---- DELEGATE ----
            MyDelegate myDelegate = MesajYaz;
            myDelegate += UyariYaz;
            myDelegate("Selam");

            MathDelegate hesapla = Topla;
            hesapla += Carp;// Topla ve Carp artık aynı delegate listesinde
            int sonuc = hesapla(3, 4);
            System.Console.WriteLine(sonuc);// Topla çaşlışır ama sadece son metodun(Carp) dönüş değeri yazdırılır.


            Dikdortgen dik = alan;
            System.Console.WriteLine(dik(4, 6));

            dik += cevre;
            System.Console.WriteLine(dik(4, 6));








            // --- ACTION ---
            // void dönen metotlar için
            Action<string> logla = s => System.Console.WriteLine("Log: " + s);
            logla("Oyun basladi");

            // --- FUNC ---
            // Geri dönüş değeri olan metotlar için (son parametre return tipidir.)
            Func<int, int, int> fark = (x, y) => x - y;
            System.Console.WriteLine("Fark: " + fark(10, 4));

            // --- PREDICATE ---
            // Her zaman bool döner
            Predicate<int> ciftMi = x => x % 2 == 0;
            System.Console.WriteLine("4 cift mi: " + ciftMi(4));

        }

        // Delegate Tanımı
        public delegate void MyDelegate(string msg); // void ve parametreli delegate
        public delegate int MathDelegate(int a, int b); // parametreli ve int döndürem delegate
        public delegate double Dikdortgen(double x, double y);
     


        //Void Metotlar
        static void MesajYaz(string MesajText)
        {
            System.Console.WriteLine("Mesaj: " + MesajText);
        }
        static void UyariYaz(string UyariText)
        {
            System.Console.WriteLine("Uyarı: " + UyariText);
        }

        //Parametreli metotlar
        static int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static int Carp(int a, int b)
        {
            return a * b;
        }


        static double cevre(double a, double b)
        {
            return 2 * (a + b);
        }
        static double alan(double a, double b)
        {
            return a * b;
        }

     
    }




}