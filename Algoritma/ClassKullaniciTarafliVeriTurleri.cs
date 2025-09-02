using System;
namespace Programlama.ClassNamespace
{
    public class ClassKullaniciTarafliVeriTurleriClass
    {
        public static void ClassMainMethod()
        {
            // 1. Tanımlama şekli
            //List<OgretimElemaniClass> -> uzun olduğu için "var" ile tanımlanabilir.
            var ogrGor = new List<OgretimElemaniClass>()
            {
                new OgretimElemaniClass(101, "Ahmet", "Yalçın", true),
                new OgretimElemaniClass(102, "Ayşe", "Demir", false),
                new OgretimElemaniClass(103, "Mehmet", "Kara", true),
                new OgretimElemaniClass(104, "Fatma", "Çelik", false),
                new OgretimElemaniClass(105, "Ali", "Şahin", true),
                new OgretimElemaniClass(106, "Zeynep", "Yılmaz", false),
                new OgretimElemaniClass(107, "Can", "Kaya", true),


            };
            System.Console.WriteLine("Liste 1. Yöntem ile Yazdırılıyor");
            ogrGor.ForEach(og => Console.WriteLine(og));
            System.Console.WriteLine();

            System.Console.WriteLine("Liste 2. Yöntem ile Yazdırılıyor");
            foreach (OgretimElemaniClass item in ogrGor)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            System.Console.WriteLine("2. Liste Tanımlaması ve Eleman Ekleme");
            //referans tite liste 2 ye eleman ekleyece o elemanın liste 1 de de görüneceğini unutma
            var liste2 = ogrGor;//ogrGor listesinin referansını liste2 ye atadık
            liste2.Add(new OgretimElemaniClass(108, "Elif", "Arslan", false));
            liste2.ForEach(l2 => System.Console.WriteLine(l2));


            System.Console.WriteLine();
            System.Console.WriteLine("Liste1 Eleman Siline");
            ogrGor.RemoveAt(0);
            
            System.Console.WriteLine("Liste1 Eleman Silindikten Sonra");
            ogrGor.ForEach(og => System.Console.WriteLine(og));

            System.Console.WriteLine();

            System.Console.WriteLine("Liste1 Eleman Silindikten Sonra Liste2");
            liste2.ForEach(l2 => System.Console.WriteLine(l2));

            System.Console.WriteLine();

            //2. Tanımlama şekli
            OgretimElemaniClass ogrGor3 = new OgretimElemaniClass(107, "Methmet", "Kara", false);

            System.Console.WriteLine(ogrGor3);

        }
    }
}