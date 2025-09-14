using System;


namespace Programlama.AlgoritmaTasarimi
{
    class CokBoyutDiziClass
    {
        public static void CokBoyutDiziMainMethod()
        {

            Matris mat = new Matris();
            int[,] X = mat.SimetrikMatrisOlustur(10);
            mat.MatrisYazdir(X);

            System.Console.WriteLine("{0}",mat.SimetrikMi(X) ? "Simetrik": "Simetrik Değil");


          
            
            
        } 
    }

}