using System;
using System.Collections;

namespace Programlama.IleriAlgoritma
{

    class DizilerClass
    {
        public static void DizilerRunMain()
        {
            // Array

            char[] arrChar = new char[] { 'b', 'a', 'k' }; // ekleme yapılamaz buradan sonra




            // ArrayList

            // object -> unboxing ->cast (T)
            var arrObj = new ArrayList();
            arrObj.Add(10);// int → object içine boxing yapılır
            arrObj.Add('b'); // char → object içine boxing yapılır
            var c = (int?)arrObj[0] + 20; // unboxing: object içindeki int tekrar int’e çevrilir

            // List<T>

            List<int> arrInt = new List<int>();
            arrInt.Add(20);
            arrInt.Add(11);
            arrInt.Add(12);
            arrInt.AddRange<int>(1, 2, 3, 4);

            foreach (int item in arrInt)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Eleman Sayısı: {0}", arrInt.Count);

            System.Console.WriteLine("Sırala:");

            arrInt.Sort();

            foreach (int item in arrInt)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Sıralanan Listeyi Ters Çevir:");

            arrInt.Reverse();

            foreach (int item in arrInt)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Listeni İlk Elemanı: " + arrInt.First());
            System.Console.WriteLine("Listeni Son Elemanı: " + arrInt.Last());

            System.Console.WriteLine("Listeni 2 Elemanı var mı: {0} ", arrInt.Contains(2) ? "var" : "yok");



            System.Console.WriteLine("2. indexteki elamnı sil");
            arrInt.RemoveAt(2);
            foreach (int item in arrInt)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Eleman Sayısı: {0}", arrInt.Count);




        }
    }
    #region Dizi Tanımı
    /*

    - En temel veri yapılarından biridir.

    - Dizi elemanlarına erişmek üzere genellikle sıfır-tabanlı indisleme (zeor-based indexing) kullanılır.

    - Tek boyutlu (single-dimesion) ya da çok boyutlu (multi-dimesion) olabilir.

    


    // T[]  -> sabit boyutlu (tercih az edilir), -> boxing/unboxing yoktur, -> HIZLI
    // 
    // 
    //  ArrayList  -> tip güvenliği yok (eski tercih hiiiiç edilmez) -> boxing | unboxing var yavaş
    // 
    //  List<T> -> herşey var , dinamik, tip güvenliği var (süper tercih) -> boxing/unboxing yoktur, HIIIZZZLI

    */
    #endregion
}