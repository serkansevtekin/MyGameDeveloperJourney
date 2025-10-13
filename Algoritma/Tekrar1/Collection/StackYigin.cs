using System;

namespace Programlama.Tekrars1
{
    public class StackYiginClass
    {
        public static void StackYiginRun() // LIFO
        {
            //Stack oluştur
            Stack<string> undoStact = new Stack<string>();

            //İşlemleri yığına ekle
            undoStact.Push("Move Player");
            undoStact.Push("Collect Item");
            undoStact.Push("Attack Enemy");

            System.Console.WriteLine("Undo actions:");

            //LIFO: son eklene ilk çıkar
            while (undoStact.Count > 0)
            {
                string action = undoStact.Pop();// Eleman çıkartır
                System.Console.WriteLine($"Undo: {action}");
            }

            //Peek
            System.Console.WriteLine("\nPeek Örneği");
            undoStact.Push("Open Door");
            undoStact.Push("Cloased Window");

            System.Console.WriteLine(undoStact.Peek());
        }
    }
  #region Tanım
      /*
        Mantık: LIFO (Last In, First Out) -> son ekelenen ilk çıkar
        Temel işlemler:
            - Push(T item) -> yığına eleman ekle
            - T Pop() -> en üstteki elemanı çıkar ve döndür
            - T Peek() -> en üsteki elemanı çıkarma, sadece bak
            - Count -> eleman sayısı
        Performans:
            -Push/Pop O(1)
        
        Kullanım senaryoları:
            - Geri alma (Undo/Rendo) sistemi
            - Fonksiyon çağrı yığınları(Call stack)
            - Derinlik öncelikli arama (DFS)
            - Menü veya sahne geçiş geçmişi
            - Object pooling / Spawn yönetimi
            - UI Navigation
        
        Not: LIFO yapısıdır, geri dönüş , geri alma , geçmiş kaydı fibi senaryolar idealdir.
      */
  #endregion
}