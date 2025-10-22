using System;


namespace CSharpProgramlama.IleriCSharpEgitimi
{  
    //Form Uygulaması açamadığımdan bu şekil
    public class RecapDemo1
    {
        public static void RecapDemo1RunMethod()
        {
            int size = 8; // 8*8 dama tahtası
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //Satır + sütünunların toplamı çiftse beyaz kare , tekse siyah kare
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("■ "); // beyaz kare
                    }
                    else
                    {
                        System.Console.Write("□ "); // siyah kare
                    }

                }
                    System.Console.WriteLine();
            }
        }
    }
}