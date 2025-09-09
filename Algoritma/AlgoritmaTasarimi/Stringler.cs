using System;

namespace Programlama.AlgoritmaTasarimi
{
    class StringlerClass
    {
        public static void StringlerMainMethod()
        {
            StringMetotlar();
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
                if (i % satirKarakterSayisi == 0)
                {
                    System.Console.WriteLine();
                }
            }
        }
        #endregion

        #region Name

        private static void StringMetotlar()
        {
            string ifade = " Afacan ";
            System.Console.WriteLine(ifade);
            System.Console.WriteLine(ifade.Length);
            System.Console.WriteLine(ifade.Trim());
            System.Console.WriteLine(ifade.Trim().Length);
            System.Console.WriteLine(ifade.TrimStart());
            System.Console.WriteLine(ifade.TrimEnd());
            System.Console.WriteLine(ifade.ToLower());
            System.Console.WriteLine(ifade.ToUpper());
            System.Console.WriteLine(ifade.Replace('a','e'));


            
        }
        #endregion

    }
}