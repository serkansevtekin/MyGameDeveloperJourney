using System;

namespace Programlama.DegerVeReferansTipNameSpace
{
    public class DegerVeReferansTipClass
    {
        public static void DegerVeReferansTipMainMethod()
        {
            // GenelRef();
            RefListeOrnek();
        }

        #region  Genel Ref
        private static void GenelRef()
        {
            int x = 10;
            int y = 20;
            System.Console.WriteLine("{0},{1}", x, y);
            //ref -> anahtar sözcüğü ekledik
            Degistir(ref x, ref y);
            System.Console.WriteLine("{0},{1}", x, y);
        }

        //ref -> anahtar sözcüğü ekledik
        private static void Degistir(ref int a, ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
            System.Console.WriteLine("{0},{1}", a, b);

        }

        #endregion

        internal static void RefListeOrnek()
        {
            //Liste Tanımı
            List<string> sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };

            /*     foreach (string item in sehirler)
                {
                    System.Console.WriteLine(item);
                } */

            //Lambda expression

            sehirler.ForEach(s => Console.WriteLine(s));
            System.Console.WriteLine();

            Console.WriteLine(new string('_', 50));

            List<string> iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));
            System.Console.WriteLine();

            sehirler.Add("Sinop");
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));

            System.Console.WriteLine();
            iller.Remove("Ankara");
            iller.ForEach(i => Console.WriteLine(i));

            System.Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
        }


    }

}