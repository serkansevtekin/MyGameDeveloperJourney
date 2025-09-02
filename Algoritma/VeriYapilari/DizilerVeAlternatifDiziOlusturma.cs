using System;
using System.Collections;

namespace Programlama.VeriYapilari
{
    class DizilerVeAlternatifDiziOlusturmaYaklasimlari
    {
        public static void DADOYMainMethod()
        {
            //Array | Dizi | Tanımlama

            int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 6, 34, 19, 55 };

            //Alternatif dizi olusturma
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length); //Array.CreateInstance ile dizi oluşturma // typeof ile veri tipi belirleme // sayilar.Length ile sayilar dizisinin uzunluğunu alıp numbers dizisinin uzunluğunu belirleme
            var arr = new ArrayList(sayilar);



            //Kopyalama | CopyTo
            KopyalamaMethod(sayilar, numbers);

            //Sıralama | Sort
            SiralamaMethod(sayilar, numbers, arr);

            //Temizleme | Clear
            ClearMethod(sayilar);

            //Kaçıncı Eleman olduğunu bulma | IndexOf
            DegereGoreIndexBulmaMethod(sayilar, 10);

            //Dolaşma | Ekrana Yazdırma
            DolasmaMethod(sayilar, numbers, arr);

        }

        private static void DegereGoreIndexBulmaMethod(int[] sayilar, int arananDeger)
        {

            int indexNo = Array.IndexOf(sayilar, arananDeger);//Değer yoksa -1 döner
            if (indexNo == -1)
            {
                System.Console.WriteLine("Deger yok");
            }
            else
            {
                System.Console.WriteLine($"{arananDeger} değeri dizide {indexNo}. sırada");
            }
        }

        private static void ClearMethod(int[] sayilar)
        {

            //Clear dan sonra sıralama koyarsak temizlenen elemanlar en başa gelir
            Array.Clear(sayilar, 2, 2); //sayilar dizisinin 2.indexten itibaren 3 elemanı temizle
        }

        private static void KopyalamaMethod(int[] sayilar, Array numbers)
        {
            //1. Yöntem
            /*  for (int i = 0; i < sayilar.Length; i++)
             {
                 numbers.SetValue(sayilar[i],i);

             } */

            //2. Yöntem

            sayilar.CopyTo(numbers, 0); // sayilar dizisini numbers dizisine 0.indexten itibaren kopyala
        }

        public static void SiralamaMethod(int[] sayilar, Array numbers, ArrayList arr)
        {
            //Sıralama
            Array.Sort(sayilar); //Dizi siralama
            Array.Sort(numbers); //Array siralama
            arr.Sort(); //ArrayList siralama

        }

        private static void DolasmaMethod(int[] sayilar, Array numbers, ArrayList arr)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine($"sayilar[{i}] = {sayilar[i]} - numbers[{i}] = {numbers.GetValue(i)} - arr[{i}] = {arr[i]}");
            }
        }

    }
}