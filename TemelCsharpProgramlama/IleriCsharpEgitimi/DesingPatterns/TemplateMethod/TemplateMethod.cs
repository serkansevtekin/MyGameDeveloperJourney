using System;

namespace TemplateMethodDesignPatternNamespace
{
    class TemplateMethodDesignPatternClass
    {
        public static void TemplateMethodDesignPatternRunMethod()
        {

            System.Console.WriteLine("Man");
            AScoringAlgorith men = new MensScoringAlgorithm();
            System.Console.WriteLine(men.GenerateScore(10, new TimeSpan(0, 2, 34)));

            System.Console.WriteLine("-------------");

            System.Console.WriteLine("Woman");
            AScoringAlgorith woman = new WomansScoringAlgorithm();
            System.Console.WriteLine(woman.GenerateScore(10, new TimeSpan(0, 2, 34)));

            System.Console.WriteLine("-------------");

            System.Console.WriteLine("Children");
            AScoringAlgorith children = new ChildrensScoringAlgorithm();
            System.Console.WriteLine(children.GenerateScore(10, new TimeSpan(0, 2, 34)));
        }
    }

    // Template method design
    abstract class AScoringAlgorith
    {
        //Template method
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateOverallScore(int score, int reduction);

        public abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateBaseScore(int hits);
    }


    class MensScoringAlgorithm : AScoringAlgorith
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }

    class WomansScoringAlgorithm : AScoringAlgorith
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }

    class ChildrensScoringAlgorithm : AScoringAlgorith
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;

        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }


    /*
    YUKARIDAKİ ÖRNEK UML ŞEMASI

 +------------------------------------------------------------+
|                AScoringAlgorith (abstract)                 |
+------------------------------------------------------------+
| + GenerateScore(hits: int, time: TimeSpan): int            |
| + CalculateBaseScore(hits: int): int {abstract}            |
| + CalculateReduction(time: TimeSpan): int {abstract}       |
| + CalculateOverallScore(score: int, reduction: int): int {abstract} |
+------------------------------------------------------------+
                              ▲
                              │
        ┌─────────────────────┼────────────────────────────────────────────┐
        │                     │                                            │
        │                     │                                            │
+------------------------+  +-----------------------------+          +-------------------------+
| MensScoringAlgorithm   |  | WomansScoringAlgorithm      |          | ChildrensScoringAlgorithm |
+------------------------+  +-----------------------------+          +-------------------------+
| + CalculateBaseScore() |  | + CalculateBaseScore()      |          | + CalculateBaseScore()   |
| + CalculateReduction() |  | + CalculateReduction()      |          | + CalculateReduction()   |
| + CalculateOverallScore() | | + CalculateOverallScore() |          | + CalculateOverallScore() |
+------------------------+  +-----------------------------+          +--------------------------+


Açıklma:
    - "AScoringAlgorith" soyut sınıftır.
    - "GenerateScore()" metodu template method'dur.
    - Üç alt sınıf (MensScoringAlgorithm, WomansScoringAlgorithm, ChildrensScoringAlgorithm) bu algoritmadaki soyut adımları kendi formülleriyle uygular.
    - Akış sırası sabittir; değişen sadece hesaplama detaylarıdır.

Not:
    Bu yapı özellikle oyun puanlama sistemlerinde, AI karar hesaplamalarında veya farklı zorluk seviyelerine göre skor formüllerinde Unity’de doğrudan uygulanabilir.    
    */


    #region Template Method Design Pattern | Tanım
    /*
    Template method, bir algoritmanın iskeletini (adımların sırasını) tanımlar, alt sınıfların bu  adımların bazılarını kendi ihtiyaçlarına göre yeniden tanımlamasına izin verir.

    * Amaç:
            "Ne yapılacağını" sabitlemek, "Nasıl yapılacağını" alt sınıflara bırakmak
    
    * Temel Yapı:
        
            - AbstractClass: Template mothod'u tanımlar, bazı adımlar soyut (abstract), bazıları varsayılan (virtual veya concrete).

            - ConcreteClass: Soyut adımları uygular, algoritma sırası değişmez.

    **** UML ŞEMASI ****

    +-------------------+
    |  AbstractClass    |
    +-------------------+
    | + TemplateMethod()|
    | + Step1()         |
    | + Step2()         |
    +-------------------+
             ^
             |
    +-------------------+
    |  ConcreteClassA   |
    +-------------------+
    | + Step1()         |
    | + Step2()         |
    +-------------------+




    */

    #endregion
}