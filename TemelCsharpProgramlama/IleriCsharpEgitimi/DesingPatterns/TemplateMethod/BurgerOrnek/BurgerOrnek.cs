using System;
using System.Collections.Specialized;

namespace TemplateMethodDesignPatternNamespace
{
    class TemplateMethodDesignPatternBurgerOrnekClass
    {
        public static void TemplateMethodDesignPatternBurgerOrnekRunMain()
        {
            ABurgerMaker beefBurger = new BeefBurger();
            beefBurger.MakeBurger("Burger Paketleniyor");

            System.Console.WriteLine("---------------");

            ABurgerMaker chickenBurger = new ChickenBurger();
            chickenBurger.MakeBurger("Burger Hazır");

        }
    }


    //Template Soyut Sınıf
    public abstract class ABurgerMaker
    {
        public string? state;
        //Template Method
        public void MakeBurger(string state)
        {
            AddBun();
            AddPatty();
            AddToppings();
            Serve(state);
        }



        protected abstract void AddToppings();

        protected abstract void AddPatty();

        protected abstract void AddBun();

        protected virtual void Serve(string state)
        {
            System.Console.WriteLine(state);
        }
    }

    // Concrete Class 1
    public class BeefBurger : ABurgerMaker
    {
        protected override void AddBun()
        {
            System.Console.WriteLine("Susamlı ekmek eklendi");
        }

        protected override void AddPatty()
        {
            System.Console.WriteLine("Dana köfte pişirilip eklendi");
        }

        protected override void AddToppings()
        {
            System.Console.WriteLine("Marul Domates ve cheddar eklendi");
        }

        protected override void Serve(string state)
        {
           System.Console.WriteLine(state);
        }
    }


    //Concrete class 2
    public class ChickenBurger : ABurgerMaker
    {
        protected override void AddBun()
        {
            System.Console.WriteLine("Tam buğday ekmeği eklendi");
        }

        protected override void AddPatty()
        {
           System.Console.WriteLine("Tavuk köfte eklendi");
        }

        protected override void AddToppings()
        {
            System.Console.WriteLine("Turşu, mayonez ve marul eklendi");
        }

        protected override void Serve(string state)
        {
            System.Console.WriteLine(state);
        }
    }

}