using System;

namespace Programlama.AlgoritmaTasarimi
{
    class CallingBaseVersionOfMethodsClass
    {
        public static void CallingBaseVersionOfMethodsRunMethods()
        {
            var h = new Kediler();
            h.SesCikar();
        }


        #region Tanım
        /*
        C# temel sınıfta yer alan bir metodu çağırmak üzere özel bir söz dizilimine sahiptir

                   base.<MethodName>

        Bu şekilde herhangi bir metodu override etmeden, temel sınıftan çağrımak mümkündür

        */
        #endregion


    }

    #region Ornek
    class Hayvanlar
    {
        internal virtual void SesCikar()
        {
            System.Console.WriteLine("Hayvan Sesi");
        }
    }

    class Kediler : Hayvanlar
    {
        internal override void SesCikar()
        {
            // Önce base (üst sınıf) metodunu çağır
            base.SesCikar(); // Çıktı Hayvan sesi

            // Sonra kendi davranışını ekle
            System.Console.WriteLine("Miyav");
        }
    }

    #endregion
}