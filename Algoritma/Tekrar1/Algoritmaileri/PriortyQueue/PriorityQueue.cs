using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Programlama.Tekrars1.Algoritma
{
    public class PriorityQueueClass
    {
        public static void PriorityQueueRunMethod()
        {
            UnitySurumuileyumluBEST();
        }

        #region Eski sürüm ve Unity de kullanacağım

        public static void UnitySurumuileyumluBEST()
        {
            MyPriorityQueueBEST<string, int> pq = new MyPriorityQueueBEST<string, int>();


            pq.Enqueue("Düşük öncelik", 5);
            pq.Enqueue("Orta öncelik", 4);
            pq.Enqueue("Orta öncelik", 3);
            pq.Enqueue("Orta öncelik", 2);
            pq.Enqueue("Yüksek öncelik", 1);


            foreach (var (item, priority) in pq)
            {
                Console.WriteLine($"{priority} - {item}");

            }

            System.Console.WriteLine("En öncelikli elemanı göster: " + pq.Peek());

            System.Console.WriteLine("Öncelik sırasına göre elemanı çıkar " + pq.Dequeue());
            System.Console.WriteLine("Öncelik sırasına göre elemanı çıkar " + pq.Dequeue());
            System.Console.WriteLine("Öncelik sırasına göre elemanı çıkar " + pq.Dequeue());

            System.Console.WriteLine("----------------");

            //SIRLAMA



            pq.Enqueue("Düşük öncelik", 5);
            pq.Enqueue("Orta altı öncelik", 4);
            pq.Enqueue("Orta öncelik", 3);
            pq.Enqueue("Orta üstü öncelik", 2);
            pq.Enqueue("Yüksek öncelik", 1);


            SortedList<int, string> stLpq = new SortedList<int, string>();//Sıralamak için 

            foreach (var (item,priority) in pq)
            {
                if (!stLpq.ContainsKey(priority))
                {
                    stLpq.Add(priority, item);
                }
            }


            foreach (var (priority, item) in stLpq)
            {
                Console.WriteLine($"{priority} - {item}");

            }

        }

        public static void UnitySurumuileyumluBASIC()
        {
            MyPriorityQueueBASIC<string, int> pq = new MyPriorityQueueBASIC<string, int>();

            pq.Enqueue("Orta", 2);
            pq.Enqueue("Düşük", 3);
            pq.Enqueue("Yüksek", 1);

            foreach (var item in pq)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Eleman sayısı = " + pq.Count);

            System.Console.WriteLine("Son elemanı göster = " + pq.Peek());



            var cikanEleman = pq.Dequeue();

            System.Console.WriteLine("Çıkan eleman = " + cikanEleman);

            System.Console.WriteLine("Eleman sayısı = " + pq.Count);

            foreach (var item in pq)
            {
                System.Console.WriteLine(item);
            }


        }


        #endregion


        #region Yeni Sürüm Kullanımı
        public static void PriorityQueueYeniSurumKullanimi()
        {
            /*
            NOT!: PriortyQueue, küçük öncelik değerini yüksek kabul eder (min-heap)
            */


            // Eleman türü: string, öncelik türü: int
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            // Eleman ekleme
            pq.Enqueue("Düşük Öncelik", 3);
            pq.Enqueue("Orta Öncelik", 2);
            pq.Enqueue("Yüksek Öncelik", 1); // 1 en yüksek öncelik

            System.Console.WriteLine($"En üstteki elemanı göster: {pq.Peek()}");

            // Eleman çıkarma
            while (pq.Count > 0)
            {
                string item = pq.Dequeue();
                System.Console.WriteLine("Çıkarılan: " + item);
            }

            System.Console.WriteLine("------------");

            pq.Enqueue("Öncelik Yüksek", 1);
            pq.Enqueue("Öncelik Düşük", 3);
            pq.Enqueue("Öncekük Orta", 2);

            //Foreach kullana bilmek için -> "UnorderedItems" zorunlu. GetEnumerator yok
            //UnorderedItems -> Öncelik sıralamasına göre dizilmez.  Sıralı iseteniyor ise Clone() edilip sıralı liste yapıla bilir
            foreach (var item in pq.UnorderedItems)
            {
                System.Console.WriteLine($"Element: {item.Element}, Öncelik: {item.Priority}");
            }

            System.Console.WriteLine();


            System.Console.WriteLine();

            //Yukarıdaki foreach'te öncelik sıralaması olamasada, çıkarma Dequeu() yaparken öncelik sıralamasına göre otomatik yapılır
            while (pq.Count > 0)
            {
                string item = pq.Dequeue();
                System.Console.WriteLine("Çıkarılan: " + item);
            }
        }

        public static void PriorityQueueYeniSurumSiraliListe()
        {
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
            pq.Enqueue("Düşük", 3);
            pq.Enqueue("Orta", 2);
            pq.Enqueue("Yüksek", 1);
            pq.Enqueue("Tekrar Orta", 2);

            //Yeni sıralı lsite oluşrutur
            //  SortedList<int, List<string>> ordered = new SortedList<int, List<string>>();
            SortedList<int, string> ordered = new SortedList<int, string>();


            //Priority Queue elemanlarını dolaş (UnorderedItems zorunlu)
            foreach (var item in pq.UnorderedItems)
            {
                int priority = item.Priority;
                string element = item.Element;

                //Aynı öncelikte birden fazla eleman olamaz
                if (!ordered.ContainsKey(priority))
                {
                    ordered.Add(priority, element);
                }
                else
                {
                    // İsteğe bağlı: tekrar eden öncelik varsa ignore et veya log yaz
                    System.Console.WriteLine($"Öncelik {priority} zaten var, '{element}' eklenmedi.");
                }

                /*   //Aynı öncelikte birden fazla eleman olabilir -> List<string> tutuyoruz
                  if (!ordered.ContainsKey(priority))
                  {
                      ordered.Add(priority, new List<string>());
                  }
                  ordered[priority].Add(element); */


            }

            foreach (var kvp in ordered)
            {
                int priority = kvp.Key;
                string element = kvp.Value;

                System.Console.WriteLine($"Öncelik: {priority}, Eleman: {element}");
            }

            /*   foreach (var kvp in ordered)
              {
                  int priority = kvp.Key;
                  List<string> items = kvp.Value;

                  foreach (var element in items )
                  {
                      System.Console.WriteLine($"Öncelik: {priority}, Eleman: {element}");
                  }
              } */

        }
        #endregion
    }


    #region Kendi Priqueu Class Unity de kullanacağım [BASİC]
    public class MyPriorityQueueBASIC<T, P> : IEnumerable<T> where P : IComparable<P>
    {
        //Elemanlar ve öncelikleri saklanır
        //Tuple kullanıyoruz (item: T , priorty: int)
        private List<(T item, P priority)> elements = new List<(T item, P priority)>();

        //Kuyruğun eleman sayısını verir
        public int Count => elements.Count;

        //Kuyruğa eleman ekleme
        public void Enqueue(T item, P priority)
        {
            //Öncelikle elemanı listeye ekliyoruz
            elements.Add((item, priority));


            /*
            Sonra listeyi öncelik sırasına göre sıralıyoruz
            Lambda kullanımı: (x,y) => x.priority.CompareTo(y.priorty)
                - x ve y: list'teki iki tuple eleman
                - CompareTo: x.priority < y.priority ise -1, = ise 0, > ise 1 döner
            Bu sayede en küçük priority (en yüksek öncelik listenin başına gelir)
            */
            elements.Sort((x, y) => x.priority.CompareTo(y.priority));// (en düşük en başta (Min-Heap))
        }

        //Eleman en yüksek öncelikli elemanı çıkar ve göster
        public T Dequeue()
        {
            if (elements.Count == 0) throw new InvalidOperationException("Queue boş");

            //Liste başındaki eleman en yüksek öncelikli
            var item = elements[0].item;

            //Çıkardıktan sonra listeden sil
            elements.RemoveAt(0);

            return item;

        }

        public T Peek()
        {
            if (elements.Count == 0) throw new InvalidOperationException("Queue boş");

            return elements[0].item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var ele in elements)
            {
                yield return ele.item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    #endregion


    #region Kendi PriorityQueue + HEAP tabanlı [BEST]

    //Isteğe bağlı IComparer<P> eklene bilir, duplicate kontrolü yapıla bilir 
    public class MyPriorityQueueBEST<T, P> : IEnumerable<(T item, P priority)> where P : IComparable<P>
    {
        //Heap yapısı listede tutulur. Her eleman : (item, priority)
        List<(T item, P priority)> heap = new List<(T, P)>();

        //Toplam eleman sayısı
        public int Count => heap.Count;

        //Eleman ekleme
        public void Enqueue(T item, P priority)
        {
            heap.Add((item, priority));

            HeapifyUp(heap.Count - 1);
        }

        //Eleman çıkarma
        public T Dequeue()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Queue boş!");

            //En yüksek öncelikli (küçük priority) eleman root'tadır.
            var rootItem = heap[0].item;

            //Son elemanı root'un yerine koyuyoruz
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            //Heap kuralını yeniden kurmak için aşağı düzenleme
            if (heap.Count > 0)
                HeapifyDown(0);


            return rootItem;

        }

        //Yüksek öncelikli elemanı sadece gösterir
        public T Peek()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Queue boş!");

            return heap[0].item;
        }


        //Yukarı düzenleme (heapify-up)
        //Yeni ekelenen eleman doğru konuma çıkana kadar yukarı taşınır
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                //Eğer parent, çocuktan küçükse zaten dığru yerdeyiz
                if (heap[index].priority.CompareTo(heap[parentIndex].priority) >= 0)
                {
                    break;
                }

                //Yer değiştir
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }


        //Aşağı düzenleme (heapify-down)
        //Root elemanı doğru konumuna inene kadar aşağı taşınır
        private void HeapifyDown(int index)
        {
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;

                //Sol çocuk küçükse güncelle
                if (left < heap.Count && heap[left].priority.CompareTo(heap[smallest].priority) < 0)
                    smallest = left;

                //Sağ çocuk da küçükse güncelle
                if (right < heap.Count && heap[right].priority.CompareTo(heap[smallest].priority) < 0)
                    smallest = right;

                // Değişim gerekemezse çık
                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;



            }
        }


        //Yardımıcı Metot: Swap -> iki elemanın yer değiştirmesi
        public void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public IEnumerator<(T item, P priority)> GetEnumerator()
        {
            foreach (var e in heap)
            {
                yield return e;
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    #endregion

    #region Tanım
    /*
    Priority Queue (Öncelik Kuyruğu) Nedir?
        Tanım: Elemanların eklenme sırasına değil, öncelik değerine göre çıkarıldığı bir kuyruktur.
        Kullanım: En yüksek öncelikli eleman kuyruğun hezaman başında olur
        Örnek senaryolar:
            - Yol bulma algoritmaları (A* Pathfinding)
            - Görev yönetimi (Task Scheduler)
            - Event Sistemi

    Temel Mantık:
        Bir Priority Queue üç ana işlevi sağlar:
            - Enqueue(item, priority): Elemanı ve önceliğini ekler
            - Dequeue(): En yüksek öncelikli elemanı çıkarır
            - Peek(): Kuyruğun başındaki elemanı gösterir, ama çıkartmaz



    */
    #endregion
}