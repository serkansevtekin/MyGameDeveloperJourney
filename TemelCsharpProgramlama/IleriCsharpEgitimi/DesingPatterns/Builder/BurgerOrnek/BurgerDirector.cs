using System;

namespace BuilderDesignBurgerNameSpace
{

    //Directory (Yapım sürecini Yönetir)
    //Burgerin hangi sıra ile oluşturulacağını belirler
    public class BurgerDirector
    {
        public void MakeBurger(BurgerBuilder builder)
        {
            builder.AddBread();
            builder.AddMeat();
            builder.AddCheese();
            builder.AddSauce();
            builder.AddVegetables();
        }
    }
}