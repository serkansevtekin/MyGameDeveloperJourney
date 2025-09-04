using System;

namespace Programlama.VeriYapilari
{
    class LinkedListClass
    {
        public static void LinkedListMainMethod()
        {
            //Temeller
            TemelBilgiler();
        }

        private static void TemelBilgiler()
        {
            //LinkedList<T> (Bağlı liste yapısı) Temelleri

            // Tanımlama
            LinkedList<string> sehirler = new LinkedList<string>();

            //Ekleme
            sehirler.AddFirst("ordu");//First ilk düğüm (özel bir düğün) hemde son düğüm

            sehirler.AddFirst("trabzon"); //İlk düğüm artık trabzon

            sehirler.AddLast("istanbul"); // Son düğüm artık istanbul

            //ordu node soranrasına samsun node ekleme
            LinkedListNode<string>? orduFindNode = sehirler.Find("ordu");
            sehirler.AddAfter(orduFindNode!, "samusun");

            //Samsundan önce giresun ekle | ? -> null kontolü
            LinkedListNode<string>? samsunOncesi = sehirler.First?.Next?.Next;
            sehirler.AddBefore(samsunOncesi!, "giresun");

            //Son eleman öncesine eleman ekleme
            LinkedListNode<string>? sonElemanOncesi = sehirler.Last?.Previous;
            sehirler.AddAfter(sonElemanOncesi!, "sinop");

            //Sinpu bul ve sonra zonguldak ekle
            LinkedListNode<string>? sinopBul = sehirler.Find("sinop");
            sehirler.AddAfter(sinopBul!, "zonguldak");

            /*  foreach (string item in sehirler)
             {
                 System.Console.WriteLine(item);
             } */


            //Pointerlara göre foreach benzeri döngü | Manuel dolaşma (Next)
            System.Console.WriteLine();
            System.Console.WriteLine("Gidiş Güzergahı");
            System.Console.WriteLine();
            var elemanGidis = sehirler.First;
            while (elemanGidis != null)
            {
                System.Console.WriteLine(elemanGidis.Value);
                elemanGidis = elemanGidis.Next;
            }

             //Pointerlara göre foreach benzeri döngü | Manuel dolaşma (Previous)
            System.Console.WriteLine();
            System.Console.WriteLine("Dönüş Güzergahı");
            System.Console.WriteLine();
            var gelisEleman = sehirler.Last;
            while (gelisEleman != null)
            {
                System.Console.WriteLine(gelisEleman.Value);
                gelisEleman = gelisEleman.Previous;
            }


        }

        #region Temel Bilgi
        /*
            --- LinkedList<T> ---
        - T -> type - safe
        - Elemanların hafızadki konumlarının sıralı olarak organize edilmediği bir liste yapısıdır.
        - Elemanlar (Node) Düğümlerden oluşur
        - Her düğüm (node), hem kendi verisini (value) hem de bir sonraki (Next) ve önceki (Previous) düğümü referansını tutar.
        - Yani arka planda zincirleme şekilde bağlı node'lardan oluşur

        -- ***. Temel Özellikleri .**--

        - Çift yönlüdür: ELemanları gem ileri hem geri bağlantısı vardır.
        - Sabit zamanda (0(1)) -> ekleme ve silme yapılabilir (başta/sonda veya referansı bilinen node'dan sonra)
        - İndeksleme yoktur -> yani myLinkedList[2] gibi doğrudan erişilemez -> erişim için baştan sona dolaşır (0(n))



        **-- Properties   **--

            - Firs -> ilk düğüm
                - First.Next -> ilk düğümden sonra gelen düğüm döner
            - Next -> bir sonraki düğümü işaret eder (Son düğüm ise null döner)
            - Last -> son düğüm
                - Last.Previous -> sondan önceki düğüm döner
            - node.Next -> o düğümden sonraki düğüm
            - node.Previous -> o düğümden önceki düğüm
            - Count -> eleman sayısı

        
        --** Metotlar --**
        
            - AddFirst(value) -> başa ekle
            - AddLast(value) -> sona ekle
            - AddBefore(node,value) -> belirtlen node'den önce ekler
            - AddAfter(node,value) -> belirtilen node'den sonra ekler
            - Remove(value) -> değeri sil
            - RemoveFirst() / RemoveLast() -> Baştaki/Sondaki elemanı sil
            - Find(value) -> değeri bul (ilk eşleşen node)
            - FindLast(value) -> değeri bul (son eşleşen node)


       -- Unity’de LinkedList<T> en çok --

            Sürekli ekleme/silme yapılan listelerde

            Object pooling (mermi, düşman, partikül yönetimi)

            AI task / path sistemlerinde

            Event/Update subscriber yönetiminde
            avantaj sağlar.
        
        */

        #endregion
    }
}