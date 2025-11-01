using System;

namespace DecoratorBurgerOrnekNamespace
{
    // Decorator
    public abstract class BurgerDecorator : Burger
    {
        protected Burger _burger;
        public BurgerDecorator(Burger burger)
        {
            _burger = burger;
        }
    }
}
