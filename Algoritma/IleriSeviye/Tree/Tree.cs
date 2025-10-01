using System;

namespace Programlama.IleriAlgoritma.Tree
{
    public class TreeClass
    {
        public static void TreeRunMethod()
        {
            var BST = new BST<int>(new int[] { 60, 40, 70 });
            BST.Add(20);
            BST.Add(45);
            BST.Add(65);
            BST.Add(85);

            var bt = new BinaryTree<int>();
            var btChar = new BinaryTree<char>();

            //  InPrePostRecursiveTravels(BST, bt);
            //InPrePostNonRecursiveTravels(BST, bt);
            //  LevelOrderNoneRecursiveMethod(BST,bt);
            // MaksimumMinimumVeFindIleDegerleriBulma(BST);

            //FindMethod(BST);
            // RemoveMethod(BST, bt);
            //MaksimumDerinlik(BST, bt);


            System.Console.WriteLine("\n");
            NewMethod(btChar);

        }

        private static void NewMethod(BinaryTree<char> btChar)
        {
            btChar.Root = new NodeTree<char>('F');
            btChar.Root.Left = new NodeTree<char>('A');
            btChar.Root.Right = new NodeTree<char>('T');
            btChar.Root.Left.Left = new NodeTree<char>('D');

            var list = btChar.LevelOrderNoneRecursiveTraversal(btChar.Root);
            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }

            System.Console.WriteLine("\n");
            System.Console.WriteLine($"Deepest Node : {btChar.DeepestNode(btChar.Root)}");
            System.Console.WriteLine($"Deepest Node : {btChar.DeepestNode()}");

            System.Console.WriteLine($"Max Depth : {btChar.MaxDepth(btChar.Root)}");

        }

        private static void RemoveMethod(BST<int> BST, BinaryTree<int> bt)
        {
            BST.Remove(BST.Root!, 37);
            BST.Remove(BST.Root!, 16);
            bt.InOrderNonRecursiveTreversal(BST.Root!).ForEach(x => System.Console.Write(x + " "));
        }

        private static void MaksimumDerinlik(BST<int> BST, BinaryTree<int> bt)
        {
            System.Console.WriteLine($"Min   : {BST.FindMin(BST.Root!)}");
            System.Console.WriteLine($"MAX   : {BST.FindMax(BST.Root!)}");
            System.Console.WriteLine($"Depth : {bt.MaxDepth(BST.Root!)}");
        }
        private static void FindMethod(BST<int> BST)
        {
            var keyNode = BST.Find(BST.Root!, 16);

            System.Console.WriteLine("{0} - Left: {1} - Right: {2}",
            keyNode.Value,
            keyNode.Left != null ? keyNode.Left.Value.ToString() : "null",
            keyNode.Right != null ? keyNode.Right.Value.ToString() : "null"
            );
        }

        private static void MaksimumMinimumVeFindIleDegerleriBulma(BST<int> BST)
        {
            System.Console.WriteLine($"Minimum value: {BST.FindMin(BST.Root!)}");
            System.Console.WriteLine($"Maximum value :{BST.FindMax(BST.Root!)}");
        }

        private static void LevelOrderNoneRecursiveMethod(BST<int> BST, BinaryTree<int> bt)
        {
            var LevelOrderNoneRecursiveList = bt.LevelOrderNoneRecursiveTraversal(BST.Root!);

            foreach (var item in LevelOrderNoneRecursiveList)
            {
                System.Console.WriteLine(item);
            }
        }
        private static void InPrePostNonRecursiveTravels(BST<int> BST, BinaryTree<int> bt)
        {
            var InOrderNonRecursiveList = bt.InOrderNonRecursiveTreversal(BST.Root!);
            foreach (var item in InOrderNonRecursiveList)
            {
                System.Console.Write(item + " ");
            }

            System.Console.WriteLine("\n");

            var PreOrderNoneRecursiveList = bt.PreOrderNoneRecursiveTreversal(BST.Root!);
            PreOrderNoneRecursiveList.ForEach(x => System.Console.Write(x + " "));

            System.Console.WriteLine("\n");

            var PostOrderNoneRecursiveList = bt.PostOrderNoneRecursiveTreversal(BST.Root!);
            foreach (var item in PostOrderNoneRecursiveList)
            {
                System.Console.Write(item + " ");
            }

        }

