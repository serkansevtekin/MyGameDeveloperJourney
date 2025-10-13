using System;
namespace Programlama.Tekrars1
{


   #region Temel Yapı
   public class Plaayer // Base class
   {
      //Alan (Field)
      public string _name;
      private int _health;

      // Özellik (Properties) prop
      public int Level { get; set; }

      public int Health
      {
         get { return _health; }
         set
         {
            if (Health < 0) Health = 0;
            else _health = value;
         }
      }

      //Contructor

      public Plaayer(string name, int health)
      {
         this._name = name;
         this.Health = health;
      }

      // Metot
      public void TakeDamage(int amount)
      {
         Health -= amount;

      }

      //method Overloading
      public void TakeDamage()
      {
         System.Console.WriteLine("Metot Overloading Take Damage");
      }
      public virtual void MedkiUse() // Virtual method
      {
         System.Console.WriteLine("Player Use Medkit");
      }

   }

   public class Enemy : Plaayer //Derived Class // Enemy class, Plaayer class tan türemiş
   {
      public int AttacPower;

      public Enemy(string name, int health, int attack) : base(name, health)
      {
         AttacPower = attack;
      }

      public void Attack(Plaayer target)
      {
         target.TakeDamage(AttacPower); // Base Class metodunu kullanıyor

      }

      public override void MedkiUse()
      {
         base.MedkiUse();//Player'ın metodu, isteğe bağlı çağırdım
         System.Console.WriteLine("Enemy Use Medkit");
      }

      //Static metot olmaz -> ❌ HATA! _name nesneye ait, static metod kullanamaz
      public void EnemyYazdir()
      {
         System.Console.WriteLine("Enemy name: " + _name);
         System.Console.WriteLine("Enemy health " + Health);
      }

   }
   #endregion


   #region Class (Sınıf) Tanım

   /*
  - class, nesne yönelimli programlamada bir nesnenin şablonudur
  - İçinde alanlar (fields), özellikler (properties), metotlar (methods), olaylar (events) ve constructor bulunabilir
  - "sturct"'tan farkı : class referans tipi, struct ise değer tipidir

   Özellikler:
        - Referans tipi: Bir nesne başka bir nesneye atanırsa, ikisi de aynı veriyi gösterir
        - Encapsulation (Kapsülleme): Alanlar private olabilir, public property veya metotlarla  erişilebilir.
        - Inheritance (Miras): Bir clas başka bir class'tan türetile bilir
        - Polymorphism(Çok Biçimlilik): virtual/override sayesinde metot davranışları değiştirile bilir
        
   :base() -> Bir class'ın üst sınıfına (base class) erişmek için kullanılır
      - Özellikle constructor veya override edilen metotlar için kullanılır.
      - base(...) yazarsan, üst sınıfın constructor'ını çağırırsın
   
   :this() -> Aynı class içindeki bir başka constructor'a erişmek için kullanılır
      - Özellikle constructor'lar arası veri iletmek ve kod tekrarını azaltmak için kullanılır
      - this(..) yazarsan, aynı class'taki diğer constructorlar'ı çağırırsın ve zorunlu alanları set edilmesini sağlayabilirsin.
   
   Encapsulation:
      - Veriyi ve davaranışı bir snıf içinde saklama ve koruma prensibi
      - Amaç veri gizliliği, güvenlik ve kontrolü

      Access Modifiers (Erişim Belirleyiciler)
         + private -> sadece sınıf içinde erişilebilir
         + protected -> sınıf ve miras alan alt sınıflar erişebilir
         + public -> her yerden erişilebilir
         + internal -> sadece aynı assembly içinde erişilebilir

      Nası Yapılır:
         - Alanları (Fields) private/protected yap -> dışarıdan doğrudan erişilemez
         - Property veya metotlar ile kontrollü erişim sapla -> okum / yazma izni verme

      Unity'de Faydaları:
         - Inspector'dan değer değiştirebilirsin ama runtime'da hatalı değer atamalarını önlersin
         - Kod daha güvenli ve bakımı kolay olur
   
   // virtual / override method:
      - Override edilen metot aynı imzaya sahip olmalı:
         - Aynı isim
         - Aynı parametreler
         - Aynı return tip


   
   */
   #endregion
}