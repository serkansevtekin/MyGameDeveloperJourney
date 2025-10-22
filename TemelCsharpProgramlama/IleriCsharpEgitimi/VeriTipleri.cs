using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class VeriTipleri
    {
        public static void VeriTipleriRunMethod()
        {
            //Integer -> 32 bit 
            int number1 = 2147483647; // min: -2,147,483,648 , max: 2,147,483,647

            System.Console.WriteLine("Integer Number is {0}", number1);

            //Long -> 64 bit
            long number2 = 1111111111111111111; // min: -9,223,372,036,854,775,808 , max: 9,223,372,036,854,775,807
            System.Console.WriteLine("Long Number is {0}", number2);

            //Short -> 16 bit
            short number3 = 32767; // min: -32,768 , max: 32,767
            System.Console.WriteLine("Short Number is {0}", number3);

            //Byte -> 8 bit (0-255)
            byte number4 = 200;
            System.Console.WriteLine("Btye Number is {0}", number4);

            //Bool -> 1 bit (true / false)
            bool condition = true;
            System.Console.WriteLine("Boolean Value: {0}", condition);

            //Char -> 16 bit (Unicode karakter, ASCI code)
            char letter = 'A';
            System.Console.WriteLine("Char Value: {0}", letter);
            System.Console.WriteLine("Char ASCI Value: {0}", (int)letter);//Tür dönüşümü

            //Float -> 32 bit (ondalıklı sayı, yaklaşık 7 basamak doğruluk)
            float temperature = 36.6f;
            System.Console.WriteLine("Float Value: {0}", temperature);

            //Double -> 64 bit (ondalıklı sayı, yaklaşık 15 - 16 basamak doğruluk)
            double pi = 3.141592653589793;
            System.Console.WriteLine("Double Value: {0}", pi);

            //Decimal -> 128 bit (finansak işlemler için, 28 - 29 basamak doğruluk)
            decimal price = 199.9m;
            System.Console.WriteLine("Decimal Value: {0}", price);


            //Enum -> sabitler kümesi -> Magic String
            Days day = Days.Tuesday;
            System.Console.WriteLine("Enum Value: {0}", day);


            //Var -> tür çıkarımı ( derleyici türü otomatik belirler )
            var number7 = 10; //int
            number7 = 'A';//int değişkene char atıyoruz ve asci koda çeviriyor
            System.Console.WriteLine("Var number is Velue: {0}", number7);
            
      

        }
        //Enum -> sabitler kümesi -> Magic String
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    }

    #region Tanım
    /*
    1. C#’ta Temel (Primitive) Veri Tipleri
    | Tür         | Bit      | Aralık           | Örnek                        | Açıklama                                                            |
| ----------- | -------- | ---------------- | ---------------------------- | ------------------------------------------------------------------- |
| **byte**    | 8        | 0 – 255          | `byte b = 255;`              | Pozitif tamsayı, genellikle byte dizilerinde (resim, dosya verisi). |
| **sbyte**   | 8        | -128 – 127       | `sbyte sb = -5;`             | Negatif ve pozitif küçük tamsayılar.                                |
| **short**   | 16       | -32,768 – 32,767 | `short s = 1000;`            | Küçük tamsayılar için.                                              |
| **ushort**  | 16       | 0 – 65,535       | `ushort us = 40000;`         | Pozitif kısa tamsayı.                                               |
| **int**     | 32       | ±2.1 milyar      | `int score = 100;`           | En çok kullanılan. Sayaç, skor, index, ID.                          |
| **uint**    | 32       | 0 – 4.2 milyar   | `uint id = 123u;`            | Negatif olmayan büyük tamsayı.                                      |
| **long**    | 64       | ±9.2 katrilyon   | `long xp = 9999999999L;`     | Büyük sayılar için.                                                 |
| **ulong**   | 64       | 0 – 1.8×10¹⁹     | `ulong big = 5000UL;`        | Pozitif büyük sayılar.                                              |
| **float**   | 32       | ~7 basamak       | `float speed = 3.14f;`       | Unity’de en sık kullanılan ondalıklı tip (pozisyon, hız, zaman).    |
| **double**  | 64       | ~15 basamak      | `double distance = 123.456;` | Daha hassas ama Unity’de az kullanılır.                             |
| **decimal** | 128      | ~28 basamak      | `decimal money = 10.5m;`     | Finansal hesaplar (oyun ekonomisi için).                            |
| **bool**    | 1        | true/false       | `bool isAlive = true;`       | Mantıksal değer.                                                    |
| **char**    | 16       | Unicode karakter | `char letter = 'A';`         | Tek karakter.                                                       |
| **string**  | değişken | metin            | `string name = "Player1";`   | Karakter dizisi.                                                    |
| **object**  | referans | her tip          | `object data = 5;`           | Her şeyi tutabilir. Taban tiptir.                                   |

    Açıklamalı halleri
    
    **  byte:
            - 8 Bit
            - Aralık: 0 ile 255
            - Örnek: byte b = 255;
            Açıklma: Pozitif tamsayı, genellikle byte dizilerinde (resim ve dosya verisi)
    
    **  sbyte:
                - 8 Bit
                - Aralık: -128 ile 127
                - Örnek: sbyte sb = -5;
                Açıklama: Negatif ve pozitif küçük tansayılar
    
    **  short:
                - 16 Bit
                - Aralık: -32,768 ile 32,767
                - Örnek: short s = 1000;
                Açıklama: Küçük tamsayılar için

    **  ushort:
                - 16 Bit
                - Aralık: 0 ile 65,535
                - Örnek ushort us = 40000;
                Açıklama: Pozitif kısa tamsayı

    **  int:
            - 32 Bit
            - Aralık: +- 2.1 milyar
            - Örnek: int score = 100;
            Açıklama: En çok kullanılan. Sayaç, skor, index, ID.

    **  uint:
                - 32 Bit
                - Aralık: 0 ile 4.2 milyar
                - Örnek: uint id = 123u;
                Açıklama: Negatif olmayan büyük sayılar

    **  long:
                - 64 Bit
                - Aralık: +- 9.2 katrilyon
                - Örnek: long xp = 9999999999L;
                Açıklama: Büyük sayılar için

    ** ulong:
                - 64 Bit
                - Araık: 0 ile 1.8×10¹⁹
                - Örnek: ulong bit = 5000UL;
                Açıklama: Pozitif büyük sayılar

    ** float:
                - 32 Bit
                - Aralık: ~7 basamak
                - Örnek: float speed = 3.14f;
                Açıklama: Unity'de en sık kullanılan ondalıklı tip (poziston, hız , zaman)

    ** double:
                - 64 Bit
                - Aralık: ~15 basamak
                - Örnek: double distance = 123.456;
                Açıklama: Daha hassas ana Unity'de az kullanılır
    
    ** decimal:
                - 128 Bit
                - Aralık: ~128 basamak
                - Örnek: decimak money = 10.5m;
                Açıklama: Finansal hesaplar (Oyun ekenomisi için)

    ** bool:
            - 1 Bit
            - Aralık: True || False
            - Örnek: bool isAlive = true;
            Açıklama: Mantıksal değer
    
    ** char:
            - 16 Bit
            - Aralık: Unicode karakter || ASCI code
            - Örnek: char letter = 'A';
            Açıklama: Tek karakter
    
    ** string:
                - Değişken Bit
                - Aralık: metin
                - Örnek: string name = "Player";
                Açıklama: Karakter dizisi
    
    ** object:
                - referans bit
                - Aralık: her tip
                - Örnek: object data = 5; , object data2 = "metin"; , object data3 = true;
                Açıklama: Her şeyi tutabilir. Taban tiptir



    Referance Type
             ** object       -> Tüm tiplerin atası. Her şey "object'ten" türetilir
             ** string       -> char dizisidir. Immutable'dir.(değiştirilemez)
             ** array(T[])   -> Sabit uzunlukta dizi
             ** class        -> Özellik + metod içeren özel tip.
             ** interface    -> Sözleşme. Hangi metodların olması gerektiğini belirtir
             ** delegate     -> Metod referansı taşır. Event sistemlerinde önemli
             ** dynamic      -> Türü çalışma zamanında belirlenir. Genelde önerilmez


    Value Type
        TAM SAYILAR                 ONDALIKLI SAYILAR                   DİĞERLERİ
          ** byte                       ** float                        ** char
          ** sbyte                      ** double                       ** bool
          ** short                      ** decimal                      ** enum
          ** ushort                                                     ** struct
          ** int                                                        record struct(C# 10+)
          ** uint
          ** long
          ** ulong


    Referance VS Value Types

        Properties                  Value Type                           Referance Type
    -- Bellek konumu                * Stack                              * Heap
    -- Kopyalama                    * Değer kopyalanır                   * Referans (adres) kopyalanır
    -- Örnek                        * int, float, struct                 * class, string, array
    -- Unity Örneği                 * Vector3, Color                     * GameObject, Transform
                                        (struct oldukları                   (class oldukları için referance type'tır)
                                          için value type'tır)

    ** Kritik fark
    
        Vector3 a = new Vector3(1,1,1);
        Vector3 b = a;  //değer kopyası
        b.x = 5; // a etkilenmez

        ------------------------------------

        Transform t1 = transform;
        Transform t2 = t1; // referans kopyası
        t.position.x = 5; // t1 de etkilenir

    
    UNITY ÖZEL VERİ TİPLERİ

        ** Vector2 / Vector3 / Vector4:
                                        - Tür: struct(value)
                                        - Kullanım: Pozisyon, yön, hız, fizik
        
        ** Quaternion:
                        - Tür: struct(value)
                        - Kullanım: Rotasyon (Euler değil, quaternion)
    
        ** Color / Color32:
                            - Tür: struct(value)
                            - Kullanım: Renk

        ** Transform:
                    - Tür: class
                    - Kullanım: Nesne konumu / dönüş / ölçek
        
        ** GameObject:
                    - Tür: class
                    - Kullanım: Sahnedeki tüm nesnelerin temel tipi
        
        ** Rigidbody / Ridigbody2D:
                                    - Tür: class
                                    - Kullanım: Fizik hareketi
        
        ** Collider / Collider2D:
                                - Tür: class
                                - Kullanım: Çarpışma alanı

        ** Material / Shader / Texture:
                                        - Tür: class
                                        - Kullanım: Görsel öğeler

        ** Sprite / Mesh / AudioClip:
                                    - Tür: class
                                    - Kullanım: Assest tipleri
    
    Kolleksiyon Tipleri

        ** Array(T[]):
                - Sabit boyut
                - Hızlı erişim
        
        ** List<T>:
                - Dinamik boyut.
                - En yaygın
        
        ** Dictionary<TKey, TValue>:
                                - Anahtar-değer eşleşmesi
                                - Hızlı lookup
        
        ** HashSet<T>:
                    - Benzersiz değerler
                    - Tekrarsız liste
        
        ** Queue<T>:
                - FIFO (First In, First Out)
                - Kuyruk sistemi (Enqueue(), Peek(), Dequeue())
        
        ** Stack<T>:
                - LIFO (Last In, First Out)
                - Yığın (Push(), Peek(), Pop())
                - Geri alma (undo) sistemi

        ** LinkedList<T>:
                        - Dinamik bağlı yapı
                        - Düğümler arası bağlantı
                        - (AddFirs, AddLast, AddBefore, AddAfter, Firs.Value, Last.Value, Find)


    ** Boxing / Unboxing

        int x = 10;
        object a = x;       // boxing
        int y = (int) a;    // unboxing

        Açıklama:
            Boxing: değer tipi -> referans tipe
            Unboxing: referans tipi -> değer tipe
            Performans kaybı yarartır, sık yapılmamalıdır

    ** const ve readonly 

        const float PI = 3.14f;     // Derleme zamanı sabiti
        readonly int id;            // sadece constructor'da atanabilir

        Açıklama:
                - Unity'de "const" genellikle sabit değerler (ör: gravity, speedLimit) için.


    ** Enum, Struct, Var

        - Enum: Sabit deperler (durum yönetimi)
                enum State { Idle, Walking, Jumping }

        - Struct: Küçük ve sık kullanılan value tipleri

                sturct Damage
                {
                    public int amount;
                    public float knockback;
                } 
        
        - Var: türü derleyici çıkarır (ama tür değişmez)
                var score = 10; // derleyici int olduğunu otomatik anlar


    ** Nullable Types

        - Bir value type'ın null olmasına izin verir
        - Unity'de bazen float? veya int? kullanılır (ör: opsiyonel veri için)

                int? health = null;
                
                if (health.HasValue) Console.WeriteLine(health.Value);



    ** Unity'de Pratik Kullanım Örnekleri

        public class Player: MonoBehaviour
        {
            public string playerName;
            public int health = 100;
            public float speed = 5f;
            public bool isGrounded;

            private Vector3 startPosition;

            void Start()
            {
                startPosition = Transform.position;
            }

            void Update()
            {
                if(isGrounded)
                {
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                }
            }
        
        }

        Bu kodda:

            - string, int, float, bool -> temel veri tipleri
            - Vector3 , Transform -> Unity veri tipleri
            - Time.deltaTime -> frame hızına göre hareket


    ** Bellek ve Performans için Bilmem Gerekenler

        - struct tipler küçükse daha hızlı (ör. Vector3)
        - class tipler heap'te tutulur; Çok oluşturulursa GC (Garbage Collector) maliyeti olur
        - string imutable'dır. StringBuilder kullan performans için.
        - Koleksiyonlarda sık ekeleme/silme varsa List<T> yerine LinkedList<T> düşünebilirim.
        - Unity'de new ile çok nesne oluşturmak "GC spike" yaratır - mümkünse önceden cache et



    ** Unity'de GC Optimizasyon Stratejileri
                | Problem                            | Çözüm                                                      |
            | ---------------------------------- | ---------------------------------------------------------- |
            | Sık `new` oluşturmak               | Nesneleri önceden oluştur, cache et, `Object Pool` kullan. |
            | String birleştirmeleri             | `StringBuilder` kullan.                                    |
            | Gereksiz `Instantiate`/`Destroy`   | Pool sistemi kur.                                          |
            | `foreach` yerine                   | `for` döngüsü kullan (daha az GC yükü).                    |
            | Büyük array kopyaları              | `Array.Clear()` veya `Array.Fill()` tercih et.             |
            | Sürekli oluşturulan geçici objeler | Struct veya static cache kullan.                           |


    **** Object Pooling (Kritik Unity Tekniği)
            - Amaç: sürekli "new / Destroy" yapmak yerine objeyi yeniden kullanmak
            - Örnek:

                    public class BulletPool : MonoBehavior
                    {
                        public GameObject bulletPrefab;
                        public List<GameObject> pool = new List<GameObject>();

                        public GameObject GetBullet()
                        {
                             foreach(var bullet in pool)
                             {
                                if(!bullet.activeInHierarchy) 
                                {
                                    return bullet;
                                }
                             }

                             GameObject newBullet = Instantiate(bulletPrefab);
                             pool.Add(newBullet);
                             return newBullet;

                        }
                    
                    }
            
            - Bu sayede:
                        - GC yükü azalır
                        - FPS düşüşü engellenir
                        - Mobile performans artar


    ** İleri sevyie Bilmem Gerekenşer (Özetle)
    | Konu                 | Açıklama                                                                                                      |
| -------------------- | ------------------------------------------------------------------------------------------------------------- |
| ** GC generations **   | .NET belleği nesne yaşına göre 3 seviyede yönetir (Gen0, Gen1, Gen2). Unity genellikle Gen0 ve Gen1 kullanır. |
| ** Pinned memory **    | GC’nin taşıyamadığı (sabitlenmiş) alanlardır, unmanaged kodla çalışırken oluşur.                              |
| ** Unmanaged memory ** | Unity C++ tarafında kullanılır (ör. Texture, Mesh verisi). GC burayı yönetmez.                                |
| ** Dispose pattern **  | `IDisposable` ile unmanaged kaynağı manuel temizlersin. (`using` bloğu ile)                                   |


    */
    #endregion
}