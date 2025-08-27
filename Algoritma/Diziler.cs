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
    }
}