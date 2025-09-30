using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.Tree
{
    public class BST<T> : IEnumerable<T> where T : IComparable // IComparable -> karşılaştırma , T için zorunlu hale getirdik
    {
        public NodeTree<T>? Root { get; set; }

        public BST() { }
        public BST(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            var newNode = new NodeTree<T>(value); // yeni düğüm oluştur
            if (Root == null) // Ağacın kökü boşsa
            {
                Root = newNode; // Yeni düğüm kök olur
                return; //metodu sonlandırır, yani ekleme işlemi bitmiştir.
            }
            else
            {
                var current = Root; // Ağacın köküyle başla
                NodeTree<T>? parent;    // Ebevyn düğümü tutacak
                while (current != null)
                {
                    parent = current; // Mevcut düğüm ebeveyn olacak

                    // Yeni değer küçükse sol alt ağaç
                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;// sol çocuğa git
                        if (current == null)
                        {
                            parent.Left = newNode;// yeni düğümü ebeveynin sol çocuğu yap
                            break;// Dönügen çık, ekleme tamam
                        }
                    }
                    else // Yeni değer büyük veya eşit ise sağ alt ağaç
                    {
                        current = current.Right; // sağ çocuğa git
                        if (current == null) // sağ boşsa ekle
                        {
                            parent.Right = newNode; // yeni düğümü ebeveynin sağ çocuğu yap
                            break; // Dönügen çık, ekleme tamam
                        }
                    }

                }

            }



        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}