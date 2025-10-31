using System;


namespace FacadeDesignPatternNamespace
{
    //Soyut yapılar 
    interface IBun { void Toast(); }
    interface IPatty { void Grill(); }
    interface IVeggies { void AddVegies(); }
    interface ISauce { void ApplySauce(); }
    interface ICheese
    {
        void Mozzerella();
        void Cheader();
    }

    //Somut Yapılar
    public class Bun : IBun
    {
        public void Toast()
        {
            System.Console.WriteLine("Ekmek kızartıldı");
        }
    }

    public class Patty : IPatty
    {
        public void Grill()
        {
            System.Console.WriteLine("Burger köftesi pişirildi");
        }
    }

    public class Veggies : IVeggies
    {
        public void AddVegies()
        {
            System.Console.WriteLine("Sebzeler eklendi (marul, domates, soğan)");
        }
    }

    public class Sauce : ISauce
    {
        public void ApplySauce()
        {
            System.Console.WriteLine("Sosylar uygulandı (ketçap, Mayonez )");
        }
    }

    public class Cheese : ICheese
    {
        public void Cheader()
        {
           System.Console.WriteLine("Cheader Eklendi");
        }

        public void Mozzerella()
        {
           System.Console.WriteLine("Mozzerella eklendi");
        }
    }

}