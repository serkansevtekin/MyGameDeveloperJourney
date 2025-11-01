using System;

namespace ProxyDesignPatternNamespace
{
    class BurgerProxy : IBurger
    {
        private RealBurger? _realBurger;
        public void MakeBurger()
        {
            // Ön kontrol veya ek işlem
            if (_realBurger == null)
            {
                _realBurger = new RealBurger();// Lazy initialization
            }
            System.Console.WriteLine("BurgerProxy: Sipariş kontrol ediliyor...");
            _realBurger.MakeBurger();
        }
    }
}