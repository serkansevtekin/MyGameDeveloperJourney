using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class Degiskenler
    {
        public static void DegiskenlerRun()
        {
            //  Degiskenlers();
            //  VeriTipleri();
            //  NullableType();

            //StringAndDate();
            //StringOrnekler();

            DateTimeDers();
        }



        private static void Degiskenlers()
        {
            var kdvOrani = 1.18;
            var urunA = 5000;
            var urunB = 6000;
            var urunC = 7000;
            var urunD = 5000;


            System.Console.WriteLine(urunA * kdvOrani);
            System.Console.WriteLine(urunB * kdvOrani);
            System.Console.WriteLine(urunC * kdvOrani);
            System.Console.WriteLine(urunD * kdvOrani);

            var sayi = 20;
            var urunAdi = "Samsun S23";
            var sayi2 = 30;
            var fiyat = 1000.25;
            var Fiyat = 1000.25;
            sayi2 = 50;
            var satistaMi = true;
            var ogrenci_No = "1025";

            System.Console.WriteLine(sayi);
            System.Console.WriteLine(urunAdi);
            System.Console.WriteLine(sayi2);
            System.Console.WriteLine(fiyat);
            System.Console.WriteLine(Fiyat);
            System.Console.WriteLine(satistaMi);
            System.Console.WriteLine(ogrenci_No);


            var ogAdi = "serkan";
            var ogSoyAdi = "serkan";
            var ogadVeSoyad = ogAdi + ogSoyAdi;
            var ogNumarasi = "1025";
            var ogCinsiyet = "Erkek";
            var ogTcKimlik = "1346937822";
            var ogDogumYili = "24.09.1994";
            var ogAdresBilgisi = "Ariç sokak no 10 porsuk çayı kemenc";
            var ogYasi = 30;

            System.Console.WriteLine(ogAdi);
            System.Console.WriteLine(ogSoyAdi);
            System.Console.WriteLine(ogadVeSoyad);
            System.Console.WriteLine(ogNumarasi);
            System.Console.WriteLine(ogCinsiyet);
            System.Console.WriteLine(ogTcKimlik);
            System.Console.WriteLine(ogDogumYili);
            System.Console.WriteLine(ogAdresBilgisi);
            System.Console.WriteLine(ogYasi);


            //ornek 2
            var urun1_fiyat = 50;
            var urun2_fiyat = 60.5;
            var urun3_fiyat = 356.45;

            var toplam = urun1_fiyat + urun2_fiyat + urun3_fiyat;

            System.Console.WriteLine(toplam);
        }
        private static void VeriTipleri()
        {
            /*     int sayi = 200;
                float kdvOrani = 1.18f;
                char cinsiyet = 'K';
                string cinsiyet2 = "Kadın";
                string urunAdi = "Samsun S23";
                bool satisDurumu = true; */

            System.Console.Write("1. sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("2. sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            System.Console.WriteLine(toplam);

        }
        private static void NullableType()
        {
            //int mas = null; // Hata: int null olamaz
            int? maas = null; // geçerli

            System.Console.WriteLine(maas.HasValue);
            System.Console.WriteLine(maas.GetValueOrDefault());

            /*  if (maas.HasValue)
                   {
                       System.Console.WriteLine("Maaş var");
                   }
                   else
                   {
                       System.Console.WriteLine("Maaş yok");
                   }
        */

        }

        private static void StringAndDate()
        {

            /*
                Strings: Karakter dizileri - referance => null
      
            //  char cinsiyet = 'E';  string cinsiyet2 = "Erkek";


        System.Console.WriteLine("Adı:");
            string? ad = Console.ReadLine();

            System.Console.WriteLine("Soyadı:");
            var soyad = Console.ReadLine();

            System.Console.WriteLine("Yaş:");
            string? yas = Console.ReadLine();

            //string concat
            //string mesaj = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır.";


            //String interpolitan
     string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır";
            System.Console.WriteLine(mesaj); 

*/

            // String Methods

            string mesaj = "Serkan sevtekin isimli kişi 20 yaşındadır.";

            System.Console.WriteLine("Karakter uzunluğu: " + mesaj.Length);
            System.Console.WriteLine("Bütün karakterler küçük harf" + mesaj.ToLower());
            System.Console.WriteLine("Bütün karakterler küçük harf" + mesaj.ToUpper());

            string BasvesonBosluksuz = mesaj.Trim();
            System.Console.WriteLine("Baştaki ve sondaki boşlukları yeni eleman sayısı {0} ", BasvesonBosluksuz.Length);

            string[] stringDizisi = mesaj.Split(" ");// stringi boşluklara göre böler ve bir string[] dizi döner
            System.Console.WriteLine("Dönen sitring dizisinin 3. indexsindeki elemanı: {0}", stringDizisi[3]);

            System.Console.WriteLine(mesaj.StartsWith("Serkan")); // ilgili string Serkan ile mi başlıyor | True , fasle döner
            System.Console.WriteLine(mesaj.StartsWith("Serkan")); // ilgili string . ile mi bitiyor | True , fasle döner

            System.Console.WriteLine("'kişi' kelimesini string içeriyor mu? {0}", mesaj.Contains("kişi"));// içeriyor mu? | True, false

            System.Console.WriteLine("'kişi' kelimeseinin başlangıç indexi {0}", mesaj.IndexOf("kişi")); // varsa indexi verir, yoksa -1 döner ve boş ise 0 verir


            System.Console.WriteLine("23 indexten başla sonuna kadar al {0}", mesaj.Substring(23));

            var yeniMesaj = mesaj.Replace("20", "10000");
            System.Console.WriteLine(yeniMesaj);



            //string.Join() static metodu
            string[] kelimeler = mesaj.Split(" "); // mesaj değişkenini boşluklara göre böl ve string dizi döndür
            var birlesim = string.Join("-", kelimeler);//kelimeler dizisini her bir elemanının arasına "-" koy
            System.Console.WriteLine(birlesim);





        }
        private static void StringOrnekler()
        {
            string kursAdi = ".NET 7 ile C# Programlama Dili";

            System.Console.WriteLine("Karakter sayısı: {0}", kursAdi.Length);

            string hepsiKucuk = kursAdi.ToLower();
            System.Console.WriteLine(hepsiKucuk);

            System.Console.WriteLine("String '.' ile mi başlamaktadır? {0}", kursAdi.StartsWith('.'));

            System.Console.WriteLine("C# bilgisi hangi konumda bulunmaktadır? {0}", kursAdi.IndexOf("C#"));

            System.Console.WriteLine("Sting C# bilgisini içeriyor mu? {0}", kursAdi.Contains("C#"));

            System.Console.WriteLine(kursAdi.Replace("Dili", "Dersleri"));


        }

        private static void DateTimeDers()
        {
            DateTime simdi = DateTime.Now;
            System.Console.WriteLine(simdi);
            System.Console.WriteLine("Day: {0}", simdi.Day);
            System.Console.WriteLine("Monyh: {0}", simdi.Month);
            System.Console.WriteLine("Year: {0}", simdi.Year);
            System.Console.WriteLine("Second: {0}", simdi.Second);
            System.Console.WriteLine("Minute: {0}", simdi.Minute);
            System.Console.WriteLine("Hour: {0}", simdi.Hour);


            System.Console.WriteLine("");
            DateTime dt = new DateTime(2018, 6, 10, 14, 30, 45); // 06/10/2018. 14:30:45
            System.Console.WriteLine(dt);

            DateTime dt2 = dt.AddYears(2);
            System.Console.WriteLine(dt2);
 
            var fark = simdi - dt;//TimeSpan objesi geldi
            System.Console.WriteLine(fark.TotalDays); // toplam gün sayısı
            System.Console.WriteLine(fark.TotalHours); // toplam saat sayısı

            System.Console.WriteLine(fark.TotalDays / 365.6); // toplam yıl sayısı

            



        }

        #region Veri tipleri
        /* 
***s
        Value Types: stack'te saklanır
            Stack: RAM'deki küçük ama hızlı bir alandır

                       Tam Sayı:               Ondalıklı Sayı:                  
                        - byte                      - float                     - char
                        - short                     - double                    - bolean
                        - integer                   - decimal                   - struct
                        - long                                                  - enum

            ör:
                int x = 5;                  
                int y = x;
                y = 10

                Stack'te iki ayrı alan oluşur:
                    x = 5;
                    y = 10;
                Yani y değiştiğinde x etkilenmez çünkü her biri kendi değerini kopya olarak taşır
                Bu yüzden "value type stack'te saklanır" denir
                Değişkenin kendisi ve değeri stack üzerinde tutulur, paylaşılmaz

***
        Referance Type: Heap'te saklanır (referansı stack'te tutulur)
            Heap: RAM'in daha geniş ama yavaş kısmıdır
                        
                        - String
                        - Class
                        - Array
                        - Interface
                        - Delegate

            Referance type bir nesene oluşturulduğunda:
                1. Gerçek veri (nsene) heap'te saklanır
                2. Adres (referans) stack'te tutulur

            Örnek:

                class Person { public string Name; }

                public void Main()
                {
                    Person p1 = new Person();
                    p1.Name = "Serkan";

                    Person p2 = p1;
                    p2.Name = "Ali";
                }

                Bellek durumu:
                    - Heap'te tek bir Person nesenesi var (Name="Ali")
                    - Stack'te p1 ve p2 adlı iki referans var, ikisi de aynı heap adresini gösteriyor
                    

            ** Veri Tipi Dönüşümü
                - implicit casting => bilinçsiz tür dönüşüm
                - explicit casting => bilinçli tür dönüşümü
                    long d = 20;
                    int e = (int) d;

                        yada
                    //Daha performanslı

                    long d = 20;
                    int e = Convert.ToInt32(d);

                    //sting için
                    int x = 10;
                    string z = x.ToString();

            ** Nullable Types
                Değer tipinin (int, bool, double gibi) null alabilmesini sağlar
                Normalde value type'lar null olamaz çünkü stack'ter gerçek bir değer taşır

                ör:
                        //int x = null; // Hata: int null olamaz
                        int? x = null; // geçerli

                ör2:
                  
                    int? age = null;
                    
                    if(age.HasValue) 
                        Console.WriteLine(age.Value);
                    else{
                    Console.WriteLine("Değer yok");
                    }

                ör3:
                   
                     int? x = null;
                     Console.WriteLine(x.GetValueOrDefault());

                * HasValue() -> nullable type'in içinde gerçek bir değer olup olmadığını bool olarak döndürür

                 * GetValueOrDefault() -> içinde değer varsa getir, yok ise default değeri getir


*/
        #endregion

    }
}