using System;

namespace Programlama.AlgoritmaTasarimi
{
    class DegiskenlerClass
    {
        public static void DegiskenMainMethod()
        {
            int max16, min16;
            max16 = System.Int16.MaxValue;
            min16 = System.Int16.MinValue;
            int max32 = System.Int32.MaxValue;
            int min32 = System.Int32.MinValue;

            byte minByte = System.Byte.MinValue;
            byte maxBayte = System.Byte.MaxValue;
            int sayi = 23;
            sayi = sayi * 2;
            System.Console.WriteLine(sayi);

            System.Console.WriteLine("Int16 -> Min : {0} \t\t Max : {1}", min16, max16);
            System.Console.WriteLine("\nInt32 -> Min : {0} \t Max : {1}", min32, max32);
            System.Console.WriteLine("\nByte -> Min : {0} \t\t Max : {1}",minByte,maxBayte);




        }
    }
}