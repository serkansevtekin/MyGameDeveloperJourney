using System;


namespace FacadeDesignPatternNamespace
{
    public class FacadeClass
    {
        public static void FacadeRunMain()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            customerManager.Dogrumu(true);
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Logging : ILogging
    {
        public void Log() => System.Console.WriteLine("Logged");
    }



    internal interface ICaching
    {
        void Cache();
    }

    class Caching : ICaching
    {
        public void Cache() => System.Console.WriteLine("Cached");

    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class Authorize : IAuthorize
    {
        public void CheckUser() => System.Console.WriteLine("User checker");
    }


    internal interface IValidation
    {
        void Validate();
    }

    class Validation : IValidation
    {
        public void Validate() => System.Console.WriteLine("Validate");
    }


    class CustomerManager
    {
        CrossCuttingConcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Logging.Log();
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();


            System.Console.WriteLine("Saved");
        }
        
        public void Dogrumu(bool dogrumu)
        {
            if (dogrumu)
            {
                _concerns.Validation.Validate();
            }
            else
            {
                System.Console.WriteLine("Validate Olamdı");
            }
        }
    }


    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidation Validation;

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
            Validation = new Validation();
        }
    }


    #region Facade Design Pattern Tanım
    /*
    Amaç:
        - Karmaşık bir alt sistem tek bir sade arayüz (facade) kullanmayı sağlar. Kullanıcı sistemin iç detaylarını bilmeden kolayca işlem yapar

    Temel Fikir:
        - Alt sistemde birden fazla sınıf vardır. Facede sınıfı bu sınıfları içeriden yönetir ve dış dünyaya tek bir giriş noktası sunar

    Kullanım Alanları:
        - Karmaşık sistemlerde basi API sunmak istediğinde
        - Kod bağımlılığını azaltmak için
        - Büyük sistemlerde modüller arası iletişimi sadeleştirmek için

    Avantajları:
        - Kullanımı kolaylaştırır.
        - Bağımlılığı azaltır (loose coupling)
        - Kod okunabilirliğini artırır.
    Dezavantaj:
        - Fazla soyutlama bazen performans veya esneklik kaybı yaratabilir

    Kısaca:
        - Facade => "Tek kapıdan gir, tümm sistemi yönet." 
                 => Karmaşık sistemleri gizleyip basit bir kullanım sağlar



    UML DİAGRAM

        +----------------+
        |    Client      |
        +----------------+
                |
                v
        +----------------+
        |    Facade      |
        +----------------+
        | +Operation()   |
        +----------------+
          /          \
         /            \
        v              v
+----------------+   +----------------+
|  SubsystemA    |   |  SubsystemB    |
+----------------+   +----------------+
| +OperationA()  |   | +OperationB()  |
+----------------+   +----------------+
        
        Açıklaması:
                - Client: Sistemi kullanan kısım
                - Facade: Tüm alt sistemleri yöneten sade arayüz. Clien sadece bununla konuşur
                - SumsystemA / SubststemB: Gerçek işlemleri yapan modül
                - İlişki:
                    - Client -> Facade ( tek yönlü bağımlılık )
                    - Facade -> Sumsystem sınıfları (içeriden çağırır)

    */
    #endregion
}