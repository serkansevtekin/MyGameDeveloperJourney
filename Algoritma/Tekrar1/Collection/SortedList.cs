using System;

namespace Programlama.Tekrars1
{
    public class SortedListTekrarClass
    {
        public static void SortedListTekrarRun()
        {
            SortedList<int, string> sL = new SortedList<int, string>();
            sL.Add(1, "balçova");
            sL.Add(3, "narlıdere");
            sL.Add(5, "buca");
            sL.Add(10, "evka3");
            sL.Add(2, "urla");
            sL.Add(0, "konak");

            foreach (var item in sL)
            {
                System.Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }

            System.Console.WriteLine("Keys[index] erişim: " + sL.Keys[2]);
            System.Console.WriteLine("Values[index] erişim: " + sL.Values[2]);
        }
        
        #region Tanım 
            /*
            Sıra: Key'ler ototmatik olarak sıralı tutulur
            Benzersizlik: Keyler benzersiz olmalı, duplicate key eklenemez
            Performans:
                - Arama: O(log n)
                - EKleme, Çıkarma: O(n) (çünkü listeyi kaydırmak gereke bilir)
            İndexleme: Key veya index ile erişim mümkün (ser.Values[index], set.Keys[index])
            
            Kullanım Senaryoları:
                - Key'e göre sıralı veri tabloları
                - Leaderboard, skor tablosu
                - Index üzerinden hızlı erişim gereken durumlar
            */
        #endregion
    }
}