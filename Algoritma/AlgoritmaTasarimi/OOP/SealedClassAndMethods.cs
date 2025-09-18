using System;

namespace Programlama.AlgoritmaTasarimi
{
    class SealedClassAndMethodsClass
    {
        public static void SealedClassAndMethodsRunMethod()
        {
            BankAccont ba = new BankAccont("serkan", 500);
            ba.ParaYatir(500);
            System.Console.WriteLine();

            ba.ParaCek(100);

        }
    }

    #region Tanım | Sealed
    /*
    Sealed Class:
        Bir sınıfı "sealed" yaparsan, o sınıftan miras alınamaz. Yani o sınıf son nokta olur.

    Sealde Method:
        Bir metotdun override edilmiş halini sealed yapasan. Alt sınıf o metodu tekrar override edemez.

    Kullanım mantığı: 
        "Ben bu metodu özelleştirdim ama daha da değişmesinin istemiyorum."

    Nerede Kullanılır:
        - sealed class -> Singleton, Helper gibi yapılar (artık miras alınsın istemezsin)
        - sealed method -> Bazı önemli metodlar override edilmesini engellemek için

    Özet:
        sealed class -> sınıftan miras alınamaz
        sealed method -> metot birkez override edilir, daha aşağıya aktarılamaz 
    */
    #endregion

    #region Ornek uygulama

    public sealed class BankAccont
    {
        public string? _hesapSahibi { get; set; }
        public decimal _bakiye { get; set; }

        public BankAccont(string HesapSahibi, decimal Bakiye)
        {
            _hesapSahibi = HesapSahibi;
            _bakiye = Bakiye;
        }

        public void ParaYatir(decimal miktar)
        {
            _bakiye += miktar;
            System.Console.WriteLine($"{_hesapSahibi} {miktar}$ yatırıldı. Yeni bakiyen: {_bakiye}$");
        }

        public void ParaCek(decimal miktar)
        {
            if (miktar > _bakiye)
            {
                System.Console.WriteLine("Yetersiz bakiye");
                return;
            }
            _bakiye -= miktar;
            System.Console.WriteLine($"{_hesapSahibi} {miktar}$ çekildi. Yeni bakiyen: {_bakiye}$");
        }
    }

    #endregion
}