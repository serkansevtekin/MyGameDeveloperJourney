using System;

namespace Programlama.IleriAlgoritma
{
    class LinkedListClass
    {
        public static void LinkedListRunMain()
        {
            //Tek yönlü bağlı liste
            //SinglyLinkedListClass.SinglyLinkedListRunMain();

            //Çift yönlü bağlı liste
            //   DoublyLinkedListClass.DoublyLinkedListRunMethod();
            LinkedListKullanim();
        }

        public static void LinkedListKullanim()
        {
            //Boş bir LinkedList<int> oluşturma
            LinkedList<int> numbers = new LinkedList<int>();

            //Başa eleman ekleme
            numbers.AddFirst(10);


            //Sona eleman ekleme
            numbers.AddLast(20);
            numbers.AddLast(30);
            numbers.AddLast(100);

            //Belirli bir düğümden sonra ekleme
            //numbers.AddAfter(numbers.Find(20) ?? numbers.Last!, 25);
            //uzun kullanım
            LinkedListNode<int>? node20 = numbers.Find(20);
            if (node20 == null)
            {
                numbers.AddLast(numbers.Last!.Value);
            }
            else
            {
                numbers.AddAfter(node20, 1000);
            }


            //Belirli bir düğümden önce ekleme
            numbers.AddBefore(numbers.Find(100) ?? numbers.Last!, 9999);



            //Elemanları yazdırma
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }


            //Eleman Silme
            numbers.Remove(25);
            numbers.RemoveFirst();
            numbers.RemoveLast();
            System.Console.WriteLine("\nSilme sonrası: ");
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }


            //Contains kontroli | Eleman var mı | True / False
            System.Console.WriteLine($"\n30 içeriyor mu? {numbers.Contains(20)}");

            //Coun 
            System.Console.WriteLine($"Eleman Sayısı: {numbers.Count}");
        }






        #region Bağlı Liste (Linked List) | Tanım
        /*
        - 2 ye ayrılır : 1. Singly Linked List ve 2. Doubly Linked List
        - İçindeki elemanların doğrusal olarak düzenlendiği veri yapısıdır.
        - Dizilere benzer bir yapısı vardır. Ancak içindeki elemanlara ulaşma yaklaşımı ile dizilerden ayrılmaktadır.
        - Rastgelere erişim (index ile erişim) yoktur. Sırayla gezilir
        - Elemanlara düğüm (LinkedListNode<T>) üzerinden erişilir
        - Her düğüm, hem bir sonraki (Next), hem de önceki (Previous) düğümü işaret eder
        - Baş (First) ve son (Last) düğümler üzerinden listeye hızlı eklem/çıkarma yapılabilir

        * Bağlı Liste İşlevleri | Main linked list operations
            - Insert -> Listeye eleman ekleme
            - Delete -> Listeden eleman silme

        * Yardımcı Bağlı Liste İşlevleri | Auxiliary linked list operations
            - Delete List -> Listedeki tüm elemanları siler ve listeyi yok eder
            - Count -> Listedeki eleman sayısını döner
            - Finde -> Listedeki bir düğümü işaret eder

    Diziler
        *Avantajları
            - Basit ve kullanımı kolay
            - Elemanlara doğrudan erişim imkanı sunar

        *Dezavantajları
            - Önceden bellek tahsisi ve dizideki boş elemanları için belleğin işgal edilmesi
            - Sabit boyut
            - Bir blok tahisisi (One block allocation)
            - Konuma dayalı karmaşık ekleme (Complex position-based insertion)

    Bağlı Liste (Linked List)
        *Avantajları
            - Bağlı liste sabit zamanda genişletilebilir
            - Önceden bellek tahsisini engeller (preallocates)

        *Dezavantajları
            - Erişim zamanı (access time)
            - En kötü durumda bir elemana eriş menin maliyeti

        */
        #endregion
    }
}