using System;

namespace Programlama.AlgoritmaTasarimi
{
    class TypeOfInheritanceClass
    {
        public static void TypeOfInheritanceRunMethod()
        {
            Otomobil oto = new Otomobil();
            oto.Calistir();
            oto.KornayaBas();

            System.Console.WriteLine();

            Otomobils otomob = new Otomobils();
            otomob.Yasam();
            otomob.HareketEt();
            otomob.KornayaBasla();

            System.Console.WriteLine();

            Otobmobiller otobmobiller = new Otobmobiller();
            otobmobiller.AracHareket();
            otobmobiller.KornayaBassss();

            System.Console.WriteLine();

            Kamyon kamyon = new Kamyon();
            kamyon.AracHareket();
            kamyon.YukTasi();


            System.Console.WriteLine("\n---------------------\n");
            System.Console.WriteLine("Interface yoluyla [Multi Inheritance] ");
            Tesla t = new Tesla();
            t.SarjEt();
            t.Sur();
        }
    }

    #region Tanım
    /*
            C# desteklenen kalıtım türleri

        1- Single Inheritance (Tekli Kalıtım)
            Bir sınıf sadece tek bir sınıftan biras alabilir
        
        2- Multilevel Inheritance (Çok Katmanlı Kalıtım)
            Bir sınıf başka bir sınıftan türeyebilir ve o da başka bir sınıftan türeyebilir

        3- Hierarchical Inheritance (Hiyerarşik Kalıtım)
            Birden fazla sınıf aynı üst sınıftan türeyebilir
        
        4- Hybrid Inheritance (Hibrit Kalıtım)
            Farklı kalıtım türlerinin bir aada kullanılmasıdır (örneğin hem hiyerarşik hemde multilevel)
            C#'ta hibrit kalıtım interface yardımı ile yapılır

            C# DESTEKLENMEYEN
        
        --** Multiple Inheritance (Çoklu kalıtım)
        Bir sınıfta aynı anda birden fazla sınıftan miras alması desteklenmez.
        Bunun yerine INTERFACE kullanılır.




        Özet:

            Single ✅

            Multilevel ✅

            Hierarchical ✅

            Hybrid (Interface ile) ✅

            Multiple (Doğrudan kullanılamaz) ❌ [interface ile]
    */
    #endregion






    #region Single Inheritance

    class Araclar
    {
        public void Calistir() => System.Console.WriteLine("Araç çalıştı");
    }

    class Otomobil : Araclar
    {
        public void KornayaBas() => System.Console.WriteLine("Korna çalındı");
    }

    #endregion

    #region Multilevel Inheritance
    class Varlik
    {
        public void Yasam() => System.Console.WriteLine("Yaşıyor...");
    }

    class Aracs : Varlik
    {
        public void HareketEt() => System.Console.WriteLine("Araç hareket ediyor");
    }
    class Otomobils : Aracs
    {
        public void KornayaBasla() => System.Console.WriteLine("Korna Çaldı");
    }
    #endregion

    #region Hierarchial Inheritance
    class Araclars
    {
        public void AracHareket() => System.Console.WriteLine("Araç hareket ediyor");
    }
    class Otobmobiller : Araclars
    {
        public void KornayaBassss() => System.Console.WriteLine("Korna çaldı");
    }
    class Kamyon : Araclars
    {
        public void YukTasi() => System.Console.WriteLine("Yük taşınıyor");
    }
    #endregion

    #region INTERFACE KULLANARAK (Multiple Inheritance)
    interface IElektirikli
    {
        void SarjEt();
    }
    interface IAraba
    {
        void Sur();
    }

    class Tesla : IElektirikli, IAraba
    {
        public void SarjEt() => System.Console.WriteLine("Şarj Oluyor...");
        public void Sur() => System.Console.WriteLine("Tesla Sürülüyor....");
    }
    #endregion

}