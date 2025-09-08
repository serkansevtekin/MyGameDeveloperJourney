using System;

namespace Programlama.AlgoritmaTasarimi
{
    class ForDongusuClass
    {
        public static void ForDongusuMainMethod()
        {
            Uygulama4();
        }

        public static void Uygulama1()
        {
            //1 den 100 e kadar 1 er 1 er art
            for (int i = 1; i < 100; i += 1)
            {
                System.Console.WriteLine("{0} -> {1}", i, i * i);
            }
            System.Console.WriteLine();

            //100 den 1 e kadar 1 er 1 er azal
            for (int i = 100; i > 1; i -= 1)
            {
                System.Console.WriteLine("{0} -> {1}", i, i * i);
            }

        }
        public static void Uygulama2()
        {
            int tekToplam = 0, ciftToplam = 0;
            System.Console.WriteLine("Limit değeri gir:");
            int limit = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Tek Sayılar");
            for (int i = 1; i < limit; i += 2)
            {
                System.Console.Write("{0,5}", i);
                tekToplam += i;// tekToplam = tekToplam + i;
            }

            System.Console.WriteLine("\n\nÇift Sayılar");
            for (int i = 2; i < limit; i += 2)
            {
                System.Console.Write("{0,5}", i);
                ciftToplam += i;// ciftToplam = ciftToplam + i;

            }

            System.Console.WriteLine("\n\nTek Toplam: {0,-5}, \t Çift Toplam: {1,-5}", tekToplam, ciftToplam);
        }
        public static void Uygulama3()
        {
            int sayac = 0;
            for (int i = 1000; i >= 0; i -= 5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }

            System.Console.WriteLine("\n\n Eleman Sayısı: {0}",sayac);
        }
        public static void Uygulama4()
        {
            //Çarpım tablosu
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    System.Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                System.Console.WriteLine();
            }

        }
    }
}