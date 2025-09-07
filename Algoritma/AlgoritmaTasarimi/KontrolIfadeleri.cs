using System;

namespace Programlama.AlgoritmaTasarimi
{
    class KontrolIfadeleriClass
    {
        public static void KontrolIfadeleriMainMethod()
        {

            //IF Else
            //  IfElseUygulama1();
            //  IfElseUygulama2();

            //Switch Case
            // SwitchCaseUygulama1();
            SwitchCaseUygulama2();

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

        public enum Renkler { Kirmizi, Yasil, Mavi }

        private static void SwitchCaseUygulama1()
        {
            Renkler r = (Renkler)new Random().Next(0, 10);// (Renkler) cast için  

            switch (r)
            {
                case Renkler.Kirmizi://0
                    System.Console.WriteLine("Renk kırmızıdır");
                    break;
                case Renkler.Yasil://1
                    System.Console.WriteLine("Renk yeşildir");

                    break;
                case Renkler.Mavi://2
                    System.Console.WriteLine("Renk mavidir");

                    break;
                default://3...10
                    System.Console.WriteLine("Renk bilinmiyor");

                    break;
            }
        }


        private static void SwitchCaseUygulama2()
        {

            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);
            switch (caseSwitch)
            {
                case 1: System.Console.WriteLine("Durum 1"); break;
                case 2:
                case 3: System.Console.WriteLine($"Case {caseSwitch}"); break;
                default:
                    System.Console.WriteLine($"Belenmeyen durum {caseSwitch}");
                    break;
            }


        }


        /* 
            --** Switch - Case **--



        */

        #endregion





    }


}