using System;

namespace ObserverDesignPatternBurgerMusteriBazliNamespace
{
    class ObserverDesignPatternBurgerMusteriBazliClass
    {
        public static void ObserverDesignPatternBurgerMusteriBazliRunMethod()
        {

            var panino = new OrderSubject("Panino");

            var orderPizza = new CustomerOrderObserver("Ali");
            panino.Attach(orderPizza);
            panino.SetOrderStatus(OrderStatus.Hazirlaniyor);
            panino.SetOrderStatus(OrderStatus.Pisiriliyor);
            panino.SetOrderStatus(OrderStatus.TeslimEdildi);

            System.Console.WriteLine();

            var BurgerKing = new OrderSubject("Burger King");

            var orderBurger = new CustomerOrderObserver("Zeynep");
            BurgerKing.Attach(orderBurger);
            BurgerKing.SetOrderStatus(OrderStatus.IptalEdildi);

            /*  //Ali'nin süpariş süreci
             OrderSubject aliOrder = new OrderSubject("Ali");
             CustomerOrderObserver aliObserver = new CustomerOrderObserver("Ali");
             CustomerOrderObserver ahmetObserver = new CustomerOrderObserver("Ahemt");
             aliOrder.Attach(aliObserver);
             aliOrder.Attach(ahmetObserver);







             //Zeynep'in sipariş süreci
             var zeynepOrder = new OrderSubject("Zeynep");
             var zeynepObserver = new CustomerOrderObserver("Zeynep");
             zeynepOrder.Attach(zeynepObserver);


             // Her biri kendi siparişini güncelliyor
             aliOrder.SetOrderStatus("Hazırlanıyor");
             System.Console.WriteLine();
             aliOrder.SetOrderStatus("Pişiriliyor");
             System.Console.WriteLine();
             zeynepOrder.SetOrderStatus("Hazırlanıyor");
             System.Console.WriteLine();
             zeynepOrder.SetOrderStatus("Teslim edildi"); */
        }
    }

    public enum OrderStatus
    {
        Hazirlaniyor,
        Pisiriliyor,
        TeslimEdildi,
        IptalEdildi
    }

    public interface IOrderObserver
    {
        void Update(OrderStatus status);
    }

    public interface ISubject
    {
        void Attach(IOrderObserver observer);
        void Detach(IOrderObserver observer);
        void Notify();
    }

    public class OrderSubject : ISubject
    {
        private readonly List<IOrderObserver> _observers = new List<IOrderObserver>();
        private OrderStatus _orderStatus;

        public string? ShopName { get; }
        public OrderSubject(string shopName)
        {
            ShopName = shopName;
            System.Console.WriteLine($"{ShopName} dükkanı açıldı");
        }

        public void SetOrderStatus(OrderStatus newStatus)
        {
            _orderStatus = newStatus;
            Notify();
        }


        public void Attach(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var obs in _observers)
            {
                obs.Update(_orderStatus!);
            }
        }
    }


    // Concrete Observer (Müşterinin kendi izleyicisi)

    public class CustomerOrderObserver : IOrderObserver
    {
        private string _name { get; }
        public CustomerOrderObserver(string name)
        {
            _name = name;
        }
        public void Update(OrderStatus status)
        {
            System.Console.WriteLine($"Bildirim -> {_name}: Siparişim '{status}' durumuna geçti");

            if (status == OrderStatus.IptalEdildi)
            {
                System.Console.WriteLine("Para geri ödendi");
            }
        }
    }




    /*
    
    UML ŞEMASI

+-------------------+
|   IOrderObserver  |
+-------------------+
| +Update(status)   |
+-------------------+
          ^
          |
+-------------------------+
| CustomerOrderObserver   |
+-------------------------+
| -_name                  |
+-------------------------+
| +Update(status)         |
+-------------------------+

+-------------------+
|   OrderSubject    |
+-------------------+
| -_orderStatus     |
| -_observers       |
| +CustomerName     |
+-------------------+
| +Attach()         |
| +Detach()         |
| +SetOrderStatus() |
| -Notify()         |
+-------------------+

    */
}