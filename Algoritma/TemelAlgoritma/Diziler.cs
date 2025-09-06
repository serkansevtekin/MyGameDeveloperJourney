using System;

namespace Programlama.DizilerNameSpace
{
    public class Diziler
    {

        public static void DizilerMainMethod()
        {
            CokBoyutluDiziler();
        }

        private static void CokBoyutluDiziler()
        {
            //Çok Boyutlu diziler
            //[,] 2 boyutlu dizi . [,,] 3 boyutlu dizi
            double[,] matris = new double[,] {
            { 1, 2, 3, 5 },
            { 2, 3, 4, 10 },
            { 3, 1, 2, 2 },
            { 5, 6, 7, 1 }
            };

            double toplam = 0;
            for (int i = 0; i < matris.GetLength(0); i++) // GetLength(0) birinci matrisi al
            {
                for (int j = 0; j < matris.GetLength(1); j++)// GetLength(1) ikinci matrisi al
                {
                    if (i == j)
                        matris[i, j] = -1;

                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0;

                    toplam += matris[i, j];
                    System.Console.Write($"{matris[i, j],5}");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine($"Toplam: {toplam}");
        }

        private static void DiziOrnegi1()
        {
            System.Console.WriteLine("Dizi boyutunu giriniz:");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[elemanSayisi];
            var r = new Random();

            for (int i = 0; i < sayilar.Length; i++)//tek satır for kullanma
                sayilar[i] = r.Next(1, 10);

            foreach (int s in sayilar)
            {
                Console.WriteLine($"{s,5} {s * s,5}"); // beş karakter ayırmak için
            }
        }

        private static void DiziGenelBilgileri()
        {
            // tanımlama & başlatma
            // int[] numaralar = new int[3]; // aynı satırdada yapıla bilir


            //tanımlama , başlatma & atama
            // int[] numaralar = new int[3]{3,5,7}; // herşey tek satırda
            // int[] numaralarDinamic = new int[]{3,5,7,8}; // dinamic dizi
            int[] numaralarDinamic = { 3, 5, 7, 8, 10 }; // dinamic dizi

            //tanımlama

            //int[] numaralar;

            //başlatma -> referans tip - new anahtar kelimesi ile kullanılır
            // numaralar = new int[3];

            /*  numaralar[0] = 3;
             numaralar[1] = 5;
             numaralar[2] = 7; */
            for (int i = 0; i < numaralarDinamic.Length; i++)
            {
                System.Console.WriteLine($"Numaralar[{i}] = {numaralarDinamic[i]}");

            }
        }


        #region  Dizilerde Kullanılan Property ve Methodların Açılamaları
        /* Dizi (Array) 
                - Temel veri yapısıdır.
                - Tek botutlu ve çok boyutlu olabilirler.
                - Sabit boyutludurlar. Bellekte uzunlukları kadar yer ayrılır.
                - [] "Köşeli parantez" ile gösterilirler. Ör: char[], int[] , string[] vb. gibi
                - Sıfır tabanlı indisleme yapılır.
                - Verilere yada hafızada ayırlan belleklere erişmek için indis yapısını kullanırız.
                - Diziler 0,1,2,3, ... , n-2, n-1 -> sıfırdan başlar
                - A dizisinin elemanlarına erişmek için -> A[0] , A[1] ...

             /* ********** Properties ********** */
        // Rank          -> Dizinin boyut (dimension) sayısını verir.
        // Length        -> Dizideki toplam eleman sayısını verir (tüm boyutlardaki eleman sayısı).

        /* ********** Methods ********** */
        // IndexOf(...) / LastIndexOf(...)  -> Elemanın dizideki konumunu bulur.
        // Copy                            -> Kaynak diziden hedef diziye elemanları kopyalar.
        // ConstrainedCopy                 -> "Copy" gibi ama hata olması durumunda hiçbir şeyin değişmemesini garanti eder.
        // Sort                            -> Diziyi küçükten büyüğe sıralar.
        // Reverse                         -> Diziyi tersine çevirir.
        // Clear                           -> Belirtilen aralıktaki elemanları default değerine çeker (int için 0, string için null).
        // Exists                          -> Dizi içinde verilen koşula uyan bir eleman var mı diye bakar.
        // Find(...) / FindAll(...) / FindIndex(...) / FindLast(...) / FindLastIndex(...)  -> Arama işlemleri.
        // Resize                          -> Dizinin boyutunu değiştirir. (Yeni dizi oluşturur, eskisini kopyalar.)
        // Clone                           -> Dizinin sığ kopyasını alır.
        // BinarySearch                    -> Sıralı dizilerde ikili arama yapar.
        // CreateInstance                   -> Dinamik olarak yeni bir dizi örneği oluşturur.
        // Empty<T>                        -> T yerine belirtilen tipte boş bir dizi döner.
        // ForEach                          -> Dizinin tüm elemanları üzerinde işlem yapar.
        // TrueForAll                       -> Tüm elemanların verilen koşula uyup uymadığını kontrol eder.


        #endregion Dizilerde Kullanılan Property ve Methodların Açılamaları

        #region  Dizi Properties Örnekleri
        public static void LengthDizi()
        {
            //Length Dizideki toplam eleman sayısını verir

            int[] numbers = { 1, 2, 3, 4 };
            System.Console.WriteLine(numbers.Length); // 4 -> Dizide 4 eleman va
        }
        public static void RankDizi()
        {
            //Rank Dizi Boyut Sayısını verir

            int[,] matrix = { { 1, 2 }, { 1, 2 } };
            System.Console.WriteLine(matrix.Rank); // 2 -> 2 boyutlu dizi
        }
        public static void IsFixedSizeDizi()
        {
            //IsFixedSize Dizi boyutunun sabit olup olmadığını döndürür (true / false)

            int[] numbers = { 1, 2, 3, 4, 5 };
            System.Console.WriteLine(numbers.IsFixedSize);// True -> Dizi boyutu değiştirilemez

        }
        public static void IsReadOnly()
        {
            //IsReadOnly Dizinin salt okunur olup olmadığını döndüdür

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            System.Console.WriteLine(numbers.IsReadOnly);// False -> Elemanlar değiştirile bilir
        }



        #endregion

        #region Dizi Method Örnekleri
        int[] mainNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 4 };
        public static void IndexOfDizi(int[] numbers)
        {
            //IndexOf Belirtilen elemanın ilk konumunu döndürür
            System.Console.WriteLine(Array.IndexOf(numbers, 3)); // 2 -> 3 elemanı 2. indexte

        }
        public static void LastIndexOfDizi(int[] numbers)
        {
            //LastIndexOf Belirtilen elemanın son konumunu döndürür
            System.Console.WriteLine(Array.LastIndexOf(numbers, 4));// 12 -> Son 4 elemanı 12. indexte
        }


        public static void SortDizi(int[] numbers)
        {
            //Sort Diziyi küçükten büyüğe sıralar
            Array.Sort(numbers);
            System.Console.WriteLine(string.Join(", ", numbers));//1,2,3,4
        }

        public static void ReverseDizi(int[] numbers)
        {
            //Reverse Diziyi tersine çevirir
            Array.Reverse(numbers);
            System.Console.WriteLine(string.Join(",", numbers));//4,2,1,9,8,7,6,5,4,3,2,1
        }

        public static void ClearDizi(int[] numbers)
        {
            //Clear Belirttiğiniz dizinin başlangıç indeksinden itibaren belirli sayıda elemanı varsayılan değerine (0) çevirir.
            Array.Clear(numbers, 1, 4);
            System.Console.WriteLine(string.Join(",", numbers));  // 1,0,0,0,0,6,7,8,9,1,2,4 ->   1. indeksten başla, 4 elemanı temizle
        }
        public static void CopyDizi(int[] numbers)
        {
            //Copy Diziyi başka bir diziye kopyalar
            int[] copyDizi = new int[numbers.Length];//Hedef diziyi aynı boyutta yaptın
            Array.Copy(numbers, copyDizi, 3);// numbers dizisindeki ilk 3 elemanı dizi2 içine kopyaladın

            Array.Copy(numbers, copyDizi, numbers.Length);//numbers dizisini kople, copyDizi dizisine kopyala 
          
           System.Console.WriteLine(string.Join(",", copyDizi)); // 1,2,3,0,0,0,0,0,0,0,0,0
        }

        public static void ResizeDizi(int[] numbers)
        {
            //Resize Dizinin eleman sayısını değiştirir
            //Array.Resize diziyi küçültürken fazla elemanları siler, büyütürken default değer(0) ekler.
            Array.Resize(ref numbers, 3);  // Diziyi 6 elemanlı hale getir
            System.Console.WriteLine(numbers.Length); // 3 
        }

        public static void ExistsDizi(int[] numbers)
        {
            //Exists Dizide belirli bir koşulu sağlayan eleman var mı kontrol eder.
            //Konrol sonucu -> True yada False döner.
            bool hasEven = Array.Exists(numbers, x => x % 2 == 0); // Çift sayı varmı
            System.Console.WriteLine(hasEven); // True

        }

        public static void FindDizi(int[] numbers)
        {
            //Find methodu dizide belirttiğiniz koşulu sağlayan ilk elemanı döndürür.
            // Koşul: 8'den büyük olan ilk sayı
            System.Console.WriteLine(Array.Find(numbers, x => x > 8));// 9
            /*
            Bulamazsa default değeri döndürür.

                int için → 0

                bool için → false

                string veya sınıf tipleri için → null
            */
        }


        public static void FindAllDizi(int[] numbers)
        {
            //FindAll Dizide belirli bir koşulu sağlayan tüm elemanları yeni bir dizi olarak döndürür
            int[] result = Array.FindAll(numbers, x => x > 4); // Lambda ifadesi ile “4’ten büyük olanları” seçtik

            System.Console.WriteLine(string.Join(",", result)); // 5,6,7,8,9
        }


        public static void TrueForAllDizi(int[] numbers)
        {
            //TreuForAll Tüm elemanların koşulları sağlayıp sağlamadığını konrol eder
            bool allPositive = Array.TrueForAll(numbers, x => x > 0);
            System.Console.WriteLine(allPositive); // True

            bool allLessThan5 = Array.TrueForAll(numbers, x => x < 5);
            System.Console.WriteLine(allLessThan5); // False

            /*
            TrueForAll → Tüm elemanlar koşulu sağlıyorsa true, en az biri sağlamazsa false

            Hiç eleman yoksa → True döner (boş dizi için varsayılan davranış)
            */
        }

        public static void BinarySearchDizi(int[] numbers)
        {
            //BinarySearch sıralı dizide elemanın konumun döndürür
            Array.Sort(numbers);//Sort Diziyi küçükten büyüğe sırala
            int elemanIndexi = Array.BinarySearch(numbers, 1); // 1. elemanın indexini al
            System.Console.WriteLine(elemanIndexi);//2
        }

       


        #endregion
    }
}