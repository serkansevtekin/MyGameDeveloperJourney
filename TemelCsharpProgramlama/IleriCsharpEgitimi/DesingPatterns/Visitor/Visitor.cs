using System;

namespace VisitorDPNamespace
{
    class VisitorDPClass
    {
        public static void VisitorDPRunMain()
        {
            //Çalışanlar oluşturuluyor
            Manager serkan = new Manager { Name = "Serkan", Salary = 1000 };
            Manager salih = new Manager { Name = "Salih", Salary = 900 };

            Worker deniz = new Worker { Name = "Deniz", Salary = 800 };
            Worker ali = new Worker { Name = "Ali", Salary = 800 };

            //Organizasyon yapısı (serkan üst, salih onun altında)
            serkan.Subordinates.Add(salih);
            salih.Subordinates.Add(deniz);
            salih.Subordinates.Add(ali);

            //En üst yöneticiden başlayarak yapıyı temsil eden sınıf
            var organisationalStructure = new OrganisationalStructure(serkan);

            //Farklı ziyaretçiler (işlemler)
            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayriseVisitor payrise = new PayriseVisitor();

            //Organizasyon tüm çalışanları üzerinden ziyaretçileri çalıştırıyor
            organisationalStructure.Accept(payrollVisitor);
            organisationalStructure.Accept(payrise);
        }
    }



    // Çalışanların hiyerarşik yapısını yöneten sınıf
    class OrganisationalStructure
    {
        public EmplyeeBase? Employee; // En üst çalışan (örneğin CEO)

        public OrganisationalStructure(EmplyeeBase? FirstEmployee)
        {
            Employee = FirstEmployee;
        }

        // Organizasyon yapısı bir ziyaretçi kabul erder
        public void Accept(VisitorBase visitor)
        {
            Employee!.Accept(visitor);
        }
    }


    // Tüm çalışanların temel sınıfı
    abstract class EmplyeeBase
    {
        public abstract void Accept(VisitorBase visitor); // Ziyaretçi kabul eden method
        public string? Name { get; set; } // Çalışan adı
        public decimal Salary { get; set; } // Maaşk
    }


    //Yöneticiyi temsil eden sınıf (ConcreteElement)

    class Manager : EmplyeeBase
    {
        public List<EmplyeeBase> Subordinates { get; set; } // Alt çalışanlar listesi

        public Manager()
        {
            Subordinates = new List<EmplyeeBase>();
        }

        // Visitor geldiğinde önce kendisi , sonra alt çalışanları ziyaret ettirir
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this); // Kendisini ziyaret ettir
            foreach (var emplyee in Subordinates)
            {
                emplyee.Accept(visitor); // ALt çalışanları da ziyaret ettir
            }
        }
    }

    // Normal çaşışan sınıfı (ConcreteElement)
    class Worker : EmplyeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this); // Sadece kendisini zayaret ettirir
        }
    }

    //Ziyaretçi arayüzü (Visitor)
    abstract class VisitorBase
    {
        //Farklı çalışan türleri için ayrı Visit metotları
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);

    }

    // Maaş ödeme işlemini yapan ziyaretçi (ConcreteVisitor)
    class PayrollVisitor : VisitorBase
    {

        public override void Visit(Worker worker)
        {
            System.Console.WriteLine($"{worker.Name} Paid {worker.Salary}");
        }

        public override void Visit(Manager manager)
        {
            System.Console.WriteLine($"{manager.Name} Paid {manager.Salary}");

        }
    }


    //Maaş artırımı işleminin yapan ziyaretçi (ConcreteVisitor)
    class PayriseVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            System.Console.WriteLine($"{worker.Name} salary increased to {worker.Salary * (decimal)1.1}");

        }

        public override void Visit(Manager manager)
        {
            System.Console.WriteLine($"{manager.Name} salary increased to {manager.Salary * (decimal)1.2}");

        }
    }

    /*
    
    Kod için Açıklama Özeti

        EmplyeeBase → tüm çalışan tiplerinin tabanı, Accept() metodu Visitor’ı kabul eder.
        
        Manager / Worker → kendi Accept() metotlarında Visitor’ın uygun Visit() metodunu çağırır.
        
        VisitorBase → tüm ziyaretçi türlerinin arayüzü.
        
        PayrollVisitor / PayriseVisitor → aynı nesneler üzerinde farklı işlemler uygular.
        
        OrganisationalStructure → hiyerarşik yapıyı temsil eder, kökten itibaren tüm elemanları gezdirir.
    */


    #region Visitor Design Pattern | Tanım
    /*
    Visitor Design Pattern, bir nesne yapısına yeni işlemler eklemenin yoludur. Mevcut sınıfı değiştirmeden nesnelere " ziyaretçiler (visitor)" göndererek ek davranış kazandırır. Özellikle farklı türdeki nesneler üzerinde aynı işlemi yapmak gerektiğinde.

    Amaç:
        - Bir nesne hiyerarşisine yeni operasyonlar eklemeyi kolaylaştırmak
        - Nsneleri sınıflarını değiştirmeden, operasyonları dışarıda toplamak


    Temel Yapı:
            
            * Visitor (Ziyaretçi Arayüzü) --> Her öğe türü için VisitX() metodunu içerir
            
            * ConcreteVisitor (Somut ziyaretçi) --> Gerçek işlemleri tanımlar

            * Element (Eleman Arayüzü) --> Accept(Visitor) metonudu tanımlar

            * ConcreteElement --> Kendine uygun Accept() metoduna ziyaretçiyi kabul eder

            * ObjectStructure (Nesne yapısı) --> Eleman listesini yönetir, tüm elemanlara "Accept" çağırır

    Kullanım Alanları:

            - Nesne türleri sabit, ama işlem türleri değişken olduğunda.

            - Dosya sisteminde her dosya türü için farklı işlem yapılacaksa.

            - Oyunlarda farklı karakter türlerine özel çarpışma/etkileşim davranışları gerekiyorsa.


  ***   UML ŞEMASı  *** 

+-----------------+        +---------------------+
|   IItemElement  |<-------|   Book / Fruit      |
|-----------------|        |---------------------|
| +Accept(v)      |        | +Accept(v)          |
+-----------------+        +---------------------+
        |                           ^
        |                           |
        |                           |
        v                           |
+-----------------+        +---------------------+
|     IVisitor    |<-------|  ShoppingCartVisitor |
|-----------------|        |---------------------|
| +Visit(Book)    |        | +Visit(Book)        |
| +Visit(Fruit)   |        | +Visit(Fruit)       |
+-----------------+        +---------------------+

**              **




    */

    #endregion
}