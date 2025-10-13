/*

Bu 8 koleksiyon Unity mobil geliştirmede tüm temel ihtiyaçları kapsar:

List<T> → Sıralı, indeksli veri, çoğu array/array benzeri kullanım.

Dictionary<TKey, TValue> → Key-value, hızlı arama ve ilişkilendirme.

HashSet<T> → Benzersiz veri, hızlı varlık kontrolü.

Queue<T> → FIFO işlemler (görev kuyrukları, event işleme).

Stack<T> → LIFO işlemler (undo, geri alma, state yönetimi).

LinkedList<T> → Sık ekleme/çıkarma gereken listeler.

SortedSet<T> → Sıralı ve benzersiz veri.

SortedList<TKey, TValue> → Key bazlı sıralı erişim.

Bunlarla oyun mantığı, entity yönetimi, event kuyrukları, benzersiz nesne yönetimi, sıralı veri işlemleri gibi tüm yaygın senaryoları çözebilirsin.

Özetle: bu koleksiyonları iyi kavradığında mobil Unity’de %95+ işini halletmiş olursun.



 Methods

    
        - Add(T item) -> Listeye eleman ekler
        - AddRange(IEnumerable<T> collecyion) -> koleksiyon ekler
        - AsReadOnly() -> Salt okunur liste döner
        - BinarySearch(T item) -> ikili arama.
        - Clear() -> tüm elemanları siler
        - Contains(T item) -> içeriyor mu? kontrol eder
        - ConvertAll<TOutput>(Convert<T,TOutput>) -> Tip dönüştürür
        - CopyTo(T[] Array) -> Diziyi Kopyalar
        - Exists(Predicate<T>) -> Koşulu sağlayan var mı?
        - Find(Predicate<T>) -> ilk eşleşeni bulur
        - FindAll(Predicate<T>) -> Tüm eşleşenleri döner
        - FindIndex(Int32, Predicate<T>) -> İlk eşleşenin indexi
        - FindLast(Predicate<T>) -> Son eşleşen döner
        - FindLastIndex(Predicate<T>) -> Son eşleşenin indexi
        - ForEach(Action<T>) -> Her elemana işlem uygular
        - GetEnumerator() -> Enumerator döner
        - GetRange(Int32, Int32) -> Belirli aralıktaki elemanlar
        - IndexOf(T item) -> ilk index
        - LastIndexOf(T item) -> Son index
        - Insert(Int32, T item) -> Belirtilen indexe ekler
        - Remove(T item) -> ilk bulduğunu siler
        - RemoveAt(Int32) -> index'e göre siler
        - RomoveAll(Predicate<T>) -> Koşula uyanları siler
        - RemoveRange(Int32, Int32) -> Aralıktakileri siler
        - Reverse() -> Ters çevir
        - Sort() -> Sırala
        - ToArray() -> Diziye Dönüştür
        - TrimExcess() -> Kapasiyeyi düşürür (performans için iyi)
        - TrueForAll(Predicat<T>) -> Tüm elemanlar koşulu sağlıyor mu
        

            */
