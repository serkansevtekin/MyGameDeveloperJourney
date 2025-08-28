using System;
using System.Collections;
namespace Programlama.ArrayListNameSpace
{
    public static class ArrayListClass
    {
        public static void ArrayListMainMethod()
        {
            /*
            - ArrayList, SystemCollections namespace'i içinde bulunan, dinamik boyutlu dizilerdir.
            -ArrayList, standart diziler (int[] , string[] vb.) gibi sabit boyutlu değildir; eleman ekledikçe veya çıkardıkça boyutları otomatik olarak değişir.
            -ArrayList, object tipide elemanlar tutar, yani herhangi bir tipte nesne ekleyebilirsin (int, string, custom object vb.)

            -- ICollection ve IEnumerable implementasyonu ile döngü ile dolaşmak ve kopyalamak çok kolaydır


            ***** 
            Not: C# 2.0 ve sonrası için List<T> kullanımı tavsiye edilir. ArrayList daha çok eski projelerde veya legacy kodlarda karşımıza çıkar.
            *****
            */

            //ArrayList Tanımlama ve veri atama
            ArrayList arrayList = new ArrayList()
            {
                10, "BTK Akademi", true, 'e'
            };

            //ArrayList Tanımlama 2
            // ArrayList arrayList = new ArrayList();



            /*  arrayList.Add(10);//boxing -> kutulama işlemi ---- Tekrar kullanmak için kutudan çıkarmak gerekir
                     arrayList.Add("BTK Akademi");
                    arrayList.Add(true);
                    arrayList.Add('e'); */

            //Dolaşma
            foreach (var item in arrayList)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();

            /*
            AddRange() metodu, bir koleksiyondaki tüm elemanları mevcut listeye eklemeye yarar. Add() gibi tek tek eklemek yerine birden fazla elemanı tek seferde ekleyebilirsin.
            
            AddRange() ile eklenen elemanlar liste sonuna eklenir, indeksleri sıralıdır.
            */
            int[] sayilar = new int[] { 23, 44, 55 };
            arrayList.AddRange(sayilar);

            //Döngü
            foreach (var item in arrayList)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();

            //Belirtilen indexteki elemanı ekrana yazdırma
            System.Console.WriteLine(arrayList[4]);

            //Bir Elemana erişme - atama
            int x = Convert.ToInt32(arrayList[0]);//unboxing -> kutudan çıkarma -performans açısından kötü
            System.Console.WriteLine(x + 10);

            //ArrayList eleman çıkarma silme

            // arrayList.Remove(10);//ArrayList içindeki 10 değerini siler

            // arrayList.RemoveAt(1);//Verilen index değerine göre eleman siler

            arrayList.RemoveRange(2, 4);// Verilen index değerlerinden(1) başlayarak, verilen değer(4) kadar eleman sil

            foreach (var item in arrayList)
            {
                System.Console.Write($"{item} ");
            }


        }
    }
    
}