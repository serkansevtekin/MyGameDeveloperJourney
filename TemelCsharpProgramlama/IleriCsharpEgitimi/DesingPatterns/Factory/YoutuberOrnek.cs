using System;

namespace FactoryMethodDesignYoutuberOrnekNameSpace
{
    public class FactoryMethodDesignYoutuberOrnekClass
    {
        public static void FactoryMethodDesignYoutuberOrnekRunMethod()
        {
            // Concrete Creator (Somut Yaratıcılar)
            // Her PizzaStore kendi fabrikasyon mantığını uygular
            PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();
            PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();



            // Client (İstemci)
            // Client sadece OrderPizza çağırır, hangi pizza nasıl yapılır bilmez
            IPizza cheesePizza = ankaraPizzaStore.OrderPizza("cheese");
            System.Console.WriteLine("Cheese pizza ordered in Ankara Store");

            cheesePizza = istanbulPizzaStore.OrderPizza("cheese");
            System.Console.WriteLine("Cheese pizza ordered in Istanbul Store");



            IPizza veggiPizza = istanbulPizzaStore.OrderPizza("veggi");
            System.Console.WriteLine("Veggi pizza ordered in İstanbul Store");


        }
    }


    // Factory Method Design Pattern - Cretional Category // 
    //Amaç: Nesne oluşturmayı alt sınıflara bırakmak

    //1) Product (Ürün Arayüzü)
    // Tüm pizza türlerinin ortak davranışını tanımlar
    interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
    }

    //2) Concrete Product (Somut Ürünler)
    // Ürün arayüzünü (IPizza) uygular
    class ChesePizza : IPizza
    {
        public void Prepare()
        {
            System.Console.WriteLine("Chese Pizza Prepared ");

        }
        public void Bake()
        {
            System.Console.WriteLine("Chese Pizza Baked ");
        }

        public void Cut()
        {
            System.Console.WriteLine("Chese Pizza Cut ");

        }


    }

    class VeggiPizza : IPizza
    {
        public void Prepare()
        {
            System.Console.WriteLine("Veggi Pizza Prepared ");

        }
        public void Bake()
        {
            System.Console.WriteLine("Veggi Pizza Baked ");
        }

        public void Cut()
        {
            System.Console.WriteLine("Veggi Pizza Cut ");

        }
    }


    //3) Creator (Yaratıcı)
    // Pizza Oluşturma işini soyutlayan sınıf
    abstract class PizzaStore
    {
        // Factory Method: alt sınıflar bu metodu override edip kendi üretim mantığını verir
        protected abstract IPizza CreatePizza(string type);

        // Template Method: Pizza oluşturma sürecinin genel akışı tanımlıdır
        public IPizza OrderPizza(string type)
        {
            // Factory Method çağrılıyor -> Alt sınıf hangi pizza üretileceğini belirler.
            IPizza pizza = CreatePizza(type);

            // Ortak süreç (Tüm pizzalar için aynı adımlar)
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();

            return pizza;
        }
    }


    //4) Concrete Creator (Somut Yaratıcılar)
    // Hangi mağaza (Factory), hangi pizza üreteceğini kendi belirler
    class AnkaraPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(string type)
        {
            // burada hangi pizza ürertileceğine karar veriliyor
            return type switch
            {
                "cheese" => new ChesePizza(),
                "veggi" => new VeggiPizza(),
                _ => throw new ArgumentException("Invalid Pizza Type", nameof(type))
            };
        }
    }

    class IstanbulPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(string type)
        {
            //Bu şehirde farklı veya pizza türleri olabilir (ileride özelleştirilebilir)
            return type switch
            {
                "cheese" => new ChesePizza(),
                "veggi" => new VeggiPizza(),
                _ => throw new ArgumentException("Invalid Pizza Type", nameof(type))
            };
        }
    }
}