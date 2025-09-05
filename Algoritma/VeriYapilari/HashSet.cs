using System;
using Microsoft.VisualBasic;

namespace Programlama.VeriYapilari
{
    class HashSetClass
    {
        public static void HashSetMainMethod()
        {
            TemelBilgiler();
        }

        private static void TemelBilgiler()
        {
            //Tanımlama | Ekleme
            var sesliHarf = new HashSet<char>()
            {
                'e','ı','i','u','ü','o','ö','b'
            };
            sesliHarf.Add('a');

            //Dögü
            System.Console.WriteLine();
            koleksiyonuYazdir(sesliHarf);

            System.Console.WriteLine();
            //Listeden Çıkarma
            sesliHarf.Remove('b');
            koleksiyonuYazdir(sesliHarf);

            var alfabe = new List<char>();

            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }

            //  alfabe.ForEach(k => System.Console.WriteLine(k));
            koleksiyonuYazdir(alfabe);

            //Türkeçede kullanılan sesli harfler
            System.Console.WriteLine();

            //  sesliHarf.ExceptWith(alfabe);

            // sesliHarf.UnionWith(alfabe);

           // sesliHarf.IntersectWith(alfabe);

            sesliHarf.SymmetricExceptWith(alfabe);

            koleksiyonuYazdir(sesliHarf);
            
            

        }

        private static void koleksiyonuYazdir(IEnumerable<char> kolleksiyon)
        {
            int i = 0;
            foreach (char item in kolleksiyon)
            {
                System.Console.Write($"{item,-5}");
                i++;
            }

            System.Console.WriteLine();
            System.Console.WriteLine("\nEleman Sayısı: {0}", i);
            

              //Eleman Sayısı
            /*   System.Console.WriteLine("\nEleman Sayısı: {0}", kolleksiyon.Count);
              System.Console.WriteLine(); */




        }

        #region Tanımlama
        /*
        HashSet<T> -> Type -safe

        - Elemanlar benzersiz
        - Sırlama yok
        - SortedSet'den perofrmanslıdır.
        - SortedSet te kullanılan Method ve Properties hepsi kullanılır.
        - Küme işlemlerine izin verir.
        */

        #endregion
    }
}