        private static void InPrePostRecursiveTravels(BST<int> BST, BinaryTree<int> bt)
        {
            //Inorder
            var InOrderList = bt.InOrder(BST.Root);

            foreach (var item in InOrderList)
            {
                System.Console.Write(item.Value + " ");
            }

            System.Console.WriteLine();

            //Preorder
            var PreOrderList = bt.PreOrder(BST.Root);

            foreach (var item in PreOrderList)
            {
                System.Console.Write(item.Value + " ");
            }

            System.Console.WriteLine();

            //PostOrder
            var PostOrderList = bt.PostOrder(BST.Root);
            foreach (var item in PostOrderList)
            {
                System.Console.Write(item + " ");
            }
        }
    }

    #region Ağaç ve İkili Ağaç Tanım
    /*

    *** 1. Ağaç (Tree) Nedir? ***

            - Ağaç, düpümlerden(node) oluşan, hiyerarşik bir veri yapısıdır.
            - En üstte kök(oot) düğüm vardır.
            - Her düğümün 0 veya daha fazla alt düğümü (child) olabilir
            - Alt düğümü olmayan düğümşere yaprak (leaf) denir.
            - Düğümler arasındaki bağlantılara kenar (edge) denir.

        ---* Özellikleri:
                - Çizge teorisindeki özel bir graf yapısıdır (çevrim içermez)
                - Genelde hyerarşik yapıları temsil etmek için kullanılır: dosya sistemleri, organizasyon şemaları, oyun ağaçları

    *** 2. İkili Ağaç (Binary Tree)

            . Her düğümün en fazla 2 alt düğümü vardır:
                - Sol çocuk (left child)
                - Sağ çocuk (right child)

            . Boş olabilir (yani sol ve sağ çocuk olmayabilir)

        --* Özel Türleri:

                *-* Full Binary Tree ( Tam İkili Ağaç): Her düğümün ya 0 yada 2 çocuğu vardır

                *-* Complate Binary Tree (Tamamlanmış İkili Ağaç): Son seviye hariç tüm sevilerer tamamen doludur, son seviye soldan sağa soğru doldurulur.

                *-* Binary Search Tree, BTS ( İkili arama ağacı ): Sol alt ağaç kökten küçül, sağ alt ağaç kökten büpü değerleri tutar

    *** 3. Ağaç Gzinmeleri (Tree Traversal)

            . Ağaç üzerindeki düpümleri belli bir sıraya göre dolaşmaya "treversal" denir.
            . Trevarsal, Derinlik öncelikli (DFS) ve genişlik öncelikli (BFS) olarak ikiye ayrılır.

        A) Derinlik Öncelikli (DFS)

            . İkli ağaçta üç temel yöntem vardır:

                1. Preorder (Kök - Sol - Sağ)
                    . Önce kök , sonra sol alt ağaç, sora sağ alt ağaç
                    . Kullanım: Ağaç kopyalama, ifade ağacından prefix ifede elde etme.
                    . Örnek Sıralama: A -> B  -> D -> E -> C -> F -> G

                2. Inorder (Sol - Kök - Sağ)
                    . Önce sol alt ağaç, sonra kök , sonra sağ alt ağaç
                    . Kullanım: İkili arama ağacında sıralı çıktı verir
                    . Örnek Sıralam: D -> B -> E -> A -> F -> C -> G

                3. Postorder (Sol - Sağ - Kök)
                    . Önce sol, sonra sağ alt ağaç , en son kök
                    . Kullanım: Bellek temizleme, ifade ağacından postfix ifade elde etme
                    . Örnek Sıra D -> E -> B -> F -> G -> C -> A

        B) Genişlik Öncelikli (BFS / Level Order)

            . Ağaç seviye seviye gezilir (Queue kullanır)
            . Örnek Sıra: A -> B -> C -> D -> E -> F -> G
    */
    #endregion
}