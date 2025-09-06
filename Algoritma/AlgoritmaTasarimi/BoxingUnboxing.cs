using System;

namespace Programlama.AlgoritmaTasarimi
{
    class BoxingUnboxingClass
    {
        public static void BoxingUnboxingMainMethod()
        {
           // TemelBilgiler();
        }

        private static void TemelBilgiler()
        {
            //Boxing - kutulama
            int i = 23;
            object o = i; //(object)i -> explict boxing (açıktan kutulama)
            //Unboxing - kutudan çıkarma 
            i *= 2; // i = i * 2;
            i = (int)o;//cast işlemi -> obje türündeki bir değeri int olarak alacağız          

            System.Console.WriteLine("Değer türü : {0}", i);
            System.Console.WriteLine("Referans tür : {0}", o);
        }
    }
}