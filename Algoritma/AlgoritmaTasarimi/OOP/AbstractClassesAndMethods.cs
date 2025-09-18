using System;

namespace Programlama.AlgoritmaTasarimi
{
    class AbstractClassesAndMethodsClass
    {
        public static void AbstractClassesAndMethodsRunMethod()
        {
            var bisklet = new Bisiklet
            {
                Marka = "Bisan",
                Model = "XC"
            };
            bisklet.BilgiGoste();
            bisklet.HareketEt();

            var kamyons = new Kamyonlar
            {
                Model = "ModVol",
                Marka = "VOLVO"
            };
            kamyons.BilgiGoste();
            kamyons.HareketEt();

            var araclasss = new AracsLar[]{

                new Bisiklet{Marka = "Salcona", Model = "NG650"},
                new Kamyonlar {Marka = "Mercedes", Model= "Actros"}
            };

            foreach (var item in araclasss)
            {
                System.Console.WriteLine();
                item.BilgiGoste();
                item.HareketEt();

            }
            System.Console.WriteLine();
            //Oyun Ornek
            Player hero = new Player { varlikIsmi = "serkan", can = 100, hasarDegeri = 220 };
            Enemy goblin = new Enemy { varlikIsmi = "Goblin", can = 200, hasarDegeri = 110 };

            hero.Saldir(goblin);

            goblin.Saldir(hero);
            
            
        }
    }

    #region Tanım | Abstract Classes and Methods [Soyut olan sınıflar ve metotlar]
    /** 
    Abstract anahtar sözcüğü ile tanımlanır.
    Abstract Classes (Soyut Sınıflar) ve Abstract Methods (Soyut Metotlar), C# ve birçok OOP dilinde bir sınıf ve metodun doğrudan kullanılamayacağını, sadece türetilmiş sınıflarda uygulanacağını belirtmek için kullanılır.

    1. Abstract Class (Soyut Sınıf)
        - Kendi başına nesne üretilemez Yani new AbstractClass() yapamazsın.
        - İçinde normal metotlar ve soyut metotlar bulunabilir.
        - Genellikle  bir şablon gibi kullanılır

    2. Abstract Method (Soyut Metot)
        - Sadece imzası vardır; gövdesi yoktur ({} yok).
        - Alt sınıflar override etmek zorundadır [Normal metotlar override zorunlu değil]        
    **/
    #endregion


    #region Ornek

    //Soyut Sınıf
    abstract class AracsLar
    {
        public string? Marka { get; set; }//Properties
        public string? Model { get; set; }//Properties

        //Normak Metot: Tüm Araçlar için ortak
        public void BilgiGoste()
        {
            System.Console.WriteLine($"Araç: {Marka} {Model}");
        }


        //Soyut metot: Her araç farklı hareket eder
        public abstract void HareketEt();
    }

    class Bisiklet : AracsLar
    {
        public override void HareketEt()
        {
            System.Console.WriteLine($"Bisiklet: {Marka} {Model} pedal çeviriyor ve ilerliyor"); ;
        }
    }

    class Kamyonlar : AracsLar
    {
        public override void HareketEt()
        {
            System.Console.WriteLine($"Kamyon: {Marka} {Model} ağır yük taşırken işlerler");
        }
    }
    
    #endregion
}