using System;

namespace Programlama.IleriAlgoritma.Graph
{ //Depth First Search
    public class DepthFirst<T>
    {
        

        public bool Find(IGraph<T> graph, T verexKey)
        {
            return DFS(graph.ReferanceVertex, new HashSet<T>(), verexKey);
        }

        private bool DFS(IGraphVertex<T> current, HashSet<T> visited, T searchVertexKey)
        {
            visited.Add(current.Key);
            System.Console.WriteLine(current.Key);
            if (current.Key!.Equals(searchVertexKey))
            {
                return true;
            }
            else
            {
                foreach (var edge in current.Edges)
                {
                    if (visited.Contains(edge.TargetVertexKey))
                    {
                        continue;
                    }
                    if (DFS(edge.TargetVertex, visited, searchVertexKey))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }

    #region DFS Tanım
    /*
Depth First Search (DFS):
    Bir ağaç veya grafı derinlemesine dolaşma algoritmasıdır. Her dalı sonuna kadar gider, geri döner, sonra diğer dala geçer.

Mantık:
- Kök düğümden başlanır
- Bir çocuk düğüme gidilir
- Onun da çocuklarına gidilir
- Artık alt çocuk kalmayınca geri dönülür
- Gidilmemiş diğer dallar aynı şekilde gezilir.

*Non-recursive adımlar (stack ile)
-Bir Stack oluştur.
-Başlangıç düğümünü push et
-Stack boş değilken:
    - En üstteki düğümü al (pop)
    - İşlemini yap(örneğin yazdır)
    - Çocuklarını stack'e ekle (genellikle sondan başa , sıra düzgün olsun diye)


** DFS :
                  A
                /   \
               B     C
              / \
             D   E

    DFS Sıralama:
        A → B → D → E → C

        Çünkü A’dan başlayıp B’ye, oradan D’ye kadar derin gidilir, D’nin altı kalmayınca geri dönülür.

***Unity’de DFS (Depth First Search) kullanabileceğin tüm yaygın alanlar:

    AI davranış ağaçları – Karakterin eylemlerini (saldır, kaç, devriye) derinlemesine  test etmek.

    Yetenek (Skill) ağaçları – Oyuncu ilerledikçe açılan yetenekleri dolaşmak.

    Sahne nesne hiyerarşisi – Parent–child ilişkili nesneleri tek tek gezmek.

    Prefab içi nesne taraması – Alt objelerde belirli bileşeni (component) bulmak.

    Quest / Görev sistemleri – Görev zincirlerini sırayla çözmek.

    Yol bulma (Pathfinding) – Küçük alanlarda A* yerine basit derin arama yapmak.

    Diyalog sistemleri – Seçenekli konuşmalarda dallanmış diyalogları gezmek.

    Puzzle çözümü / harita keşfi – Labirent veya bağlantı tabanlı sistemlerde.

    Scene graph analizleri – Performans ölçümü veya optimizasyon için nesne ağacı taraması.

    ScriptableObject bağımlılık çözümü – Veri nesneleri arasındaki bağlantıları kontrol  etmek.

    Runtime hierarchy tool – Oyun sırasında hiyerarşiyi derin tarayarak bilgi toplamak.

    Event propagation (olay yayılımı) – Alt node’lara olay iletimi.

    Save/Load sistemleri – Hiyerarşik veriyi (ör. envanter ağacı) sırayla kaydetmek veya yüklemek.

    Procedural generation – Harita veya seviye oluştururken hiyerarşik yapı kurmak.

    Dependency çözümü – Bir bileşenin başka hangi bileşenlere bağlı olduğunu bulmak.
  */
    #endregion
}