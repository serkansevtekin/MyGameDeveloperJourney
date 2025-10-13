using System;

namespace Programlama.Tekrars1
{
    public class SortedDictionaryTekrarClass
    {
        public static void SortedDictionaryTekrarRun()
        {

            SortedDictionary<int, string> sD = new SortedDictionary<int, string>();
            sD.Add(1, "balçova");
            sD.Add(3, "narlıdere");
            sD.Add(5, "buca");
            sD.Add(10, "evka3");
            sD.Add(2, "urla");
            sD.Add(0, "konak");

            foreach (var item in sD)
            {
                System.Console.WriteLine($"Key: {item.Key} - {item.Value}");
            }


            System.Console.WriteLine();
            
            
            var ss = new SortedDictionary<int, List<PlayersLi>>();
            ss.Add(1, new List<PlayersLi>()
            {
                new PlayersLi("AA",100),
                new PlayersLi("BB",20),
                new PlayersLi("CC",90),
                new PlayersLi("DD",40),


            });
            ss.Add(2, new List<PlayersLi>()
            {
                new PlayersLi("AAAA",10),
                new PlayersLi("BBBB",40),
                new PlayersLi("CCCC",90),
                new PlayersLi("DDDD",80),


            });

            //  var player = new PlayersLi("serkan", 100);
            // ss[1].Add(player);


            foreach (var kvp in ss)
            {
                foreach (var player in kvp.Value)
                {
                   if (player._health < 50)
                   {
                     System.Console.WriteLine($"Name: {player._name} - Healt: {player._health}");
                   }
                }
                
            }
            
            



        }
    }

    #region Tanım
    /*
    Sıra: Key'ler otomatik sıralı tutulur (IComparable<T> veya Comparer<T> ile)
    Benzersizlik: Key'ler benzersiz olamslı, duplicate eklenemz
    İç yapı: Tree tabanlı (Red-Black Tree), ekeleme/çıkarma O(log n)
    İndexer erişimi: O(log n)
    Performans:
        - Küçük / orta boyutta "SortedList" göre biraz daha yavaş ama büyük veri setlerinde daha stabil
    Kullanım Senaryoları:
        - Büyük ve sık ekleme/çıkarma yapılan veri setleri
        - Key bazlı sıralı erişim gereken durumlar (leaderboard, skor tabloları)

    Özet:
        - Az veri -> SortedList
        - Çok veri -> SortedDictionary
    */
    #endregion
}