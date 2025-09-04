using System;

namespace Programlama.VeriYapilari
{
    class DictionaryClass
    {


        public static void DictionaryMainMethod()
        {   //Temel Bilgiler
            //TemelBilgilerMethod();

            Ornek();
        }

        public static void Ornek()
        {
            //Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {100,new Personel("Zeynep","Coşkun", 5000)},
                {120,new Personel("Ahmet","Can",9000)}
            };

            personelListesi.Add(110, new Personel("Mehmet", "Sonsoz", 7500));


            //1
            foreach (var item in personelListesi)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }

            System.Console.WriteLine("----------------------");
            //2
            foreach (var item in personelListesi)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value.Adi} , {item.Value.Soyadi} , {item.Value.Maas}");
            }
            
        }

     



        private static void TemelBilgilerMethod()
        {
            // Dictionary

            //Tanımlama | Dictionary<TKey,TValue>;
            var telefonKodlari = new Dictionary<int, string>()
            {//Ekleme 1.Yöntem
                {332,"Konya"},
                {424,"Elazığ"},
                {466,"Art"},
                {422,"Malatya"}
            };

            //Ekelme 2.Yöntem
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            //Erişme
            telefonKodlari[466] = "Artvin"; // 466 key değerini buluyoz ve onu artvin ile değiştiriyoruz

            //ContainKey -> Anahtar var mı? yok mu? | true , false
            if (!telefonKodlari.ContainsKey(312))
            {
                System.Console.WriteLine("Ankara'nın kod bilgisi tanımlı değil");
                telefonKodlari.Add(312, "Ankara");
                System.Console.WriteLine("Yeni kod eklendi");
            }

            //ContainsValue -> Değer(Value) var mı? yok mu? | true , false
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                System.Console.WriteLine("Malatya kod bilgisi tanımlı değil");
                telefonKodlari.Add(422, "Malatya");
                System.Console.WriteLine("Yeni kod eklendi");
            }

            //Çıkartma
            telefonKodlari.Remove(322);

            //Anahtar varsa değeri döner

            if (telefonKodlari.TryGetValue(422, out string? sehirAdi))
            {
                System.Console.WriteLine($"Bulundu: {sehirAdi!}");
            }
            else
            {
                System.Console.WriteLine("Böyle bir veri yok");
            }

            //Dönme
            foreach (var item in telefonKodlari)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }


            //Count -> Eleman sayısını verir
            System.Console.WriteLine($"Eleman Sayısı: {telefonKodlari.Count}");
            //Clear -> tüm elemanları siler
            telefonKodlari.Clear();
            System.Console.WriteLine("Tüm elemanlar silindi");


        }

        #region Temel Bilgiler

        /*
                **** Dictionarry (Sözlük) ***

        Kullanım Amacı:
            Hızlı  arama, ekleme , silme işlemlerini yapmak.
        
        Temel Yapısı:
        Dictionary<TKey,TValue> dict = new Dictionary<TKey,TValue>();
        
        - TKey -> Anahtarın türü
        - TValue -> Değerin türü
        
        - Anahtarlar benzersiz olamlıdır. Aynı anahtar tekrar eklenemez.
        - Value benzersiz değildir.
        
        *   Önemli Methodlar    *
        - Add(key,value) -> Yeni eleman ekler (aynı key varsa hata verir)
        - Remove(key) -> Anahtara göre siler
        - Clear() -> Tüm elemanları siler
        - ContainsKey(key) -> Anahtar varmı kontrol eder
        - ContainsValue(value) -> Value varmı kontrol eder
        - TryGetValue(key, out type value) -> Anahtar varsa değeri döner, yoksa hata vermez

        TryGetValue Kullanımı

            //Bu yöntem, KeyNotFoundException hatasını engeller
            if(ogrenciler.TryGetValue(2, out string isim))
            {
                Console.WriteLine($"Öğrenci bulunundu: {isim}");
            } 
            else
            {
                Console.WriteLine("Öğrenci bulunamadi);
            }

        
        * Properties *
        - Keys -> Tüm anahtarları döner
        - Values -> Tüm değerleri döner
        - Count -> Eleman sayısını verir.


        *Unity'de Kullanım Alanları*
        - GameObject veya Prefab Yönetimi
        - Item / Envanter Sistemi
        - Oyuncu Skor / Data Takibi
        - AI / Yol bulma (Pathfinding)
        .
        .
        .

             
        
        
        */


        #endregion
    }
}