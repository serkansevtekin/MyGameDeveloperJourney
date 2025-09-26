using System;
using System.Collections;

namespace Programlama.IleriAlgoritma
{
    public class SinglyLinkedListClass
    {
        //Tek Yönlü Bağlı Liste
        public static void SinglyLinkedListRunMain()
        {


            AraDugumSilmeMethod();


        }
        private static void AraDugumSilmeMethod()
        {
            var list = new SinglyLinkedList<int>(new int[] { 23, 44, 32, 55 });
            list.Remove(32);

            list.Remove(55);
            //   list.Remove(13); // yok 
            list.Remove(23);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

        }
        private static void RemoveFirstandLastMethod()
        {
            // rastgele sayı üretici
            var rnd = new Random();

            //5 elemanlı bir liste olıştur
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                //her iterasyonda rastgele sayı üret 1 (dahil) - 10 (hariç) arası bir sayı üret
                int randomNumber = rnd.Next(1, 10);

                //her iterasyonda bu rastgele sayıyı listeye ekle
                numbers.Add(randomNumber);
            }

            //Fisher–Yates Shuffle algoritması ile listeyi karıştr

            for (int i = numbers.Count - 1; i > 0; i--)
            {
                // 0 ile i (dahil) arasında rastgele bir index seç
                int j = rnd.Next(0, i + 1);

                // numbers[i] ve = numbers[j] değerlerini takas et
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
            var list = new SinglyLinkedList<int>(numbers);
            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }

            System.Console.WriteLine();

            System.Console.WriteLine($"{list.RemoveFirst()} has been removed");

            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }

            System.Console.WriteLine();

            System.Console.WriteLine($"{list.RemoveLast()} has been removed");

            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }
        }

        private static void LINQileVeriYapilari()
        {
            var rnd = new Random();//rasgele sayı üretir

            //1'den 10'a kadar sayılar üret(1,2,3..10)
            //Bu sayıları rastgele sırala (OrderBy + rnd.Next)
            //Listeye dönüştür
            ////Fisher–Yates Shuffle algoritması ile daha performansılısı yazılır.
            var inital = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();

            var linkedlist = new SinglyLinkedList<int>(inital);
            var q = from item in linkedlist where item % 2 == 1 select item;

            foreach (var item in q)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
            linkedlist.Where(x => x > 5).ToList().ForEach(x => System.Console.WriteLine(x + " "));



        }
        #region Tek yönlü bağlı liste Uygulamalar
        private static void TekYonluUygulama2()
        {
            var arr = new char[] { 'a', 'b', 'c' };

            var list = new List<char>(arr);
            var clinkedlist = new LinkedList<char>(arr);
            list.AddRange(new char[] { 'd', 'e', 'f' });

            var linkedlist = new SinglyLinkedList<char>(list);
            foreach (var item in linkedlist)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
            var charset = new List<char>(linkedlist);
            charset.ForEach(c => System.Console.WriteLine(c));
        }

        private static void TekYonluUygulama1()
        {
            var linkedlist = new SinglyLinkedList<int>();
            //3 , 2 , 1
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);

            // 3 , 2 , 1 , 5 , 6
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);

            //araya ekeleme
            linkedlist.AddAfter(linkedlist.Head!.Next!, 32);
            // 3, 2, 32, 1, 5, 6
            //linkedlist.Head! = 3
            //linkedlist.Head!.Next!= 2

            foreach (var item in linkedlist)
            {
                System.Console.WriteLine(item);
            }


            System.Console.WriteLine();
            var list = new SinglyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
        #endregion
    }


    #region Node Design (Düğüm Tasarımı)
    partial class NodeDesign<T>
    {
        public NodeDesign<T>? Next { get; set; } // Sonraki Düğüme Referans
        public T Value { get; set; } // Veriyi Tutar

        public NodeDesign(T value)
        {
            Value = value;

        }
        public override string ToString() => $"{Value}";
    }
    #endregion

    #region Tek yönlü bağlı listede 
    internal class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedList()
        {

        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddFirst(item);
            }
        }

        public NodeDesign<T>? Head { get; set; }


        private bool isHeadNull => Head == null; //Head null kontrol True yada false döner

        //Başa ekleme
        public void AddFirst(T value)
        {

            var newNode = new NodeDesign<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        //Sona ekleme
        public void AddLast(T value)
        {
            var newNode = new NodeDesign<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                return;
            }
            var current = Head;
            while (current!.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode; //newNode;
        }


        // Araya ekleme
        public void AddAfter(NodeDesign<T> node, T value)
        {

            if (node == null)
            {
                throw new ArgumentException();
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new NodeDesign<T>(value);

            var current = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("There reference nod is not in this List.");
        }
        //Liste Başındaki ilk elemanı kaldırma
        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("Underglow! Nothing to remove.");

            var firstValue = Head!.Value;
            Head = Head!.Next;
            return firstValue;
        }

        // Liste Sonundaki elemanı kaldırma
        public T RemoveLast()
        {
            var current = Head;
            NodeDesign<T>? prev = null;
            while (current!.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastValue = prev!.Next!.Value;
            prev!.Next = null;

            return lastValue;

        }

        //Ara Dugum Silme
        public void Remove(T value)
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothint to remove");

            if (value == null)
                throw new ArgumentNullException();


            var current = Head;
            NodeDesign<T>? prev = null;
            do
            {
                if (current!.Value!.Equals(value))
                {
                    // son eleman mı?
                    if (current.Next == null)
                    {
                        //head
                        if (prev == null)
                        {
                            Head = null;
                            return;
                        }
                        //son eleman kesin
                        else
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else
                    {
                        // head
                        if (prev == null)
                        {
                            Head = Head!.Next;
                            return;
                        }
                        else // ara düğüm
                        {
                            prev.Next = current.Next;
                            return;
                        }
                    }
                }
                prev = current;
                current = current.Next;

            } while (current != null);
            throw new ArgumentException("The value could not be found in the list!");
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        public IEnumerator GetEnumerator() => ((IEnumerable<T>)this).GetEnumerator();

    }

    internal class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private NodeDesign<T>? Head;
        private NodeDesign<T>? _current;

        public SinglyLinkedListEnumerator(NodeDesign<T>? head)
        {
            Head = head!;
        }

        public T Current => _current!.Value;

        object IEnumerator.Current => _current!;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head!;
                return true;
            }
            else
            {
                _current = _current.Next!;
                return _current != null ? true : false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
    #endregion






    #region SinglyLinkedList Tanımı



    /*  Singly Linked Lists

    - Temel İşlevler

        * Listeye ekleme
            *-* Liste başına ekleme yapma
            *-* Kuyruğa ekleme (liste sonuuna) ekleme yapma
            *-* Araya ekleme yapma

        * Listede dolaşma
        
        * Listede silme

    
    */
    #endregion
}