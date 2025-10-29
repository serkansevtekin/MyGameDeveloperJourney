using System;
using Business;
using Entities;

namespace KatamanliMimari
{
    class KatamanliMimariClass
    {
        public static void KatamanliMimariMain()
        {
            var manager = new PlayerManager();
            var player1 = new Player { Id = 1, Name = "serkan", Coin = 500 };
            manager.AddPlayer(player1);

            foreach (var p in manager.GetPlayers())
            {
                System.Console.WriteLine($"{p.Name} - {p.Coin} coin");
            }
        }
    }
    #region Tanım
    /*

    MyGameProject
    │
    ├── Program.cs                 → Presentation Layer
    │
    ├── Business                   → Business Logic Layer
    │   └── PlayerManager.cs
    │
    ├── DataAccess                 → Data Access Layer
    │   └── PlayerDal.cs
    │
    └── Entities                   → Entity / Model Layer
        └── Player.cs



    **** ---- TANIM ----- *****
    Katmanlı mimari (Leyared Architecture), yazılım sistemlerini farklı sorumluluklara sahip katmanlara ayıran bir tasarım desenidir.

    *-* Temel Katmanlar *-*

        1) Presentation Layer (UI / Client)
            - Kullanıcı arayüzü ve etkileşim
            - Örnek: Unity oyun ekranı, buttonlar , input
        
        2) Application / Services Layer (Bussines Logic)
            - İş kuralları ve uygulama mantığı
            - Örnek: Coin ekleme, skor hesaplama, inventory yönetimi

        3) Data Access Layer (DAL)
            - Veritabanı işlemleri, CRUD operasyonları
            - Örnek: MSSQL üzerinden player tablosuna veri yazma/okuma

        4) Database Layer
            - Fiziksel veri saklama
            - Örnek: MSSQL , JSON, MySQL veritabanı




    *-* Akış Örneği (OYUN) *-*

        Unity Client (Presentation)
        
                ↓
        
        Game Service / API (Bussines Logic)

                ↓

        Repository / DAL

                ↓

        MSSQL Database


            -- Client -> Sadece servis katmanına istek gönderir
            -- Servis -> iş mantığını uygular, veritabanını ile iletişimi DAL üzerinden yapar
            -- Katmanlar birbirinden bağımsız -> test, bakım ve ölçeklenebilirlik kolay
        
        ** UNİTY DE **
        
        
            Unity Client
            │
            ├─ Firebase Auth → Kullanıcı giriş/çıkış
            │
            ├─ JSON Offline Cache → PlayerPrefs veya local JSON dosyası
            │
            └─ Backend / API → MSSQL veya Supabase

    */
    #endregion
}