using System;

namespace ProxyDesignPatternNamespace
{
    //RealSubject
    class RealBurger : IBurger
    {
        public void MakeBurger()
        {
            System.Console.WriteLine("RealBurger: Cheeseburger yapılıyor");
        }
    }
}