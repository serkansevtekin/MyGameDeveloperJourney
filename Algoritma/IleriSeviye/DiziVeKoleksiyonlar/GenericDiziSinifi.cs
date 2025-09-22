using System;

namespace Programlama.IleriAlgoritma
{
    class GenericDiziSinifiClass
    {
        public static void GenericDiziSinifiRunMethod()
        {
            var arr = new Array<int>();

            arr.Add(23);
            arr.Add(55);
            arr.Add(44);
            arr.Add(12);
            arr.Add(34);


            
            System.Console.WriteLine($"{arr.Count} / {arr.Capacity}");
        }
    }
}