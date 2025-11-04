using System;

namespace CommandDesignPatternNamespace
{
    class CommandDesignPatternClass
    {
        public static void CommandDesignPatternRun()
        {
            // Receiver: işlemleri gerçekten yapan nesne
            StockManager stockManager = new StockManager();

            // ConcreteCommand nesneleri oluşturuluyor
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);

            // Invoker: Komutları sırasıyla çalıştıran sınıf
            StockController stockController = new StockController();

            //Komutlar (siparişler) sıraya alınıyor
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(buyStock);

            // Tüm komutlar sırayla uygulanıyor
            stockController.PlaceOrders();


        }
    }

    // Receiver sınıfı: Asıl işlemleri yapan taraf
    class StockManager
    {
        private string? _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {

            _quantity++;
            System.Console.WriteLine("Stock: {0}, {1} bought!", _name, _quantity);
        }

        public void Sell()
        {
            _quantity--;
            System.Console.WriteLine("Stock: {0}, {1} sold!", _name, _quantity);

        }

    }

    // Komut arayüzü: Tüm komutlar aynı execute metodunu taşır
    interface IOrder
    {
        void Execute();

    }

    // ConcreteCommand 1: Alım işlemi
    class BuyStock : IOrder
    {
        private StockManager? _stockManager;

        public BuyStock(StockManager? stockManager)
        {
            _stockManager = stockManager;
        }

        // Execute çağrıldığında Receiver’daki Buy() çalışır
        public void Execute()
        {
            _stockManager!.Buy();
        }
    }
    // ConcreteCommand 2: Satış işlemi
    class SellStock : IOrder
    {
        private StockManager? _stockManager;

        public SellStock(StockManager? stockManager)
        {
            _stockManager = stockManager;
        }

        // Execute çağrıldığında Receiver’daki Sell() çalışır
        public void Execute()
        {
            _stockManager!.Sell();
        }
    }

    // Invoker: Komutları sıraya alır ve uygular
    class StockController
    {
        List<IOrder> _orders = new List<IOrder>();

        // Komut (sipariş) listeye eklenir
        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }

        //Listedeki tüm komutlar sırayla çalıştırılır
        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear(); // Çalşıştıktan sonra liste temizlenir
        }
    }


    /*
    Özet:
        StockManager: Receiver – işi yapan sınıf.

        BuyStock, SellStock: ConcreteCommand – her biri belirli işlemi temsil eder.

        IOrder: Command arayüzü – tüm komutlar aynı arayüzü paylaşır.

        StockController: Invoker – komutları sıraya koyar ve yürütür.

        CommandDesignPatternRun: Client – sistemi kurar, komutları oluşturur ve Invoker’a iletir.

        Bu örnek klasik Command Pattern (Queue tabanlı) yapısının birebir karşılığıdır.


    YUKARIDAKİ KODUN UML ŞEMASI

    +------------------+        +--------------------+        +------------------+
    |     Client       |        |      Invoker       |        |     Receiver     |
    | (Main Method)    |        | StockController    |        |  StockManager    |
    +------------------+        +--------------------+        +------------------+
    | - buyStock       |        | - _orders: List<IOrder>    | - _name          |
    | - sellStock      |        |--------------------|        | - _quantity      |
    |------------------|        | + TakeOrder(cmd)   |        |------------------|
    | + CommandDesign..|------->| + PlaceOrders()    |------->| + Buy()          |
    |                  |        +--------------------+        | + Sell()         |
    +------------------+                                         +----------------+
             |
             |
             v
    +-------------------+
    |     IOrder        |  << Command >>
    +-------------------+
    | + Execute()       |
    +-------------------+
             ^
             |
             +-----------------------------+
             |                             |
    +-------------------+          +-------------------+
    |   BuyStock        |          |   SellStock       |
    +-------------------+          +-------------------+
    | - _stockManager   |          | - _stockManager   |
    |-------------------|          |-------------------|
    | + Execute()       |          | + Execute()       |
    +-------------------+          +-------------------+

| UML Rolü                | Koddaki Sınıf               | Açıklama                                             |
| ----------------------- | --------------------------- | ---------------------------------------------------- |
| **Client**              | `CommandDesignPatternRun()` | Komutları oluşturur ve Invoker’a gönderir.           |
| **Command (interface)** | `IOrder`                    | Tüm komutlar `Execute()` metodunu uygular.           |
| **ConcreteCommand**     | `BuyStock`, `SellStock`     | Her biri `StockManager` üzerinde farklı işlem yapar. |
| **Receiver**            | `StockManager`              | Gerçek işi yapan sınıf (`Buy`, `Sell`).              |
| **Invoker**             | `StockController`           | Komutları sıraya alır ve uygular.                    |



    */


    #region Command Design Pattern | Tanım
    /*

Command Design Pattern, bir isteği (komutu) nesne olarak kapsüller. Böylece istekler sıralanabilir, kaydedilebilir , geri alınabilir (umdo yapılabilir) hale gelir. 
Ana Amaç: Komutu gönderen (Invoker) ile komutu gerçekleştiren (Receiver) arasında gevşek bağlılık sağlamak

Temel Mantık:

            * Command (Arayüz): Tüm komutların ortak Execute() metodunu tanımlar
            * ConcreteCommand: Belirli bir işlemi temsil eder, Receiver üzerinde bir eylemi çağırır
            * Receiver: Gerçek iş yapan sınıftır
            * Invoker: Komutları çalıştıran sınıftır
            * Client: Komut nesnelerini oluşturur ve ilişkilendirme yapar

Kullanım Alanları:

            - Undo/Rendo işlemleri
            - Input işlemleri (Oyuncu eylemleri)
            - Makre veya Replay sistemleri
            - AI eylemeleri
            - Event veya cutscene sistemlerinde

Kısaca:
    Unity'de çok temel projelerde gerekmez ama orta-büyük oyunlarda, özellikle Editor tool, komut kaydı, inpur-action sistemleri gibi yapılara Command Pattern kullanıı oldukça yaygındır

*** UML ŞEMASI ***



+----------------+       +-------------------+       +----------------+
|    Client      |       |      Invoker      |       |    Receiver    |
+----------------+       +-------------------+       +----------------+
|                |       | - _command:Command|       | + Action()     |
|----------------|       |-------------------|       +----------------+
| + Main()       |-----> | + SetCommand(c)   |                ^
|                |       | + ExecuteCommand()|                |
+----------------+       +-------------------+                |
                             |                             |
                             v                             |
                   +-------------------+                   |
                   |    Command        |<------------------+
                   +-------------------+
                   | + Execute()       |
                   +-------------------+
                             ^
                             |
                   +-------------------+
                   | ConcreteCommand   |
                   +-------------------+
                   | - _receiver:Receiver|
                   | + Execute()         |
                   +-------------------+

    ***             ***




    */
    #endregion
}