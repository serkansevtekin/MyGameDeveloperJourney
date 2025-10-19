using System;
using System.Collections;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class CollectionClass
    {
        public static void CollectionRunMet()
        {
            //   ArrayList();
            //   GenericList();
            Dictionary();
        }

        public static void ArrayList()
        {
            ArrayList liste = new ArrayList();
            liste.Add(10);
            liste.Add("10");
            liste.Add("ali");
            liste.Add(null);
            liste.Add(true);


            var liste2 = new ArrayList()
            {
                5,
                "Ahmet",
                false,
                4.5,
                null
            };
            int[] sayilar = { 1, 2, 4, 5, 2, 4 };
            liste.AddRange(sayilar);

            var eleman = Convert.ToInt32(liste[0]);
            var isim = liste[2]!.ToString();

            /*       System.Console.WriteLine(eleman);
                  System.Console.WriteLine(isim); */


            //insert
            liste.Insert(2, "sadik");
            liste.InsertRange(8, liste2);

            liste.Remove(null);
            liste.RemoveAt(2);
            liste.RemoveRange(4, 3);

            //contains , indexOf
            System.Console.WriteLine(liste.Contains(10));
            System.Console.WriteLine(liste.IndexOf(4.5));

            /*  foreach (var item in liste)
           {
               System.Console.WriteLine(item);
           }
*/

        }
        public static void GenericList()
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);

            List<string> isimler = new List<string>() { "ali", "ahmet", "ayşe" };

            List<Product> urunler = new List<Product>();
            urunler.Add(new Product() { Id = 1, Title = "Iphone 14", Price = 40000 });
            urunler.Add(new Product() { Id = 2, Title = "Iphone 15", Price = 50000 });
            urunler.Add(new Product() { Id = 3, Title = "Iphone 16", Price = 60000 });

            urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "Iphone 17", Price = 70000 });

            urunler.Remove(urunler[0]);
            urunler.RemoveAt(2);
            foreach (var urun in urunler)
            {
                System.Console.WriteLine($"{urun.Title} - {urun.Price}");
            }


        }
        public static void Dictionary()
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(41, "Kocaeli");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(53, "Rize");

            Dictionary<int, string> sayilar = new Dictionary<int, string>()
            {

                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"}
            };

            //update
            sayilar[1] = "One";


            System.Console.WriteLine(plakalar[41]);

            if (plakalar.ContainsKey(34))
            {
                System.Console.WriteLine(plakalar[34]);

            }

            foreach (KeyValuePair<int, string> plaka in plakalar)
            {
                System.Console.WriteLine(plaka.Key + " - " + plaka.Value);
            }



            /*    foreach (var (key,value) in plakalar)
               {
                   System.Console.WriteLine(key + " - "+ value);
               }


    */

            System.Console.WriteLine();
            ///Özel ve kullanışlı list -> buna özel bir koleksiyon tipi tanımlanmamış.
            List<KeyValuePair<int, string>> list3 = new List<KeyValuePair<int, string>>();
            list3.Add(new KeyValuePair<int, string>(1, "Bir"));
            list3.Add(new KeyValuePair<int, string>(2, "İki"));
            list3.Add(new KeyValuePair<int, string>(3, "Üç"));

            list3.Insert(1, new KeyValuePair<int, string>(100,"yüz"));
            foreach (var (key, value) in list3)
            {
                System.Console.WriteLine(key + " - " + value);
            }


        }
    }

    class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
    }
}