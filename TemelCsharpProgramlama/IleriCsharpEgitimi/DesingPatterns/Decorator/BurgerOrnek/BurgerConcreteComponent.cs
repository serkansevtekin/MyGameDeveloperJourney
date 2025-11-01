using System;

namespace DecoratorBurgerOrnekNamespace
{
    // ConcreteComponent
    public class BasicBurger : Burger
    {
        public override double GetCost()
        {
            return 5.0;
        }

        public override string GetDescription()
        {
            return "Basic Burger";
        }
    }
}
