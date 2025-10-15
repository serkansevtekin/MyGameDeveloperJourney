using System;

namespace Programlama.Tekrars1
{

    public class DSTClass
    {
        public static void DSTRunMethod()
        {

            DisjoinSet<string> ds = new DisjoinSet<string>();
            ds.MakeSet("A");
            ds.MakeSet("B");
            ds.MakeSet("C");

            ds.Union("A", "B");

            System.Console.WriteLine(ds.IsConnceted("A", "B"));
            System.Console.WriteLine(ds.IsConnceted("A","C"));
            
        }
    }


    #region Disjoint Set

    public class DisjoinSet<T> where T : notnull
    {
        private Dictionary<T, T> parent = new Dictionary<T, T>();

        //Eleman ekleme
        public void MakeSet(T x)
        {
            if (!parent.ContainsKey(x))
            {
                parent[x] = x;
            }
        }

        //Root parent bul (path compression)
        public T Find(T x)
        {
            if (!parent.ContainsKey(x))
                MakeSet(x);

            if (!parent[x].Equals(x))
                parent[x] = Find(parent[x]);

            return parent[x];
        }


        // iki seti birleştir
        public void Union(T x, T y)
        {
            T rootX = Find(x);
            T rootY = Find(y);
            if (!rootX.Equals(rootY))
            {
                parent[rootY] = rootX; // rootY'yi rootX'e bağla
            }
        }
        
        //Küme kontrolü
        public bool IsConnceted(T x , T y)
        {

            return Find(x).Equals(Find(y));
        }

    }

    #endregion



    #region Tanım
    /*
    Disjoint Set (Union - Find) Nedir?
    * Disjoint Set, bir gurup elemanı birbirinden ayrı kümeler halinde tutan bir veri yapısıdır

    Amaç: Hangi eleman hangi kümede?
    Çok hızlı şekilde:
        - Find -> eleman hangi kümeye ait olduğu bulur
        - Union -> iki kümeyi birleştirir

   Unity'de Nerelerde kullanılır?
        - Bağlanlılı objeleri guruplayıp yönetmek
        - Alan, blge veya group kontrolü (connection components)

    Temel Mantık:
        - Her eleman önce kendi kümesinde (parent = kendisi)
        - Find ile root parent bulunur
        - Union ile iki kümenin root'ları birleştirilir

    Özet:

        Disjoint Set → küme yönetimi, bağlı eleman kontrolü

        Unity’de → bağlı objeler, bölgeler, network vs. için pratik

        Performans → n log n gibi hızlı, path compression ve union by rank ile çok daha hızlı
    */
    #endregion
}