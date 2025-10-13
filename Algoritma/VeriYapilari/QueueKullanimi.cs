using System;
using System.Collections;

namespace Programlama.VeriYapilari
{
    class QueueKullanımıClass
    {
        public static void QueueMainMethod()
        {
            //Temel Bilgiler
            // TemelBilgiler();

            //Queue Uygulamsı Örnek1
            //QueueOrnekUygulamasi();

            //Cheatgpt Örnek
            //CheatgptOrnek();

            //Bağımsız kopya yada listeye çevirme | ToList() , new List<T>(queue)
            BagimsizKopya();
        }

        private static void BagimsizKopya()
        {
            //Kuyruk | Queue
            Queue<int> kuyruk = new Queue<int>();

            kuyruk.Enqueue(1);
            kuyruk.Enqueue(2);

            //Listeler
            List<int> liste1 = kuyruk.ToList();

            List<int> liste2 = new List<int>(kuyruk);

            //Kuyruğa yeni eleman ekleme
            kuyruk.Enqueue(3);

            //Listelere yeni eleman ekeleme
            liste1.Add(10);

            liste2.Add(1000);

            //Hepsini ekrana yazdırma

            System.Console.WriteLine("\n --- Queue(kuyruk) ---");

            foreach (int item in kuyruk)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("\n --- List<int> | ToList() ile ---");

            foreach (int item in liste1)
            {
                System.Console.WriteLine(item);
            }
            
             System.Console.WriteLine("\n --- new List<int>(queue) ---");

            foreach (int item in liste2)
            {
                System.Console.WriteLine(item);
            }



        }

        private static void CheatgptOrnek()
        {
            // Tanımlama | Queue<T> değişkenAdi = new Queue<T>();
            Queue<string> kuyruk = new Queue<string>();

            //Eleman ekeleme | Enqueue()
            kuyruk.Enqueue("elma");
            kuyruk.Enqueue("armut");
            kuyruk.Enqueue("muz");
            kuyruk.Enqueue("kiraz");

            //Eleman sayısı | Count
            System.Console.WriteLine($"\nKuyruktaki eleman sayısı: {kuyruk.Count}");



            //Kuyruktaki Tüm elemanlar
            System.Console.WriteLine("\n---- Kuyruktaki Elemanlar ----");
            foreach (string item in kuyruk)
            {
                System.Console.WriteLine(item);
            }

            //İlk işlenecek elemanı göster ama çıkarma | Peek()
            System.Console.WriteLine("\n---- Peek (ilk işlenecek elemanı gör)");
            System.Console.WriteLine($"Peek: {kuyruk.Peek()}");

            //ilk işlenecek elemanı çıkar ve göster
            System.Console.WriteLine("\n--- Dequeue (İlk işleneceke elemanı çıkar ve göster)");
            System.Console.WriteLine($"Dequeue: {kuyruk.Dequeue()}");


            System.Console.WriteLine($"\n Yeni ilk eleman: {kuyruk.Peek()}");


            // Eleman varmı | Contains() -> ture , false döner
            System.Console.WriteLine("\n---- Contains (İçeriyor mu?) ----");
            System.Console.WriteLine($"'Muz' var mı? {kuyruk.Contains("muz")}");


            // List<T> dönüştürme | ToList() veya  new List<string>(kuyruk) 
            List<string> yeniMeyveListesi = kuyruk.ToList();

            System.Console.WriteLine("\nListye çevrilen elemanlar:");
            foreach (string item in yeniMeyveListesi)
            {
                System.Console.WriteLine(item);
            }


            //Elemanları kopylama | ToList() veya  new List<string>(kuyruk)
            List<string> copyaList = new List<string>(kuyruk);
            System.Console.WriteLine("\nListye kopyalanan elemanlar:");
            foreach (string item in yeniMeyveListesi)
            {
                System.Console.WriteLine(item);
            }

            //Kapasiteyi kırp | TrimExcess()
            System.Console.WriteLine("\n---- TrimExcess (Fazla kapasiteyi kırp) ---");
            kuyruk.TrimExcess();


            //Kapasiteyi göster | Capacity
            System.Console.WriteLine($"\n Kapasite : {kuyruk.Capacity}");

            //Tüm elemanları sil | Clear()
            System.Console.WriteLine("\n-----  Clear (Tümünü temizle) -------");
            kuyruk.Clear();
            System.Console.WriteLine($"Tüm kuyruk elemanları temizlendi. Eleman Sayısı : {kuyruk.Count}");
        }

        private static void TemelBilgiler()
        {
            //Tanımlama
            var karakterKuyrugu = new Queue<char>();

            //Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');

            //Diziye çevirme | Listeye çevirme
            char[] dizi = karakterKuyrugu.ToArray();//Diziye atma
            List<char> Liste = karakterKuyrugu.ToList();//Listeye atma



            //Kaç Eleman var
            System.Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");

            //Kuyruğun başındaki elemanı göster
            System.Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");

            //Çıkarma
            System.Console.WriteLine($"{karakterKuyrugu.Dequeue()} ilk eklenen eleman kuyruktan çıkartıldı");


            //Kaç Eleman var
            System.Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");

            //Kuyruğun başındaki elemanı göster
            System.Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");


        }

        private static void QueueOrnekUygulamasi()
        {

            var sesliHarfler = new List<char>()
            {
                'a','e','ı',',','u','ü','o','ö'
            };
            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();
            foreach (char item in sesliHarfler)
            {
                System.Console.WriteLine($"{item,-5} Kuyruğa eklensin mi? [e/h]");
                secim = Console.ReadKey();
                System.Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(item);
                    System.Console.WriteLine($"\n{item,-5} kuyruğa eklendi");
                    System.Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
            }
            System.Console.WriteLine();


            System.Console.WriteLine("\nKuyruktaki tüm elemanlar");
            foreach (char item in kuyruk)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Kuyruktan elemanların kaldırılması işlemi için Esc tuşuna basın");
            secim = Console.ReadKey();


            if (secim.Key == ConsoleKey.Escape)
            {

                while (kuyruk.Count > 0)
                {
                    System.Console.WriteLine($"{kuyruk.Peek()} kuyruktan çıkartılıyor");
                    System.Console.WriteLine($"{kuyruk.Dequeue()} kuyruktan çıkarıldı");
                    System.Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");
                }
                System.Console.WriteLine("\n kuyruktan çıkrma işlemi yapıldı");

            }






        }

        #region Queue (Kuyruk) veri yapısı
        /*
        Mantık: FIFO (First In, First Out) -> ilk eklenen ilk çıkar
        Temel İşlemler:
            - Enqueue(T item)-> kuyruğa ekle
            - T Dequeue() -> kuyruğun başındaki öğeyi çıkar ve dödür
            - T Peek() -> Baştaki öğeyi çıkarma, sadece bak
            - Count -> öğe sayısı
        
        Performans:
            Enqueue / Dequeue O(1)

        Kullanım senaryoları:
            -Task veya event sıralaması
            - Job processing / coroutine yöntemi
            - Breadth-first search (BFS) algoritması

        Özet: FIFO mantığı ile veri yönetimi sağlar, sıralı işleme gerektiren durumlar için uygundur.



        */

        #endregion
    }
}