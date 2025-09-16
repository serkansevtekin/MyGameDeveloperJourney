using System;

namespace Programlama.AlgoritmaTasarimi
{
    class ExtensionsMethodClass
    {
        public static void ExtensionsMethodRunMethod()
        {
            // ornek
            string s = "Merhaba Dünya";
            System.Console.WriteLine($"Kelime Sayısı: {s.KelimeSayisi()}");
            /*
            normalde string classında böyle Kelime sayısı diye bir  metot yoktu biz oynu StringExtension classı içinde Extension method yazarak methodu stringe genişlettik
            */

            //ornek1
            List<int> liste = new List<int> { 1, 2, 3, 4, 5, 6 };
            System.Console.Write($"List Extension Ornek:  ");
            liste.Yazdir();


        System.Console.WriteLine();

            //ornek2
            Kisi k1 = new Kisi("Serkan");
            string TamAdi = k1.Adi + " "+ k1.TamAd("sevtekin", 175);
            System.Console.WriteLine(TamAdi);
        }
    }


    #region Tanımı
    /* 
    - Bir sınıfı genişletmenin yollarından biri de "extension methods" kullanımıdır.
    - Kalıtım bir uygulamaya fonksiyonellik kazandıran yöntemlerden biridir.
    - Extensions method kullanımı da yine bir sınıfı genişletmek için tercih edilebilecek yollar arasındadır
    - Bu yöntem kalıtım (Inheritance) kullanılmadığında uygulanabilir
    - Extension methods'lar sınıfın kaynak kodunda bulunmadan bir sınıfın parçası gibi görünebilen static yöntemlerdir.
    - Derleyici "this" anahtar kelimesiyle özel bir tür için extension method yazıldığını anlayabilmektedir.

    Özet: Extension method, var olan bir sınıfa yeni fonksiyon eklemenin yoludur.

        **--- Bir sınıfı genişletmenin yolları ***---

    0. Inheritance (Kalıtım)
    1. Partial Class
    2. Extension Methods (Genişletme Metotları)
    3. Composition (Bileşim)
    4. Interfaces (Arayüz)

    */
    #endregion

    #region Ornek
    public static class StringExtension // extension methods için class static olmalı
    {
        //public static -> Extension metotlar static sınıf içinde static metot olmalıdır
        // this string s -> string tipine bu metodu genişletiyor. Artık herhangi bir string nesnesi çağrılabilir.
        //s.Split().Length -> Stringi boşluklardan böler ve kelime sayısını döndürür
        public static int KelimeSayisi(this string s) => s.Split().Length;
    }
    #endregion

    #region Örnek 1

    public static class ListExtensions
    {
        public static void Yazdir<T>(this List<T> liste)
        {

            foreach (var item in liste)
            {
                System.Console.Write($"{item}");
            }

        }
    }
    #endregion

    #region Ornek 2
    public static class KisilerExtensions
    {
        public static string TamAd(this Kisi k, string soyAd, int boy)
        {
            return $"{k.Adi} {soyAd} {boy}";
        }

       
        
       
    }
        
    #endregion


}