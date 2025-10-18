using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class DongularClass
    {
        public static void DongularRunMethod()
        {
            //ForDongusu();
            //WhileDongusu();
            DoWhileDongusu();
            ForeachDongusu();
        }

        private static void ForDongusu()
        {
            /* int toplam = 0;
            for (int i = 1; i <= 100; i += 1)
            {
                toplam += i;
            }
            System.Console.WriteLine($"Sayıları toplamı: {toplam}"); */

            /*      System.Console.Write("Başlangıç sayısı: ");
                 int basSayi = Convert.ToInt32(Console.ReadLine());

                 System.Console.Write("Bitiş sayısı: ");
                 int bitSayi = Convert.ToInt32(Console.ReadLine());

                 int top = 0;

                 for (int i = basSayi ; i < bitSayi; i++)
                 {
                     top += i;
                 }
                 System.Console.WriteLine(top); */

            /*  string[] isimler = { "ali", "ahmet", "can", "yelda", "seda" };

             for(int i=0; i < isimler.Length; i++)
             {
                 System.Console.WriteLine(isimler[i]);
             }
  */
            int[] sayilar = { 1, 3, 4, 18, 36, 41, 56, 89, 90, 111, 137 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 3 == 0)
                {
                    System.Console.WriteLine(sayilar[i]);
                }
            }

        }
        private static void WhileDongusu()
        {
            /*  for (int i = 0; i < 10; i++)
             {
                 System.Console.WriteLine(i);
             } */
            /*   int i = 0;
              while (i < 10)
              {
                  System.Console.WriteLine(i);
                  i++;
              } */

            /*  string[] isimler = { "ali", "ahmet", "canan" };

             var i = 0;
             while (i<isimler.Length)
             {
                 System.Console.WriteLine(isimler[i]);
                 i++;
             } */
            /*  var secim = "e";
             var sayac = 1;
             var toplam = 0;
             while (secim == "e")
             {
                 System.Console.WriteLine($"{sayac}. sayı: ");
                 toplam += Convert.ToInt32(Console.ReadLine());

                 System.Console.Write("Devam etmek istiyormusunuz? (e/h) ");
                 secim = Console.ReadLine();
                 sayac++;
             }

             System.Console.WriteLine($"{sayac} adet sayının toplamı: {toplam}"); */


            /*  string isim = "serkan sevtekin";
             for (int i = 0; i < isim.Length; i++)
             {
                 if (isim[i] == 'e')
                 {
                     continue;
                 }
                 if (isim[i] == 't')
                 {
                     break;
                 }
                 System.Console.Write(isim[i]);
             } */

            Random rnd = new Random();
            int tutulan = rnd.Next(1, 100);
            System.Console.WriteLine(tutulan);
            int hak = 3;
            while (hak > 0)
            {
                hak--;
                System.Console.Write("Sayıyı tahmin et: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == tutulan)
                {
                    System.Console.WriteLine("Tebrikler");
                    break;
                }
                else
                {
                    if (hak == 0)
                    {
                        System.Console.WriteLine("Oyun bitti");
                        break;
                    }

                    if (tutulan > sayi)
                    {
                        System.Console.WriteLine("Yukarı");
                    }
                    else
                    {
                        System.Console.WriteLine("Aşağı");
                    }

                }

            }

        }
        private static void DoWhileDongusu()
        {

        }

        private static void ForeachDongusu()
        {

        }
    }
}