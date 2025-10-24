using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Constructor
{

    /// <summary>
    /// Singelton Design Pattern örneği -> Monobehavior için geçerli değil
    /// Amaç: GameManager sınıfının uygulama boyunca TEK bir örneği oluşturmak
    /// </summary>
    /// 
    /// sealde clas:
    ///             - Başka bir sınıf bu sınıftan türetilemez
    ///             - Singleton veya helper sınıflarda sık kullanılır
    ///             - Performans açısından JIT optimizasyonuna izin verir
    public sealed class GameManager
    {
        //1. readonly static field: yanlızca bir tane örnek oluşturulur ve değiştirilemez
        private static readonly GameManager _instance = new GameManager();

        //2. public static property: dış dünyaya tek bir öreğe erişim verir
        public static GameManager Instance => _instance;
        //3. Private constructor: Dışarıdan new GameManager() yapılmasını engeller
        private GameManager()
        {
            Score = 0;
            System.Console.WriteLine("GameManager Constructor Çalıştı");
        }

        //4. Static olmayan property: Oyunun skorunu tutar
        public int Score { get; private set; }


        //5. Nırmal Method: Singleton örneğiyle kullanılacak bir işlem
        public void AddScrore(int value)
        {
            Score += value;
            System.Console.WriteLine($"Skor arttı: {Score}");
        }

    }
    

    /*
    
    >>>>!!!! UNİTY DE SİNGLETON ORNEK !!!!<<<<<

    using UnityEngine;

// Amaç: GameManager tek bir instance ile tüm sahnelerde erişilebilir
public class GameManager : MonoBehaviour
{
    // 1. Statik instance alanı
    public static GameManager Instance { get; private set; }

    // 2. Awake() → Unity’de constructor yerine kullanılır
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;                 // İlk örnek atanır
            DontDestroyOnLoad(gameObject);   // Sahne değişse bile yok olmasın
            Debug.Log("GameManager oluşturuldu.");
        }
        else
        {
            Destroy(gameObject);             // Zaten instance varsa, yeni nesneyi yok et
        }
    }

    // 3. Örnek method
    public void AddScore(int value)
    {
        Debug.Log($"Score +{value}");
    }
}




    void Start()
{
    // Tek instance üzerinden çağrı
    GameManager.Instance.AddScore(10);
}
    
!!! Bu yapı "Unity projelerinde en yaygın ve güvenli Singleton yöntemidir"
**** Mantık:
            - Instance static olduğu için tüm sınıflardan erişilebilir
            - Awake() -> içibde kontrol -> tek instance grantilenir
            - DontDestroyOnLoad -> sahne değişse bile singleton korunur
            - Başka GameObject'te tekrar GameManager varsa yok edilir, tek örnek kalır

        
    
    */
}