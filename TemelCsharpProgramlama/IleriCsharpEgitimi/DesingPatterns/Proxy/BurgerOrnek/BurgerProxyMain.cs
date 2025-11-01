using System;

namespace ProxyDesignPatternNamespace
{
    class BurgerProxyClass
    {
        public static void BurgerProxyRunMain()
        {
            BurgerProxy burgerProxy = new BurgerProxy();
            burgerProxy.MakeBurger();
        }
    }


    /*
              <<interface>>
          +------------------+
          |    IBurger       |
          +------------------+
          | +MakeBurger()    |
          +------------------+
                 ^
                 |
      ------------------------
      |                      |
+------------------+    +------------------+
|  RealBurger      |    |  BurgerProxy     |
+------------------+    +------------------+
| +MakeBurger()    |    | -realBurger: RealBurger |
+------------------+    +------------------+
                        | +MakeBurger()          |
                        +------------------------+

        Açıklama:
            * IBurger -> Ortak arayüz
            * RealBurger -> gerçek burger yapımını gerçekleştiren sınıf
            * BurgerProxy -> Sipariş kontrolü, erken erişim kontrolü veya önbellekleme eklemek için kullanılır
            * İstemci (Program) Proxy ile çalışıri gerçek nesneye dolaylı yoldan erişilir

    */
}