using System;

namespace Programlama.AlgoritmaTasarimi
{
    class StringlerClass
    {
        public static void StringlerMainMethod()
        {
            /*  Desen1('*', 10);
             Desen1();
             Desen1('!'); 
             */

            Desen2();
             Desen2('/',10);
             Desen2('*'); 
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
    }
}