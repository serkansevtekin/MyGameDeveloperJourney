using System;

namespace Programlama.IleriAlgoritma
{
    class KolleksiyonlarinOrtakOzellikleriClass
    {
        public static void KolleksiyonlarinOrtakOzellikleriRunMethod()
        {

        }
        
        #region Kolleksiyonların Ortak Özellikleri Tanım
            /*

                Kolleksiyonların Ortak Özellikleri 

            1- Kolleksiyonun numaralandırma yeteneği
                    - System.Collection.IEnumerable veya System.Collections.Generic.IEnumerable<T>
            
            2- Bir "Enumerator", kolleksiyondaki herhangi bir öğeye taşınabilir bir işaretçi olarak düşünebilir.

            3- Bir "foreach" dögüsü "GetEnumerator" metodu kullanılarak taşınabilir işaretçi yardımıyla koleksiyondaki öğeler üzerinde dolaşabilir

            4- System.Collections.Generic.IEnumerable<T> sorgulanabilir bir tip olarak düşünülebilir ve LINQ ifadeleriyle sorgulanabilir

            5- LINQ sorguları, verilere erşim için ortak bir model sağlar

            6- LINQ filtreleme, sıralama, guruplama yetenekleriyle veri erişim performansını arttırır


            - Bir gurup nesnenin organize bir şekilde yönetildiği yapılar Collections olarak ifade edilebilir.

            - Bu yapılarda ilgili veri yapısına ekleme yapma, araya ekleme yapma, arama, sıralama ya da özel bir takım fonksiyonlar içerir

            - Collections ifadeleri generic yada non-generic olarak tanımlanabilirler.

            1. - Generic Koleksiyonlar (System.Collections.Generic)
                
                - Genelde "GENERIC" kodlama tercih edilir

                    * List<T>.                           -> Dinamik dizi, index ile erişim, çok kullanılan

                    * Dictionary<TKey,TValue>            -> Sözlük (anahtar , değer), hızlı lookup

                    * Queue<T>                           -> Kuyruk (FIFO) -- First In Firs Out

                    * Stack<T>                           -> Yığın  (LIFO) -- Last In First Out

                    * HashSet<T>                         -> Tekrar etmeyen elemanlar Küme 

                    * SortedDictionary<TKey, TValue>     -> Key'e göre sıralı dictionary

                    * SortedList<TKey, TValue>           -> Key'e göre sıralı, index ile erişimi destekler

                    * SortedSet<T>                       -> Tekrar etmeyen elemanlar, sıralı saklanır



                    Not: Generic, tip güvenlği var ve performans çok iyi. Günümüzde standart olarak  kabul ediliyor. Namespace'si "System.Collections.Generic"

                    Özellikleri: 
                        
                        * Elemanların tipi(int,string,bool,char) baştan belli olur
                        * Performanslıdır -> boxing / unboxing yok
                        * Modern projelerde her zaman tercih edilen koleksiyonlardır.


                    - MOBİL OYUN (Uniy) için ideal
                        * Çoğunlukla List<T>, Dictionary<TKey,TValue>, Queue<T>, Stack<T>, HashSet<T>, SortedSet<T>, SortedList<TKey,TValue>, SortedDictionary<TKey,TValue> yeterli olur.

                        * SortedList<TKey, TValue> ve SortedDictionary<TKey, TValue> -> genelde leaderboard, skor tablosu, sıralı item listesi gibi işleerde kullanılır.

                        * SortedSet<T> -> benzersiz sıralı değerler gerektiğinde (örneğin ID veye unique spwan point listesi)

                        ** UNITY'DE KOLLEKSİYON KULLANIM REHBERİ **

                            - T[](Array):
                                Sabit boyutlu, performans kritik veri (mesela 100 enemy transform pozisyonu). Cache-friendly, en hızlı erişim.

                            - List<T>:
                                Dinamik büyüyen/küçülen koleksiyon, çoğu yerde varsayılan çözüm (ör: aktif düşman listesi, envanter)

                            - Dictionary<TKey, TValue> :
                                ID -> Nesne eşleme, lookup çok hızlı (ör: PlayerID -> PlayerData, itemID -> Prefab)

                            - Queue<T> :
                                FIFO mantığı gereken durumlar (ör: mermi ateşleme sırası, event kuyruğu)
                            
                            - Stack<T> :
                                LIFO matığı gereken durumlar (ör: undo sistemi, menü navigation stack)

                            - HashSet<T> :
                                Tekrar etmeyen benzersiz deperler (ör: aktif bölgelerdeki benzersiz düşman ID'leri, bisited nodes)

                            - SortedDictionary<TKey, TValue> :
                                Skor tablosu gibi sıralı saklanamsı gereken key-value datalar

                            - SortedList<TKey, TValue>:
                                Hem sıralı dictionary gem index erişimi gerektiğinde (ör: sıralı item listesi)

                            - SortedSet<T>:
                                Benzersiz ve sıralı eleman listesi (ör: sıralı spawn point ID'leri)

                        Genel kural Unity’de:

                            -* %80 kullanım: List<T> ve Dictionary<TKey,TValue>
                            -* 
                            -* Performans kritik yerde: T[]
                            -* 
                            -* Özel algoritma/senaryo: Queue, Stack, HashSet, Sorted*




                ||||||||| ESKİ TİP||||||| - MOBİL OYUN (Uniyu) için kullanılmamalı
             2. - Non-Generic Koleksiyonlar (System.Collections)

                - Eski tip kolleksiyonlardır. .Net Freamwork'ün ilk sürümlerinden beri vardır.
                 
                    * Tüm elemanları "object" tipinde tutar.-> boxing/unboxing olur (int, char gibi value type’lar için).

                        - ArrayList
                        - Hastable
                        - Queue
                        - Stack
                        - SortedList

                - Tip güvenliği yoktur -> yanlış tip koyabilirsin, runtime'da patlar
                - Esnek ama performans kaybı çok.

            */
        #endregion
    }
}