using System;
using System.Collections.Specialized;

namespace Programlama.DongulerNameSpace
{
    public static class Donguler
    {
        public static void DongulerMainMethod()
        {
            //  Döngüler = For , While , do-while , foreach

            //While
            //  WhileDongusuMethod();

            //do-while -> Herhangi bir koşula bakmaksızın bir kere kesin çalışır. Sonra while koşuluna bakar
            // DoWhileMethod();

            //For Döngüsü
            ForMethod();

        }

        private static void DoWhileMethod()
        {
            System.Console.WriteLine("Bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            do
            {
                System.Console.Write(" {0,3} ", i);
                i += 2;// 2 , 2 art
            } while (i < n);
        }

        private static void WhileDongusuMethod()
        {
            int i = 0;

            while (i < 10)
            {

                System.Console.WriteLine($"Döngü sayac: {i}"); // WriteLine -> satır satır yazmak için
                i++; // i = i + 1 ve i += 1 -> hepsi aynı
            }
            System.Console.WriteLine("Döngü Sonu i değeri: " + i);

            //2. örnek
            int sayac = 1;
            while (sayac <= 10)
            {
                //Write -> yan yana yamak için
                System.Console.Write("{0,-5}", sayac); //{0,5} -> 0  buraya bir değişken gelecek demek. "5" burada örnek. 5 ise her karakter için 5 karakter yer ayır ve sağa hizala. +5 sağa hizala , -5 sola hizala. 5. karakter benim verim gelsin
                sayac = sayac + 1; // sayac++ ve sayac +=1 -> hepsi aynı
            }

            //3. örnek
            int sayac2 = 1;
            while (sayac2 <= 10)
            {

                System.Console.WriteLine("{0,-3} {1,-3}", sayac2, sayac2 * sayac2);
                sayac2 += 1;
            }

            //4. Örnek
            int sayac3 = 10;
            while (sayac3 >= 1)
            {
                System.Console.WriteLine("{0,-3} {1,-3}", sayac3, sayac3 * sayac3);
                sayac3 -= 1;
            }
        }

        private static void ForMethod()
        {
            //Genel Bilgiler
            //  ForGenelVeRevers();
          

            //örnek 1
            //ForOrnek1();

            //örnek 2
            // ForOrnek2();

            //örnek 3
            ForOrnek3();

        }

        #region  ForGenelVeReversFor
        public static void ForGenelVeRevers()
        {
            for (int i = 0; i < 100; i += 5)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine("Revers For");
            //Rvers for -> forr
            for (int i = 100; i >= 0; i -= 5)
            {
                System.Console.WriteLine(i);
            }
        }

        #endregion ForGenelVeReversFor


        #region For Ornekleri
        public static void ForOrnek1()
        {
            System.Console.WriteLine("i degeri ve karesi");

            for (int i = 1; i < 10; i += 1)
            {
                System.Console.WriteLine("{0,-3} {1,-3}", i, i * i);
            }

        }

        private static void ForOrnek2()
        {
            System.Console.WriteLine("2 Sayı Giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i += 1)
            {
                // i sayısı 3'e tam bölünüyorsa (kalan 0 ise) bu koşul çalışır, yani i 3'ün katıdır
                if (i % 3 == 0)
                {
                    continue;//i değerini direk artış miktarı kadar arttırır

                }
                if (i == 100)
                {
                    break;//döngüden çık
                }
                System.Console.WriteLine("{0,-3}", i);
            }
        }
        public static void ForOrnek3()
        {
            System.Console.WriteLine("Değer gir");
            int n = Convert.ToInt32(Console.ReadLine());
            
        
            for (int i = 0; i < n; i += 1)
            {
                for (int j = 0; j <= i; j += 1)
                {
                    System.Console.Write(" * ");
                }
                System.Console.WriteLine();
            }
        }

        #endregion  For Ornekleri


    }

}