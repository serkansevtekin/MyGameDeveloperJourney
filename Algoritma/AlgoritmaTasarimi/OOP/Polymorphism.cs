using System;

namespace Programlama.AlgoritmaTasarimi
{
    class PolymorphismClass // Polymorphism (Çok Biçimlilik)
    {


        public static void PolymorphismRunMethod()
        {
            //Virual Methoda yazdığımız kodlara devam

            //Run-Time Polymorphism (Çalışma Zamanı Çok Biçimlilik)
            var r = new Dikdortgen
            {
                Pozisyon = { X = 55, Y = 25 },
                Boyut = { Genislik = 200, Yukseklik = 100 }
            };
            SekilCiz(r);

            // Ornek {1. Compile-Time Polymorphism (Derleme Zamanı Çok Biçimlilik)}
            var m = new Matematiks();
            System.Console.WriteLine(m.Topla(2, 3));//int -> 5
            System.Console.WriteLine(m.Topla(2.5, 3.5)); // double -> 6

            // Ornek {Run-Time Polymorphism (Çalışma Zamanı Çok Biçimlilik)}
            Hayvan h1 = new Kedi();
            Hayvan h2 = new Kopek();

            h1.SesCikar();
            h2.SesCikar();
        }


        internal static void SekilCiz(Sekil sekil) => sekil.Ciz();



        #region Tanım
        /*
        - Polimorfizmde, çağrılan yöntem derleme zamanı sırasında değil, dinamik olarak tanımlanır.
        - Derleyici bir sanal metot tablosu (vtable) oluşturur ki bu yablo çalışma zamanı sırasında çağrılabilecek metotların bir listesini içerir ve derleyici çalışma zamanında type (tip) dikkate alarak metotları çağırır.
        
        */
        #endregion


    }


    #region ornek {1. Compile-Time Polymorphism (Derleme Zamanı Çok Biçimlilik)}
    class Matematiks
    {
        public int Topla(int a, int b) => a + b;
        public double Topla(double a, double b) => a + b;


    }

    #endregion

    #region Ornek {Run-Time Polymorphism (Çalışma Zamanı Çok Biçimlilik)}
    class Hayvan
    {
        public virtual void SesCikar()
        {
            System.Console.WriteLine("Hayvan Sesi");
        }
    }

    class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            System.Console.WriteLine("Miyav");
        }
    }

    class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            System.Console.WriteLine("Hav ");
        }
    }
    #endregion
}