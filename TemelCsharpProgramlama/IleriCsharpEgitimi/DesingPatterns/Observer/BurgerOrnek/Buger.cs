using System;
using BuilderDesignBurgerNameSpace;
using CSharpProgramlama.IleriCSharpEgitimi;

namespace ObserverDesignPatternBurgerNamespace
{
    class ObserverDesignPatternBurgerClass
    {
        public static void ObserverDesignPatternBurgerRun()
        {
            BurgerManager manager = new BurgerManager();

            CustomerObserver customer1 = new CustomerObserver("Ali");
            CustomerObserver customer2 = new CustomerObserver("Zeynep");
            KithenObserver kitchen = new KithenObserver();
            InventoryObserver inventory = new InventoryObserver();


            manager.Attach(customer1);
            manager.Attach(customer2);
            manager.Attach(kitchen);
            manager.Attach(inventory);

            manager.AddBurger("Cheese Deluxe", 8.99);
            manager.AddBurger("Spicy Volcano", 10.49);

            manager.Detach(customer2);
            manager.AddBurger("Vegan Special", 9.25);




        }
    }




    //Observer arayüzü
    public interface IObserver
    {
        void Update(BurgerInfo info);
    }

    // Subject Arayüzü
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();

    }

    // Durum nesnesi (state)
    public class BurgerInfo
    {
        public string? Name { get; set; }
        public double Price { get; set; }
    }

    // Concrete Subject (Somut nesne)
    public class BurgerManager : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        private BurgerInfo? _latestBurger;
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var obs in _observers)
            {
                obs.Update(_latestBurger!);
            }
        }


        // Yeni burger duyurusu
        public void AddBurger(string name, double price)
        {
            _latestBurger = new BurgerInfo { Name = name, Price = price };
            System.Console.WriteLine($"\n [Manager] New burher relased:{name} ({price})");
            Notify();
        }

    }



    // Concrete Observer 1. Müşteri bildirimi
    public class CustomerObserver : IObserver
    {
        private readonly string _customerName;
        public CustomerObserver(string name)
        {
            _customerName = name;
        }
        public void Update(BurgerInfo info)
        {
            System.Console.WriteLine($"[Customer - {_customerName}] Yeni burger çıktı {info.Name}, fiyatı: {info.Price}");
        }
    }


    // Concrete Observer 2. Mutfak bildirimi
    public class KithenObserver : IObserver
    {
        public void Update(BurgerInfo info)
        {
            System.Console.WriteLine($"[Kitchen] Yeni burger menüye eklendi: {info.Name}. Malzemeler hazırlanıyor...");
        }
    }

    // Concrete Observer 3. Stok sistemi bildirimi
    public class InventoryObserver : IObserver
    {
        public void Update(BurgerInfo info)
        {
            System.Console.WriteLine($"[Inventory] {info.Name} için stok kontrolü başlatıldı");
        }
    }


    /*
    
    UML Diyagramı

+----------------------+
|      ISubject        |
+----------------------+
| +Attach(obs)         |
| +Detach(obs)         |
| +Notify()            |
+----------------------+
           ^
           |
+----------------------+
|   BurgerManager      |
+----------------------+
| -_observers          |
| -_latestBurger       |
+----------------------+
| +AddNewBurger()      |
| +Notify()            |
+----------------------+

+----------------------+
|      IObserver       |
+----------------------+
| +Update(info)        |
+----------------------+
           ^
           |
    ----------------------------
    |           |             |
+----------------+ +----------------+ +----------------+
|CustomerObserver| |KitchenObserver | |InventoryObserver|
+----------------+ +----------------+ +----------------+
| -_customerName |                 |                  |
+----------------+ +----------------+ +----------------+
| +Update(info)  | | +Update(info)  | | +Update(info)  |
+----------------+ +----------------+ +----------------+

    
    */
}