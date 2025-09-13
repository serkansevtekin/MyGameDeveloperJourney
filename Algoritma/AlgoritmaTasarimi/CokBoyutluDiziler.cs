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
            int[,] X = mat.MatrisOlusturma(3, 4);
            int[,] Y = mat.MatrisOlusturma(3, 4);

            mat.MatrisYazdir(X);
            System.Console.WriteLine();
            mat.MatrisYazdir(Y);
            System.Console.WriteLine("\n{0}",mat.MatrisKarsilastir(X,Y) ? "Eşit": "Eşit Değil");

            
        } 
    }

}