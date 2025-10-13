using System;
using System.Diagnostics.CodeAnalysis;

namespace Programlama.Tekrars1
{
    public class HashSetClassi
    {
        public static void HashSetRun()
        {
            // Temel();
            //AktifDusmanPozisyonlariniTakip();
            // KumeIslemleri();

            var set = new HashSet<PlayersLi>();
            set.Add(new PlayersLi("aa", 100));
            set.Add(new PlayersLi("hh", 20));
            set.Add(new PlayersLi("bb", 60));
            set.Add(new PlayersLi("serkan", 100));
            set.Add(new PlayersLi("cc", 1));

            foreach (var item in set)
            {
                System.Console.WriteLine(item._name);
            }
        }

        private static void Temel()
        {
            //HashSet oluşur ->benzersiz (unique) ve sıra garantisi olmayan öğeler saklayan, hızlı arama ve ekleme sağlayan bir koleksiyondur.
            HashSet<int> activeEnemies = new HashSet<int>();

            //Düşman ekleme
            activeEnemies.Add(101);
            activeEnemies.Add(102);

            activeEnemies.Add(103);

            activeEnemies.Add(101);//False , tekrar ekelenemez. zaten var

            System.Console.WriteLine($"Enemy count: {activeEnemies.Count}");

            System.Console.WriteLine("Active Enemies: ");

            foreach (var id in activeEnemies)
            {
                System.Console.WriteLine($"Enemise ID: {id}");
            }

            //Arama
            System.Console.WriteLine($"\nContains ID 102? {activeEnemies.Contains(102)}");

            //Silme
            activeEnemies.Remove(103);
            System.Console.WriteLine($"After removing 103, contains? {activeEnemies.Contains(103)}");

            //Clear
            activeEnemies.Clear();
            Console.WriteLine($"Enemey count after clear: {activeEnemies.Count}");
        }
        private static void KumeIslemleri()
        {
            HashSet<int> forestEnemies = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> caveEnemies = new HashSet<int>() { 3, 4, 6, 7, 8 };
            System.Console.WriteLine(("Forest: " + string.Join(", ", forestEnemies)));
            System.Console.WriteLine(("Cave: " + string.Join(", ", caveEnemies)));

            //1. Union(birleşim)
            var union = new HashSet<int>(forestEnemies);
            union.UnionWith(caveEnemies);
            System.Console.WriteLine(("\nBirleşim: " + string.Join(", ", union)));

            //2. Intersection (kesişim)
            var Intersection = new HashSet<int>(forestEnemies);
            Intersection.IntersectWith(caveEnemies);
            System.Console.WriteLine(("Kesişim (Intersect): " + string.Join(", ", Intersection)));

            //3. Difference (forest - cave) -> ExceptWith
            var Difference = new HashSet<int>(forestEnemies);
            Difference.ExceptWith(caveEnemies);
            System.Console.WriteLine(("Fark (Except): " + string.Join(", ", Difference)));

            //4. Symmetric diffrerence (sadece birinde olanlar)
            var symDiff = new HashSet<int>(forestEnemies);
            symDiff.SymmetricExceptWith(caveEnemies);
            System.Console.WriteLine(("Sadece birinde olanlar (Symmmetric): " + string.Join(", ", symDiff)));

        }
        private static void AktifDusmanPozisyonlariniTakip()
        {
            HashSet<Vector3> activeEnemyPosition = new HashSet<Vector3>(new Vector3Comparers());
            Vector3 enemy1 = new Vector3(1, 0, 2);
            Vector3 enemy2 = new Vector3(5, 0, 3);
            Vector3 enemy3 = new Vector3(1, 0, 2);//tekrar

            activeEnemyPosition.Add(enemy1);// true
            activeEnemyPosition.Add(enemy2);// true
            activeEnemyPosition.Add(enemy3); // false , tekrar

            System.Console.WriteLine("Active enemy Positions:");
            foreach (var pos in activeEnemyPosition)
            {
                System.Console.WriteLine(pos);
            }

            //Arama
            Vector3 searchPos = new Vector3(5, 0, 3);
            System.Console.WriteLine($"\nContains{searchPos}? {activeEnemyPosition.Contains(searchPos)}");

            //silme
            activeEnemyPosition.Remove(enemy1);
            System.Console.WriteLine($"\nAfter removing {enemy1}, count: {activeEnemyPosition.Count}");

        }
    }
    #region Örnek

    //Basit vector3 struct'ı (Unity'de Transform.position yerine)
    public struct Vector3
    {
        public float X, Y, Z;
        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z}) ";
        }
    }

    //vector 3 için comparer (has ve eşitlik)
    public class Vector3Comparers : IEqualityComparer<Vector3>
    {
        public bool Equals(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public int GetHashCode(Vector3 v)
        {
            return HashCode.Combine(v.X, v.Y, v.Z);
        }
    }

    #endregion
    

    #region Tanım
        /*

        Mantık: Küme (matematiksel set) -> aynı elemandan sadece biri bulunur.
        Temel özellik: Tekrarlanan değeri otomatik engeller
        Sıra: Sıra garantisi yok. Eleman eklenme sırarsı korunmaz
        Temel ilşlemler:
            - Add, Remove, Contains işlemleri O(1) ortalama karmaşıklıktadır.

            - Küme işlemleri: UnionWith, IntersectWith, ExceptWith, SymmetricExceptWith
   
            - Add() → ekler, tekrar eklenirse false

            - Remove() → çıkarır
  
            - Contains() → kontrol eder

            - UnionWith() -> Birleşim

            - IntersectWith() -> Kesişim

        Performans:
            Add, Remove, Contains işlemleri O(1) ortalama

        Unity Mantığıyla Kullanım Önerisi

            - Düşman spawn sistemi: hangi düşmanlar aktif takip edilebilir
            - Trigger veya colider içindeki benzersi objeleri tutmak
            - Item pickup setleri: oyuncunun topladığı itemler unique olsun
            - Aktif düşman veya toplanabilir nesne listesi
            - Trigger/Checkpoint ID’leri: tekrar tetiklenmesin
            - Benzersiz tag veya event kaydı
            - Aynı şey iki kez olmasın gereken her senaryo


    HashSet<T> içindeki elemanlar eklediğin sırayla tutulmaz ve yazdırılırken farklı sırayla çıkabilir.
Sebep: her eleman bellekte hash koduna göre bir konuma yerleştirilir, bu yüzden sıralama rastgele görünür.
    

     Özet
        Benzersiz eleman tutar
        Sıra garantisi yoktur
        HashSet<T> = unique koleksiyon

      

        ExceptWith() -> bir kümeden başka bir kümedeki elemanları çıkarır
            ör: A.ExceptWith(B) -> A kümesinde olup B'de olmayanlar kalır.

        SymmetricExceptWith() -> iki küme arasındaki farklı elemanları bırakır. Yani her iki kümede de olanları siler, sadece tek tarafta olanları tutar
            ör: A:{1,2,4,6,7} B:{1,2,3,4,5} 
                    A.SymmetricExceptWith(B) => {3,5,6,7}
        Unity’de genellikle ID veya referans takibi için kullanılır

*/
    #endregion
}