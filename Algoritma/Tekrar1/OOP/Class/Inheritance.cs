using System;

namespace Programlama.Tekrars1.InheritanceSpecial
{

    public class InheritanceClass
    {
        public static void InheritanceRun()
        {
            Character warrior = new Warior("Thor", 100, 20);
            Character archer = new Archer("Legolars", 70, 50);

            warrior.ShowStatus();
            warrior.Attack();

            archer.ShowStatus();
            archer.Attack();
        }
    }



    //Tüm karakterlerin ortak özellikleri
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }

        //Her karakter kendine özel saldırı yapabilir
        public abstract void Attack();

        //Ortak metot
        public void ShowStatus()
        {
            System.Console.WriteLine($"{Name} has {Health} health.");
        }
    }


    // Derived class (miras alan sınıf)
    public class Warior : Character
    {

        public int Strength { get; set; }

        public Warior(string name, int health, int strength) : base(name, health)
        {
            this.Strength = strength;
        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} attacks with sword for {Strength} damage!");
        }

    }

    public class Archer : Character
    {
        public int Range { get; set; }
        public Archer(string name, int health, int range) : base(name, health)
        {
            this.Range = range;
        }



        public override void Attack()
        {
            System.Console.WriteLine($"{Name} shoots an arrow from {Range} meters!");
        }
    }


    #region  Inheritance (Kalıtım) Tanım
    /*
    Bir sınıfın başka bir sınıfın özelliklerini ve metotlarını devralmasıdır. Böylece ortak kodlar tekrar yazılmaz, alt sınıflar ek özellik veya davranış ekleyebilir

    -- Bir sınıf başka bir sınıfın tüm özelliklerini miras alır ve geliştirebilir
    */
    #endregion
}