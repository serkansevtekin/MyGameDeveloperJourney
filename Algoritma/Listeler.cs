using System;
using System.Collections.Generic;
namespace Programlama.ListelerNameSpace
{
    /*
    List<T> Nedir?

        List<T>, System.Collections.Generic namespace’i içinde bulunan generic (tip güvenli) dinamik dizidir.

        Eleman ekledikçe veya çıkardıkça boyutu otomatik olarak değişir.

        Generic olduğu için sadece tek tip veri saklar, bu sayede hem tip güvenliği sağlar hem de boxing/unboxing hataları olmaz.
    */

    public static class ListelerClass
    {
        public static void ListelerMainMethod()
        {
            /*

               List<T> -> Liste<Type> -> Yer tutucu


               T → Type Parameter

               List’in içine eklenecek elemanların tipini temsil eder.

               List’i oluştururken T yerine gerçek bir tip yazarsın (int, string, custom class, vb.).

               //Tip Güvenliği
               Örnek: List<int> -> Integer değerlerden oluşan bir liste
            */


            //Tanımlama 
            // referans tipli veri new anahtar sözcüğü ile başlatırız
            //  var sayilarListesi = new List<int>();
            List<int> sayilarListesi = new List<int>(){10,15,20};

    
             //Ekleme
            int x = 55;

            sayilarListesi.Add(x);

            int[] Seri = new int[] { 70, 80, 90 };
            List<int> ellenecekListe = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

          
            //   sayilarListesi.Add("Ahmet"); Type farklılığından dolayı mümkün değil



            //Döngü ile Dolaşma

            foreach (int item in Seri)
            {
                sayilarListesi.Add(item);//sayilarListesine , Seri  dizisinin elemanlarını ekledi. Yada AddRange() kullanılmalı
            }

            //AddRange() -> Toplu liste ve dizi ekleme kodu
            sayilarListesi.AddRange(ellenecekListe);

            sayilarListesi.AddRange(new int[] { 40, 50, 60 });

            //Araya Ekleme
            sayilarListesi.Insert(3, 0);//araya ekleme -> 3. index'e 0 değerini elkler
            sayilarListesi.InsertRange(4, new int[] { 80, 90 });

            //Eleman atma, çıkarma
            sayilarListesi.RemoveAt(3);//3. index teki değeri listeden atar

            // IndexOf verilem dizi içindeki verinin index değerini bulur
            // bulunan bu index değeri RemoveAt içine eklenir ve o indexteki veri silinir yada çıkartılır
            sayilarListesi.RemoveAt(sayilarListesi.IndexOf(55));
    


            foreach (int item in sayilarListesi)
            {
                System.Console.Write($"{item,-5}");
            }

            
            
            

        }
    }

    
}