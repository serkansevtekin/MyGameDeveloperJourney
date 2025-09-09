using System;

namespace Programlama.AlgoritmaTasarimi
{
    class CharVeRakamKarsiliklari
    {
        public static void AsciiCodeKarsili()
        {
            for (int i = 65; i < 90; i++)
            {
                System.Console.Write("{0,5}", (char)i);
                if (i % 5==0)
                {
                    System.Console.WriteLine();
                }
            }
        }
    }
}