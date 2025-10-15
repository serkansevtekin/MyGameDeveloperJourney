using System;

namespace Programlama.Tekrars1.Heap
{
    public class HeapMainClass
    {
        public static void HeapMainRun()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("---- Max Heap ----");

            MaxHeap maxH = new MaxHeap();
            maxH.Insert(1);
            maxH.Insert(3);
            maxH.Insert(10);
            maxH.Insert(5);

            System.Console.WriteLine("Max Heap Eleman Sayısı: {0}", maxH.Count);

            System.Console.WriteLine("Tepe eleman {0}", maxH.Peek());
            maxH.PrintHeap(); // 10 , 5 , 3 , 1

            System.Console.WriteLine("Max heap'ten çıkan eleman: {0}", maxH.PopMax()); // 10

            maxH.PrintHeap(); // 5 , 1 , 3


            System.Console.WriteLine();
            System.Console.WriteLine("---- Min Heap ----");

            MinHeap mnH = new MinHeap();

            mnH.Insert(10);
            mnH.Insert(5);
            mnH.Insert(1);
            mnH.Insert(3);

            System.Console.WriteLine("Max Heap Eleman Sayısı: {0}", mnH.Count);

            System.Console.WriteLine("Tepe eleman {0}", mnH.Peek());

            mnH.PrintHeap();

            System.Console.WriteLine("Min heap'ten çıkan eleman: {0}",mnH.PopMin()); //1

            mnH.PrintHeap();


            System.Console.WriteLine("Min heap'ten çıkan eleman: {0}",mnH.PopMin()); //3

            mnH.PrintHeap();

        }
    }




    #region HEAP Tanım
    /*
    Heap bir binary tree'dir
    Ama farkı: her düğümün çocuklarıyla belirli bir sıralama ilişkisi vardır

    Max Heap: Root (en üst) her zaman en büyük değere sahip
    Min Heap: Root her zaman en küçük değere sahiptir
    
    HeapifyUp: Yeni ekelene elemanı doğru pozisyona ulaşana kadar yukarı taşı
    HeapifyDown: Root (veya değiştirilmiş elemanı) doğru pozisyona ulaşıncaya kadar aşağı taşır

   
    
    Özet:
        - Max Heap: En büyük root'ta
        - Min Heap: En küçük root'ta
        - Insert -> HeapifyUp
        - Pop -> HeapifyDown

    Diziler ile index ile çalışıyor -> mobil oyunlarda hızlı ve hafif
    */

    #endregion
}