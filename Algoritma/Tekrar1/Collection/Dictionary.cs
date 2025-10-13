using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Programlama.Tekrars1
{
    public class DictionaryTkeyTValueClass
    {
        public static void DictionaryTkeyTValueRun()
        {
            // Temel();
            V3Ornek();
        }

        private static void Temel()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "serkan");
            dict.Add(2, "Ayşe");
            dict.Add(3, "Hamz");
            dict[4] = "Mehmet";

            System.Console.WriteLine(dict[3]);
            if (dict.TryGetValue(1, out string? val)) //Key var mı kontrol eder, yoksa hata fırlatmaz.
            {
                System.Console.WriteLine(val);
            }
            foreach (var item in dict)
            {
                System.Console.WriteLine($"Key: {item.Key}. Value: {item.Value}");
            }

            if (dict.ContainsKey(6)) // 2. key varmı
            {
                System.Console.WriteLine($"Dict 2: {dict[2]}");
            }
            else
            {
                System.Console.WriteLine("Key yok");
            }

            if (dict.ContainsValue("serkan"))
            {
                System.Console.WriteLine($"Dict serkan");
            }
            else
            {
                System.Console.WriteLine("Değer yok");
            }



            dict.Remove(1);
            dict.Clear();
        }

        private static void V3Ornek()
        {
            //Dictionary oluşur, Vector3 key , string value
            var players = new Dictionary<Vector3, string>(new Vector3Comparer());

            //Oyuncu pozisyonları ve simileri
            Vector3 playerPos = new Vector3(1, 0, 2);
            Vector3 enemyPos = new Vector3(5, 0, 3);

            players[playerPos] = "Player";
            players[enemyPos] = "Enemy";

            //Belirli bir pozisyondaki objeyi bul
            Vector3 searchPos = new Vector3(1, 0, 2);
            if (players.ContainsKey(searchPos))
            {
                System.Console.WriteLine($"Found at {searchPos}: {players[searchPos]}");
            }
            foreach (var kvp in players)
            {
                System.Console.WriteLine($"Position {kvp.Key}: {kvp.Value}");
            }
        }
    }

    //ör -> Vector3 içn comparer
    class Vector3Comparer : IEqualityComparer<Vector3>
    {
        public bool Equals(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public int GetHashCode(Vector3 v)
        {
            return HashCode.Combine(v.X, v.Y, v.Z);
        }
        /*
        IEqualityComparer<T> C# arayüzü (interface) olup, bir türün eşitlik mantığını özelleştirmek için kullanılır.

        1. Ne işe yarar?

            Dictionary<TKey, TValue> veya HashSet<T> gibi hash tabanlı koleksiyonlar, anahtarların eşit olup olmadığını ve hash kodlarını bilmek zorundadır.
            
            IEqualityComparer<T> ile:
            
            Equals(T x, T y) → iki öğe eşit mi?
            
            GetHashCode(T obj) → öğenin hash kodu ne?
        
        */
    }


#region Tanım
    /*
    Key: benzersi olmalı, duplicate eklenemez
    Value: Karmaşık veya basit olabilir
    Sıra: Key'lerin ekleme sırasını garanti etmez
    Erişim: key üzerinden O(1) ortalama
    Performans:
        - Ekleme, silme, arama: O(1) ortalama
    Kullanım Senaryoları:
        - Hızlı key-value erişimi
        - ID-object ilişkisi
        - Inventory sistemleri , veri eşleme, lookup tabloları

    Önemli:
        - Dictionary hash tabanlıdır, hızlı arama sağlar
        - Key sırasına bağlı işler içn "SortedDictionary" veya "OrderedDictionary" kullanılır
        - Küçük ve orta boyutlu ve key sıralı bir tablo istiyorsan "SortedList" kullanılır.
    */
#endregion
}