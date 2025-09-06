using System;

namespace Programlama.KarakterSabitleriNameSpace
{
    public class KarakterSabitleri
    {
        public static void KarakterSabitleriMethod()
        {
            //Yorum Satırları 
            //     int i = 3; // i değişkeni 3 ata
            // System.Console.WriteLine(i); // ekrana i değerini yazdır

            //i değişkeninin karesi
            //  System.Console.WriteLine("Karesi: " + i * i);
            /*
            Yorum Bloğu 
            */

            /* int sayi = 0;
            System.Console.WriteLine(sayi);
            System.Console.WriteLine(sayi + sayi);
            System.Console.WriteLine(sayi * sayi); */


            /*
            Refactoring 
            -> Kodun daha okunabilir, düzenli, bakımı kolay hale getirilmesidir. Ama çalışma mantığı ve performansı aynı kalır.
            */

            //Static method
            RefactoringMethod();

            //non-static
            KarakterSabitleri k = new KarakterSabitleri();
            k.KacisIadeleriMethod();

        }

        private static void RefactoringMethod()
        {
            int sayi = 3;
            System.Console.WriteLine(sayi);
        }

        private void KacisIadeleriMethod()
        {
            /*
            \n -> alt satıra geç
            \t -> klavyedeki "Tab" tuşu ile aynı görev. 6 , 7 karakterlik boşlık verir.
            \a -> uyarı vermek için- alert üretir

            örnek: @"C:\user\zcomenrt"

            */
            string ifade = "BTK Akademi \n Programlama \t Öğreniyorum";
            System.Console.WriteLine(ifade);
        }
    }
    
}