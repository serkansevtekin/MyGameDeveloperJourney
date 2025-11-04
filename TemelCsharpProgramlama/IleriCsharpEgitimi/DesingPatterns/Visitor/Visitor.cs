using System;

namespace VisitorDPNamespace
{
    class VisitorDPClass
    {
        public static void VisitorDPRunMain()
        {

        }
    }

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