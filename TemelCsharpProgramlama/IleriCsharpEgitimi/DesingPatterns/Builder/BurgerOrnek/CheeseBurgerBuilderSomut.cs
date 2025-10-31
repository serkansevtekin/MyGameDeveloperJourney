using System;

namespace BuilderDesignBurgerNameSpace
{
    public class CheeseBurgerBuilder : BurgerBuilder
    {

        public CheeseBurgerBuilder(string Name)
        {
            _buger.Name = Name;
        }
        public override void AddBread() => _buger.AddIngredient("Susamlı Ekmek");

        public override void AddCheese() => _buger.AddIngredient("Cheaddar Peyniri");

        public override void AddMeat() => _buger.AddIngredient("Dana Eti");

        public override void AddSauce() => _buger.AddIngredient("Ketçap + Mayanoz");

        public override void AddVegetables() => _buger.AddIngredient("Marul + Domates");
    }
}