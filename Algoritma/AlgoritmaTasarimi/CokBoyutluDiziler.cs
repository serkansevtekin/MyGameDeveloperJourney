using System;


namespace Programlama.AlgoritmaTasarimi
{
    class CokBoyutDiziClass
    {
        public static void CokBoyutDiziMainMethod()
        {

            Matris mat = new Matris();
            int[,] X = mat.AltUcgenMatris(4, 1, 9);
            mat.MatrisYazdir(X);

            System.Console.WriteLine("{0}",mat.AltUcgenMatrisMi(X) ? "Alt Ucgen Matris":"Alt ucgen matris değil");

            




        }
    }

}