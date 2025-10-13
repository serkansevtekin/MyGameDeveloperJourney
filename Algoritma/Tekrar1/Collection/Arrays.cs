using System;

namespace Programlama.Tekrars1
{
    public class ArraysClass
    {
        public static void ArraysRun()
        {
            string[] carArray = { "BMW", "Audi", "Tesla" };

            carArray.Append("sadad");

            foreach (var item in carArray)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine($"Eleman Sayısı: {carArray.Count()}");
        }
    }
}