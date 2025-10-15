using System;

namespace Programlama.Tekrars1.Tree
{
    public class GenericTreeClass
    {
        public static void GenericTreeRun()
        {

            TreeNode<string> root = new TreeNode<string>("Root");

            var a = new TreeNode<string>("A");
            var b = new TreeNode<string>("B");
            var c = new TreeNode<string>("C");
            var d = new TreeNode<string>("D");
            var e = new TreeNode<string>("E");
            var f = new TreeNode<string>("F");



            root.AddChild(a);
            root.AddChild(b);
            a.AddChild(c);
            a.AddChild(d);
            d.AddChild(e);
            b.AddChild(f);

            //Parent öğrenme
            System.Console.WriteLine("E'nin parent'ı: " + e.Parent?.Value);

            //DFS traversal
            root.Traverse(node => System.Console.WriteLine(node.Value));

            //Arama örneği
            var found = root.Find(n => n.Value == "E");
            System.Console.WriteLine("Bulunan: " + found?.Value);

            root.TraverseBFS(node => System.Console.WriteLine(node.Value));
        }



    }

    // Node sınıfı
    public class TreeNode<T>
    {
        public T Value; // Düğümün taşıdığı veri
        public List<TreeNode<T>> Children; // Alt düğümler
        public TreeNode<T>? Parent { get; private set; } // Üst düğüm (opsiyonel ama faydalı)

        public TreeNode(T value)
        {
            Value = value;
            Children = new List<TreeNode<T>>();
            Parent = null;
        }

        //Child ekelem
        public void AddChild(TreeNode<T> child)
        {
            child.Parent = this;  // Bağşamtıyı iki yönlü kur
            Children.Add(child);
        }


        //DFS ile ağacı dolaşma
        public void Traverse(Action<TreeNode<T>> action)
        {
            action(this);
            foreach (var child in Children)
            {
                child.Traverse(action);
            }
        }


        //Değer arama (DFS)
        public TreeNode<T>? Find(Func<TreeNode<T>, bool> predicate)
        {
            if (predicate(this)) return this;

            foreach (var child in Children)
            {
                var result = child.Find(predicate);
                if (result != null) return result;
            }

            return null;
        }



        //BFS ile ağacı dolaşma
        public void TraverseBFS(Action<TreeNode<T>> action)
        {
            Queue<TreeNode<T>> qu = new Queue<TreeNode<T>>();
            qu.Enqueue(this);

            while (qu.Count > 0)
            {
                var current = qu.Dequeue();
                action(current);

                foreach (var child in current.Children)
                {
                    qu.Enqueue(child);
                }
            }
        }






        //UNITY OZEL BOLUM
        /*    void Start() 
       {
           // Sahnedeki root objeleri (hiç parent'ı olmayanlar)
           GameObject[] rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

           // Her root objeyi TreeNode olarak ekle
           List<TreeNode<GameObject>> roots = new List<TreeNode<GameObject>>();
           foreach (var rootGO in rootObjects)
           {
               TreeNode<GameObject> rootNode = CreateTree(rootGO);
               roots.Add(rootNode);
           }

           // Örnek: DFS ile hiyerarşiyi yazdır
           foreach (var root in roots)
           {
               root.Traverse(node => Debug.Log(node.Value.name));
           }
       }
           //Recursive olarak GameObject ve childrenlarını TreeNode yapısına çevir
           TreeNode<GameObject> CreateTree(GameObject go)
           {
               TreeNode<GameObject> node = new TreeNode<GameObject>();
               foreach (Transform child in go.transform)
               {
                   TreeNode<GameObject> childNode = CreateTree(child.gameObject);
                   node.AddChild(childNode);
               }
               return node;
           }
    */


    }


    #region Tree(Ağaç) Tanım
    /*
    Tree (Ağaç): Hiyerarşik bir veri yapısıdır. Bir üst (root) ve alt (child) düğümlerden oluşur
    Node (Düğüm): Tree'nin temel birimi. İçinde veri ve alt düğümleri tutabilir.
    Root (Kök): Ağacın en üst düğümü. Tek olur
    Leaf (Yaprak): Alt düğümü olmayan düğümler
    Parent / Child: Bir düğüm alt düğümleri child, kendisi üst düğüm için parent olur.

    Özellikler:
        - Her düğüm bir veya birden fazla child sahibi olabilir
        - Ağaç yönlü (Direction) ve yönsüz (Non-direction) olabilir
        - Binary Tree : Her düğüm en fazla 2 child alabilir
        - N-ary Tree : Her düğüm sınırsız sayıda child alabilir. Unity'de genelde " N-ary Tree " kullanıyoruz
    */
    #endregion

    #region DFS (Depth-First Search / Derinlik öncelikli arama)

    /*
    Ağacı veya graph'ı derinlemesine dolaşır
    Bir dalı mümkün olduğunca aşağı inerek tamamladıktan osnra diper dallara geçer
    Stack mantığı ile çalışır.
    Örnek Ağaç:
        Root
         ├─ A
         │   ├─ C
         │   └─ D
         └─ B

    Dfs sırası (pre-order, yani önce kendisi sonra çocuklar):
        Root -> A - C - D -> B


    örnek Kod:

        //Recursive olarak çalışır DFS , istenirse non-recutsive olarak ta yazılabilir
        public void TRaverseDFS(Action<OrnekDFSKoduClass<T>> action)
        {
            action(this);//önce kendisi
            foreach (var child in Children)
            {
                child.TRaverseDFS(action); // sonra çocuk
            }
        }

    Avantaj:
        - Az hafıza kullanılır (Sadece dalı tutmak yeterli)
        - Belirli bir dalı hızlı okumak için ideal
    
    Dezavantaj:
        - Çok derin ağaçlarda stack overflow olabilir
        - Tüm katmanları eşit şekilde gezmek zor
 */
    #endregion

    #region BFS (Breadth - First Search / Genişlik öncelikli arama)
    /*
    Ağacı yada graph'ı katman katman dolaşır
    Önce root ve root'un çocukları, sonra çocukları çocukları vs
    Queue (kuyruk) mantığıyla çalışır
    Örnek ağaç:
        Root
          ├─ A
          │   ├─ C
          │   └─ D
          └─ B

    BFS sırası: Root → A → B → C → D
        - Önce root
        - Sonra root'un çocukları (A,B)
        - Sonra A'nın çocukları (C,D)

    Örnek Kod:
     public void TraverseBFS(Action<TreeNode<T>> action)
    {
        Queue<TreeNode<T>> qu = new Queue<TreeNode<T>>();
        qu.Enqueue(this);

        while (qu.Count > 0)
        {
            var current = qu.Dequeue();
            action(current);

            foreach (var child in current.Children)
            {
                qu.Enqueue(child);
            }
        }
    }

    BFS Avantaj
        - Katman katman gezmek için ideal
        - Kısa yol veya en yakın node'u bulmak için iyi

    BFS Dezavantaj
        - Daha fazla hafıza kullanılır (Kuyrukta bir katman tutmak gerekebilir)
        - Derin dallarda yavaş ilerleyebilir
    */
    #endregion
}