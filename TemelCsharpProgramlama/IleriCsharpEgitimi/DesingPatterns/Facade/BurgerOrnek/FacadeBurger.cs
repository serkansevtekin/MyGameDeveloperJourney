using System;


namespace FacadeDesignPatternNamespace
{

    public class BurgerFacade
    {

        CrossCuttingConcernsBurger _corners;
        public BurgerFacade()
        {
            _corners = new CrossCuttingConcernsBurger();
        }

        public void CheaderBurger()
        {
            System.Console.WriteLine("Cheder Burger hazırlanıyor:");
            _corners._bun.Toast();
            _corners._patty.Grill();
            _corners._cheese.Cheader();
            _corners._veggies.AddVegies();
            _corners._sauce.ApplySauce();

            System.Console.WriteLine("Chedar Burger Hazır \n");
        }


        public void MozzerellaBurger()
        {
            System.Console.WriteLine("Mozzerella Burger hazırlanıyor:");
            _corners._bun.Toast();
            _corners._patty.Grill();
            _corners._cheese.Mozzerella();
            _corners._veggies.AddVegies();
            _corners._sauce.ApplySauce();
            System.Console.WriteLine("Mozzerella Burger Hazır \n");
        }

        public void VeggiesBurger()
        {
            System.Console.WriteLine("Veggies Burger hazırlanıyor:");
            _corners._bun.Toast();
            _corners._patty.Grill();
            _corners._veggies.AddVegies();
            _corners._sauce.ApplySauce();
            System.Console.WriteLine("Veggies Burger Hazır \n");
        }


    }

    class CrossCuttingConcernsBurger
    {
        public IBun _bun;
        public IPatty _patty;
        public IVeggies _veggies;
        public ISauce _sauce;
        public ICheese _cheese;

        public CrossCuttingConcernsBurger()
        {
            _bun = new Bun();
            _patty = new Patty();
            _veggies = new Veggies();
            _sauce = new Sauce();
            _cheese = new Cheese();
        }
    }

}