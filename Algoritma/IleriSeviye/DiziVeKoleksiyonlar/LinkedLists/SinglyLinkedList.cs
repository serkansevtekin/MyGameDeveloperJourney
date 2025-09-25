using System;
using System.Collections;

namespace Programlama.IleriAlgoritma
{
    public class SinglyLinkedListClass
    {
        //Tek Yönlü Bağlı Liste
        public static void SinglyLinkedListRunMain()
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

            var list = new SinglyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }


        }
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

    #region Tek yönlü bağlı listede AddFirst işlevi | Liste Başına Ekleme
    internal class SinglyLinkedList<T> : IEnumerable<T>
    {
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


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        public IEnumerator GetEnumerator() => GetEnumerator();

    }

    internal class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
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