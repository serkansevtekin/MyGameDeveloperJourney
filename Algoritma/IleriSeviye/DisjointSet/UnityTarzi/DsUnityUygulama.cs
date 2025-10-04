using System;

namespace Programlama.IleriAlgoritma.DisjoinSet
{
    public class DsUnityUygulamaClass
    {
        public static void DsUnityUygulamaRunMethod()
        {
            var ds = new Ds<int>();

            /*  //Eleman ekleme
             ds.MakeSet("A");
             ds.MakeSet("B");
             ds.MakeSet("C");
             ds.MakeSet("D");

             //Kümeleri birleştirme
             ds.Union("A", "B");
             ds.Union("C", "D");
             ds.Union("B", "C");

             System.Console.WriteLine(ds.FindSet("A"));
             System.Console.WriteLine(ds.FindSet("D"));

             System.Console.WriteLine();
             foreach (var item in ds)
             {
                 System.Console.WriteLine(item);
             }

             System.Console.WriteLine(); */

            //eleman ekleme
            var group1 = new List<int> { 1, 2, 3, 4 };
            var group2 = new List<int> { 5, 6, 7, 8 };
            var group3 = new List<int> { 10, 11, 12, 13 };

            foreach (var item in group1) ds.MakeSet(item);
            foreach (var item in group2) ds.MakeSet(item);
            foreach (var item in group3) ds.MakeSet(item);

            System.Console.WriteLine($"Union öncesi 7 root {ds.FindSet(7)}");

            //kümeleri birleştirme
            ds.Union(3, 5);
            ds.Union(3, 6);
            ds.Union(3, 1);
            ds.Union(3, 7);

            System.Console.WriteLine($"Union sonrası 7 root {ds.FindSet(7)}");



            //kök ve kümeleri göster
            var sets = ds.GetSets();
            foreach (var item in sets)
            {
                System.Console.WriteLine($"Root: {item.Key} -> Elements: {string.Join(",", item.Value)}");
            }


        }
    }
}