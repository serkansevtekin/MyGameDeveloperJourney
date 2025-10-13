using System;
using Programlama.AlgoritmaTasarimi;
using static Programlama.Tekrars1.MiniGame;

namespace Programlama.Tekrars1
{
    public class DegiskenlerClass
    {
        public static void DegiskenlerRunMet()
        {
            IntDegisken();
            floatDegisken();
            BoolDegisken();
            StringDegisken();
            CharDegiskeni();
            EnumDeg(GameState.Playing);
            StructKullanim();

            System.Console.WriteLine();

            //Mini Game
            MiniGameOrnek();

            System.Console.WriteLine('\n');


            //Mini Game Ornek 2
            MiniGameOrnek2();
        }
        private static void MiniGameOrnek2()
        {
            var pl1 = new Character("Serkan", CharacterClassEnum.Warrior, 0, 20);
            pl1.levelUp(2,30);

            System.Console.WriteLine(pl1);
            pl1.levelUp(3);

            System.Console.WriteLine(pl1);

            System.Console.WriteLine("Name: {0}", pl1.Name);
            System.Console.WriteLine("Class: {0}", pl1.classType);
            System.Console.WriteLine("Level: {0}", pl1.Level);
            System.Console.WriteLine("Güç: {0}", pl1.AttaclPower);

            Character pl2 = new Character();
            pl2.Name = "Suat";
            pl2.classType = CharacterClassEnum.Mage;
            pl2.Level += 10;
            pl2.AttaclPower = 120;

            System.Console.WriteLine(pl2);

            System.Console.WriteLine();

            List<Character> cc = new List<Character>()
            {
                new Character("Portaklal",CharacterClassEnum.Archer,2,50),
                new Character("Portaklal2",CharacterClassEnum.Archer,5,80),
                new Character("Portaklal3",CharacterClassEnum.Warrior,1,20),
                new Character("Portaklal4",CharacterClassEnum.Mage,2,50),

            };
            //sedece archer olanları getir
            for (int i = 0; i < cc.Count; i++)
            {
                if (cc[i].classType == CharacterClassEnum.Archer)
                {
                    System.Console.WriteLine(cc[i]);
                }
            }

            //LINQ ile sadce archer olanları geir
            /* var archers = cc.Where(x => x.classType == CharacterClassEnum.Archer);
            foreach (var item in archers)
            {
                System.Console.WriteLine(item);
            } */


        //struct olduğundan ve değer tip olduğundan orjinal değişmez. ondan böyle yaptık    
          for (int i = 0; i < cc.Count; i++)
          {
                if (cc[i].Level == 2)
                {
                    var temp = cc[i];
                    temp.Level += 6;
                    cc[i] = temp;
                }
            System.Console.WriteLine(cc[i]);
          }
        }
        private static void MiniGameOrnek()
        {
            Playerss player1 = new Playerss("Serkan", 100, 0);


            //Enum ile gameState değişimleri similasyonu
            CheckerGameState(MiniGame.GameState.Playing, player1);
            CheckerGameState(MiniGame.GameState.Paused, player1);
            CheckerGameState(MiniGame.GameState.GameOver, player1);
        }

        public static void IntDegisken()
        {//ör player Health ve Skor
            int playerHealth = 100;
            int platerScore = 0;

            //Hasar alma
            playerHealth -= 20;
            platerScore += 50;
            System.Console.WriteLine("Can: " + playerHealth);
            System.Console.WriteLine("Skor: " + platerScore);
        }

        public static void floatDegisken()
        {// ör player Speed ve Zaman
            float playerSpeed = 5.5f;
            float deltaTime = 0.02f; // Unity'de deltaTime gibi
            float moveDistance = playerSpeed * deltaTime;
            System.Console.WriteLine("Hareket mesafesi: " + moveDistance);
        }

        public static void BoolDegisken()
        {
            //ör: Player state

            bool isJumping = false;
            bool isAlive = true;

            //Oyuncu zıpladı
            isJumping = true;

            System.Console.WriteLine("Zıplıyor mu? " + isJumping);
            System.Console.WriteLine("Hayatta mı? " + isAlive);
        }


        public static void StringDegisken()
        {//ör : player Name veya UI mesaj
            string playerName = "Serkan";
            string message = playerName + " oyuna katıldı!";

            System.Console.WriteLine(message);
        }

        public static void CharDegiskeni()
        {
            //ör Input kontrolü

            char keyPressed = 'W';
            if (keyPressed == 'W')
            {
                System.Console.WriteLine("ileri hareket");
            }
        }

        //Enum- Oyun Durumu
        public enum GameState
        {
            Playing,
            Paused,
            GameOver
        }
        public static void EnumDeg(GameState gmSt)
        {
            GameState gameState = gmSt;
            switch (gameState)
            {
                case GameState.Playing:
                    Console.WriteLine("Oyun devam ediyor");
                    break;
                case GameState.Paused:
                    Console.WriteLine("Oyun duraklatıldı");
                    break;
                case GameState.GameOver:
                    Console.WriteLine("Oyun bitti");
                    break;
            }
        }


        //Struct - Player Position
        struct Nokta
        {
            public float x;
            public float y;
            public void Print()
            {
                System.Console.WriteLine($"X: {x}, Y: {y}");
            }
        }

        public static void StructKullanim()
        {
            Nokta nokta1;
            nokta1.x = 10.5f;
            nokta1.y = 20.3f;
            nokta1.Print();

            // Kopyalama -> Not: nokta2 değiştirildiğinde nokta1 etkilenmez çünkü struct value type.
            Nokta nokta2 = nokta1;
            nokta2.x = 30f;
            nokta2.Print();
            nokta1.Print();
        }

        /*
        Struct Nedir?

            struct değer tipi (value type) bir yapıdır.

            Küçük veri gruplarını tutmak için kullanılır.

            Heap yerine stack’te tutulur (bu yüzden hafızada hızlıdır).

            Genellikle küçük objeler, pozisyon, renk, vektör gibi durumlar için uygundur.

            class ile farkı: class reference type, struct value type.
        Temel Özellikleri

            Değer tipi: Bir struct değişkeni kopyalandığında, kopyası tamamen bağımsız olur.

            Küçük veri için: Büyük veri veya karmaşık nesneler için class tercih edilir.

            Constructor: Parametresiz constructor yazamazsın; default 0 değerleri otomatik gelir.

            Inheritance: Struct miras alamaz (interface implement edebilir).
        */
    }
}