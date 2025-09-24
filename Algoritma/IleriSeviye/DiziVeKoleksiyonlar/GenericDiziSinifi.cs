using System;
using System.Collections;
using Programlama.AlgoritmaTasarimi;

namespace Programlama.IleriAlgoritma
{
    class GenericDiziSinifiClass
    {
        public static void GenericDiziSinifiRunMethod()
        {
            /* var arr = new Array<int>();

            arr.Add(23);
            arr.Add(55);
            arr.Add(44);
            arr.Add(12);
            arr.Add(34);

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine($"{arr.Count} / {arr.Capacity}");

            //dizinin son elemanını siler
            arr.Remove();
            System.Console.WriteLine("Son eleman silindi");
            System.Console.WriteLine($"{arr.Count} / {arr.Capacity}");

            System.Console.WriteLine("-----");
            arr.Where(x => x % 2 == 0).ToList().ForEach(x => System.Console.WriteLine(x));
 */

            //Constructor ile


            /*  var arr = new Array<int>(55, 56, 58, 59, 22);
             foreach (var item in arr)
             {
                 System.Console.WriteLine(item);
             } */
            /* 
                        System.Console.WriteLine("\n------------------");
                        var p1 = new Array<int>(1, 2, 3, 4, 5, 6, 7);
                        var p2 = new int[] { 8, 9, 10, 11, 12, 13 };
                        var p3 = new List<int>() { 14, 15, 16, 17, 18, 19 };
                        //var p4 = new ArrayList() { 21, 22, 23, 24, 25 }; Hata verir -> tip günenliğini garanti etmiyor

                        var arr2 = new Array<int>(p3);
                        foreach (var item in arr2)
                        {
                            System.Console.WriteLine(item);
                        } */

            var arr = new Array<int>();
            for (int i = 0; i < 8; i++)
            {
                arr.Add(i + 1);
                System.Console.WriteLine($"{i + 1} has been added to array");
                System.Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            }
            System.Console.WriteLine();

            for (int i = arr.Count; i >= 1; i--)
            {
                System.Console.WriteLine($"{arr.Remove()} has been removed from the array");
                System.Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            }

            System.Console.WriteLine();
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }

            var arrr = new Array<int>(1, 2, 3, 4, 5, 6, 7);
            
            var crr = (Array<int>)arrr.Clone();
            arrr.Add(55555);
            crr.Add(11111);
            foreach (var item in arrr)
            {
                System.Console.Write(item);
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"{arrr.Count} / {arrr.Capacity}");
            System.Console.WriteLine();
            foreach (var item in crr)
            {
                System.Console.Write(item);
            }
            System.Console.WriteLine();
             System.Console.WriteLine($"{crr.Count} / {crr.Capacity}");
        }
    }
}