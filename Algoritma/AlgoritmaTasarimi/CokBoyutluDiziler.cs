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
            int[,] X = mat.MatrisOlusturma(4,3);
            mat.MatrisYazdir(X);

            int[,] Y = mat.ReshapeMatris(X, 3, 4);
            mat.MatrisYazdir(Y);
        } 
    }

}