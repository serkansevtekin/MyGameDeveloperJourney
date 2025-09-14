using System;


namespace Programlama.AlgoritmaTasarimi
{
    class CokBoyutDiziClass
    {
        public static void CokBoyutDiziMainMethod()
        {

            Matris mat = new Matris();
            int[,] X = mat.DiyagonalMatris(3,1,5);
            mat.MatrisYazdir(X);


            System.Console.WriteLine("{0}", mat.KosegenMatrisMi(X) ? "Köşegen Matris" : "Köşegen Matris değil");




        }
    }

}