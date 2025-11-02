using System;

namespace StrategyDesignPatternNamespace
{
    class StrategyDesignPatternClass
    {
        public static void StrategyDesignPatternRunMethod()
        {

            //Constructor var ise
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreditCalculatorBase = new Before2010CreditCalculator();
            customerManager.SaveCredit();

            System.Console.WriteLine("---------------");

            customerManager.CreditCalculatorBase = new After2010CreditCalculator();
            customerManager.SaveCredit();
        }
    }

    abstract class CreditCalculatorBase
    {
        public abstract void Claculate();
    }

    class Before2010CreditCalculator : CreditCalculatorBase
    {
        public override void Claculate()
        {
            System.Console.WriteLine("Credit calculated using before2010");
        }
    }

    class After2010CreditCalculator : CreditCalculatorBase
    {
        public override void Claculate()
        {
            System.Console.WriteLine("Credit calculated using after2010");

        }
    }
    
    class CustomerManager
    {
        public CreditCalculatorBase? CreditCalculatorBase { get; set; }

        public void SaveCredit()
        {
            System.Console.WriteLine("Customer manager business");
            CreditCalculatorBase!.Claculate();
        }
    }





    #region Strategy Pattern Design | Tanım
    /*
    Strategy: Davtanışı çalışma zamanında değiştirmeyi sağlar. Kullanım amacı algoritma veya davranışı sınıflara ayırıp Context içinde değiştirebilmek

    * Amaç: Bir işlemin farklı algoritmalarnı birbirinin yerine kullanılabilir hale getirmek

    * Katmanlar: Strategy (arayüz), ConcreteStrategy'ler, Context

    * Avantaj: Açık/Kapalı prensibine uyar. Yeni strateji eklemek kolaydır. Kod tekrarını azaltır.

    * Dezavantajı: Strateji sayısı artarsa sınıf sayısı çoğalır. Basit durumlarda gereksiz olabilir


    *** UML Şeması (Basit Metin Temsili) ***

+-----------------+        <<uses>>        +----------------------+
|    Context      |----------------------->|     IStrategy        |
|-----------------|                         |----------------------|
| - strategy:IStrategy |                     | + Execute(params)    |
| + Context(IStrategy) |                     +----------------------+
| + SetStrategy(IStrategy) |
| + DoOperation()  |
+-----------------+

       /_\ 
        |
+----------------+   +----------------+
| ConcreteStratA |   | ConcreteStratB |
|----------------|   |----------------|
| + Execute(...) |   | + Execute(...) |
+----------------+   +----------------+

***                 ***

*-*-- Unity'de Strategy Pattern genellikle şu alanlarda kullanılır
    
    1) AI davranışları

    2) Haraket sistemleri:
            - Karakterin farklı kontrol modları (yürüyüş, yüzme, uçuş) Strategy ile ayrılır
    
    3) Silah ve yetenek sistemi:
            - Oyuncu seçtiği silaha göre farklı atış algoritması uygulanır
        
    4) Input sistemi:
            - Platforma (Pc, mobil, gamepad) göre farklı input stratejileri çalıştırılır
    
    5) Damage hesaplama, item kullanımı, kamera hareketi gibi durumlarda da modülerlik sağlar

    Özetle:
        - Unity'de davranış değişimi gerekiyorsa Strategy uygundur
        - MonoBehaviour için new ile strateji seçip çalıştırılır
        - ScriptableObject tabanlı stratejiler de tercih edilir

    */
    #endregion
}