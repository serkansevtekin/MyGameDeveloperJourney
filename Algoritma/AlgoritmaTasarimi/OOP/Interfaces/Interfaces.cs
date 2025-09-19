using System;

namespace Programlama.AlgoritmaTasarimi
{
    class InterFaceClass
    {
        public static void InterFaceRunMain()
        {
            /*   MevduatHesabi mevduatHesabi = new MevduatHesabi();
              mevduatHesabi.Yatir(100);
              mevduatHesabi.Cek(500);
              mevduatHesabi.Cek(50);
              System.Console.WriteLine(mevduatHesabi.ToString());//2.yol
              System.Console.WriteLine("Bakiye: " + mevduatHesabi.Bakiye);//1. yol



              System.Console.WriteLine();



              YatirimHesabi yatirimHesabi = new YatirimHesabi();
              yatirimHesabi.Yatir(100);
              yatirimHesabi.Cek(500);
              yatirimHesabi.Cek(50);
              System.Console.WriteLine(yatirimHesabi.ToString());//2.yol
              System.Console.WriteLine("Bakiye: " + yatirimHesabi.Bakiye);//1. yol */


            //Trasnfer Interface
            var mevduatHesabi = new MevduatHesabi();
            var aktfitHesap = new AktifHesap();

            mevduatHesabi.Yatir(500);
            aktfitHesap.Yatir(800);

            System.Console.WriteLine($"Mevduat Hesabı trasfer öncesi bakiye {mevduatHesabi.Bakiye}");
            System.Console.WriteLine($"Aktif Hesap trasfer öncesi bakiye {aktfitHesap.Bakiye}");

            aktfitHesap.TrasferYap(mevduatHesabi, 200);
            aktfitHesap.TrasferYap(mevduatHesabi, 400);
            System.Console.WriteLine("Trasfer sonrası " + mevduatHesabi.ToString());
            System.Console.WriteLine(aktfitHesap.ToString());

        }
    }

    #region Tanım
    /*
    - Interface tanımlaması yapılırken genellikle "I" deyimi ile başlanır örnek: IOrnek
    - Bir "interface" yapısından sınıf türetmek, daha önce imzası tanımlanmış olan metotların "implemente" edilmesi anlamına gelir.
    - Tüm nesne yönenelimli diller "interface" yapısını desteklemez.
    - Genel olarak "interface" tapısı sadece methods, properties, indexer ve events'ların deklarasyonunun içerir.

    - Bir abstract sınıf implementasyonlar veya implementasyonu olmayan üyeler içerir. 
    - ANCAK interface yapısı, herhangi bir implementasyon içermez yani tamamen soyuttur.
    - Çünkü interdace yapısının üyeleri her zaman abstract şeklinde tanımlanır.
    
    - Bununla birlikte abstract deyimi interface için gerekli değildir.
     
     - Abstract sınıflarda olduğu gibi interface üzerinde somutlaştırma, yani nesne üretme yapılamaz.
     - Interface yapısı sadece üyelerin imzalarını taşır
     -Intrface yapısı ne constructor ne de field üyelerine sahip değildir
     - Interface tanımlamasında modifier kullanımına da izin verilmez
     - Interface üyeleri her zaman public olarak tanımlanır ve virtual olarak deklare edilemez

    //Interface Nedir? | AI yazısı
     - Interface -> Bir sözleşmedir (contract).
     - İçinde sadece imzalar (metot, property, event, indexer tanımları) bulunur.
     - Gövde (implementation) yazılmaz.
     - Interface'i implemente eden (uygulayan) sınıf, bu sözleşmedeki her şeyi uygulamak zorundadır.
     - Sadece imzalar (C# 8+ default implementation ile gövde yazılabilir)
     - Constructor yok.

    //Interface Avantajı | AI yazısı
        * Çoklu miras mümkün (C#'ta sınıflarda çoklu miras yok ama interface ile olur)  
        * Farklı sınıfları ortak bir çatı altında toplar
        * Polymorphism sağlar -> bir interdace tüpünden değişken, farklı sınıflara işaret edebilir     
    */
    #endregion


}