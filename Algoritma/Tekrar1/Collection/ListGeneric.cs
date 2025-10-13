using System;

namespace Programlama.Tekrars1
{
    public class ListTClass
    {
        public static void ListTRunMethod()
        {
            //  TemelKullanim();

            List<PlayersLi> player = new List<PlayersLi>();
            player.Add(new PlayersLi("serkan", 100));
            player.Add(new PlayersLi("Hero1"));

            foreach (var item in player)
            {
                System.Console.WriteLine($"Player name: {item._name} ve health: {item._health}");
            }
        }

        private static void TemelKullanim()
        {
            List<int> numbers = new List<int>() { 10, 40, 50, 60 };
            numbers.Add(20);
            numbers.Add(30);


            numbers.AddRange(new int[] { 70, 80, 90, 0 });

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine($"Eleman Sayısı: {numbers.Count}");

            numbers.Remove(30);
            numbers.RemoveAt(0);//indexteki elemanı siler

            System.Console.WriteLine($"Belirtilen indexteki eleman: {numbers[0]}");

            if (numbers.Contains(20))//Listede var mı
            {
                System.Console.WriteLine("true");
            }
            else
            {
                System.Console.WriteLine("Flase");
            }


            System.Console.WriteLine($"Elemanın listedeki index'i: {numbers.IndexOf(80)}");

            numbers.Sort();//listeyi küçükten büyüğe doğru sıralar

            numbers.ForEach(x => System.Console.WriteLine(x));

            numbers.Reverse();//Listeyi ters çevir

            int found = numbers.Find(x => x > 50);//Koşula uyan ilk lemanı döndürür
            System.Console.WriteLine(found);
            System.Console.WriteLine();
            List<int> bigNumber = numbers.FindAll(x => x > 50);//Koşula uyan tüm elemanları liste olarak dönürür
            foreach (var item in bigNumber)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            numbers.Insert(5, 1000);//5. index'e 1000 elemanını ekle
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            int[] arr = numbers.ToArray(); // listeyi diziye çevirir

            bool anyHeigh = numbers.Any(x => x > 50); // Biri 50'den büyük mü
            bool allHeigh = numbers.All(x => x > 10); // Hepsi 10'dan büyük mü
            var filtered = numbers.Where(x => x > 20); // 20'den büyükleri al

            numbers.Clear();
            System.Console.WriteLine($"Eleman Sayısı: {numbers.Count}");
        }
    }


    //ör

    public class PlayersLi
    {
        public string _name { get; private set; }
        public int _health { get; private set; }
        public PlayersLi(string name, int health = 100)
        {
            this._name = name;
            this._health = health;
        }

    }


        #region Tanım
            /*
            Sıra: Elemanlar ekleme sırasına göre tutulur
            Benzersizlik: Yok, duplicate eklenebilir
            İndexleme: Direkt erişim O(1)(list[0], list[5] vb.)
            Performans:
                - Ekeleme (sona): amortize O(1)
                - Ekleme/çıkarma (ortada): O(n)
                - Arama(Contains, indexOf): O(n)
            
            Kullanım Senaryoları:
                - Sıralı veri saklama
                - index bazlı erişim
                - Oyun objeleri listesi, inventroy, skor tabloları

            Önemli:
                - "List<T>" küçük/orta boyutlu veri için performanslı ve kullanımı basit.
                - Mobil Unity'de en çok kullanılan koleksiyondur.
            */
        #endregion
}