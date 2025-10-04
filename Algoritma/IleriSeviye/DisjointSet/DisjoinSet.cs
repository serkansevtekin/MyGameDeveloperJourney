using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.DisjoinSet
{
    /// <summary>
    /// Generic Disjoint Set (Union-Find) sınıfı
    /// Elemanları generic tip T temsil eder ve T null olamaz
    /// </summary>
    /// <typeparam name="T">Disjoint Set eleman tipi (notnull olmalı)</typeparam>
    public class DisjoinSet<T> : IEnumerable<T> where T : notnull
    {
        /// <summary>
        /// Elemanları ve ilişkili DisjoinSetNode nesnelerini saklayan dctionary
        /// Key: Elamnın Kendisi (T)
        /// Value: Elemanın Node bilgisi (rank ve parent)
        /// Dictionary , elemanlar üzerinde hızlı erişim ve find/union işlemleri sağlar
        /// </summary>
        private Dictionary<T, DisjoinSetNode<T>> set = new Dictionary<T, DisjoinSetNode<T>>();


        public DisjoinSet()
        {
            
        }

        public DisjoinSet(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                MakeSet(item);
            }
        }

        /// <summary>
        /// Disjoint Set içindeki toplam eleman sayısı.
        /// Sadece sınıf içinden değiştirilebilir (private set;), dışarıdan okunabilir
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Yeni bir eleman ekler ve kendi kümesinde başlatır
        /// Eleman zaten varsa işlem yapmaz
        /// </summary>
        /// <param name="Value">Eklenecek elemanın değeri</param>
        public void MakeSet(T Value)
        {
            //Eğer eleman zaten mevcutsa hata fırlatılır
            if (set.ContainsKey(Value))
            {
                throw new Exception("The value has already been defined");
            }

            //Yeni bir node oluşturulu, Rank başlangıçta 0 olur
            var newSet = new DisjoinSetNode<T>(Value, 0);

            //Node kendi kendisini parent olarak ayarlar (başlangıçta tek elemanlı küme)
            newSet.Parent = newSet;

            //Dictionary'e eklenir
            set.Add(Value, newSet);

            //Toplam eleman sayısı artırılır
            Count++;
        }

        /// <summary>
        /// Verilen elemanın aity olduğu kümenin temsilcisini (root) dödürür
        /// Path compression uygulanabilir
        /// </summary>
        /// <param name="Value">Kökü bulunacak eleman</param>
        /// <returns>Kümenin temsilci elemanı</returns>
        public T FindSet(T Value)
        {
            if (!set.ContainsKey(Value))
            {
                throw new Exception("The value is not in this set!");
            }
            return findSet(set[Value]).Value!;

        }
        private DisjoinSetNode<T> findSet(DisjoinSetNode<T> node)
        {
            var parent = node.Parent;
            if (node != parent)
            {
                node.Parent = findSet(node.Parent!);
                return node.Parent!;
            }
            return parent;
        }

        /// <summary>
        /// İki elamanın ait olduğu kümeleri birleştirir.
        /// Rank ve size kullanarak dengel birleştirme yapılabilir
        /// </summary>
        /// <param name="ValueA">Birinci eleman</param>
        /// <param name="ValueB">İkinci eleman</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Union(T ValueA, T ValueB)
        {
            //Genel ValueA veya ValueB boş ise hata döndür 
            if (ValueA == null || ValueB == null) throw new ArgumentNullException();

            //Kökleri bul
            var rootA = FindSet(ValueA);
            var rootB = FindSet(ValueB);

            //Aynı küme kontrolü
            if (rootA.Equals(rootB))
            {
                return;
            }

            /*
            Node'ları al
                - Dictionary'den ilgili köklerin DisjoinSetNode nesneleri alınır
                - Bu nesneler Rank ve Parent bilgilerini içerir (Value değeride var)
            */
            var nodeA = set[rootA];
            var nodeB = set[rootB];

            /*
            Rank eşit ise
                -Eğer iki kümenin rank'ları eşitse, birini diğerinin altına ekle
                - Burda nodeB alt node, nodeA parnet (üst) node olur
                - Yani nodeB artık nodeA üzerinden köke ulaşacak
                - nodeA'nın parent'ı değişmez, kendisi üst (root) olarak kalır
                - Üstteki node'un Rank değeri 1 artırılır, çünkü artık daha yüksek bir ağaç oluştu
            */
            if (nodeA.Rank == nodeB.Rank)
            {
                nodeB.Parent = nodeA;
                nodeA.Rank++;
            }
            /*
            Rank farklı ise
                - Daha küçük ranklı ağaçi büyük rank'lı ağacın altına eklenir
                - Böylece ağaç dengeli kalır ve Find işlemleri hızlı olur
            */
            else
            {
                if (nodeA.Rank < nodeB.Rank)
                {
                    nodeA.Parent = nodeB; // nodeA’nın parent’ı nodeB oluyor.

                }
                else
                {
                    nodeB.Parent = nodeA;//nodeB’nın parent’ı nodeA oluyor.
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            /* return set.Values.Select(x => x.Value).GetEnumerator()!; */
            var list = new List<T>();
            foreach (var node in set.Values)
            {
                list.Add(node.Value!);
            }
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    /*
    
    çalışma prensibini anlaman:

Her eleman kendi kümesinde başlar (MakeSet).

Find → kökü bulur, path compression ile hızlandırır.

Union → rank’a göre birleştirir, küçük ağacı büyük ağacın altına ekler.

Kod detaylarını ezberlemek yerine:

Referans vs. array mantığını anlamak

Parent ve Rank kullanımını kavramak yeterli.

Kod her zaman internette, notlarında veya kendi kütüphanende bulunabilir.
    */
}