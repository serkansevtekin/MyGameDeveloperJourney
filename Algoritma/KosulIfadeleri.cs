using System;
using System.Diagnostics;
namespace Programlama.KosulIfadeleriNameSpace
{
    public static class KosulIfadeleri
    {
        public static void KosulIfadeleriMainMethod()
        {
            //İf Else
        //    IfElseKosul();

            //switch - case
            SwitchCaseKosul();

        }


        #region If Else Koşulu
        //#region Kodun Bölümlere ayrılmasına ve kolay okunmasına yarar
        private static void IfElseKosul()
        {
            // Örnek -> Tek Mi? Çift Mi?
            TekCiftMi();

            //Örnek -> Mutlak değer
            MutlakDeger();

            //Örnek -> (chast türü) Console.Read()

            CharOzellik();
        }

        private static void CharOzellik()
        {

            var k = (char)Console.Read(); //
            if (char.IsDigit(k))//char türüne cast edilen "k" değişkeni rakammı(char.IsDigit())
            {
                System.Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k)) //char.IsLower() girilen "k" değişkeni küçk harf mi
            {
                System.Console.WriteLine("Kucuk Karakter");
            }
            else if (char.IsUpper(k))//char.IsUpper() girilen "k" değişkeni büyük harf mi
            {
                System.Console.WriteLine("Büyük Karakter");
            }
            else
            {
                System.Console.WriteLine("Bilinmeyen karakter");
            }
            System.Console.WriteLine(k);
        }

        private static void MutlakDeger()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                System.Console.WriteLine($"|{n}| = {n * -1} ");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }

        private static void TekCiftMi()
        {
            System.Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                System.Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else
            {
                System.Console.WriteLine($"{sayi} tek bir sayıdır.");
            }
        }

        #endregion

        #region  switch - case

        enum Islemler{
            Toplama = 1,
            Cikarma = 2,
            Carpma = 3,
            Bolme = 4
        }
        private static void SwitchCaseKosul()
        {
            //Örnek -> Temel Dört İşlem "Enum" Yapısı ile
            //Rasgele sayı üretmek için (new Random().Next(minValue,maxValue))
            Islemler secim = (Islemler) (new Random().Next(1,4)) ;//Verilen random değerini değişenin tipi olan Islemler tipine cast ettik
            int A = 10, B = 20;
            switch (secim)
            {
                case Islemler.Toplama: 
                    System.Console.WriteLine($"{A} + {B} = {A + B}");
                 break;
                case Islemler.Cikarma:
                    System.Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Islemler.Carpma:
                System.Console.WriteLine($"{A} * {B} = {A * B}");
                    break;
                case Islemler.Bolme:
                System.Console.WriteLine($"{A} / {B} = {A / B}");
                    break;
                default:
                System.Console.WriteLine("\aGeçersiz İşlem");
                    break;

            }
            
        }
        #endregion
    }
}