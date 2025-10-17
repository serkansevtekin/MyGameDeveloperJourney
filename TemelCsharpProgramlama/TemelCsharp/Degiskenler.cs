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

            StringAndDate();
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
            */
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