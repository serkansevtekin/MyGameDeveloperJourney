using System;

namespace Programlama.DegiskenlerNameSpace
{
    public class Degiskenler
    {
        public static void DegiskenlerMethod()
        {
            //Tip
            /*   int sayi1 = 0;
              float pi = 3.14f;
              char secim = 'e';
              string isim = "serkan";
              bool dogruMu = false; */

            //Atama
            //string isim = "serkan";
            string isim;
            isim = "Serkan";
            Console.WriteLine("Merhaba " + isim + ".");
            isim = "Mehmet";
            Console.WriteLine("Merhaba Sayın " + isim + ".");
            
            int sayi = 2;
            System.Console.WriteLine(sayi);
            System.Console.WriteLine(sayi + 2);
            System.Console.WriteLine(sayi * sayi);
            System.Console.WriteLine(sayi -5);
           

        }
    }
}
