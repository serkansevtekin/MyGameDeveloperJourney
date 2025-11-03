using System;

namespace ObserverPatternNamespace
{
    class ObserverPatternClass
    {
        public static void ObserverPatternRunMethod()
        {
            // Gözlemciler oluşturuluyor
            CustomerObserver customerObserver = new CustomerObserver();
            EmployeeObserver employeeObserver = new EmployeeObserver();

            // Gözlemlenen nesne (Subject) oluşturuluyor
            ProductManager manager = new ProductManager();

            // Gözlemciler ProductManager'a ekleniyor
            manager.Attach(employeeObserver);
            manager.Attach(customerObserver);

            // Bir gözlemci çıkarılıyor (artık bildirim alamayack)
            manager.Detach(customerObserver);

            // ürün fiyatı değiştiriliyor -> kalan gözlemcilere bildirim gider
            manager.UpdatePrice();

        }
    }

    // SUBJECT (Gözlenen nesne)
    class ProductManager
    {
        // Gözlemcileri tuttan liste
        List<AObserver> _observers = new List<AObserver>();

        // Ürünün fiyatı değiştiğinde çağrılan metot
        public void UpdatePrice()
        {
            System.Console.WriteLine("Product price changed");
            Notify();// Tüm gözlemcilere haber ver
        }

        // Yeni gözlemci ekleme
        public void Attach(AObserver observer)
        {
            _observers.Add(observer);
        }

        // Gözlemci çıkarma
        public void Detach(AObserver observer)
        {
            _observers.Remove(observer);
        }

        //Tüm gözlemcileri bilgilendirme

        private void Notify()
        {
            foreach (var obs in _observers)
            {
                obs.Update();// her gözlemci kendi Update() metodunu çalıştırır
            }
        }
    }

    // OBSERVER (Soyut gözlemci)
    abstract class AObserver
    {
        public abstract void Update(); // Her alt sınıf kendi bildirim davranışını tanımlar
    }

    // CONCRETE OBSERVER 1
    class CustomerObserver : AObserver
    {
        public override void Update()
        {
            System.Console.WriteLine("Message to customer: Product price changed!");
        }
    }


    // CONCRETE OBSERVER 2
    class EmployeeObserver : AObserver
    {
        public override void Update()
        {
            System.Console.WriteLine("Message to employee: Product price changed!");

        }
    }
    /*
    Bu haliyle kodun işleyişi: => state yok , sadece bildirim var
        1) "ProductManager" gözlemlenen sınıftır
        2) "AObserver" soyut gözlemci arayüzüdür
        3) "CustomerObserver" ve "EmployeeObserver", gözlemci rollerini üstlenir
        4) "UpdatePrice()" çağrıldığında "Notify()" metodu aktif gözlemcilere bildirim gönderir
    */



    #region Observer Pattern | Tanım
    /*
Observer pattern (Gözlemci deseni), bir nesnenin durumu değiştiğinde, bu durumu ilgilenen diğer nesnelere otomatik olarak bildirilmesini sağlayan bir davranışsal tasarım desenidir. 
* Unity, UI ve oyun olaylarını yönetirken çok kullanışlıdır. 
* Amaç:
        - Bir nesnede (Subject) değişiklik olduğunda, ona bağlı gözlemcileriin (Observer) otomatik olarak haberdar edilmesini sağlamak

** UML ŞEMASI **


    +----------------+
    |    Subject     |
    +----------------+
    | -observers     |
    | -state         |
    +----------------+
    | +Attach()      |
    | +Detach()      |
    | +Notify()      |
    +----------------+
             |
             |
             v
    +----------------+
    |   IObserver    |
    +----------------+
    | +Update(state) |
    +----------------+
             ^
             |
    +-------------------+
    | ConcreteObserver  |
    +-------------------+
    | -name             |
    +-------------------+
    | +Update(state)    |
    +-------------------+


Uml Açıklama:
    - Subject durumu değiştikçe tğm bağlı gözlemcilere (IObserver) haber verir
    - Unity'de Event ve Action ile benzer işlevler gözlemci olarak kullanıla bilir
**            **
    */
    #endregion
}