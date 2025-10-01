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

        #region Ekeleme 
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
        #endregion

        #region Minimum ve Maksimum Bulma
        public NodeTree<T> FindMin(NodeTree<T> root)
        {
            if (root == null) throw new Exception("Tree is empty");
            NodeTree<T> current = root;

            //en soldaki düğüme git
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;// minimum değer

        }
        public NodeTree<T> FindMax(NodeTree<T> root)
        {
            if (root == null) throw new Exception("Tree is empty");
            var current = root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current;
        }


        #endregion


        #region Find İşlevi
        public NodeTree<T> Find(NodeTree<T> root, T key)
        {

            if (root == null) throw new Exception("root boş");
            if (key == null) throw new Exception("key boş");

            NodeTree<T>? current = root;



            //current null değilse ve değer bulunmadıysa devam et [CompareTo => üçlü karşılaştırma]
            while (current != null && key.CompareTo(current.Value) != 0)
            {
                if (key.CompareTo(current.Value) < 0)//Aranan değer küçükse sola git
                {
                    current = current.Left!;
                }
                else //Aranan değer büyükse sağa git
                {
                    current = current.Right!;
                }

            }

            if (current == null)
            {
                throw new Exception("Aranan değer ağaçta bulunamadı");
            }

            return current;
        }
        #endregion

        #region Remove İşlevi
        public NodeTree<T> Remove(NodeTree<T> root, T key)
        {
            if (root == null) throw new ArgumentNullException();
            if (key == null) throw new ArgumentNullException();

            // rekürsif ilerle
            if (key.CompareTo(root.Value) < 0)
            {
                root.Left = Remove(root.Left!, key);
            }
            else if (key.CompareTo(root.Value) > 0)
            {
                root.Right = Remove(root.Right!, key);
            }
            else
            {
                //silme işlevini uygulayabiliriz
                //tek çocul ya da çocuksuz
                if (root.Left == null)
                {
                    return root.Right!;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                //iki çocuk
                root.Value = FindMin(root.Right).Value;
                root.Right = Remove(root.Right!, root.Value!);
            }

            return root;
            
        }
        #endregion

     

       

        #region Ağaç yaprak sayısı hesaplama

        #endregion

        #region Yarım ve tam düğüm sayısı

        #endregion

        #region Kökten Yaprağa Yolların bulunması

        #endregion

        #region GetEnumerator Uygulaması

        #endregion


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