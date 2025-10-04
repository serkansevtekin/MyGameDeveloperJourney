using System;
namespace Programlama.IleriAlgoritma.DisjoinSet
{
    public class DsUgulamaClass
    {
        public static void DsUgulamaRunMethod()
        {
            var ds = new DisjoinSet<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });

            ds.Union(5, 6);
            ds.Union(1, 2);
            ds.Union(0, 2);

            for (int i = 0; i < 7; i++)
            {
                System.Console.WriteLine($"Find({i}) = {ds.FindSet(i)}");
            }



        }
    }
}