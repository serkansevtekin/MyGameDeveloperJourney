using System;


namespace FactoryMethodDesignNameSpace
{
    class FactoryMethodDesignClass
    {
        public static void FactoryMethodDesignMain()
        {
            // CustomerManager, hangi logger'ı kullanacağını bilmiyor.
            // LoggerFactory2 hangi logger'ı (LogFNetLogger) üreteciğne karar veriyor
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2());
            customerManager.Save();

            System.Console.WriteLine();

            //Unity ile alakalı Factory Örnek
            //Farklı fabrika seçilerek faklı ürünler üretilebilir

            // Concrete Creator seçimi -> OrcFactory Kullanılıyor
            // Bu satırda Game nesnesine hangi düşman üretileceğini söylüyoruz
            Game game = new Game(new WolfManFactory());
            game.Run();


        }
    }

    #region BTK

    // -------------------------------
    // 1️⃣ Factory Method Deseni Yapısı
    // -------------------------------

    // IloggerFactory = soyut Fabrika arayüzü
    // Hangi logger oluşturulacak, alt sınıflar karar verecek
    public interface ILoggerFactory
    {
        ILogger CreaterLogger();
    }

    // Ilogger = soyut ürün arayüzü
    // Loglama işleminin genel davranışı burada tanımlanır
    public interface ILogger
    {
        void Log();
    }


    // -------------------------------
    // 2️⃣ Somut Ürünler (Concrete Product)
    // -------------------------------

    public class EdLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with EdLogger");
        }
    }

    public class LogFNetLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged with LogFNetLogger");
        }
    }


    // -------------------------------
    // 3️⃣ Somut Fabrikalar (Concrete Factory)
    // -------------------------------

    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreaterLogger()
        {
            //Bussines kararı: EdLogger üertilecek
            return new EdLogger();
        }
    }

    public class LoggerFactory2 : ILoggerFactory
    {

        //Bussines kararı: LogFNetLogger üretilecek

        public ILogger CreaterLogger()
        {
            //Bussines to decide factory
            return new LogFNetLogger();
        }
    }



    // -------------------------------
    // 4️⃣ Factory Method kullanan sınıf
    // -------------------------------

    public class CustomerManager
    {
        private ILoggerFactory? _loggerFactory;

        // Constructor'da hangi fabrika kullanılacağını dışarıdan alıyoruz
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            System.Console.WriteLine("Saved!");

            // Nesneyi doğrudan new yapmıyoruz
            // Hangi logger kullanılacaksa fabrika karar veriyor
            ILogger logger = _loggerFactory!.CreaterLogger();
            logger.Log();
        }
    }
    #endregion

    #region Unity ile alakalı Factory Örnek
    // Product(Ürün) -> Ortak arayüz 
    // Tüm somut ürünleri (Orc Goblin) uygulayacağı ortak davranışları tanımlar
    public interface IEnemy
    {
        void Attack();
    }

    // Concrete Product(Somut Ürünler) -> Gerçek Sınıflar
    // Product arayüzünü (IEnemy) uygular ve kendi davranışını tanımlar
    public class Orc : IEnemy
    {
        public void Attack() => System.Console.WriteLine("Orc saldırdı!");
    }

    public class Goblin : IEnemy
    {
        public void Attack() => System.Console.WriteLine("Goblin saldırdı!");
    }

    public class WolFMan : IEnemy
    {
        public void Attack() => System.Console.WriteLine("WolfMan saldırdı!");
    }

    // Creator (Yaratıcı) -> Üretim metodunu tanımlar
    // Nesne oluşturma işlemini soyutlar (hangi düşman üretileceğini bilmez)
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy();
    }


    // Concrete Creator (Somut Yaratıcılar) -> Gerçek üreticiler
    // Hangi somut ürünü üreteceğine kendisi karar verir
    public class OrcFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy() => new Orc();
    }

    public class GoblinFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy() => new Goblin();
    }
    public class WolfManFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy() => new WolFMan();
    }

    // Client (İstemci) -> Factory'yi kullanarak nesne üretir, detayları bilmez
    public class Game
    {
        private readonly IEnemyFactory _factory;

        public Game(IEnemyFactory enemyFactory)
        {
            _factory = enemyFactory;
        }

        public void Run()
        {
            IEnemy enemy = _factory.CreateEnemy(); // Üretim Factory'ye devredildi
            enemy.Attack();
        }
    }

    #endregion




    #region Factory Method Design | Tanım
    /*
    Factory Method, nesne oluşturma işini alt sınıflara bırakan bir yaratıcı(Creational) tasarım desnidir.
    Yani:
        "Bir sınıf, hangi nesene oluşturuacağına kendisi karar vermez -- bunu alt sınıflar belirler"


    Amaç:
        - Nesne oluşturma işlemini merkezileştirmek
        - " new " bağımlılığını ortadan kaldırmak
        - Esnek ve genişletilebilir bir yapı kurmak
        - Nesne oluşturmayı soyutlamak, kod bağımlılığını azaltmak, esnekliği artırmak

        Basit Mantık:

                Normalde: 
                        var car = new BMW();

                Factory Method ile:
                        var car = carFactory.CreateCar();

            Yani "new" işlemi doğrudan değil, fabrika metodu üzerinden yapılır.
            Alt sınıf hangi nesneyi üreteceğine karar verir

    Örnek Yapılar:
            1. Product(Ürün) -> Ortak arayüz (örneğin: ICar)
            2. Concrete Product(Somut Ürünler) -> Gerçek Sınıflar (BMW, Mercedes)
            3. Creator(Yaratıcı) -> Üretim metodunu tanımlar (CarFactory)
            4. Concrete Creator(Somut Yaratıcılar) -> Gerçek üreticiler (BMWFactory, MercedesFactory)

    Unity'de Kullanım Örneği:
        Factory Method özellikle:
            * Düşman / karakter / mermi üretimi
            * UI element spawn sistemi
            * Item veya PowerUp üretimi

    */
    #endregion
}