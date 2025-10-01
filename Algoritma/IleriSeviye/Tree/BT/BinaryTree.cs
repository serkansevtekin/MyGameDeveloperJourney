using System;

namespace Programlama.IleriAlgoritma.Tree
{
    //Generic BinaryTree sınıfı, T tipi IComparable olmalı
    public class BinaryTree<T> where T : IComparable
    {
        public NodeTree<T>? Root { get; set; }

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
            if (root == null) throw new Exception("This tree is empty");

            var s = new Stack<NodeTree<T>>();
            s.Push(root);

            //Önce sağ , sonra sol push edilir çünkü stack LIFO'dur.
            while (s.Count != 0)
            {
                var node = s.Pop();
                list.Add(node);

                if (node.Right != null)
                {
                    s.Push(node.Right);
                }
                if (node.Left != null)
                {
                    s.Push(node.Left);
                }
            }

            return list;
        }

        #endregion

        #region Non Recursive PostOrder Traversal
        public List<NodeTree<T>> PostOrderNoneRecursiveTreversal(NodeTree<T>? root)
        {
            var list = new List<NodeTree<T>>();
            if (root == null) throw new Exception("This tree is empty");
            var s = new Stack<NodeTree<T>>();

            NodeTree<T> currentNode = root;
            NodeTree<T>? lastVisited = null;
            while (s.Count != 0 || currentNode != null)
            {
                if (currentNode != null)
                {
                    s.Push(currentNode);
                    currentNode = currentNode.Left!;
                }
                else
                {
                    var peekNode = s.Peek();
                    if (peekNode.Right != null && lastVisited != peekNode.Right)
                    {
                        currentNode = peekNode.Right;
                    }
                    else
                    {
                        list.Add(peekNode);
                        lastVisited = s.Pop();
                    }
                }
            }

            return list;
        }

        #endregion


        #region Level OrderTraversal (Seviye bazlı dolaşım) Non Recursive
        public List<NodeTree<T>> LevelOrderNoneRecursiveTraversal(NodeTree<T>? root)
        {
            var list = new List<NodeTree<T>>();
            var q = new Queue<NodeTree<T>>();
            q.Enqueue(root!);
            while (q.Count > 0) // eleman varsa
            {
                var temp = q.Dequeue();
                list.Add(temp);

                if (temp.Left != null)
                {
                    q.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }
            }
            return list;
        }
        #endregion

        #region Maksimum Derinliği bulma
        public int MaxDepth(NodeTree<T> root)
        {
            if (root == null) return 0;
            int leftDepth = MaxDepth(root.Left!);
            int rightDepth = MaxDepth(root.Right!);

            return (leftDepth > rightDepth) ? leftDepth + 1 : rightDepth + 1;
        }
        #endregion

        #region  En derin düğümü bulma
        public NodeTree<T>? DeepestNode(NodeTree<T> root)
        {
            NodeTree<T>? temp = null;
            if (root == null) throw new ArgumentNullException();
            var q = new Queue<NodeTree<T>>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                temp = q.Dequeue();
                if (temp.Left != null)
                {
                    q.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }
            }
            return temp!;
        }

        public NodeTree<T> DeepestNode()
        {
            var list = LevelOrderNoneRecursiveTraversal(Root);
            return list[list.Count - 1];
        }
        #endregion
    }
}