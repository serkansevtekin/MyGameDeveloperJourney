using System;

namespace Events
{
    class EventsClass
    {
        public static void EventsRun()
        {
            //Basic();

            /// Chatgpt ornek 1
            Player player = new Player();
            player.SkorDegisti += shor;
            player.SkorEkle(10);
            player.SkorEkle(10);

            /// Chatgpt ornek 2
            Button btn = new Button();
            btn.Click += BildirimGoster;
            btn.Click += Logla;

            // event tetikleniyor
            btn.Tikla();


        }
        /// Chatgpt ornek 2
        private static void Logla(string msg)
        {
            System.Console.WriteLine($"Log kaydı: {msg}");
        }

        private static void BildirimGoster(string msg)
        {
            System.Console.WriteLine($"Ekran bildirimi: {msg}");
           
        }
        /// Chatgpt ornek 1
        private static void shor(int yeniSkor)
        {
            System.Console.WriteLine($"Yeni skor: {yeniSkor}");
        }


        ///Kendi başına örnek
        private static void Basic()
        {
            //50 stoklu "Hard Disk" ürünü oluşturuluyor
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            //50 stoklu "gsm" ürünü oluşturuluyor
            Product gsm = new Product(50);
            gsm.ProductName = "GSM";

            //gsm ürünü için stok zaldığında tetiklenecek olaya abone oluyor
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }


        //event tetiklendiğinde çalışan metot
        private static void Gsm_StockControlEvent()
        {
            System.Console.WriteLine("Gsm about to finish!!");
        }
    }


    //Event imzası: parametresiz metotlar bu delegate'i kullanabilir
    public delegate void StockControl();
    public class Product
    {
        //event tanımı (nullable, null olabilir)
        public event StockControl? StockControlEvent;

        public string? ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                //Eğer stok 15 veya altına düşerse event tetiklenir
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            System.Console.WriteLine("{1} Stock amount: {0}", Stock, ProductName);
        }
    }




    /// Chatgpt ornek 1
    class Player
    {
        public delegate void SkorDegistiHandler(int yeniSkor);
        public event SkorDegistiHandler? SkorDegisti;

        int skor = 20;
        public void SkorEkle(int puan)
        {
            skor += puan;
            SkorDegisti?.Invoke(skor); // event tetikleniyor
        }

    }

    /// Chatgpt ornek 2
    class Button
    {
        public delegate void ClickHandler(string msg);
        public event ClickHandler? Click;

        public void Tikla()
        {
            System.Console.WriteLine("Butona tıklandı");
            Click!.Invoke("Buton olayı tetiklendi");
        }
    }

    #region Tanım
    /*
    
    Event (olay), C#'ta nesnede gerçekleşen durumu diğer nsenelere bildirmek için kullanılır.
    
    Temel Yapı:  Delegate + event + event tetikleme (invoke)

    Özet:
        - Delegate -> Olayın imzasını tanımlar (hangi parametreleri taşıyacak)
        - Event -> Bu olayı dış dünyaya açar (abone olunabilir ama dışarıda tetiklenemez)
        - Subscriber (Aboneler) -> " += " ile olaya bağlanır
        - Publisher (Yayıncı) -> Olay gerçekleştiğinde eventName?.Invoke() ile bildirilir

    */
    #endregion
}