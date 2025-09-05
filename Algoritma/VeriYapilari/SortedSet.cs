using System;

namespace Programlama.VeriYapilari
{
    class SortedSetClass
    {
        public static void SortedSetMainMethod()
        {
            //  Temelleri();
            //Uygulama();
            KumeUygulamasi();
        }

        private static void KumeUygulamasi()
        {
            //Küme Fonksiyonları

            //var A = new SortedSet<int>() { 1, 2, 3, 4 };
            // var B = new SortedSet<int>() { 1, 2, 5, 6 };
            var A = new SortedSet<int>(RastgeleSayiUret(10));
            var B = new SortedSet<int>(RastgeleSayiUret(10));

            #region Yazdirma

            System.Console.WriteLine();
            System.Console.WriteLine("A Kümesi");
            foreach (int item in A)
            {
                System.Console.Write($"\t{item,-5}");
            }
            System.Console.WriteLine();

            System.Console.WriteLine();
            System.Console.WriteLine("A Kümesi");
            foreach (int item in B)
            {
                System.Console.Write($"\t{item,-5}");
            }
            System.Console.WriteLine();
            #endregion

            //Birleşim (Union)  
            //  A.UnionWith(B);

            //Kesişim
            //A.IntersectWith(B);

            //Setten diğer kolleksiyonlardaki elemanları çıkarır
            // A.ExceptWith(B);

            //Sette olmayan elemanları ekler, olanları çıkarır (Fark işlemi)
            //A.SymmetricExceptWith(B);

            //A benin alt kümesimi
            //A.IsSubsetOf(B); // True / False döner


            System.Console.WriteLine();
            System.Console.WriteLine("\nSadece A");
            foreach (int item in A)
            {
                System.Console.Write($"\t{item,-5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"\nToplam Eleman Sayısı: {A.Count}");
            System.Console.WriteLine();

        }
        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 10));
            }
            return list;
        }

        private static void Uygulama()
        {
            //Ornek
            var sayilarList = new List<int>();
            var r = new Random();
            System.Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilarList.Add(r.Next(0, 10));// 0 ile 10 arasında rasgele sayı üret ve sayilar listesine ekle
                System.Console.Write($"{sayilarList[i],-3}");
            }
            System.Console.WriteLine();

            //Listedeki benzersiz(unique) elemanları bulma
            var benzersizSayiSet = new SortedSet<int>(sayilarList);
            System.Console.WriteLine();
            System.Console.WriteLine("\nBenzersiz sayıların listesi \n");
            foreach (int item in benzersizSayiSet)
            {
                System.Console.Write($"{item,-3}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("\nBenzersiz sayilar: {0}", benzersizSayiSet.Count);
        }


        private static void Temelleri()
        {
            //SortedSet<T> 
            //Tanım
            var isimList = new SortedSet<string>();

            //Ekleme
            if (isimList.Add("Mehmet"))
            {
                System.Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                System.Console.WriteLine("Ekeleme başarısız");
            }
            System.Console.WriteLine("{0}", isimList.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");

            if (isimList.Add("Mehmet"))//mehmet var mı? yok ise ekle varsa ekleme
            {
                System.Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                System.Console.WriteLine("Ekeleme başarısız");
            }

            isimList.Add("Sule");
            isimList.Add("Neslihan");
            isimList.Add("Fahrettin");
            isimList.Add("Fatih");

            System.Console.WriteLine("\nİsimler Listesi\n");
            foreach (string item in isimList)
            {
                System.Console.WriteLine(item);
            }

            //Eleman Kaldırma
            isimList.Remove("Sule");

            System.Console.WriteLine("\nEleman Kaldırma Sonrası İsimler Listesi\n");
            foreach (string item in isimList)
            {
                System.Console.WriteLine(item);
            }

            //RemoveWhere(predicate) -> koşula bağlı eleman kaldırma
            isimList.RemoveWhere(deger => deger.Contains("a"));
            System.Console.WriteLine("\n Koşula Bağlı Eleman Kaldırma Sonrası İsimler Listesi\n");
            foreach (string item in isimList)
            {
                System.Console.WriteLine(item);
            }


            //Eleman sayısı
            System.Console.WriteLine($"Eleman Sayısı:  {isimList.Count}");

        }


        #region Temel Bilgiler
        /*
        - Elemanları benzersiz(unique) olmalıdır
        - Elemanları sıralı olarak tutar.
        - Sıralama işlemi ekleme esnasında yapılır.
        - Elemanlar otomatik olarak sıralanır.
        - Add() - ekleme -> bool döner
        - Remove() - eleman silme
        - RemoveWhere(Predicate<T> match) -> elemanları verilen predicate(koşul) göre siler. Lamda yazılır.

        -Dinamik bir ver yapısı
        -Küme teorisini destekler:
            -Kesişim, Birleşim, Ayrım , Alt kümeler

        predicate = koşul




        **--** PROPERTIES **--**
        - Count -> Eleman sayısını verir
        - Comparer -> Elemanları sıralamak için kullanılarn "IComparer<T>" nesnesini verir.
        - Min -> En küçük eleman döner
        - Max -> En büyük eleman döner
        - IsReadOnly -> Set'in salt okurnur olup olmadığını belirtir (Genellikle false)



        *--* METHODS *--*

        ** A) Eleman Ekleme ve Silme

        - Add(T item) -> Elemanı sete ekler. Zaten varsa false döner

        - Remove(T item) -> Bilirtilen elemanı setten siler. True/False döner

        - RemoveWhere(Predicate<T> match) -> Predicate'e (koşul) uyan tüm elemanları siler. Kaç elaman sildiğinin bilgisi döner.

        - Clear() -> Setin tüm elemanlarını siler.




        ** B) Sorgulama

        - Contains(T item) -> Eleman sette var mı? Kontrol eder.

        - TryGetValue(T equalValue, out T actualValue) -> set içinde eş değer bir elemanı bulur ve out ile verir.

        - GetViewBetween(T lowerValue, T upperValue) -> Belirli bir aralıktaki elemanları içeren yeni bir görünüm döner




        ** C) Set İşlemleri (Küme (Kesişim, Birleşim, Ayrım , Alt kümeler))

        - UnionWith(IEnumerable<T> other) -> Seti diğer kolleksion ile birleştirir

        - IntersectWith(IEnumerable<T> other) -> Set ile diğer kolleksiyonun kesişimini alır

        - ExceptWith(IEnumerable<T> other) -> Setten diğer kolleksiyonlardaki elemanları çıkarır

        - SymmetricExceptWith(IEnumerable<T> other) -> Sette olmayan elemanları ekler, olanları çıkarır (Fark işlemi)

        - IsSubsetOf(IEnumerable<T> other) -> Setin diğer kolleksiyonun alt kümes olup olmadığını konrol eder

        - IsSupersetOf(IEnumerable) -> Setin diğer kolleksiyonun üst kümesi olup olmadığını konrol eder.

        - Overlaps(IEnumerable<T> other) -> Set ile diğer kolleksiyonun ortak elemanı var mı? Kontrol eder.

        - SetEquals(IEnumerable<T> other) -> Set ile diğer kolleksion tamamen eşit mi? Kontrol eder.



        ** D) Enumeration

        - GetEnumerator() -> Set elemanları üzerine dönemek için enumeratör döner

        - CopyTo(T[] array, int arrayIndex) -> Elemanları bir diziye kopyalar
        */
        #endregion
    }
}