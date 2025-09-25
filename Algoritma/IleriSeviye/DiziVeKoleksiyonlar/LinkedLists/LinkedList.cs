using System;

namespace Programlama.IleriAlgoritma
{
    class LinkedListClass
    {
        public static void LinkedListRunMain()
        {
            //Tek yönlü bağlı liste
            SinglyLinkedListClass.SinglyLinkedListRunMain();
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