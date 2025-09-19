using System;
using System.Collections;

namespace Programlama.AlgoritmaTasarimi
{
    class TipBelirsizTurİleArrayFonksClass
    { 
        public static void TipBelirsizTurİleArrayFonksRunMethod()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            List<int> list = new List<int>();
            string[] names = { "Hakan", "Serkan", "Murat", "Ayşe" };
            for (int i = 5; i < 10; i++)
            {
                list.Add(i);
            }
            ProcessItem<int>(arr);
            ProcessItem<int>(list);
            ProcessItem<string>(names);
        }

        // Generic bir metod tanımlıyoruz
        // T = koleksiyondaki eleman tipi (int, string, obje vb.)
        public static void ProcessItem<T>(IList coll)
        {
            System.Console.WriteLine("Is readonly {0} for this collection", coll.IsReadOnly);
            foreach (T item in coll)
            {
                System.Console.WriteLine(item.ToString() + " ");
            }
            System.Console.WriteLine();
        }
    }
}