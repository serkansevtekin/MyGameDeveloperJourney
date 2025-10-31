using System;

namespace BuilderDesignBurgerNameSpace
{
    class BuilderDesignBurgerClass
    {
        public static void BuilderDesignBurgerRunMain()
        {
            BurgerDirector director = new BurgerDirector();

            
            //1.Cheese Burger
            BurgerBuilder cheeseBuilder = new CheeseBurgerBuilder("Peynirli Burger");
            director.MakeBurger(cheeseBuilder);
            Burger cheeseBurger = cheeseBuilder.GetBurger();
            cheeseBurger.ShowBurger();

            //2. Chicken Burger
            BurgerBuilder chickenBuilder = new ChickenBurgerBuilder("Tavuklu Burger");
            director.MakeBurger(chickenBuilder);
            Burger chickenBurger = chickenBuilder.GetBurger();
            chickenBurger.ShowBurger();
        }
    }
}