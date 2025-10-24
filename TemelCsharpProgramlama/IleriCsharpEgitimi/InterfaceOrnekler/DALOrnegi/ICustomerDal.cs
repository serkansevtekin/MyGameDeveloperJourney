using System;
namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces
{
    interface ICustomerDAL
    {
        void Add();
        void Update();
        void Delete();
    }
}


/*
        Dal -> Data Access Layer
* Dal -> Yazılım mimarisinde veri erişim katmanı anlamına gelir.

** Temel Mantık:
                - Veritabanı veya dosya sistemi ile doğrudan iletişim kuran katmandır
                - Uygulamanın diğer katmanları (UI, bussiness logic) Dal ile veri okur / yazar, veri kaynağı detaylarını bilmez

** Özellikleri:
                - Sadece veri işlmleri yapar: CRUD(Create, Read, Update, Delete).
                - Diğer katmanlardan bağımsızdır: UI veya iş mantığı değişse DAL değişmez
                - Soyutlama sağlar: SQL, JSON, Firebase farketmez, diğer katmanlar DAL ile konuşur

** Avantajları:
                - Kodun okunabilirliği Artar
                - Veri kaynağı değiştirmek kolaydır. (JSON, DB, Firebase)
                - Test ve bakımı kolaylaştırır

***** UNITY KISMINDA DAL

** Mantık:
            * DAL == veri erişim katmanı
            * Unity projelerinde genellikle JSON, ScriptableObject, PlayerPrefs veya Firebase üzerinden beri okuma/yazma yapılır
            * DAL, bu veri kaynaklarını soyutlayarak diğer sistemlerden izole eder

** Örnek Kullanım senaryoları
        - Skill ve item yönetimi:
                                - JSON'dan skill ve item verilerini okur (LoadSkills(), LoadItems())
                                - Kodun geri kalanı DAL'ın hangi veri kaynağı kullandığını bilmez
        
        - Player Progress / Save System:
                                        - PlayerPrefs veya Firebase ile skor, seviye envanter kaydedilir
                                        - BLL / UI sadece DAL aracaılığıyla veri okur/yazar

        - Modüler Sistem:
                        - Gelecekte JSON -> Firebase veya SQLite geçişi kolay olur
                        - Kodun geri kalanı hiç değişmez

    !!ÖZET!!
        - Unity'de DAL kullnamak profesoyonel ve temiz bir mimari sağlar
        - Özellikle büyük oyun projelerinde veya çok oyunculu sistemlerde faydalıdır.


*/