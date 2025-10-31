using System;

namespace BuilderDesignBurgerNameSpace
{
    public class ChickenBurgerBuilder : BurgerBuilder
    {
        public ChickenBurgerBuilder(string Name)
        {
            _buger.Name = Name;
        }
        public override void AddBread() => _buger.AddIngredient("Susamlı Ekmek");

        public override void AddCheese() => _buger.AddIngredient("Mozzerella");

        public override void AddMeat() => _buger.AddIngredient("Tavuk Göğsü");

        public override void AddSauce() => _buger.AddIngredient("Ranch Sos");

        public override void AddVegetables() => _buger.AddIngredient("Marul + Salatalık");
    }
}