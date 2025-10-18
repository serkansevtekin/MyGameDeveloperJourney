using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class KosulBloc
    {
        public static void KosulBlocRun()
        {
            //IfElse();
            //IfElseUygulama1();
            //IfElseUygulama2();
            // IfElseUygulama3();
            TernaryIf();


            //SwitchCase();

        }

        private static void IfElse()
        {
            /*    string userName = "serkan";
               string password = "123";
               if (userName != "serkan")
               {
                   System.Console.WriteLine("Username yanlış");
               }
               else if (password != "123")
               {
                   System.Console.WriteLine("password yanlış");

               }
               else
               {
                   System.Console.WriteLine("Merhaba");
               } */

            int x = 10;
            int y = 20;

            if (x > y)
            {
                System.Console.WriteLine("x y'den büyük");
            }
            else if (x == y) { System.Console.WriteLine("x y'ye eşit"); }
            else
            {
                System.Console.WriteLine("x y'den küçük");

            }



        }

        private static void IfElseUygulama1()
        {
            System.Console.WriteLine("Toplama için: +");
            System.Console.WriteLine("Çıkarmak için: -");
            System.Console.WriteLine("Çarpma için: *");
            System.Console.WriteLine("Bölme için: /");

            System.Console.Write("Seçiminiz: ");
            string? secim = Console.ReadLine();

            System.Console.Write("1. Sayıyı gir: ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("2. Sayıyı gir: ");
            double sayi2 = Convert.ToInt32(Console.ReadLine());


            if (secim == "+")
            {
                System.Console.WriteLine("Toplama: {0}", sayi1 + sayi2);
            }
            else if (secim == "-")
            {
                System.Console.WriteLine("Çıkarma: {0}", sayi1 - sayi2);

            }
            else if (secim == "*")
            {
                System.Console.WriteLine("Çarpma: {0}", sayi1 * sayi2);

            }
            else
            {
                System.Console.WriteLine("Bölme: {0}", sayi1 / sayi2);
            }



        }
        private static void IfElseUygulama2()
        {
            System.Console.Write("1. yazılı notu: ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("2. yazılı notu: ");
            double y2 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Sözlü notu: ");
            double s = Convert.ToInt32(Console.ReadLine());

            double ortalama = (y1 + y2 + s) / 3;

            if (ortalama > 0 && ortalama < 24)
            {
                System.Console.WriteLine($"Ortalaman: {ortalama} ve Not değeri: 0");
            }
            else if (ortalama >= 25 && ortalama < 44)
            {
                System.Console.WriteLine($"Ortalaman: {ortalama} ve Not değeri: 1");

            }
            else if (ortalama >= 45 && ortalama < 54)
            {
                System.Console.WriteLine($"Ortalaman: {ortalama} ve Not değeri: 2");

            }
            else if (ortalama >= 55 && ortalama < 69)
            {
                System.Console.WriteLine($"Ortalaman: {ortalama} ve Not değeri: 3");

            }
            else if (ortalama >= 70 && ortalama < 84)
            {
                System.Console.WriteLine($"Ortalaman: {ortalama} ve Not değeri: 4");

            }
            else
            {
                System.Console.WriteLine($"Ortalaman: {ortalama} ve Not değeri: 5");

            }


        }

        private static void IfElseUygulama3()
        {
            System.Console.Write("1. Sayıyı giriniz: ");
            double s1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("2. Sayıyı giriniz: ");
            double s2 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("3. Sayıyı giriniz: ");
            double s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2 && s1 > s3)
            {
                System.Console.WriteLine($"En büyük sayı {s1}");
            }
            else if (s2 > s1 && s2 > s3)
            {
                System.Console.WriteLine($"En büyük sayı {s2}");

            }
            else
            {
                System.Console.WriteLine($"En büyük sayı {s3}");

            }

        }

        private static void TernaryIf()
        {
            int sayi = -3;
            string sonuc = (sayi % 2 == 0)
            ? (sayi > 0) ? "Sayı pozitif çift " : "Sayı negatif çift"
            : (sayi > 0) ? "Sayı pozitif tek " : "Sayı negatif tek";

            System.Console.WriteLine(sonuc);
        }

        private static void SwitchCase()
        {
            /*  int gun = (int)DateTime.Now.DayOfWeek;

             switch (gun)
             {

                 case 1: System.Console.WriteLine($"{gun} gün => Pazartesi"); break;
                 case 2: System.Console.WriteLine($"{gun} gün => Salı"); break;
                 case 3: System.Console.WriteLine($"{gun} gün => Çarşamba"); break;
                 case 4: System.Console.WriteLine($"{gun} gün => Perşembe"); break;
                 case 5: System.Console.WriteLine($"{gun} gün => Cuma"); break;
                 case 6: System.Console.WriteLine($"{gun} gün => Cumartesi"); break;
                 default: System.Console.WriteLine($"{gun} gün => Pazar"); break;

             } */

            int ay = DateTime.Now.Month;

            switch (ay)
            {

                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar");
                    break;
                default:
                    System.Console.WriteLine("Hatalı ay");
                    break;
            }

        }

    }
}