using System;
using System.Collections;

namespace CompositeDesignPatternNamespaces
{
    class CompositeDesignPatternBurgerClass
    {
        public static void CompositeDesignPatternBurgerRunMethod()
        {
            // Leafler
            var lettuce = new Ingredient("Lettuce");
            var tomato = new Ingredient("Tomato");
            var cheese = new Ingredient("cheese");
            var patty = new Ingredient("patty");

            //Composite burger
            var burger = new BurgerComposite("Cheseburger", 200);
            burger.Add(lettuce);
            burger.Add(tomato);
            burger.Add(cheese);
            burger.Add(patty);
         

            var chickenBurger = new BurgerComposite("Chicken burger", 300);
            chickenBurger.Add(lettuce);
            chickenBurger.Add(tomato);
            chickenBurger.Add(cheese);
            chickenBurger.Add(patty);

            // Daha büyük bir burger menüsü
            var menu = new BurgerComposite("Burger Menu");
            menu.Add(burger);
            menu.Add(chickenBurger);

            menu.Display();



        }
    }

    //UML Uyumlu örnek

    // Component
    interface IComponent
    {
        string? Name { get; }

        void Display(int depth = 0);
        decimal GetPrice();
    }


    // Leaf - tek bir malzeme
    class Ingredient : IComponent
    {
        public string? Name { get; set; }


        public Ingredient(string name) => Name = name;

        public void Display(int depth = 0)
        {
            System.Console.WriteLine($"- {depth} {Name} ");
        }

        public decimal GetPrice()
        {
            return 0;// leaf'ib fiyatı yok
        }
    }

    // Composite - Birden fazla bileşen içerebilir (katmanlı burger)
    class BurgerComposite : IComponent
    {
        public string? Name { get; private set; }
        public decimal Price { get; private set; } // Sadece composite giyat var
        private List<IComponent> _children = new List<IComponent>();


        public BurgerComposite(string name, decimal price = 0)
        {
            Name = name;
            Price = price;
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public void Display(int depth = 0)
        {
            System.Console.WriteLine($"- {depth} {Name} {Price}");
            foreach (var child in _children)
            {
                child.Display(depth + 2);
            }

        }

        public decimal GetPrice()
        {
            return Price;// Sadece kendi fiyatını döndürür

        }
    }
}