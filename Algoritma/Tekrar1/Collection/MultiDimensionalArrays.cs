using System;

namespace Programlama.Tekrars1
{
    //Çok boyutlu diziler
    public class MultiDimessionalArraysClass
    {
        public static void MultiDimessionalArraysRun()
        {
            //  RectangularArray();
            JaggedArray();
        }

        private static void RectangularArray()
        {
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            System.Console.WriteLine(matrix[0, 1]);

            System.Console.WriteLine();


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        private static void JaggedArray()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5, 6, 7, 8 };
            jagged[2] = new int[] { 9 };

            System.Console.WriteLine(jagged[0][1]);

            System.Console.WriteLine(jagged[1][4]);
            System.Console.WriteLine(jagged[2][0]);

            System.Console.WriteLine();

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    System.Console.Write(jagged[i][j] + " ");
                }

                System.Console.WriteLine();
            }


        }
    }

    #region Tanım
    /*
     Birden fazla satır ve sütun içeren dizilerdir
     C# ta iki türü vardır:
             Dikdörtgen(rectangular) -> [ , ]
             Jagged(köşeli) -> [][]

     *- Dikdörtgen Dizi (Rectangular)
             - Tüm satır ve sütun sayıları aynıdır

             Özellikleri:
                 - Tek bir bellek blogunda tutulur
                 - GetLength(0) -> satır sayısı
                 - GetLength(1) -> sütun sayısını

     *- Jagged Dizi (Array of Arrays)
         Satırların sütun sayısı farklı olabilir
         Özellik:
             - Her alt dizi bağımsızdır, farklı uzunlukta olabilir


    Kullanım alanları:
        - Oyun haritaları (grid)
        - Pixel tabanlı işlemler
        - Matematiksel matris işlemleri
        - Tile-based 2D unity sahneleri
    */
    #endregion
}