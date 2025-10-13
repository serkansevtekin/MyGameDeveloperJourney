using System;

namespace Programlama.Tekrars1
{

     public class AbsClass
    {
        public static void AbsRunMet()
        {
            /* Warior war = new Warior();
            war.Name = "serkan";
            war.Attack();
            war.NamePrint(); */

            Wariorr w = new Wariorr("serkan", 100);
            Mage m = new Mage("Maria", 80);

            w.Attack();
            m.Attack();

            w.TakeDamage(30);
            m.TakeDamage(30);
            
            w.Heal(10);
            m.Heal(10);
        }   
    }


    #region Kapsamlı Ornek
    // Soyut (abstract) sınıf: nesne oluşturulamaz, sadece kalıtılır
    public abstract class Caracter
    {
        //Alan (Field)
        protected string _name;

        //Özellik (Properties)
        protected int _health;

        public int Health{ get => _health; set => _health = value; }

        //Constructor: alt sınıflar çağırabiliri
        public Caracter(string Name, int Health)
        {
            this._name = Name;
            this._health = Health;
        }

        //Abstract Method: gövdesizdir, alt sınıf override etmek zorunda
        public abstract void Attack();

        //Virtual metot: Alt sınıf istere override eder zorunlu değil
        public virtual void TakeDamage(int amount)
        {
            _health -= amount;
            if (_health < 0) _health = 0;

        }

        //Normal metot: alt sınıflar override edemez ( normal method)

        public void Heal(int amount)
        {
            _health += amount;
            System.Console.WriteLine($"{_name} healed {amount}. Health = {_health}");
        }
    }

    //Alt sınıf: abstract sınıfı miras alır

    public class Wariorr : Caracter
    {
        public Wariorr(string Name, int Health) : base(Name, Health) { }
        
        //A
        public override void Attack()
        {
            System.Console.WriteLine($"{_name} swing a sword!");
        }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount / 2); // Zırh sayesinde yarı hasar
            System.Console.WriteLine($"{_name}'s armor reduced the damage.");
        }
    }

    public class Mage : Caracter
    {
        public Mage(string Name, int Health):base(Name,Health){}

        public override void Attack()
        {
           System.Console.WriteLine($"{_name} casts a fireball");
        }
    }



    #endregion
   
    #region Örnek

    abstract class CharacterAbstract
    {
        private string _name = "";
        public string Name { get => _name; set => _name = value; }

        public CharacterAbstract()
        {
            System.Console.WriteLine("Boş abstrack constructor çalıştı");
        }

        public CharacterAbstract(string Name)
        {
            this._name = Name;
            System.Console.WriteLine("Parametreli abstrack constructor çalıştı");

        }

        public abstract void Attack(); // gövdesiz metot, zorunlu override
        public void NamePrint() { System.Console.WriteLine($"Abstract class normal Method {Name}"); } // normal metod
    }

    class Warior : CharacterAbstract
    {
        public Warior()
        {
            System.Console.WriteLine("Boş Warior constructor");
        }
        public Warior(string Name) : base(Name) { System.Console.WriteLine("Warior class constructor çalıştı"); }

        public override void Attack()
        {
            System.Console.WriteLine($"Warior class attack {Name}");
        }
    }

    #endregion

    #region Abstract Class Tanım
    /*
       ** Interface -> kontrat (sözleşme)
        ** Abstract -> şablon (saslak sınıf)

    - "abstract" anahtar kelimesiyle tanımlanan sınıflar nesnesi oluşturulmaz.
    - Yanlızca kalıtım yoluyla kullanılır

    Özellikler::
        1. Abstract metotlar yanzlızca abstract sınıf içinde bulunabilir
        2. Abstract metotlar gövdesizdir ve override edilmek zorundadır
        3. Normal metotlar da içerebilirler (farkı budur, interdace'den ayrılır)
        4. Nesne oluşturulamaz
                Character c = new Character() //  Oluşturulamaz

    Kullanım Amaçları:
        - Ortak bir şablon veya teel davranış tanımlamak
        - Alt sınıflara zorunlu görevler (metotlar) vermek

    Özet:
        - abstract class = "Nesnesi oluşturuşlamaz, miras verilir"
        - absract method = "Gövdesiz , alt sınıf yazmak zorundadır
    */
    #endregion
}