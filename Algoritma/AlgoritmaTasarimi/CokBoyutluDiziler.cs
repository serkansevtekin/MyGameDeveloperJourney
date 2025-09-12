using System;

namespace Programlama.AlgoritmaTasarimi
{
    class CokBoyutDiziClass
    {
        public static void CokBoyutDiziMainMethod()
        {
            /* //Tamımlama
                int[,,] array1 = new int[4, 2, 3];
     */

            Matris mat = new Matris();
            int[,] X = mat.DiyagonalMatris(3);
            mat.MatrisYazdir(X);

            System.Console.Write("\n Diyagonal eleman listesi: ");
            int[] D = mat.DiyagonelElemanlariListele(X);
            mat.MatrisYazdir(D);

            System.Console.WriteLine("\nMatrisin izi: {0}",mat.BirMatrisinİziTrace(X));

        }
    }

}