using System;

namespace DecoratorBurgerOrnekNamespace
{
    
    //Component
    public abstract class Burger
    {
        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
