using System;

namespace DecoratorBurgerOrnekNamespace
{

    // ConcreteDecorator 1
    public class Cheese : BurgerDecorator
    {
        public Cheese(Burger burger) : base(burger) { }

        public override double GetCost()
        {
            return _burger.GetCost() + 1.0;
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Cheese";
        }
    }



    // ConcreteDecorator 2
    public class Lettuce : BurgerDecorator
    {
        public Lettuce(Burger burger) : base(burger)
        {

        }

        public override double GetCost()
        {
            return _burger.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Lettuce";
        }
    }

    // ConcreteDecorator 3
    public class Tomato : BurgerDecorator
    {
        public Tomato(Burger burger):base(burger)
        {
            
        }
        public override double GetCost()
        {
            return _burger.GetCost() + 0.7;
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Tomato";
        }
    }

   
}
