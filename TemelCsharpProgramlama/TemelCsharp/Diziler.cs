using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class Diziler
    {
        public static void DizilerRunMet()
        {
            //DiziTanimlama();
            // DiziMetodlari();
            //ArraySlicing();
            //TekBoyutluDiziUygulamalari();

            //TupleIleOrnek();
            CokBoyutluDizi();
        }

        private static void TupleIleOrnek()
        {
            //3 ogrencilik dizi
            (string Ad, int Not)[] ogrenciler = new (string, int)[2];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                System.Console.Write($"{i}. Öğrenci Adı: ");
                string ad = Console.ReadLine() ?? "";

                //int.TryParse ile | isteğe bağlı istersen Convert.ToInt32 ilede yapılır
                int not;
                while (true)
                {
                    System.Console.Write($"{i}. ÖğrenciNot: ");
                    if (int.TryParse(Console.ReadLine(), out not))
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Geçersiz not tekrar deneyin");
                    }
                }
                ogrenciler[i] = (ad, not);
            }

            foreach (var o in ogrenciler)
            {
                Console.WriteLine($"{o.Ad} adlı öğrencinin Notu: {o.Not}");
            }

        }

        private static void DiziTanimlama()
        {
            string[] kursAdi = ".net 7 ile C# programlama dersleri".Split(' ');
            System.Console.WriteLine(kursAdi[3]);

            string[] isimler = new string[5];
            isimler[0] = "serkan";
            isimler[1] = "ali";
            isimler[2] = "canan";
            isimler[3] = "ahmet";
            isimler[4] = "çınar";

            int[] numaralar = { 100, 200, 300, 400, 500 };


            System.Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");

            //Veya class ile

            Ogrenci[] ogrenciler = new Ogrenci[5];
            ogrenciler[0] = new Ogrenci("serkan", 100);
            ogrenciler[1] = new Ogrenci("ali", 200);
            ogrenciler[2] = new Ogrenci("canan", 300);
            ogrenciler[3] = new Ogrenci("ahmet", 400);
            ogrenciler[4] = new Ogrenci("çınar", 500);

            System.Console.WriteLine($"{ogrenciler[0].Numara} numaralı öğrencinin adı {ogrenciler[0].Isim}");



        }

        private static void DiziMetodlari()
        {
            string[] sehirler = { "istanbul", "izmir", "ankara", "rize", "kocaeli" };
            int[] plakar = { 67, 53, 41 };

            // elemanı güncelleme
            //  sehirler[0] = "sakarya"; // 0 nolu indexin değerini sakarya yap
            sehirler.SetValue("sakarya", 0);  // SetValue(değer,index); 0 nolu indexin değerini sakarya yap


            // Belirtilen index'teki elemanı alır
            System.Console.WriteLine(sehirler.GetValue(0));

            // eleman sayısı
            System.Console.WriteLine(sehirler.Length);

            //dizi üzerinde arama
            System.Console.WriteLine(Array.IndexOf(sehirler, "ankara")); // index no döner

            //Sıralama (alfabetik olarak)
            Array.Sort(sehirler);
            System.Console.WriteLine(sehirler.GetValue(0));

            //Eleman dizide varmı
            System.Console.WriteLine(sehirler.Contains("ankara")); // true, false

            //elemanları ters çevirme
            System.Console.WriteLine(plakar.GetValue(0));

            Array.Reverse(plakar);
            System.Console.WriteLine(plakar.GetValue(0));


            //eleman silme -> Clear() -> dizinin tüm elemanlarının değerlerini sıfırlar ama dizi boyutu değişmez
            Array.Clear(sehirler);
            System.Console.WriteLine("Cleardan sonra 0. indexteki eleman " + sehirler.GetValue(0));
            System.Console.WriteLine("Clear dan sonra eleman sayisi: {0}", sehirler.Length);

            // dizi eleman sayısını sıfırlama
            System.Console.WriteLine("Plakalar dizisi eleman sayısı " + plakar.Length);

            // yeni ve 0 elemanlı bir dizi oluşturuyouz. Eski dizi garbage collector (GC) tarafından otomatik olarak temizlenir, eğer artık ona referans yoksa
            plakar = new int[0];
            System.Console.WriteLine("Plakalar dizisi yeni eleman sayısı " + plakar.Length);
        }

        private static void ArraySlicing()
        {
            //  ArraySlicing (Dizi parçalama)

            string[] sehirler = { "istanbul", "izmir", "ankara", "rize", "kocaeli" };
            System.Console.WriteLine(sehirler.Length);

            var sonuc = sehirler[0..3];
            System.Console.WriteLine(sonuc[1]);
            System.Console.WriteLine(sonuc.Length);


            //Tekrarlı işlemlerde döngü kullanma

            foreach (var item in sonuc)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            foreach (var item in sehirler[2..5])
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            foreach (var item in sehirler[..])// hepsini seçmiş oluyoruz
            {
                System.Console.WriteLine(item);
            }
        }

        private static void TekBoyutluDiziUygulamalari()
        {

            //Dizi uygulamalari

            //1.
            string[] ogrenciler = new string[3];
            int[] notlar = new int[3];

            if (ogrenciler.Length == notlar.Length)
            {

                for (int i = 0; i < ogrenciler.Length; i++)
                {
                    System.Console.Write($"{i}. Oğrenci Adı: ");
                    ogrenciler[i] = Console.ReadLine() ?? "";

                    System.Console.Write($"{i}. Oğrenci Not: ");
                    notlar[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < ogrenciler.Length; i++)
                {
                    System.Console.WriteLine($"{ogrenciler[i]} adlı öğrencinin Notu: {notlar[i]}  ");
                }

                System.Console.WriteLine("Öğrenciler dizisi eleman sayısı: {0}", ogrenciler.Length);

                System.Console.WriteLine("ilk iki öğrenceinin:");
                for (int i = 0; i < 2; i++)
                {
                    System.Console.WriteLine($"{ogrenciler[i]} adlı öğrencinin Notu: {notlar[i]}  ");
                }

                int toplam = 0;

                for (int i = 0; i < notlar.Length; i++)
                {
                    toplam += notlar[i];
                }
                System.Console.WriteLine("Tüm Öğrencilerin not ortalaması: {0}", toplam / notlar.Length);

            }




        }

        private static void CokBoyutluDizi()
        {
            string[] ogrenciler = { "Ali", "Ahmet", "Canan" };

            //int[,] notlar = new int[3, 3];
            int[][] notlar = new int[3][]; // jingeed array

            notlar[0] = new int[3];
            notlar[1] = new int[3];
            notlar[2] = new int[3];


            //ali 
            notlar[0][0] = 50;
            notlar[0][1] = 60;
            notlar[0][2] = 70;
            
            //ahmet
            notlar[1][0] = 60;
            notlar[1][1] = 80;
            notlar[1][2] = 90;

            //canan
            notlar[2][0] = 50;
            notlar[2][1] = 70;
            notlar[2][2] = 30;

            var otalama_1 = (notlar[0][0] + notlar[0][1] + notlar[0][2]) / 3;
            var otalama_2 = (notlar[1][0] + notlar[1][1] + notlar[1][2]) / 3;
            var otalama_3 = (notlar[2][0] + notlar[2][1] + notlar[2][2])/3;


            Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {otalama_1}");
            Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {otalama_2}");
            Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {otalama_3}");
            

        }
    }

    partial class Ogrenci
    {
        public string? Isim { get; set; }
        public int Numara { get; set; }

        public Ogrenci(string isim, int numara)
        {
            this.Isim = isim;
            this.Numara = numara;
        }
    }




}