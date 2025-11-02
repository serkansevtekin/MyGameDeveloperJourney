using System;


namespace StrategyDesignPatternNamespace
{
    class StrategyDesignPatternBurgerOrnekClass
    {
        public static void StrategyDesignPatternBurgerOrnekRunMethod()
        {
            var burger = new Burger("Chese Burger");
            var context = new Context();

            // 1. Grill Stratejisi
            context.SetStrategy(new GrillStrategy());
            context.CookStrategy(burger);

            // 2. Fry Stratejisi
            context.SetStrategy(new FryStrategy());
            context.CookStrategy(burger);




        }
    }


    // Burger class
    class Burger
    {
        public string? Name { get; set; }

        public Burger(string name)
        {
            Name = name;
        }
    }


    //Strategy arayüzü
    interface IStrategy
    {
        void Cook(Burger burger);
    }

    //ConcreteStrategy 1
    class GrillStrategy : IStrategy
    {
        public void Cook(Burger burger)
        {
            System.Console.WriteLine($"{burger.Name} ızgarada pişiriliyor");
        }
    }

    //ConcreteStrategy 2
    class FryStrategy : IStrategy
    {
        public void Cook(Burger burger)
        {
            System.Console.WriteLine($"{burger.Name} tavada kızartılıyor");
        }
    }

    //Context sınıfı
    class Context
    {
        private IStrategy? _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            if (strategy == null)
            {
                throw new ArgumentNullException(nameof(strategy), "Strateji seçilmedi");
            }
            _strategy = strategy;

        }

        public void CookStrategy(Burger burger)
        {
           
            _strategy!.Cook(burger);
        }

    }
}