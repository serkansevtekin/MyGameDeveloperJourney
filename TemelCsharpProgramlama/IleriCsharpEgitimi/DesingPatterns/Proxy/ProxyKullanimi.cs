using System;

namespace ProxyDesignPatternNamespace
{
    class ProxyDesignPatternClass
    {
        public static void ProxyDesignPatternRunMain()
        {
            CreditManagerProxy creditManagerProxy = new CreditManagerProxy();
            System.Console.WriteLine(creditManagerProxy.Calculate());
            System.Console.WriteLine(creditManagerProxy.Calculate());


        }
    }

    abstract class CreditBase
    {
        public abstract int Calculate();
    }

    class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);// isteğe bağlı operasyon arasında bekletiyoruz
            }
            return result;
        }
    }

    class CreditManagerProxy : CreditBase
    {
        CreditManager? _creditManager;

        int _cachedValue;
        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }
            return _cachedValue;
        }
    }


    #region Proxy Design Pattern | Tanım
    /*
    Proxy Design Pattern, yazılım tasarımında " bir nesneye doğrudan erişimi kontrol etmek için kullanılan yapısal (structural) bir tasarım desenidir. Temel amacı, gerçek nesneye erişimi bir temsilci (proxy) üzerinden sağlamaj, böylece ek kontrol, önbellekleme veya yük paylaşımı gibi işlemleri yönetmektir.

    1) Tanım:
        - Proxy, gerçek nesnenin arayüzünü (interface) uygular ve istemcilerin gerçek nesneye dolayalı yoldan erişmesini sağlar

    2) Kullanım Amaçları:
        - Kontrol: Nesneye erişimi sınırlandırmak veya yetkilendirme yapmak
        - Önbellekleme (Caching): Sık erişilen verileri saklayarak performansı arttırmak
        - Gecikmeli Yükleme (Lazy initialzation): Nesneye ihtiyaç olunca oluşturmka
        - Uzak Proxy (Remote Proxy): Ağ üzerinden gerçek nesneye erişim sağlamak
        - Nesneye erişimi merkezi bir noktadan kontrol etme.

    3) Tipleri:
        - Virtual Proxy: Nesne sadece ihtiyaç duyulduğunda oluşturulur
        - Protection Proxy: Erişim izinlerini kontrol eder.
        - Remote Proxy: Nesne farklı biri sunucuda ise erişimi sağlar
        - Cache Proxy: Sık kullanılan verileri saklar


   ** UML DİAGRAM
    
        <<interface>>
      +----------------+
      |    ISubject    |
      +----------------+
      | +Request()     |
      +----------------+
             ^
             |
  -----------------------
  |                     |
+----------------+     +----------------+
|  RealSubject   |     |     Proxy      |
+----------------+     +----------------+
| +Request()     |     | -realSubject: RealSubject |
+----------------+     +-------------------------+
                       | +Request()              |
                       +-------------------------+

    Açıklama:
        1) ISubject: Proxy ve RealSubject'in ortak arayüzü
        2) RealSubject: Gerçek iş yapan nesne
        3) Proxy: Gerçek nesneye erişimi kontrol eden sınıf
                - Genellikle lazy loading, cache ve authorization gibi işlemleri içerir
                - İçinde RealSubject'e referans tutar ve gerektiğinde çağrı yapar

    **

    Unity'de En Çok Kullanılan Proxy Tipleri

        1) Virtual Proxy (Lazy Inititalization):
            * En yaygın kullanılan tip
            * Amaç: Gerçek nesneyi gecikmeli oluşturmak (Lazy loading)
            * Proxy sınfı sadece RealSubject'i ihtiyaç olunca yaratır
            * Büyük veya ağır nesneleri (3D modeller, texture'lar, audio) sadece ihtiyaç olduğunda yükler
            * Örnek:
                    - Büyük bir düşman prefab'ını sahneye ilk girdiğinde değil, oyuncu menzile girdiğinde instatiate etmek

        2) Protection Proxy:
            * Multiplayer oyunlarda veya belirli oyun nesnelerine erişim kısıtlamak için kullanılır
            * Örnek:
                    - Sadece admin kullanıcılarının değişitebildiği oyun ayarları

        3) Remote Proxy:
            * Unity'de çoğunlukla networked oyunlarda veya server-client iletişimlerinde kullanılır
            * Örnek:
                    - Oyuncu envanteri verilerini sunucudan çekmek için bir proxy üzerinden çağırmak

        4) Cache Proxy:
            * Oyunlarda asset bundle veya veritabanı srgularında sık kullanılır
            * Örnek:
                    - MSSQL'den çekilen oyuncu istatistiklerini önbelleğe almak
    */
    #endregion
}