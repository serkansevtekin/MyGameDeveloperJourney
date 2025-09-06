using System;

namespace Programlama.AlgoritmaTasarimi
{
    class KontrolIfadeleriClass
    {
        public static void KontrolIfadeleriMainMethod()
        {

            //IF Else
            //  IfElseUygulama1();
            IfElseUygulama2();

            //Switch Case

        }

        #region IF Else

        private static void IfElseUygulama1()
        {
            System.Console.WriteLine("Bir karakter girin: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))//IsUpper -> Girilen değer büyük harf mi?
            {
                System.Console.WriteLine("Girilen karakter büyük bir karakter.");
            }
            else if (Char.IsLower(ch)) //IsLower -> Girilen değer küçük harf mi?
            {
                System.Console.WriteLine("Girilen karakter küçük bir karakter.");

            }
            else if (Char.IsDigit(ch)) //IsDigit ->  Sayısal bir değer mi
            {
                System.Console.WriteLine("Karakter bir sayıdır");
            }
            else
            {
                System.Console.WriteLine("Karakter alfanumerik bir ifade değildir.");
            }

            bool result = true;

            if (result)// !(ünlem) -> true ise false , false ise true çevirir
            {
                System.Console.WriteLine("Sonuc 1");
            }
            else
            {
                System.Console.WriteLine("Sonuc 2");
            }


        }
        private static void IfElseUygulama2()
        {
            int m = 9;
            int n = 7;
            int p = 5;

            if (m >= n && m >= p)
            {
                System.Console.WriteLine("En büyük m");
            }
            else if (m > n && !(p > m))
            {
                System.Console.WriteLine("En büyük m");
            }

            if (m > n || m > p)
            {
                System.Console.WriteLine("m en küçük değil");
            }

            m = 4;
            if (!(m >= n) || m >= p)
            {
                System.Console.WriteLine("m artık en küçük!");
            }

        }


        /*
         --** IF Else **--

        */

        #endregion

        #region Switch - Case

        private static void SwitchCaseUygulama1()
        {

        }
        private static void SwitchCaseUygulama2()
        {

        }


        /* 
            --** Switch - Case **--



        */

        #endregion





    }


}