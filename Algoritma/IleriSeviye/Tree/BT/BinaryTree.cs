using System;

namespace Programlama.IleriAlgoritma.Tree
{
    //Generic BinaryTree sınıfı, T tipi IComparable olmalı
    public class BinaryTree<T> where T : IComparable
    {
        #region In Order Dolaşım Özyineleme (recursion)
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
   
        #region  Preorder Dolaşım Özyineleme (recursion)
            
        #endregion
    }
}