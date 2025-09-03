using System;

namespace Programlama.VeriYapilari
{
    class QueueKullanımıClass
    {
        public static void QueueMainMethod()
        {
            //Temel Bilgiler
            TemelBilgiler();
        }

        public static void TemelBilgiler()
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
            System.Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkartıldı");


            //Kaç Eleman var
            System.Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");

            //Kuyruğun başındaki elemanı göster
            System.Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");


        }

        #region Queue (Kuyruk) veri yapısı
        /*
            - Queue -> sıralı işlerin düzenli yapılmasını sağlar.

            - FIFO(First In, First Out) İlk giren ilk çıkar

            - Gerçek Hayattaki benzetme "Market kasası kuyruğu"

            **Özellikleri**
                - Enqueue() -> "Ekleme" Kuyruğun sonuna eleman ekler
                - Dequeue() -> "Çıkarma" Kuruğun başındaki elemanı çıkarır
                - Peek() -> "Gösterme" Kuyruğun başındaki elemanı gösterir
                - Count -> Eleman sayısını verir
                - Clerar -> Kuyruğu tamamen temizler.

            /// Oyunlarda Kullanım Alanları ///

             - Oyun içi Event / İşlem kuyruğu
             - AI (Yapay Zeka) Hareket Kuyruğu
             - Pathfinding (Yol Bulma - BFS)
             - Projectile | Mermi Havuzu | Object Pooling
             - Multiplayer | Server Sistemleri
             - Animasyon | Ses Kuyruğu




        */

        #endregion
    }
}