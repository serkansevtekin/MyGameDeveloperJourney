using System;

namespace Programlama.VeriYapilari
{
    class StackKullanimiClass
    {
        public static void StackMainMethod()
        {

            

            BasicStack();

        }


        #region AI Ornek

        public static void BasicStack()
        {
            //Tanımlama | Stack<T>
            Stack<string> kelimeler = new Stack<string>();

            //Ekleme | Push()
            kelimeler.Push("elma");
            kelimeler.Push("armut");
            kelimeler.Push("muz");

            //Ekelene elemanları döngü ile görme
            foreach (var item in kelimeler)
            {
                System.Console.WriteLine(item);
            }

            //üsttekini gör ama çıkarma | Peek()
            System.Console.WriteLine(kelimeler.Peek());

            //Çıkarma | Pop()
            System.Console.WriteLine($"Pop: {kelimeler.Pop()}");

            //Eleman sayısı | Count (properties)
            System.Console.WriteLine($"Kalan eleman sayısı: {kelimeler.Count}");
        }
            
        #endregion




        public static void OrnekMetod2()
        {
            System.Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10; // Sayının son basamağını bul (mode 10)
                sayiYigini.Push(k); // Bulunan basamağı yığına ekle
                sayi = sayi / 10; // Sayıyı bir basamak küçült
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var item in sayiYigini)
            {
                System.Console.WriteLine($"{item} * {Math.Pow(10, n - i)} = {item * Math.Pow(10, n - i)}");
                i++;
            }

            /*  Math.Pow(x, y) nedir?

             C#’ta üs alma fonksiyonudur.

             - x taban
             - y üs

             👉 Yani Math.Pow(2, 3) → 2^3 = 8 
             */
        }


        private static void YiginOrnegi()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                System.Console.WriteLine($"{karakterYigini.Peek()} Yığına eklendi");
                System.Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
            //ek Bilgi
            var dizi = karakterYigini.ToArray();// stack i diziye aktardık
            System.Console.WriteLine("\nYığından Çıkarma İşlemi için bir tuşa basın");
            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                System.Console.WriteLine($"{karakterYigini.Pop()} Yığından çıkarıldı.");
                System.Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
        }



        #region Temel 

        // Static metod -> Non-static metod = Evet, nesne oluşturmak zorunlu
        //Stack ile alakasız static olamayan bir metot kullanımı
        // Non-static method → nesneye bağlı, sınıfın örneği (instance) üzerinden çağrılır.
        /* StackKullanimiClass stackClass = new StackKullanimiClass();
        stackClass.StackTemelleriMethod(); */
        public void StackTemelleriMethod()
        {


            //Stack<T> Tanımlama
            var karakterYigini = new Stack<char>();


            // Ekleme - Push() | En üsteki nesneyi göster - Peek()
            EklemeVeGostermeMethod(karakterYigini);

            //Çıkarma - Pop()
            CikarmaMethod(karakterYigini);
        }

        public void EklemeVeGostermeMethod(Stack<char> karakterYigini)
        {
            karakterYigini.Push('A');
            System.Console.WriteLine(karakterYigini.Peek());//En üsteki nesneyi göster | Peek()

            karakterYigini.Push('B');
            System.Console.WriteLine(karakterYigini.Peek());//En üsteki nesneyi göster | Peek()

            karakterYigini.Push('C');
            System.Console.WriteLine(karakterYigini.Peek());//En üsteki nesneyi göster | Peek()

        }
        public void CikarmaMethod(Stack<char> karakterYigini)
        {
            //Hem Yığından çıkar hemde çıkan elemanı göster
            System.Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
            System.Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
            System.Console.WriteLine(karakterYigini.Pop() + " Yığından çıkartıldı");
        }
        #endregion

    }

    #region Temel Bilgi
    /*
      **  Stack<T> Yapısı  **

    - System.Collection.Generic sınıfı altında yer alır.
    - Generic -> Boxing ve Unboxing yoktur. Bu nedenle daha hazlıdır.
    - T -> Type(tip) -> Stack<int> , Stack<string> -> tip güvenliği
    - LIFO -> Last-In First-out -> Son gelen, ilk çıkar.

    Properties
    -Count -> eleman sayısı döner

    Methods
    - push() -> yeni eleman ekler (üste koyar).
    - pop() -> en üstteki elemanı çıkarır ve döndürür
    - peek() -> en üsteki elemanı döndürür
    - Contains(T item) Stack içinde belirtilen eleman varmı kontol
    - Clear() -> tüm elemanları temizler
    - ToArray() -> Stack içeriğini diziye kopyalar
    - TrimExcess() -> Fazladan ayrılan belleği serbest bırakır
    - GetEnumerator() -> foreach ile gezmeye imkan verir.

    --**-- KULLANIM ALANLARI --**--
    * Ayrıştırma
    * Ters Çevirme
    * Hafıza Tönetimi
   ** Fonksiyon Çağrıları & Özyinileme (Recursion)

      Programlama dillerinin çağrı yığınları aslında Stack mantığıyla çalışır.

      Örn: Bir fonksiyon başka bir fonksiyonu çağırdığında dönüş sırası Stack yapısına göre tutulur.

   ** Oyunlarda Kullanım

    Envanter Sistemi: Bazı oyunlarda son aldığın item ilk çıkar (örn. blok dizme, kutu açma).

    Hamle Geri Alma: Satranç, kart oyunları, bulmaca.

    Stacking Mekaniği: Hyper-casual oyunlarda karakterin topladığı objelerin üst üste dizilmesi (mesela odun, kutu, taş).

    State Management: Oyun sahneleri veya UI ekranlarını Stack üzerinde yönetebilirsin.



    Özetle:
Stack<T> genelde geçici veri saklama, geri dönüşlü işlemler, özyinileme, gezinti (geri/ileri) ve algoritma (DFS, parantez dengeleme) için kullanılır.
Oyunlarda ise özellikle undo, inventory, stacking mekaniği için çok uygundur. 


*/



    #endregion
}