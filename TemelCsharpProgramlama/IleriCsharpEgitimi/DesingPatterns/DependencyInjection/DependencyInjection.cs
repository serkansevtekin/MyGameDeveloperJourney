using System;

namespace DependencyInjectionNamespace
{
    class DependencyClass
    {
        public static void DependencyRunMethod()
        {
            // Dependency Injection burada gerçekleşiyor
            // ProductManager, hangi veri erişim sınıfını kullanacağını DI ile  daşarıdan alıyor
            ProductManager productManager = new ProductManager(new NhProductDal());
            productManager.Save();
        }
    }

    // Bağlılıklar için arayüz (soyutlama)
    // Farklı veri erişim yöntemleri bu interface'i uygular
    interface IProductDal
    {
        void Save();
    }

    // Concrete Class 1
    class EfProductDal : IProductDal
    {
        public void Save()
        {
            System.Console.WriteLine("Saved with Ef");
        }
    }

    // Concrete Class 2
    class NhProductDal : IProductDal
    {
        public void Save()
        {
            System.Console.WriteLine("Saved with Nh");

        }
    }

    // Ürün yönetimi yapan sınıf
    // Ardık IProductDal'a bağımlıi, ama hangi implementasyonu kullanığını bilemez
    class ProductManager
    {
        private IProductDal _productDal;

        // Constructor Injection:
        // Bağımlılık dışarıdan verilir (örnek: EfProductDal, NhProductDal)
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Save()
        {
            // İş kuralları ( Busness  logic ) burada olur

            _productDal.Save(); // veri kaydetme işlemi arayüz üzerinden yapılır
        }
    }


    #region Depedency injection pattern | Tanım
    /*
    Dependency Injection (DI), bir sınıfın bağımlı olduğu nesneleri kendi içinde oluşurmak yerine dışarıdan almasını sağlayan tasarım desenidir.

    Amaç:
        - Bağımlılıkları azaltmak
        - Test Edilebilirliği artırmak
        - Bağımlılık yönetimini kolaylaştırmak

    Üç Temel DI yöntemi vardır:
        - Constructor Injection: Bağımlılık, sınıfın yapıcınsa verirlir. (En yaygın ve örnerilen yöntem)
        - Setter Injection: Bağımlılık, property araclığıyla atanır
        - Method Injection: Bağımlılık, metot parametresiyle göderilir.
        
    Unity de DI:
            Unity’de Dependency Injection (DI) sık kullanılır, özellikle orta–büyük ölçekli projelerde. Ama Unity kendi içinde DI framework’ü sunmaz; genelde Zenject, Extenject veya VContainer gibi kütüphaneler kullanılır.

        Unity’de Kullanım Alanları:

            Game Manager / Audio Manager / Save System / UI Controller

            Service Locator yerine daha temiz bağımlılık yönetimi

            Prefab tabanlı nesne üretiminde (Factory Pattern ile) sık entegre edilir


        UML ŞEMA

+---------------------+         +---------------------+
|    ProductManager   |         |    IProductDal      |
+---------------------+         +---------------------+
| - _productDal       |<>-------| + Save()            |
| + Save()            |         +---------------------+
+---------------------+                  ^
                                         |
         +----------------------+--------+----------------------+
         |                                             |
+---------------------+                     +---------------------+
|    EfProductDal     |                     |    NhProductDal     |
+---------------------+                     +---------------------+
| + Save()            |                     | + Save()            |
+---------------------+                     +---------------------+

Uml Şema Açıklama:

    ProductManager, IProductDal arayüzüne bağımlı.

    EfProductDal ve NhProductDal bu arayüzü uygular.

    DependencyClass, hangi veri erişim sınıfının kullanılacağını belirler ve injection işlemini yapar.

    Bu yapı sayesinde ProductManager sınıfı değiştirilmeden farklı veri erişim katmanlarıyla çalışabilir.

    */
    #endregion
}