using System;

namespace Programlama.Tekrars1
{
    public sealed class Enemt { }

    // class Boss: Enemt{} // Hata! Enemt sealed


    #region Örnek

    class Characte
    {
        public virtual void Attack() { System.Console.WriteLine("Normal attack "); }
    }

    class Playe : Characte
    {
        public sealed override void Attack() { System.Console.WriteLine("Power Attack"); }
    }

    class Nag : Characte
    {
        // public override void Attack() { } // Hata! sealed metot ezilemez.
    }

    #endregion

    #region Sealed Class  ve Sealed override Tanım
    /*
    Tanım: "sealed" anahtar kelimesiyle işaretlenen sınıflar katılınamaz
    Amaç:
        - Miras (inheritance) kapatmak
        - Sınıf davranışını değiştirilemez hale geritrmek
        - Güvenlik veya performans için kodun kontrollü kullanımını sağlamak
    
    Kullanım Yerleri:
        - Freamwork veya kütüphanelerde, geliştiricilerin sınıfı genişletmesini istemediğinde
        - "override" edilen moetotların yeniden ezilmesini engellmek için (sealled override)

    sealed override -> Ben override ediyorum ama benden sonra kimse edemez
    */
    #endregion
}