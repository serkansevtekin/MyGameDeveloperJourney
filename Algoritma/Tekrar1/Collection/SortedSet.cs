using System;

namespace Programlama.Tekrars1
{
    public class SortedSetClass
    {
        public static void SortedSetRun()
        {
            SortedSet<int> s = new SortedSet<int>();

            for (int i = 0; i < 10; i++)
            {
                s.Add(new Random().Next(1, 10));
            }
            foreach (var item in s)
            {
                System.Console.Write(item + " ");

            }

            if (s.Contains(2))
            {
                System.Console.WriteLine("Var");
                s.Remove(2);
                foreach (var item in s)
                {
                    System.Console.Write(item + " ");

                }
            }
            else
            {
                System.Console.WriteLine("yok");
            }



        }

        #region Tanımı
        /*
        Sıra: Elemanlar otomatik sıralı tutulu (Küçükten büyüğe doğru)
        Benzersizlik: Aynı değeri ekleyemezsin
        Performans:
            -Ekleme, silme i arama: O(log n)

        Sıralama mantığı:
            - T tipi IComparable<T> implement etmeli
            - veya Comparer<T> sağlanmalı

        Kullanım senaryosu
            - Sıralı benzersiz veri listesi
            - LeaderBoard, skor tablosu
            - Zaman Çizelgesi, event sıralama


        - Sıralı ve bezersiz olması dışında hash tabanlı değildir, dolayısıyla "HashSet<T>" kadar hızlı arama yapamaz.
        */
        #endregion
    }
}