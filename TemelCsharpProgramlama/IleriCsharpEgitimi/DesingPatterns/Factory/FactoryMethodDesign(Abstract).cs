using System;

namespace FactoryMethodDesignAbstractNameSpace
{
    class FactoryMethodDesignAbstractClass
    {
        public static void FactoryMethodDesignAbstractRun()
        {
            ProductManager productManager = new ProductManager(new Factory2());
            productManager.GetAll();

            System.Console.WriteLine();
            //AI ORnek

            Game game = new Game(new OrcFactory());
            game.Run();

            game = new Game(new GoblinFacory());
            game.Run();

        }
    }

    #region BTK
    public abstract class Logging
    {
        public abstract void Log();
    }

    class Log4NetLogger : Logging
    {
        public override void Log()
        {
            System.Console.WriteLine("Log4NetLogger");
        }
    }

    class NLogger : Logging
    {
        public override void Log()
        {
            System.Console.WriteLine("NLogger");

        }
    }

    public abstract class Caching
    {
        public abstract void Cache();
    }

    public class MemCache : Caching
    {
        public override void Cache()
        {
            System.Console.WriteLine("MemCache");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache()
        {
            System.Console.WriteLine("RedisCache");
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }

    public class ProductManager : IProduct
    {
        private Logging _logging;
        private Caching _caching;
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogger();
            _caching = _crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log();
            _caching.Cache();
            System.Console.WriteLine("Prducts Listed!");
        }
    }

    public interface IProduct
    {
        void GetAll();
    }
    #endregion

    #region AI

    // Abstract Products
    public interface IEnemy { void Attack(); }
    public interface IWeapon { void Use(); }

    //Concrete Products
    public class Orc : IEnemy { public void Attack() => System.Console.WriteLine("Ork Saldırı"); }
    public class OrcWeapon : IWeapon { public void Use() { System.Console.WriteLine("Orc Kılıcını Kullandı"); } }

    public class Goblin : IEnemy { public void Attack() { System.Console.WriteLine("Goblin Saldırı"); } }
    public class GoblinWeapon : IWeapon { public void Use() { System.Console.WriteLine("Goblin mızrağını fırlattı"); } }

    //Abstract Factory
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy();
        IWeapon CreateWeapon();
    }

    //Concrete Factory
    public class OrcFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy() => new Orc();

        public IWeapon CreateWeapon() => new OrcWeapon();
    }

    public class GoblinFacory : IEnemyFactory
    {
        public IEnemy CreateEnemy() => new Goblin();

        public IWeapon CreateWeapon() => new GoblinWeapon();
    }


    //Client
    public class Game
    {
        private readonly IEnemy _enemy;
        private readonly IWeapon _weapon;

        public Game(IEnemyFactory factory)
        {
            _enemy = factory.CreateEnemy();
            _weapon = factory.CreateWeapon();
        }

        public void Run()
        {
            _enemy.Attack();
            _weapon.Use();
        }
    }


    #endregion

    #region  Tanım
    /*
    Abstract Factroy Design Pattern

    Amaç: Birbiriyle ilişkili nesneleri (ürün aileleri) oluşturmak için bir arayüz tanımlar;
            ancak bu nesnelerin tam olarak hangi sınıftan üretileceğini alt sınıflara bırakır.

        Yani: "Orc düşmanını ve onun silahını" aynı anda üretebilmek istiyorsan Abstract Factory tam yeridir.

    Temel Bileşenler
        1. Abstract Factory (Soyut Fabrika)
            - Ürün ailelerinin nasıl üretileceğini tanımlar
        2. Concrete Factory (Somut Fabrika)
            - Abstract Factoriy'yi uygular ve belli bir ürün ailesini oluşturur
        3. Abstract Product (Soyut Ürün)
            - Her ürün ailesinin ortak arayüzü
        4. Concrete Product (Somut ürün)
            - Gerçek Sınıflar
        5. Client (İstemci)
            - Factory'yi kullanır ama hangi ürünün üretildiğini bilmez
        
    */
    #endregion

}