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
            int[,] X = mat.DiyagonalMatris(5);
            mat.MatrisYazdir(X);
            
            int[] D = mat.DiyagonelElemanlariListele(X);
            mat.MatrisYazdir(D);


        }
    }

}