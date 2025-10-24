using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class CollectionsClass
    {
        public static void CollectionRun()
        {
            // ArrayListKul();

            //TipGunvenliKolleksiyonList();

            DictionaryKullanimi();

        }

        private static void DictionaryKullanimi()
        {
            Dictionary<string, string> dictionart = new Dictionary<string, string>();
            dictionart.Add("book", "Kitap");
            dictionart.Add("table", "Tablo");
            dictionart.Add("computer", "Bilgisayar");

            System.Console.WriteLine(dictionart["table"]);

            foreach (var item in dictionart)
            {
                System.Console.WriteLine(item.Value);
            }
            System.Console.WriteLine(dictionart.ContainsKey("glass"));
            System.Console.WriteLine(dictionart.ContainsValue("Tablo"));
        }

        private static void TipGunvenliKolleksiyonList()
        {
            //Tip güvenli Kolleksiyonlar
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            System.Console.WriteLine(cities.Contains("Anakara")); // Listede Ankara var mı
            foreach (var item in cities)
            {
                System.Console.WriteLine(item);
            }

            /*  List<Custom> customs = new List<Custom>();
             customs.Add(new Custom { Id = 1, FirsName = "serkan" });
             customs.Add(new Custom { Id = 2, FirsName = "Derin" });
              */

            List<Custom> customs = new List<Custom>()
            {
               new Custom { Id = 1, FirsName = "serkan" },
                new Custom { Id = 2, FirsName = "Derin" }

            };



            // Collections Properties and Methods



            /*  var cusm = new Custom
             {
                 Id = 3,
                 FirsName = "Salih"
             };
             customs.Add(new Custom()); */

            customs.AddRange(new List<Custom>
            {
                //cusm,
                new Custom { Id = 4, FirsName = "Hakan" },
                new Custom { Id = 5, FirsName = "Altun" }
            });

            // customs.Clear();//elemanları siler
            var count = customs.Count; // eleman sayısı
            System.Console.WriteLine("Count: {0}", count);

            //Contains kullanmak için classa Equals ve GetHashCode override etmek gerek
            bool ex = customs.Contains(new Custom { FirsName = "Altun" });
            System.Console.WriteLine(ex);

            //Büyük liste için Dictionary Lookup
            Dictionary<int, Custom> byId = new Dictionary<int, Custom>();
            Dictionary<string, Custom> byName = new Dictionary<string, Custom>();


            foreach (var item in customs)
            {
                byId[item.Id] = item;
                if (item.FirsName != null)
                {
                    byName[item.FirsName] = item;
                }
            }

            if (byId.TryGetValue(1, out Custom? idLookUp))
            {
                System.Console.WriteLine("Dictionary Id Lookup: " + idLookUp.FirsName);
            }

            if (byName.TryGetValue("serkan", out Custom? nameLookUp))
            {
                System.Console.WriteLine("Dictionary Name lookup: " + nameLookUp.FirsName);
            }


            // Küçük ve orta listelerde LINQ lookup
            // id ye göre isim bul
            var foundById = customs.FirstOrDefault(c => c.Id == 1);
            System.Console.WriteLine(foundById != null ? $"Found by Id: {foundById.FirsName}" : "Not Found");


            //İsime göre id bul

            var founByName = customs.FirstOrDefault(c => c.FirsName == "serkan");
            System.Console.WriteLine(founByName != null ? $"Found by Name: {founByName.Id}" : "Not Found");




            //Ama: LINQ ile Any kullanarak ta yapabilirz (Küçük listeler en mantıklı yol) 
            bool existsId = customs.Any(x => x.FirsName == "Altun");
            bool existsFirstName = customs.Any(x => x.Id == 1);
            System.Console.WriteLine(existsId);
            System.Console.WriteLine(existsFirstName);


            customs.Insert(0, new Custom { Id = 0, FirsName = "Salih" });

            System.Console.WriteLine("Count: {0}", customs.Count);


            //Tek nesene silmek için
            var toRemove = customs.FirstOrDefault(c => c.FirsName == "serkan");
            if (toRemove != null) { customs.Remove(toRemove); }

            //Profestonel çömzüm LINQ + RemoveAll -> değer kontrolü yapar (mobilde önerilen yöntem).
            customs.RemoveAll(c => c.FirsName == "Hakan");

            foreach (var item in customs)
            {
                System.Console.WriteLine($"{item.Id}. First Name: {item.FirsName}");

            }

        }

        private static void ArrayListKul()
        {
            //ArrayList -> tip güvenli değildir (Tercih edilmez)
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add(true);
            cities.Add('a');
            cities.Add(12.45m);
            foreach (var item in cities)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    class Custom
    {
        public int Id { get; set; }
        public string? FirsName { get; set; }


    }
}