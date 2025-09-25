using System;

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
    internal class SinglyLinkedList<T>
    {
        public NodeDesign<T>? Head { get; set; }

        public void AddFirst(T value)
        {

            var newNode = new NodeDesign<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new NodeDesign<T>(value);
            if (Head == null)
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