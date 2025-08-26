using System;
using System.Runtime.InteropServices;
namespace Programlama.DizeDegismezleriNameSpace
{
    public class DizeDegismezleri
    {
        public static void DizeDegismezleriMethod()
        {
            //  OrtuluDegiskenTanimi();
            var ifade = "Merhaba programlama dünyası";
            System.Console.WriteLine(ifade);
            System.Console.WriteLine("İfadenin uzunluğu: " + ifade.Length);
            System.Console.WriteLine("ifade büyük harf oldu: " + ifade.ToUpper());
            System.Console.WriteLine("İfade küçük harf oldu: " + ifade.ToLower());
            System.Console.WriteLine("Baştaki boşlıkları kes: " + ifade.TrimStart());
            System.Console.WriteLine("Sondaki boşlıkları kes: " + ifade.TrimEnd());
            System.Console.WriteLine("0. Karakter : " + ifade[0]);
            System.Console.WriteLine("1. Karakter : " + ifade[1]);
            System.Console.WriteLine("Son Karakter : " + ifade[ifade.Length - 1]);


        }

        private static void OrtuluDegiskenTanimi()
        {
            // örtülü değişken => var
            /*
            VAR
            var aslında “her şey olabilir” anlamında değil; derleyiciye (compiler) türü otomatik çıkart (type inference yap)” demektir.

            📌 Ne zaman kullanmalı?

            ✅ Tür açıkça belli ise (new ile nesne oluştururken)
            ✅ Uzun generic tanımlarda okunabilirliği artırmak için
            ✅ LINQ / anonim tiplerde

            ❌ Ama her yerde var kullanmak kod okunabilirliğini azaltır.
            */
            var ifade = Console.ReadKey(); // == ConsoleKeyInfo ifade2 = Console.ReadKey();

            System.Console.WriteLine(ifade.Key);
            System.Console.WriteLine(ifade.KeyChar);
        }
    }

}