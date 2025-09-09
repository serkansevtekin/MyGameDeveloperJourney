using System;

namespace Programlama.AlgoritmaTasarimi
{
    class StringlerClass
    {
        public static void StringlerMainMethod()
        {
            KarakterSeti();
            KarakterSeti(128, 255);
            KarakterSeti(128, 255, 10);

        }

        #region Desen1

        /// <summary>
        /// Desen oluşturucu
        /// </summary>
        /// <param name="c">Karakter tanımı</param>
        /// <param name="n">Tekrar sayısı</param>
        private static void Desen1(char c = '*', int n = 5)
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("{0,10}", new string(c, i));
            }

        }
        #endregion

        #region Desen2

        /// <summary>
        /// Desen oluşturucu
        /// </summary>
        /// <param name="c">Karakteri tanımı</param>
        /// <param name="n">Tekrar sayısı</param>
        private static void Desen2(char c = '!', int n = 4)
        {
            for (int i = n; i >= 0; i--)
                System.Console.WriteLine("{0}", new string(c, i));
        }

        #endregion

        #region Karakter Seti
        private static void KarakterSeti(int baslangicIndisi = 65, int bitisIndisi = 90, int satirKarakterSayisi = 5)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)
            {
                System.Console.Write("{0,5}", (char)i);
                if (i % satirKarakterSayisi==0)
                {
                    System.Console.WriteLine();
                }
            }
        }
        #endregion

    }
}