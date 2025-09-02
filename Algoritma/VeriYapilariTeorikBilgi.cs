/*
                ** Veri Yapıları (Data Structures) **

    - Veri yaposı, veriye erişim , verinin depolanmasını ve verinin organisasyonunu temsil eden bir kabramdır.
    
    - Bir veri yapısı, veri değerleri, veriler arasındaki ilişkiler ve verilere uygulanabilecek işlevler veya işlemlerin bri kolleksiyonudur.

    - Genellikle verimli veri yapıları, verimli algoritmaların anahtarıdır.
    
    - Veri yapıları birincil ve ikincil hafızada depolanan verileri organize etmek üzere kullanılır.

    - Veri yapılarını aslında soyut bir kavram olarak ele alınmalıdır. Anahtar kelime -> Abstract Data Type (ADT)

    - Soyut veri türlerinin temelini oluşturur

    - Soyut veri türü ise veri türünün mantıksal biçimini tanımlar.
*/

/*
                ** TANIMLI KOLLEKSİYONLAR **
    
    - Bir koleksiyon (collection) yapılandırılmış bir veri türüdür.

    ---- Kolleksiyonlar -> 
    1. Doğrusal kolleksiyonlar (Linear Collections) 

        - Doğrusal kolleksiyonlar elemanları bir listesini ifade eder ve liste içindeki bir eleman, listedeki { bir başka elemanı takip edecek şekilde } organize edilmiştir.

        - Normalde doğrusal bir kolleksiyon (birinci, ikinci, üçüncü, ...) verinin pozisyonu tarafından sıralanır.

        - Doğrusal kolleksiyonlara örnek olarak -> Array (Dizi), List (Liste), Queue (Kuyruk), Stack (Yığın) verilebilir.


    2. Doğrusal Olmayan Kolleksiyonlar (Non-Linear Collections) 

        - Doğrusal olmayan koleksiyonlar, koleksiyon içindeki elemanları bir pozisyon sırasın göre organize etmez.

        - Veriyi organize ederken pozisyon bilgisini kullanmazlar.
        
        - Doğrusal olmayan kolleksiyonlara örnek olarak -> Graph (Graf), Tree (Ağaç), Dictionary ve HashSet verilebilir.
        
    ----
        🔹 Linear (Doğrusal) vs Non-Linear (Doğrusal Olmayan)


    1. Linear Collections (Doğrusal)

        Elemanlar ardışık olarak bellekte tutulur.

        Index ile erişim veya sırayla dolaşım mantığı vardır.

    Örnek:

        Array → arr[0], arr[1], arr[2]…

        List<T> → dinamik, ama ardışık erişim mantığı var

        Queue → FIFO

        Stack → LIFO

    2. Non-Linear Collections (Doğrusal Olmayan)

        Elemanlar hash tabanlı veya ağaç yapısı ile tutulur.

        Bellekte ardışık olmak zorunda değil.

        Erişim key veya hash üzerinden yapılır.

    Örnek:

        Dictionary<TKey, TValue> → key üzerinden O(1) erişim
        
        HashSet<T> → hash ile unique değer kontrolü
        
        Graph, Tree → düğümler ve kenarlar ile bağlantılı

*/