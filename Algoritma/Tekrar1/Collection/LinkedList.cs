using System;

namespace Programlama.Tekrars1
{
    public class LinkedListTekrarClass
    {
        public static void LinkedListTekrarRun()
        {
            LinkedList<char> ch = new LinkedList<char>();
            ch.AddFirst('A');
            ch.AddLast('B');
            ch.AddLast('C');
            ch.AddLast('Z');

            //Node referansını al
            LinkedListNode<char> nodeB =ch.Find('B')!;//'B' elemanı

            //B'den sonra ekle
            ch.AddAfter(nodeB, 'X');

            //B'den önce ekle
            ch.AddBefore(nodeB, 'Y');

            foreach (var item in ch)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("\n");

            //silme


            //Remove-> True / False
            System.Console.WriteLine("C : {0}", ch.Remove('C') ? "Silindi" : " Bulunamadı");

            //Belirli bir değeri bulup silmek
            if (ch.Find('X') != null)
            {
                ch.Remove('X');
            }


            System.Console.WriteLine("İlk eleman: {0}", ch.First());
            ch.RemoveFirst();
            System.Console.WriteLine("İlk eleman silindi");
            foreach (var item in ch)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();


            System.Console.WriteLine("Son eleman: {0}", ch.Last());
            ch.RemoveLast();
            System.Console.WriteLine("Son eleman silindi");
            foreach (var item in ch)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            //Tersine çevir elemanları
            var node = ch.First;
            while (node != null)
            {
                var next = node.Next;
                ch.Remove(node);
                ch.AddFirst(node); // başa taşı
                node = next;
            }

            foreach (var item in ch)
            {
                System.Console.WriteLine(item);
            }
        }
        
        #region Tanım
            /*
            Yapı: Çift yönlü bağlı liste (doubly linked list)
            Sıra: Elemanlar ekleme sırasına göre tutulur
            Benzersizlik: Yok, duplicate eklenebilir
            Erişim:
                - İndexleme yavaş (O(n)), çünkü sıralı diziler gibi direkt erişim yok
                - Baş ve son elemandan ekleme/çıkarma hızlı (O(1))
            Performans:
                - Orta boyutlu veri için insert/remove avantajlı, özellikle baş/son veya belirli bir node referansıyla.
            
            Kullanım Senaryoları:
                - FIFO/LIFO yapısı gereğinde (queue / stack implementasyonu)
                - Sık ekeleme/çıkarma yapılan listeler
                - Node referansına dayalı veri manipülasyonu

            Not: İndexleme için "List<T>" daha uygundur, "LinkedList<T>" daha çok ekeleme / çıkarma yoğun olduğu senaryolarda avantajlıdır
            */
        #endregion
    }
}