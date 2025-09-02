using System;
using System.Collections;

namespace Programlama.VeriYapilari
{

    class HastableClass
    {
        public static void HastableMainMethod()
        {
            //Hastable GenelBilgiler
            // GenelBilgiler();

            //Hastable Uygulamasi
            HashtableUyuglamasiMethod();
        }

        private static void GenelBilgiler()
        {


            //Tanımlama
            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");


            //Dolaşma | DictionaryEntry
            DolasmaMethod(sehirler);

            //Sadece Anahtarları alma | Keys
            SadeceAnahtarAlmaMethod(sehirler);


            //Sadece Değerleri alma | Values
            SadeceDegerAlmaMethod(sehirler);


            //Elemana Erişme | sehirler[55]

            ElemanaErismeMethod(sehirler);


            //Eleman Silme | Remove
            ElemanSilmeMethod(sehirler);
        }

        private static void SadeceAnahtarAlmaMethod(Hashtable sehirler)
        {
            System.Console.WriteLine("\nAnahtarlar (Keys)");
            ICollection anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void SadeceDegerAlmaMethod(Hashtable sehirler)
        {
            System.Console.WriteLine("\nDeğerler (Values)");
            //var degerler = sehirler.Values;
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void ElemanaErismeMethod(Hashtable sehirler)
        {
            System.Console.WriteLine("\nElemana Erişme");
            System.Console.WriteLine(sehirler[55]);
        }

        private static void ElemanSilmeMethod(Hashtable sehirler)
        {
            System.Console.WriteLine("\nEleman Silme");
            sehirler.Remove(23);
            DolasmaMethod(sehirler);
        }

        private static void DolasmaMethod(Hashtable sehirler)
        {
            foreach (DictionaryEntry item in sehirler)
            {
                System.Console.WriteLine($"{item.Key,-5} - {item.Value,-20} ");
            }
        }

        /*
               **HASTABLE**
           
           - Non-generic -> object -> boxing / unboxing
           - Key / Value pairs -> Anahtar / Değer çiftleri
           - Key / Value -> ICollection (Interface)

           - Key (Anahtar) -> Contain Key
           - Value (Değer) -> Contain Value

            Not : Anahtarlar tekil olmak zorunda
           */


        private static void HashtableUyuglamasiMethod()
        {
            //örnek uygulama -> yeni url oluşturma

            //başlığı okuma
            System.Console.WriteLine("Başlık Giriniz");
            string? baslik = Console.ReadLine();

            //küçültme
            baslik = baslik!.ToLower();

            //Hastable
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','g'},
                {'.','-'},
                {'?','-'}
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value!);
            }

            baslik = baslik.TrimEnd('-');// Eğer sondaki '-' varsa sil
            //ekranda yazdır
            System.Console.WriteLine(baslik);
            
        }
    }

}