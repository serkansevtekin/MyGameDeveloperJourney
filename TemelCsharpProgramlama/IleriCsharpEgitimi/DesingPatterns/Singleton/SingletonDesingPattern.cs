using System;

namespace SingletonDesingPatternNameSapce
{
    class SingletonDesingPatternClass
    {
        public static void SingletonDesingPatternMain()
        {
            var customerManger = CustomerManager.CreateAsSingleton();

            customerManger.Save();

          

        }
    }


 

    sealed class CustomerManager
    {

        private static CustomerManager? _customerManager;

        //Tread safe için
        static object _lookObject = new object();

        // Constructor private, dışarıdan new ile oluşturulamaz
        // Yeni constructoru olan, ama dışarıdan erişilemeyen bir nesne
        private CustomerManager() { }



        //Customer nesenesi daha önce oluşturulmuş mu, oluşturulmuş ise onu kullan oluşturulmamış ise oluştur
        public static CustomerManager CreateAsSingleton()
        {

            //kısa yazım (unity için yeterli, Thread safe değil)
            //   return _customerManager ?? (_customerManager = new CustomerManager());



            //Tread Safe için

            lock (_lookObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
                return _customerManager;
            }



            /*  
            // Uzun yazım
        
           //Customer manger oluşturup, oluşturulmadığını kontorl et
            if (_customerManager == null)
            {
                //oluşturulmamış ise oluştur
                _customerManager = new CustomerManager();
            }
            //Customer manager var ise onu gönder
            return _customerManager; */
        }


        //örnek metot
        public void Save()
        {
            System.Console.WriteLine("Saved!");
        }


    }



    #region Singleton Desing Pattern | Tanım

    /*
    - Singleton tasarm deseni, bir sınıftan yanlızca bir tane nesne oluşturulmasını garanti altına alan ve bu nesneye global bir erişim noktası sağlayan bir yapıdır.
    - Genellikle sistemde tek bir "merkez" nesnenin olamsı gereken durumlarda kullanılır (örn. oyun yönetimi, logging, ayar yönetimi)

    Temel özellikleri:
        1) Tek bir örnek(instance) oluşturulur
        2) Global erişim sağlar
        3) Kontrollü ve güvenli nsene oluşturma sağlar

    Kullanım Alanları:
        - Logging sistemleri
        - Configuration/Settings yönetimi
        - Database bağlantıları
        - Oyun yöneticisi (Game Manager) veya Audio Manager gibi global yönetici nesneler

    Avantajları:
        * Tek nesne sayesinde hafıza ve kaynak yönetimi kolaydır
        * Global erişim noktası sağlar

    Dezavantajları:
        * Test etmeyi zorlaştırabilir (Mocklamak zor)
        * Çok kullanılırsa kod bağımlılığı artar (tight coupling)

    
    Thread-safe Singleton:
        - Bu versyionda lock sayesinde aynı anda iki thread erişilse bile sadece bir tane instance oluşturulabilir. !!!!Not: Unity'de bu durum genellikle oluşmaz.

            ** Unity'nin çalışma modeli **
                - Update, Start, Awake, LateUpdate, OnTriggerEnter vb. hepsi ana thread üzerinde çalışır.
                - Unity'nin API'si (Instatiate, Destroy, FindObjectOfType vb.) sadece ana thread'den çağrılabilir
                - Dolayasıyla aynı anda Singleton'a iki thread'in erişmesi neredeyse imkansız
                    Yani thread-safe kodun:
                        lock(_lock) -> kısmı her erişimde kilit mekanizması oluşturur ama hiç bir işe yaramz. Sadece mikro gecikme (CPU cycle kaybı) getirir
                
                Na Zaman Mantıklı olabilir:
                    - Arka planda Task.Run() veya Thread kullanıyorsan
                    - O thread, Singleton'a erişip veri güncelliyorsa (örneğin: async network sistemleri, async data loading)
                    - Ya da Unity job System ile özel veri taşııyorsa 

                    ** DOTS(ECS), Burst, Multiplyer (Netcode, Miror, Phaton), Job System gibi sistemlerde thread-safe Singleton artık kritik hale helebilir
        
        | Senaryo                                   | Thread-safe Gerekli mi? | Önerilen Yapı                      |
        | ----------------------------------------- | ----------------------- | ---------------------------------- |
        | Normal Unity (tek sahneli, single player) | ❌ Hayır                 | Basit Singleton                    |
        | Multiplayer (Photon, Mirror, Netcode)     | ✅ Evet                  | Thread-safe Singleton              |
        | DOTS / ECS / Burst                        | ✅ Evet                  | Thread-safe veya `NativeContainer` |
        | Async Tasks / Background Threads          | ✅ Evet                  | `lock` veya `ConcurrentQueue`      |




    
    UNITY ORNEK CODE

    using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            // Sahnedeki örneği bul, yoksa hata ver
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    // Otomatik oluşturulmasını istiyorsan:
                    GameObject obj = new GameObject("GameManager");
                    _instance = obj.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    // Awake sadece bir örneğin kalmasını sağlar
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject); // Sahnedeki fazlalıkları sil
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject); // Sahne değişince yok olmasın
    }

    // Örnek kullanım
    public void StartGame()
    {
        Debug.Log("Oyun başladı!");
    }
}



    */

    #endregion
}