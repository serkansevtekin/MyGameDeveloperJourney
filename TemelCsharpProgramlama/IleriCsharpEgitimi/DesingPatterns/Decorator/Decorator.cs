using System;

namespace DecoratorNamespace
{
    class DecoratorClass
    {
        public static void DecoratorRunMain()
        {
            var persneCar = new PersonelCar { Make = "BMW", Model = "3.20", HirePrice = 2500 };

            SpecialOffer specialOffer = new SpecialOffer(persneCar);
            specialOffer.DiscountPercentage = 10;
            System.Console.WriteLine("Concrete: {0}", persneCar.HirePrice);

            System.Console.WriteLine("Special Offer: {0}", specialOffer.HirePrice);

        }
    }

    abstract class CarBase
    {
        public abstract string? Make { get; set; }
        public abstract string? Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }


    class PersonelCar : CarBase
    {
        public override string? Make { get; set; }
        public override string? Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    class CommericalCar : CarBase
    {
        public override string? Make { get; set; }
        public override string? Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    abstract class CarDecoratorBase : CarBase
    {
        CarBase _carBase;

        public CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }
        public override string? Make { get; set; }
        public override string? Model { get; set; }
        public override decimal HirePrice
        {
            get
            {
                return _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage/100;
            }
            set
            {

            }
        }
    }




    #region Decorator Design Patter | Tanım
    /*
* Decorator Design Pattern, nesnelere ek işlevsellik eklemek için kullanılan yapısal bir tasarım desenidir.
* Temel amacı, var olan sınıfı değiştirmeden davranışını dinamik olarak genişletmektir.
* C#'ta genellikle  interface veya abstract class kullanılarak uygulanır.

Özet Manık:
    1) Component: Temel interface veya abstract class. Tüm nesneler bu yapıyı uygular
    2) ConcreteComponent: Orjinal sınıf, Temel işlevi sağlar
    3) Decorator: Component'i referans alır, interface'i uygular ve davranışı gerektiğinde değiştirir veya genişletir.
    4) Concrete decorator: Ek özellikleri ekleyen sınıf


 **   UML DİAGRAMI  **

          +------------------+
          |   Component      |  <<interface / abstract class>>
          +------------------+
          | +Operation()     |
          +------------------+
                   ^
                   |
        +----------------------+
        | ConcreteComponent    |
        +----------------------+
        | +Operation()         |
        +----------------------+
                   ^
                   |
          +------------------+
          |   Decorator      |  <<abstract class>>
          +------------------+
          | -component: Component |
          | +Operation()     |
          +------------------+
                   ^
                   |
        +----------------------+
        | ConcreteDecorator    |
        +----------------------+
        | +AddedBehavior()     |
        | +Operation()         |
        +----------------------+

        Açıklama:
            * Componenet: Temel interface veya abstract class
            * ConcreteComponent: Orjinal nesne, temel davranışı sağlar
            * Decorator: Component'i referans alır ve interface'i uygular
            * ConcreteDecorator: Ek davranış ekler, operation() override eder

 **                 **
    Avantajları:
        - Mevcut sınıfları değiştrimeden yeni davranış ekler
        - Birden fazla dekorator zincirlenebilir
        - Açık/Kapalı pirensibine uygundur (Open/Closed Principle)

    Dezavantajları:
        - Çok fazla dekorator ile karmaşık yapı oluşabilir
        - Hangi sınıf hangi dekoratörü kullandığını takip etmek zorlaşabilir.
    */
    #endregion
}