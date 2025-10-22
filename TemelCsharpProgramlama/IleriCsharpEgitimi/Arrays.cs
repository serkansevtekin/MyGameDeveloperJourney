using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class Arrays
    {
        public static void ArraysRun()
        {
            //TekBoyutluAraays();
            CokBoyutluArrays();
        }

        public static void TekBoyutluAraays()
        {
            string[] students = new string[3];
            students[0] = "Serkan";
            students[1] = "Ali";
            students[2] = "Salih";

            //                       0         1        2
            string[] students2 = { "Kazım", "Derin", "Leman" };
            students2[1] = "Serkan";

            foreach (var item in students2)
            {
                System.Console.WriteLine(item);
            }






        }

        public static void CokBoyutluArrays()
        {
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmir","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };

           for (int i = 0; i < regions.GetLength(0); i++)// satır
           {
                for (int j = 0; j < regions.GetLength(1); j++)//sütun
                {
                    System.Console.WriteLine(regions[i, j]);
                }
             System.Console.WriteLine();
           }

        }
    }
}