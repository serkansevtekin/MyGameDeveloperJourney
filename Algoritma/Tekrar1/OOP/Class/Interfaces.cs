using System;

namespace Programlama.Tekrars1
{
    public class InterfaceClassss
    {
        public static void InterfaceRun()
        {
            IPlayer player = new Waryor(1, "Ares");
            player.DisplayInfo();
            player.Attack();

            //Indexer kullanımı
            player[0] = "Health Potion";
            System.Console.WriteLine($"Inventory slot 0: {player[0]}");

            //Event dinleme
            player.OnLevelUp += () => System.Console.WriteLine("Level Up Eveny Triggared!");
            ((Waryor)player).LevelUp();

            //Polimorfizm: aynı nesne farklı interface'lerle davranıyor (isteğe bağlı)
            IEnemy enemy = (IEnemy)player;
            enemy.Attack(); // Explicit impelementatin -> sadee Ienemy referansından erişilir
            enemy.Defend();
        }
    }


    #region Ornek
    //Interface Tanımları
    public interface IEntity
    {
        public int Id { get; set; } // Property -> gövde yok
        void DisplayInfo(); // Metot -> gövde yok
    }

    public interface IEnemy
    {
        void Attack(); // Aynı isimli metot -> çakışma olacak
        void Defend();
    }

    // Interface Miras
    public interface IPlayer : IEntity
    {
        public string Name { get; set; }
        event Action? OnLevelUp;  // Event -> olay bildirimi
        string this[int index] { get; set; } // indexer tanımı
        void Attack(); // Aynı isimli metot -> çakışma olacak
    }

    // Interface'leri uygulanan sınıf
    public class Waryor : IPlayer, IEnemy
    {

        //Field -> interface içinde yasak ama class içinde serbest
        private string[] _inventory = new string[3];
        private int _level;

        //Indexer -> interface'te tanımlandı, burada uygulanıyor
        public string this[int index]
        {
            get => _inventory[index];
            set => _inventory[index] = value;
        }

        //Property'ler interface'ten geliyor -> göveyi burada yazıyoruz
        public string Name { get; set; }
        public int Id { get; set; }

        // Event tanımlama -> interface'te bildirildi, burada uygulanıyor
        public event Action? OnLevelUp;

        public Waryor(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            _level = 1;
        }
        // IPlayer -> metot gövdesi murada
        public void Attack() // IPlayer için implicit
        {
            System.Console.WriteLine($"{Name} Swing a sword");
        }

        //Ienemy -> antı isimli Attack metodu çakıştı
        // Bu durumda Explicit Implementation kullanılır
        void IEnemy.Attack() // IEnemy için explicit
        {
            System.Console.WriteLine($"{Name} attacks viciously as an enemy!");
        }

        public void Defend()
        {
           System.Console.WriteLine( $"{Name} raised a shield!");
        }

        // IEntity -> ortak metot
        public void DisplayInfo()
        {
            System.Console.WriteLine($"ID: {Id}, Name: {Name}, Level: {_level}");
        }
        
        //class kendi metodu
        public void LevelUp()
        {
            _level++;
            System.Console.WriteLine($"{Name} leveled up tu {_level}!");
            OnLevelUp?.Invoke(); // event tetikleme
        }



    }


    #endregion


    #region Interface Tanım
    /*
    ** Interface -> kontrat (sözleşme)
    ** Abstract -> şablon (saslak sınıf)

    * "Interface", bir sınıfın hangi metotlarıi ve özellikleri veya olayları içermesi gerektiğini tanımlar.
    * Ama nasıl çalıştıklarını (gövdeyi). Gövdesi yok.
        - Interface = "Ne yapacak?"
        - Abstract class = "Ne + nasıl yapacak (kısmen)?"

    * Interface'in kendisinden nesne oluşturulamaz, sadece uygulanan sınıf tarafından doldurulur (implemente edilir)

    ** Bir sınıf Interface'i implemente ediyor ise tüm üyelerini yazmak zorundadır.

    ** Çoklu kalıtımı class için yasak, ama Interface için serbesttir

    Interface'lerde Ozellikler (property):
            - Sadece tanımlanır, gövde yazılamaz
            - Uygulanan sınıf getter ve setter'ı sağlamak zorundadır

    Interface'lerde Alan (Field) Olamaz:
            - Interface içinde field (değişkeni tanımlanamaz)
            - Sadece metot, property, event, indexer bulunur.

    Interface'lerde Constructor Olamaz:
            - Interface'in constructor'ı olamaz, çünkü nesnesi oluşturulamaz
            - Sınıflar, kendi constructor'larında interface'i doldurur.

    Interface Mirası:
            - Interface başka bir interface'ten miras alına bilir
            - Bu, daha geniş davranış setleri oluşturmak için kullanılır.2

    Polimorfizm (Çok Biçimlilik)
            - Interface'ler birden fazla sınıfı tek bir tür üzerinden işleyebilmesini sağlar

    Explicit Implementation (Açık Uygulama)
            - Aynı isimde iki Interface metodu çakışırsa, "explicit implementation" kullanılır
            - Bu, metotların sadece interface referansından erişilmesini sağlar




    */

    #endregion
}