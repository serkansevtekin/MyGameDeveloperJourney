using System;


namespace Programlama.AlgoritmaTasarimi
{
    class CokBoyutDiziClass
    {
        public static void CokBoyutDiziMainMethod()
        {

            Matris mat = new Matris();
            int[,] X = mat.MatrisOlusturma(3, 3);
            mat.MatrisYazdir(X);
            System.Console.WriteLine("|X| = {0}", mat.DeterminantHesabi(X));

            
        } 
    }

}