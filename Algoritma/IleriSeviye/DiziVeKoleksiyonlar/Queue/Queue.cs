using System;
using System.Collections;

namespace Programlama.IleriAlgoritma
{
    public class IleriQueueClass
    {
        public static void IleriQueueMainMethod()
        {
            AnaQueueKullanimi();
            //StrategyPatternKullanarakApp();
        }

           public static void AnaQueueKullanimi()
           {
               //Queue oluşturma
               Queue<int> numbers = new Queue<int>();

               //Eleman Ekleme (Enqueue)
               numbers.Enqueue(10);
               numbers.Enqueue(20);
               numbers.Enqueue(1100);

               //Dögü ile eleman ekleme (Enqueue)
               for (int i = 30; i <= 100; i += 10)
               {
                   numbers.Enqueue(i); 
               }

               //Eleman Sayısı (Count)
               System.Console.WriteLine("Eleman Sayısı : " + numbers.Count);

               //Tüm elemanları gezmek
               System.Console.Write("\nTüm Elemanlar: ");
               foreach (var item in numbers)
               {
                   System.Console.Write(item + " ");
               }

               // İlk elemanı görüntüle (Peek)
               System.Console.WriteLine($"\nİlk eleman: {numbers.Peek()}");

               // İlk elemanı çıkar (Dequeue)
               int cikan = numbers.Dequeue();
               System.Console.WriteLine($"Çıkartılan: {cikan}");

               System.Console.Write("\nKalan Elemanlar: ");
               foreach (var item in numbers)
               {
                   System.Console.Write(item + " ");
               }
                System.Console.WriteLine("\n Kalan Eleman Sayısı : " + numbers.Count);

           }

     /*    public static void StrategyPatternKullanarakApp()
        {
            var numbers = new int[] { 10, 20, 30 };
            var q1 = new Queue<int>(QeueuType.Array);
            var q2 = new Queue<int>(QeueuType.LinkedList);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
                q1.Enqueue(item);
                q2.Enqueue(item);
            }

            System.Console.WriteLine($"q1 Count: {q1.Count}");
            System.Console.WriteLine($"q2 Count: {q2.Count}");



            System.Console.WriteLine($"{q1.Dequeue()} hase been removed from q1");
            System.Console.WriteLine($"{q2.Dequeue()} hase been removed from q2");

            foreach (var item in q1)
            {
                System.Console.WriteLine(item);

            }
            System.Console.WriteLine($"q1 Peek: {q1.Peek()}");
            System.Console.WriteLine($"q2 Peek: {q2.Peek()}");

        } */
    }


/* 
    public class Queue<T> : IEnumerable<T>
    {
        private readonly IQueue<T> queue;
        public int Count => queue.Count;

        public Queue(QeueuType qType = QeueuType.Array)
        {
            if (qType == QeueuType.Array)
            {
                queue = new ArrayQueue<T>();
            }
            else
            {
                queue = new ListLinkedQueue<T>();
            }
        }

        public T Dequeue()
        {
            return queue.DeQueue();
        }
        public T Peek()
        {
            return queue.PeekQ();
        }
        public void Enqueue(T value)
        {
            queue.EnQueue(value);
        }

        public IEnumerator<T> GetEnumerator() => queue.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    internal class ListLinkedQueue<T> : IQueue<T>
    {
        private readonly LinkedList<T> linkedL = new LinkedList<T>();
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
            {
                throw new Exception("Empty queue");
            }
            var temp = linkedL.First!.Value;
            linkedL.RemoveFirst();
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            linkedL.AddLast(value);
            Count++;
        }
        public T PeekQ() => Count == 0
          ? throw new Exception("Empty queue")
          : linkedL.First!.Value;

        public IEnumerator<T> GetEnumerator() => linkedL.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        /* {//LINQ kullanmadan yazım
   if (linkedL.Count == 0)
   {
       throw new Exception("Empty queue");
   }
   return linkedL.First!.Value;
} 
    }

    internal class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> list = new List<T>(); // concrete
        public int Count { get; private set; }


        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("Empty queue!");

            var temp = list[0];
            list.RemoveAt(0);
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            list.Add(value);
            Count++;
        }

        public T PeekQ()
        {
            if (Count == 0)
                throw new Exception("Empty queue!");

            return list[0];
        }

        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public interface IQueue<T> : IEnumerable<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T PeekQ();
    }

    public enum QeueuType
    {
        Array = 0,     // List<T>
        LinkedList = 1 // LinkedList<T>
    }

 */
    #region Queue (Kuyruk) | Tanım
    /*
     ***** FIFO (First In, First Out) mantığıyla çalışan veri yapısıdır  -  İlk eklenen eleman, ilk çıkar
     - Gündekik örnek: Market kasa sırası , banka sırası 

        *-- Temel İşlemler --*
            - Enuqueu : Kuyruğun sonuna eleman ekler
            - Dequeue : Kuyruğun başındaki elemanı çıkarır
            - Peek : Çıkarmadan, sıradaki ilk elemanı gösterir
            - Count : Eleman sayısını verir
            - Clear : Kuyuğu tamamen temizler

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