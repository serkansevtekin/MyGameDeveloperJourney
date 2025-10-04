using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.DisjoinSet
{

    //Disjoin Set sınıfı
    public class Ds<T> : IEnumerable<T> where T : notnull
    {
        //Elemanları saklayan Dictionary
        private readonly Dictionary<T, DsNode<T>> set = new();

        public int Count { get; private set; } //Toplam eleman sayısı

        // Yeni eleman ekleme
        public void MakeSet(T value)
        {
            //Eleman zaten varsa hata ver
            if (set.ContainsKey(value)) throw new Exception("Calue already exists");
            var node = new DsNode<T>(value); // node oluştur
            set.Add(value, node); // Dictionary'e ekle
            Count++;
        }

        //Elemanın küme kökünü bulma (Path compression)
        public T FindSet(T value)
        {
            // ilgili düğümü sözlükten al |  set[value] -> anahtara karşılık gelen node döner
            var node = set[value];

            // root'u bulmak için parent'lar arasında yıkarı çık
            var root = node;
            while (root.Parent != root)
            {
                root = root.Parent!;
            }

            //Path compression: tüm düğümleri doğrudan root'a bağla
            var current = node;
            while (current.Parent != root)
            {
                var parent = current.Parent; // geçici olarak parent sakla
                current.Parent = root;      //  current artık doğrudan root'a bağlanır
                current = parent;           // yukarı doğru ilerle
            }
            // root dğümü değerini döndür
            return root.Value!;
        }


        //İki elemanın kümelerini birleştirme
        public void Union(T valueA, T valueB)
        {
            var rootA = FindSet(valueA);    //valueA kökünü bul
            var rootB = FindSet(valueB);    //valueB kökünü bul

            if (rootA.Equals(rootB)) return; // Zaten aynı küme ise çık

            var nodeA = set[rootA]; // nodeA al
            var nodeB = set[rootB]; // nodeB al

            if (nodeA.Rank == nodeB.Rank)//Rank eşit ise
            {
                nodeB.Parent = nodeA;   //nodeB alt, nodeA üst
                nodeA.Rank++;           //nodeA rank artır


            }
            else
            {
                if (nodeA.Rank < nodeB.Rank) //nodeA küçük rank -> alt
                {
                    nodeA.Parent = nodeB;
                }
                else                        // nodeB küçük rank -> alt
                {
                    nodeB.Parent = nodeA;
                }
            }

        }

        //Mevcut kümleri liste halinde döndür (kök -> alt elemanlar)
        public Dictionary<T, List<T>> GetSets()
        {
            var result = new Dictionary<T, List<T>>();
            foreach (var key in set.Keys)
            {
                var root = FindSet(key);
                if (!result.ContainsKey(root))
                {
                    result[root] = new List<T>();
                }
                result[root].Add(key);
            }
            return result;
        }


        public IEnumerator<T> GetEnumerator()
        {
           // return set.Values.Select(x => x.Value).GetEnumerator();
            
            var list = new List<T>();
            foreach (var node in set.Values)
            {
                list.Add(node.Value);
            }
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}