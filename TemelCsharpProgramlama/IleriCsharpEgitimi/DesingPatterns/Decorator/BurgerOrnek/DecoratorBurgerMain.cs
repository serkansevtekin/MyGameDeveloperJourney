using System;

namespace DecoratorBurgerOrnekNamespace
{
    class DecoratorBurgerClass
    {
        public static void DecoratorBurgerRunMain()
        {
            Burger myBurger = new BasicBurger();
            System.Console.WriteLine($"{myBurger.GetDescription()} : {myBurger.GetCost()}");

            //Burger üzerine peynir ve marul ekeledik
            myBurger = new Cheese(myBurger);
            myBurger = new Lettuce(myBurger);
            System.Console.WriteLine($"{myBurger.GetDescription()} : {myBurger.GetCost()}");

            //Üzerine domates de ekledik
            myBurger = new Tomato(myBurger);
            System.Console.WriteLine($"{myBurger.GetDescription()} : {myBurger.GetCost()}");

        }
    }

    #region Açıklama
        /*
        - BasicBurger temel sınıi değiştirilmiyor
        - Cheese, Lettuce, Tomato dekoratörler, burger'e ekstra özellik ekliyor
        - İstediğin kadar dekoratörü dinamik olarak zincirleyebilirsin
        - Böylece Open/Closed Principle sağlanıyor: var olan sınıfları değiltirmeden davranış ekliyorsun

     **   Örneğin UML ŞEMASI **
          
          
          +------------------+
          |     Burger       |  <<abstract class>>
          +------------------+
          | +GetDescription(): string |
          | +GetCost(): double       |
          +------------------+
                   ^
                   |
        +----------------------+
        |    BasicBurger       |  <<ConcreteComponent>>
        +----------------------+
        | +GetDescription(): string |
        | +GetCost(): double       |
        +----------------------+
                   ^
                   |
          +------------------+
          |  BurgerDecorator |  <<abstract class>>
          +------------------+
          | -_burger: Burger |
          | +GetDescription(): string |
          | +GetCost(): double       |
          +------------------+
                   ^
       --------------------------
       |            |            |
+---------------+ +------------+ +------------+
|    Cheese     | |  Lettuce   | |   Tomato   |  <<ConcreteDecorators>>
+---------------+ +------------+ +------------+
| +GetDescription(): string     |
| +GetCost(): double            |
+-------------------------------+


Uml açıklaması:
    * Burger: 
            - Tüm burger türlerinin ortak arabirimi tanımlar. Diğer sınıflar bu yapıya göre davranır

    * BurgerBasic: 
            - Temel burgerdir. En sade halidir. Üzerine dekoratörler eklenecektir

    * BurgerDecorator: 
            - Tüm dekoratörlerin temelini oluşturur. İçinde bir "Burger" nesnesi tutar ve  methodları ona  devreder

    * Cheese, Lettuce, Tomato: 
            - Her bir BurgerDecorator'dan türetilmiltir ve yeni özellik ekler.

**              **

        */
    #endregion
}

