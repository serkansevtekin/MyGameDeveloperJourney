using System;
using System.Collections;

namespace Programlama.VeriYapilari
{
    class SortedListClass
    {
        public static void SortedListMainMethod()
        {
            //SortedList |Temeller
            //  SortedListTemelleriMethod();
            SortedListUygulamaMethod();
        }

        private static void SortedListTemelleriMethod()
        {
            var list = new SortedList()
            {
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"},
                {8,"Sekiz"},
                {5,"Beş"},
                {6,"Altı"}
            };
            list.Add(4, "Dört");

            //Dolaşım
            foreach (DictionaryEntry item in list)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }

            System.Console.WriteLine("Listedeki Eleman Sayısı: " + list.Count);
            System.Console.WriteLine("Listenin Kapasitesi: " + list.Capacity);
            /*
            Amaç: Koleksiyonun kapasitesini, içerdiği eleman sayısına eşitlemek.
            Bu sayede gereksiz bellek kullanımını azaltırsın.   
            */
            list.TrimToSize();
            System.Console.WriteLine("TrimToSize Sonrası Listenin Kapasitesi: " + list.Capacity);

            //Erişim
            //Key
            System.Console.WriteLine("Key'e bağlı değer: " + list[4]);// [key] girilir-> key e bağlı değer alma 

            //Indeks'e bağlı erişim
            System.Console.WriteLine("Indekse bağlı değer: " + list.GetByIndex(4));// indekse bağlı değer alma

            System.Console.WriteLine("Indekse bağlı key: " + list.GetKey(0));// indekste bulunan key değerini verir

            //liste sonundaki elemana ulaşma
            System.Console.WriteLine("Liste sonundaki eleman değeri: " + list.GetByIndex(list.Count - 1));

            //Liste sonundaki keye ulaşma
            System.Console.WriteLine("Liste sonundaki key: " + list.GetKey(list.Count - 1));

            //Sadece tüm anahtarları almak

            ICollection anahtar = list.Keys;
            System.Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtar)
            {
                System.Console.WriteLine(item);
            }

            //Sadece tüm değerleri almak
            System.Console.WriteLine("\nTum Değerleri almak");
            ICollection tumDegerler = list.Values;
            foreach (var item in tumDegerler)
            {
                System.Console.WriteLine(item);
            }

            //Key varmı yokmu Kontrollü
            System.Console.WriteLine("\n Key varmı ve güncelleme");
            if (list.ContainsKey(1)) //içinde anahtar (key) değeri 1 var mı diye kontrol eder.
            {
                list[1] = "One";//içindeki 1 anahtarlı elemanın değerini "One" olarak günceller.
            }
            foreach (DictionaryEntry item in list)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }

        private static void SortedListUygulamaMethod()
        {
            SortedList kitapIcerigi = new SortedList()
            {
                {1,"Önsöz"},
                {50,"Degişkenler"},
                {40,"Operatörler"},
                {60,"Döngüler"},
                {45,"İlişkisel Operatörler"}
            };

            System.Console.WriteLine("\nİçindekiler");
            System.Console.WriteLine(new string('-',25));
            System.Console.WriteLine($"{"Konular",-20}  {"Sayfalar",5}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                System.Console.WriteLine($"{item.Value,-25}{item.Key,5}");
            }
        }

        #region Kavramsal Genel Bilgiler
        /*
        **SortedList

        - DictionaryEntry ile yönetiyoruz.
        - System.Collecitions sınıfına aittir
        - Non-generic (object)
        - Key - Value pairs
        - Ekleme yapılırken key sıralanır.
        - Sıralı organize edilir
        - Hem key(anahtar) ile hemde index ile elemanlara erişmek mümkün
        - anahtarları sıralamak için IComparer arayüzünü kullanabilir.

        Özellikler (Properties)
        - Count → Eleman sayısı.
        -IsFixedSize → Sabit boyutlu mu?
        - IsReadOnly → Salt okunur mu?
        - IsSynchronized → Thread-safe mi?
        - Keys → Anahtar koleksiyonu.
        - Values → Değer koleksiyonu.         
        - SyncRoot → Thread senkronizasyonu için nesne.


        Metodlar (Methods)
        
        - IndexOfKey -> Anahtarın sıralı indexi
        - IndexOfValue -> Değerin sıralı indexi
        - GetKey -> Indexteki anahtarı alır
        - GetByIndex -> Indexteki değeri alır
        - Contains -> Anahtar var mı
        - ContainsValue -> Değer var mı
        - Add -> Yeni eleman ekler
        - Clear -> Tüm elemanları siler
        - Remove -> Anahtara göre siler
        - RemoveAt -> Indekse göre siler
        - SetByIndex -> Indeksteki değeri değiştirir
        
        */

        #endregion
    }
}