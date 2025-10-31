using System;

namespace AdapterDesignPatternNamespace
{
    class AdapterDesignPatternClass
    {
        public static void AdapterDesignPatternRun()
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();
        }
    }

    class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.log("User Data");
            System.Console.WriteLine("Saved!");
        }
    }

    interface ILogger
    {
        void log(string message);
    }

    class EdLogger : ILogger
    {
        public void log(string message)
        {
            System.Console.WriteLine($"Logged {message}");
        }
    }

    //Farzı mishal (DLL) Başkasının yazdı dokunamıyoruz
    class Log4Net
    {
        public void LogMessage(string message)
        {
            System.Console.WriteLine($"Logged with Log4New {message}");
        }
    }


    //ADapter desing pattern
    class Log4NetAdapter : ILogger
    {
        public void log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }

    #region Adapter Design Pattern | Tanım
    /*

Amacı:
    - Farklı arayüzlere sahip sınıfların birlikte çaluşmasını sağlamak
    - Mevcut bir sınıfın arayüzünü istemci tarafından beklenen bir arayüze dönüştürür.
    - Yani, iki uyumsuz arayüzü birbirine "adaptör" yardımıyla uyumlu hale geririr. 

Kullanım Senaryoları:
    - Mevcut bir sınıf yeniden yazmadan başka bir sistemle uyumlu hale getirmek istiyorsanız.
    - İki farklı sınıfın birbiriyle çalışması gerekiyor ama arayüzleri farklı

Yapısı:
    - Target (Hedef): İstemcinin beklediği arayüz
    - Adaptee (Uygulama Sınıfı): Mevcut sınıf, arayüzü istemcinin beklediği gibi değil
    - Adapter (Adaptör): Target arayüzünü implement eder ve Adaptee metodlarını Target metodlarına dönüştürür.

Avantajları:
    - Mevcut kodu değiştirmeden kullanmayı sağlar
    - Esnek ve yeniden kullanılabilir bir çözüm sunar

Dezavantajları:
    - Fazla adaptör sınıfı oluşturulsa kod karmaşıklaşabilir




    UML ŞEMASI

    +-----------+           +-----------+
    |  Target   |           |  Adaptee  |
    |-----------|           |-----------|
    | Request() |           | Specific  |
    +-----+-----+           | Request() |
          |                 +-----+-----+
          |                       ^
          v                       |
    +-------------+                |
    |  Adapter    |----------------+
    +-------------+
    | Request()   |
    +-------------+


    */
    #endregion
}