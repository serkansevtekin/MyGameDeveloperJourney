using System;



namespace PrototypeDesignNameSpace
{
    /*
Özet:
    Prototype patter, bir nesnenin mevcut halini klonlayarak yeni bir örnek oluşturur
    "MemberwiseClone()" sadece yüzeysel kopya yapar ( referans tipler aynı adresi paylaşır )
    Burada customer2, cutomer1'den bağımsız bir kopyadır
*/

    class PrototypeDesignClass
    {
        public static void PrototypeDesignRunMethod()
        {
            //Ana nesne oluşturuluyor
            Customer customer1 = new Customer { Id = 1, FirstName = "serkan", LastName = "sevtekin", City = "Ankara" };

            //Ana nesnenin kopyası oluşturuluyor
            Customer customer2 = (Customer)customer1.Clone();

            //Kopya nesne üzerinde değişiklik yapılıyor
            customer2.FirstName = "Salih";

            //Ana nense etkilen miyor
            System.Console.WriteLine("Ana nesne: " + customer1.FirstName);
            System.Console.WriteLine("Clone nesne: " + customer2.FirstName);
        }
    }

    // Soyut sınıf: Klonlanabilir temel yapı
    public abstract class Person
    {
        // Klonlama işlemini alt sınıflar zorunlu olarak tanımlayacak
        public abstract Person Clone();

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    //Customer sınıfı (müşteri)
    public class Customer : Person
    {
        public string? City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

    //Employee sınıfı (Çalılşan)
    public class Employee : Person
    {
        public decimal Maas { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }




    #region Tanım
    /*
    Amaç:
        Yeni nesne oluştururken maliyetli veya karmaşık bir "new" işleminden kaçınmak için mevcut bir nesnenin kopyasını (clone) oluşturmak


    Kavramlar:
        - Nesne oluşturma süreci pahalıysa (örneğin, çok veri yüklüyorsa veya karmaşık başltama gerekiyorsa), onun klonunu çıkarmak performans sağlar
        - "Prototype" nesnesi, kendinin kopyalayabilecek bir arayüz (genellikle ICloneable) uygular.


    Yapı:
        1) Prototype (Interface veya Abstract class): Clone() metodunu tanımlar
        2) ConcretePrototype (Somut class): Clone() metonudu implement eder
        3) Client: Yeni nesne oluşturmak yerine mevcut prototipi klonlar


    Özet Cümle:
        Prototype deseni, nesne oluşyruma maliyetini azaltır, mevcut nesneleri klonlayarak yeni nesne üretir.

    Kullanım Alanları:
            - Oyunlarda düşman, silah, mermi, effect gibi benzer nesneleri hızlı çoğaltmak.
            - Nesne başlatması pahalı olan durumlarda (veritabanı yüklemeleri, karmaşık hesaplamalar vb.)
    */
    #endregion
}