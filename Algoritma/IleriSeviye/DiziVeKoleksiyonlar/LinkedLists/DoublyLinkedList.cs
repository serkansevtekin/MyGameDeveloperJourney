using System;
using System.Collections;

namespace Programlama.IleriAlgoritma
{
    public class DoublyLinkedListClass
    {
        public static void DoublyLinkedListRunMethod()
        {
            var list = new DoublyLinkedList<char>(new List<char>() { 'a', 'b', 'c', 'd' });
            list.Remove('b');
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

        }
    }

    #region Doubly Linked List (Çift Bağlantılı liste) | Tanım  
    /*
    * Her düğümün hem bir sonraki hem de bir önceki düğümü işaret ettiği bir bağlı listedir
        - Tek yönlü linked list'ten farkı, sadece next değil, prev ponter'ının da olmasıdır
        - Node ekleme ve silme işlemşeri daha esnek, özellikle ortadn ekleme/silme için uygundur
        - Avantajı: Liste içinde ileri ve geri yönde kolay gezinme sağlar
        - Dezavantajı: Bellek kullanımı fazladır



    */
    #endregion

    // Düğüm (Node) sinifi
    public class NodeDoubly<T>
    {


        public NodeDoubly<T>? Prev { get; set; }
        public NodeDoubly<T>? Next { get; set; }
        public T Value { get; set; }


        public NodeDoubly(T value)
        {
            this.Value = value;
            this.Prev = null;
            this.Next = null;

        }

        public override string ToString() => Value?.ToString() ?? "null";

    }

    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public NodeDoubly<T>? Head { get; set; }
        public NodeDoubly<T>? Tail { get; set; }

        private bool isHeadBool => Head == null;
        private bool isTailBool => Tail == null;


        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

        //AddFirst
        public void AddFirst(T Value)
        {
            var newNode = new NodeDoubly<T>(Value);

            if (Head == null) // liste boş
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Prev = newNode;
                Head = newNode;
            }

        }

        //AddLast

        public void AddLast(T Value)
        {
            if (Tail == null)
            {
                AddFirst(Value);
                return;
            }
            var newNode = new NodeDoubly<T>(Value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
        }


        //AddAfter
        public void AddAfter(NodeDoubly<T> refNode, NodeDoubly<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException();
            }

            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev = refNode;
                newNode.Next = null;

                Head = refNode;
                Tail = newNode;

                return;
            }

            if (refNode != Tail)
            {
                newNode.Prev = refNode;
                newNode.Next = refNode.Next;

                refNode.Next!.Prev = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next = newNode;
                Tail = newNode;
            }



        }

        //FirstRemove
        public T RemoveFirst()
        {
            if (isHeadBool)
                throw new Exception("");

            var temp = Head!.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head!.Prev = null;
            }
            return temp;
        }

        //LastRemove
        public T RemoveLast()
        {
            if (isTailBool)
                throw new Exception("Empty List");

            var temp = Tail!.Value;
            if (Tail == Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail!.Prev!.Next = null;
                Tail = Tail.Prev;
            }
            return temp;
        }

        //Remove
        public void Remove(T value)
        {
            if (isHeadBool)
            {
                throw new Exception("Empty list");
            }

            //Tek Eleman
            if (Head == Tail)
            {
                if (Head!.Value!.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }

            // En az iki eleman
            var current = Head;
            while (current != null)
            {
                if (current.Value!.Equals(value))
                {
                    //current -> ilk eleman
                    if (current.Prev == null)
                    {
                        current!.Next!.Prev = null;
                        Head = current!.Next;
                    }
                    //curent -> son eleman
                    else if (current!.Next == null)
                    {
                        current!.Prev!.Next = null;
                        Tail = current.Prev;
                    }
                    //current -> arada bir pozisyonda
                    else
                    {
                        current!.Prev!.Next = current!.Next;
                        current!.Next!.Prev = current!.Prev;
                    }
                    break;
                }
                current = current!.Next;
            }


        }




        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}