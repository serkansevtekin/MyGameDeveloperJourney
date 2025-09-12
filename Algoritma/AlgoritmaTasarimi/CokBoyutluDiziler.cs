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
            int[,] X = mat.MatrisOlusturma(5,3);
            mat.MatrisYazdir(X);

            System.Console.WriteLine();
            int[,] Tr = mat.Transpoz(X);
            mat.MatrisYazdir(Tr);
        } 
    }

}