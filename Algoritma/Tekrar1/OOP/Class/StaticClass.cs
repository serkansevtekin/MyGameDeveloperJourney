using System;

namespace Programlama.Tekrars1
{
    public class StaticClassClass
    {
        public static void StaticClassRun()
        {
            int result = MathHelper.Add(5, 3);
            System.Console.WriteLine(result);
        }
    }

    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    #region Static Class Tanım
        /*
        Tanım: Sadece static üyeler içerebilen ve nesne oluşturulamayan class
        Kullanım: Yardımcı (utility) metodlar, sabitler veya golbal veriler için

        Özellikleri:
            + Nesne oluşturulamaz
            + Tüm üyeleri static olmak zorunda
            + Unity'de helper/metod classları için çok yaygın
        */
    #endregion
}