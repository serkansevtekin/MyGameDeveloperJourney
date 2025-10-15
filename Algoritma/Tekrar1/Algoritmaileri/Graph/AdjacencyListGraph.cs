using System;
using System.Collections;

namespace Programlama.Tekrars1.Graph
{
    //Asıl kullanılacak kısım

    public class AdjacencyListGraph<T> : IEnumerable<T> where T : notnull
    {
        private Dictionary<T, List<T>> adjacencyList = new Dictionary<T, List<T>>();

        //Node ekle
        public void AddNode(T node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<T>();
            }

        }

        //Node Kaldır (ilgili tüm edge'leri de sil)
        public void RemoveNodeRecursive(T node)
        {
            if (!adjacencyList.ContainsKey(node)) return;

            //Önce alt node'ları al ve recursive sil
            var neighbors = new List<T>(adjacencyList[node]); // node'un, alt nodlarını alır
            foreach (var item in neighbors)
            {
                RemoveNodeRecursive(item);
            }

            //Node'u sil
            adjacencyList.Remove(node);

            // Diğer node'lardan bu node'a olan edge'leri sil
            foreach (var kvp in adjacencyList.Values)
            {
                kvp.Remove(node);
            }

        }

        //Edge ekle (Directed)
        public void AddEdge(T from, T to)
        {
            if (!adjacencyList.ContainsKey(from)) AddNode(from);
            if (!adjacencyList.ContainsKey(to)) AddNode(to);
            adjacencyList[from].Add(to);

        }

        //Edge Kaldır
        public void RemoveEdgeRecursive(T from, T to)
        {
            if (!adjacencyList.ContainsKey(from)) return;

            //Edge kaldır
            adjacencyList[from].Remove(to);

            //Eğer artık bşka node'dan to'ya gelen edge yoksa, to'yu sil
            bool hasIncoming = false;
            foreach (var neighbor in adjacencyList.Values)
            {
                if (neighbor.Contains(to))
                {
                    hasIncoming = true;
                    break;
                }
            }
            if (!hasIncoming)
            {
                // to ve alt nodlarını recursive sil
                RemoveNodeRecursive(to);
            }
        }

        //Node sayısı
        public int NodeCount => adjacencyList.Count;

        //Edge sayısı
        public int EdgeCount
        {
            get
            {
                int count = 0;
                foreach (var kvp in adjacencyList)
                {
                    count += kvp.Value.Count;
                }
                return count;
            }

        }

        //Node varmı kontrol
        public bool HasNode(T node) => adjacencyList.ContainsKey(node);

        //Node'nin çocuklarını getir
        public List<T>? GetNode(T node)
        {
            //TyryGetValue -> bir key dictionary'de olup olmadığını kontol et ve varsa değerini al
            if (adjacencyList.TryGetValue(node, out var negihbors))
            {
                return negihbors; // bu node komşuları döndürür
            }
            return null;
        }

        // Edge varmı konrol
        public bool HasEdge(T from, T to)
        {
            return adjacencyList.ContainsKey(from) && adjacencyList[from].Contains(to);
        }

        //Graph içindeki bir node'u ve onun latındaki tüm bağlanıları silek için yazılmış



        //Clear graph
        public void Clear()
        {
            adjacencyList.Clear();
        }


        //Graph'ı gezebilemk için (foreach desteği)
        public IEnumerator<T> GetEnumerator()
        {
            return adjacencyList.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Debug amaçlı yazdırm (cw -> Unityde Debug.Log())
        public void PrintGraph()
        {
            foreach (var node in adjacencyList)
            {
                string neighbors = string.Join(", ", node.Value);
                System.Console.WriteLine($"{node.Key} -> {neighbors}");
            }
        }
    }

    #region Ornek
    /*

   public class OrnekAdjacencyListGraph
{
    //Her node'un komşularını listele
    private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();


    //Node ekle
    public void AddNode(int node)
    {
        if (!adjacencyList.ContainsKey(node))
            adjacencyList[node] = new List<int>();
    }

    //Edge ekle (Directed)
    public void AddEdge(int from, int to)
    {
        if (!adjacencyList.ContainsKey(from)) AddNode(from);
        if (!adjacencyList.ContainsKey(to)) AddNode(to);
        adjacencyList[from].Add(to);

    }

    //Graph yazdır
    public void PrintGraph()
    {
        foreach(var node in adjacencyList)
        {
            System.Console.Write(node.Key + ": ");
            foreach (var neighbor in node.Value)
            {
                System.Console.Write(neighbor + " ");
            }
            System.Console.WriteLine();
        }
    }
}
    */
    #endregion


    #region Blabla
    /*

1️⃣ Yönlü (Directed) ve Yönsüz (Undirected) farkı

    Directed Graph (Yönlü)

    Kenarların bir yönü vardır: A → B

    A “B’ye bağlanmış” ama B otomatik olarak “A’ya bağlanmış” sayılmaz.

    Undirected Graph (Yönsüz)

    Kenar çift yönlüdür: A — B

    A ve B birbirine bağlıdır, iki taraf da birbirine gider.

2️⃣ Unity’de neden genellikle yönlü kullanıyoruz?
a) AI ve Pathfinding mantığı

    Karakter veya düşman hareketlerinde:

    Node A → Node B (yol tek yönlü) olabilir.

    Örnek: Tek yönlü köprü, merdiven, teleport portal.

    Yönsüz graph olsaydı her bağlantı çift yönlü olur, gerçek dünya senaryosunu simüle etmek zorlaşır.

b) Oyun objeleri arasındaki mantık

    Trigger veya event zincirleri:

    Button → Door (buton kapıyı açar)

    Door → Button gerekmez → tek yönlü bağlantı yeterli.

    Script tabanlı dependency sistemleri:

    Bir obje başka objeye bağımlı → tek yönlü graph ideal.

c) Kontrol ve performans

    Directed graph, adjacency list’i daha sade ve hafif tutar:

    A → B eklemek yeterli, tersini eklemeye gerek yok.

    Undirected graph’da her edge için iki kayıt tutulur → hafıza + update maliyeti artar.

d) Weighted ve pathfinding algoritmaları

    A* veya Dijkstra gibi algoritmalarda yönlü graph esnekliği sağlar.

    Mesafe / cost farklı yönlerde değişebilir (tek yönlü yol + farklı ağırlık).       
    */
    #endregion

}