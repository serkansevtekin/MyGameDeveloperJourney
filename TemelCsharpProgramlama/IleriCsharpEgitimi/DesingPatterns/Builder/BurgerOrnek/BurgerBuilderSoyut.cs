using System;

namespace BuilderDesignBurgerNameSpace
{
    //Abstact Builder (Soyut Yapıcı)
    // Tüm build'ların ortak davranışı
    public abstract class BurgerBuilder
    {
        protected Burger _buger = new Burger();

        public abstract void AddBread();
        public abstract void AddMeat();
        public abstract void AddCheese();
        public abstract void AddSauce();
        public abstract void AddVegetables();


//Ortak metot tüm build'lar kullanabilir
        public Burger GetBurger()
        {
            return _buger;
        }
    }
}