using System;

namespace Programlama.Tekrars1
{
    public class QueueClass
    {
        public static void QueueRun() // FIFO
        {
            //TemelQueue();
            DusmanSpawnSirasi();
        }

        private static void TemelQueue()
        {
            Queue<string> task = new Queue<string>();
            task.Enqueue("Spawn enemy");
            task.Enqueue("Play sound");
            task.Enqueue("Show Message");

            System.Console.WriteLine($"Kuyruğun başındaki elemanı göster: {task.Peek()}");
            System.Console.WriteLine("Görev sırası:\n");
            foreach (var item in task)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("\nDequeue sonrası \n");
            System.Console.WriteLine("Çıkartılan eleman {0}", task.Dequeue());
            System.Console.WriteLine($"Kuyruğun başındaki elemanı göster: {task.Peek()}");
            System.Console.WriteLine();
            foreach (var item in task)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void DusmanSpawnSirasi()
        {
            //Queue Oluşur
            Queue<string> enemyQ = new Queue<string>();

            //Düşmanları sıra ile ekle
            enemyQ.Enqueue("Goblin");
            enemyQ.Enqueue("Orc");
            enemyQ.Enqueue("Troll");

            System.Console.WriteLine("Enemies spawning in order:");

            //FIFO ile ilk eklenen spawn olur
            while (enemyQ.Count > 0)
            {
                var enemySpawn = enemyQ.Dequeue();
                System.Console.WriteLine($"Spawned: {enemySpawn}");
            }


            //Peek örneği
            enemyQ.Enqueue("Dragon");
            System.Console.WriteLine($"\nNext enemy to spawn (peek): {enemyQ.Peek()}");
        }
    }

    /*
 Mantık: FIFO (First In, First Out) -> ilk eklenen ilk çıkar
        Temel İşlemler:
            - Enqueue(T item)-> kuyruğa ekle
            - T Dequeue() -> kuyruğun başındaki öğeyi çıkar ve dödür
            - T Peek() -> Baştaki öğeyi çıkarma, sadece bak
            - Count -> öğe sayısı
        
        Performans:
            Enqueue / Dequeue O(1)

        Kullanım senaryoları:
            -Task veya event sıralaması
            - Job processing / coroutine yöntemi
            - Breadth-first search (BFS) algoritması

        Özet: FIFO mantığı ile veri yönetimi sağlar, sıralı işleme gerektiren durumlar için uygundur.


    */
}