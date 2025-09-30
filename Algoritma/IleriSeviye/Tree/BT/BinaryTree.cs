using System;

namespace Programlama.IleriAlgoritma.Tree
{
    //Generic BinaryTree sınıfı, T tipi IComparable olmalı
    public class BinaryTree<T> where T : IComparable
    {
        #region InOrder Dolaşım Özyineleme (Recursive)
        //Public metot: In-Order traversal yapar ve sonucu List<NodeTree<T>> olarak döner
        public List<NodeTree<T>> InOrder(NodeTree<T>? root)
        {
            //Her çağrıda temiz bir liste oluşturuyoruz
            var list = new List<NodeTree<T>>();

            //Rekürsif yardımcı metod çağrısı
            InOrderHelper(root, list);

            // Listeyi dön
            return list;
        }

        //private yardımcı metot: In-Order traversal yapar ve lisyeyi doldur
        private void InOrderHelper(NodeTree<T>? root, List<NodeTree<T>> list)
        {
            //eğer root null değilse devam et
            if (root != null)
            {
                //sol alt ağacı ziyaret et
                InOrderHelper(root.Left, list);

                // Mevcut düğümü listeye ekle
                list!.Add(root);

                //sağ alt ağacı ziyaret et
                InOrderHelper(root.Right, list);

            }
        }
        #endregion

        #region  PreOrder Dolaşım Özyineleme (Recursive)
        public List<NodeTree<T>> PreOrder(NodeTree<T>? root)
        {
            var list = new List<NodeTree<T>>();
            PreOrderHelper(root, list);
            return list;
        }

        private void PreOrderHelper(NodeTree<T>? root, List<NodeTree<T>> list)
        {
            if (root != null)
            {
                list.Add(root);
                PreOrderHelper(root.Left, list);
                PreOrderHelper(root.Right, list);
            }
        }

        #endregion

        #region PostOrder Dolaşım Özyineleme (Recursive)
        public List<NodeTree<T>> PostOrder(NodeTree<T>? root)
        {
            var list = new List<NodeTree<T>>();
            PostOrderHelper(root, list);
            return list;
        }
        private void PostOrderHelper(NodeTree<T>? root, List<NodeTree<T>> list)
        {
            if (root != null)
            {
                PostOrderHelper(root.Left, list);
                PostOrderHelper(root.Right, list);
                list.Add(root);
            }
        }
        #endregion


        #region Non Recursive InOrder Traversal
        public List<NodeTree<T>> InOrderNonRecursiveTreversal(NodeTree<T> root)
        {
            // Sonuçları saklayacağımız list
            var list = new List<NodeTree<T>>();

            // Ziyaret edilecek düğümleri tutmak için stack (LIFO)
            var s = new Stack<NodeTree<T>>();

            //Başlangıç noktası: kök düğüm
            NodeTree<T> currentNode = root;

            //Stack boş değilse veye ilerleyecek bir node varsa devam et
            while (s.Count > 0 || currentNode != null)
            {
                //1. Adım: Sol alt ağaç boyunca ilerle, her düğümü stack'e ekle
                while (currentNode != null)
                {
                    s.Push(currentNode);                // mevcut düğümü stack'e ekle
                    currentNode = currentNode.Left!;    // sol çocuğa git
                }

                //2. Adım: En soldaki node'a ulaşıldı, şimdi stacten geri çık
                currentNode = s.Pop();  //Stack'ten bir düğüm çıkar
                list.Add(currentNode);  // O düğümü listeye ekle (ziyaret et)

                //3. Adım: Sağ alt ağacı gezmek için sağ alt çocuğa git
                currentNode = currentNode.Right!;
            }
            // In-Order sıralanmış listeyi döndür
            return list;
        }

        #endregion

        #region Non Recursive PreOrder Traversal
        public List<NodeTree<T>> PreOrderNoneRecursiveTreversal(NodeTree<T> root)
        {
            var list = new List<NodeTree<T>>();
            var s = new Stack<NodeTree<T>>();
            

            return list;
        }

        #endregion

        #region Non Recursive PostOrder Traversal


        #endregion


    }
}