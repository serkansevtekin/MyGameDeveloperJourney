using System;
using System.Runtime.CompilerServices;

namespace DelegateOrnek2
{
    class DelegateOrnek2Class
    {
        public static void DelegateOrnek2RunMethod()
        {
            // --- Delegates ---
            MathDelegate mathDelegate = Toplam;
            System.Console.WriteLine(mathDelegate(6, 3));

            mathDelegate += Cikarma;
            System.Console.WriteLine(mathDelegate(6, 3));

            mathDelegate += Carpma;
            System.Console.WriteLine(mathDelegate(6, 3));



            // --- Action ---
            // ActionKullanim();


            // --- Func ---
            // FuncKullanim();

            // --- Predicate ---
            //PredicateKullanimi();

        }

        private static void PredicateKullanimi()
        {
            // Genelde kolleksion filitreleme, arama  ve koşul kontrolünde kullanılır

            // Basit kullanım
            Predicate<int> ciftMi = x => x % 2 == 0;
            System.Console.WriteLine(ciftMi(10));

            // Listeyle Kullanım (List<T>.Find)
            List<int> sayilar = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Predicate<int> buyukmu = x => x > 3;

            int sonuc = sayilar.Find(buyukmu);
            System.Console.WriteLine(sonuc); // 4 (ilk eşleşen)


            //Liste ile ikinci kullanım
            List<int> sayilar2 = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int Bul(List<int> liste, int hedef)
            {
                return liste.Find(x => x == hedef);
            }
            int sonuc2 = Bul(sayilar, 6);
            System.Console.WriteLine(sonuc2);//6




            //FindAll ile çoklu sonuç
            List<int> sayilar3 = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> sonucListesi = sayilar3.FindAll(x => x % 2 == 0);
            System.Console.WriteLine(string.Join(", ", sonucListesi));



            //RemoveAll ile koşula göre silme
            List<int> sayilar4 = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            sayilar4.RemoveAll(x => x < 3);
            System.Console.WriteLine(string.Join(", ", sayilar4));


            //Karmaşık nesneler kullanım
            List<Oyuncu> oyuncular = new()
            {
                new(){Ad="Ali",Skor=50},
                new(){Ad="Ayşe",Skor=80},
                new(){Ad="Can",Skor=30}

            };

            Predicate<Oyuncu> kazanan = o => o.Skor >= 60;
            Oyuncu bulunan = oyuncular.Find(kazanan) ?? new();
            System.Console.WriteLine(bulunan.Ad); // Ayşe

            System.Console.WriteLine("-------------------");

            Predicate<Oyuncu> kazananlar = o => o.Skor >= 40;
            var bulunanlar = oyuncular.FindAll(kazananlar) ?? new();
            foreach (var item in bulunanlar)
            {
                System.Console.WriteLine(item.Ad); // Ali , Ayşe
            }

            System.Console.WriteLine("------------------");

            // Metot referansı olark
            bool BuyukMuu(int x) => x > 100;
            Predicate<int> kontrol = BuyukMuu;
            System.Console.WriteLine(kontrol(150));

        }

        private static void FuncKullanim()
        {
            // Tek parametreli
            Func<int, int> kareAl = x => x * x;
            System.Console.WriteLine(kareAl(5));

            // iki parametreli
            Func<int, int, int> topla = (a, b) => a + b;
            System.Console.WriteLine(topla(3, 4));

            //Üç parametreli (string dönen)
            Func<string, int, int, string> formatla = (isim, yas, id) => $"{isim} - {yas} - {id}";
            System.Console.WriteLine(formatla("serkan", 31, 1001));

            // Karma tipler
            Func<float, int, string> bilgi = (oran, sayi) => $"Oran: {oran}, Sayı: {sayi}";
            System.Console.WriteLine(bilgi(0.75f, 42));

            //Func başka bir func döndüre bilir
            Func<int, Func<int, int>> carpici = x => (y => x * y);
            var carp = carpici(2);
            System.Console.WriteLine(carp(5));

            //LINQ ile kullanım
            List<int> sayilar = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Func<int, bool> ciftMi = s => s % 2 == 0;
            var ciftler = sayilar.Where(ciftMi);
            System.Console.WriteLine(string.Join(", ", ciftler));
        }

        private static void ActionKullanim()
        {
            Action<string> yazi = isim =>
            {
                System.Console.WriteLine($"Selam {isim}");
            };
            yazi("Serkan");

            Action<int, int> log = (a, b) => VoideMethod(a, b);
            log(6, 3);

            Action<int> log2 = s => System.Console.WriteLine(s);
            log2(6 + 3);

            Action<string, int, bool> bilgiYaz = (isim, yas, aktif) =>
            {
                System.Console.WriteLine($"İsim: {isim}, Yaş: {yas}, Aktif: {aktif}");
            };
            bilgiYaz("Ali", 25, true);



            // Action dizisi (birden fazla işlem zinciri)
            Action<int> islemler = x => System.Console.WriteLine($"Gelen: {x}");
            islemler += x => System.Console.WriteLine($"Küresi: {x * x}");
            islemler += x => System.Console.WriteLine($"Küpü: {x * x * x}");
            islemler(3);


            //Action event gibi kullanılabilir
            Action onGameStart = delegate { }; // boş delegate -> null kontrolü gerekmez
            // Olay gerçekleştiğinde çalışacak metotlar ekleniyor
            onGameStart += () => System.Console.WriteLine("Oyun Başlıyor...");
            onGameStart += () => System.Console.WriteLine("Müzik Çalıyor");
            // delegate tetikleniyor (Invoke)
            onGameStart();
        }

        //Delegate
        delegate int MathDelegate(int a, int b);


        //Methods
        static int Toplam(int s1, int s2)
        {
            return s1 + s2;
        }
        static int Cikarma(int s1, int s2)
        {
            return s1 - s2;
        }
        static int Carpma(int s1, int s2)
        {
            return s1 * s2;
        }

        static void VoideMethod(int a, int b)
        {
            System.Console.WriteLine(a + b);
        }
    }


    class Oyuncu { public string? Ad; public int Skor; }
}