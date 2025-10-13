using System;

namespace Programlama.Tekrars1
{
    public class DongulerClass
    {
        public static void DongulerRunMethod()
        {
            ForDongusu();
            ForeachDongusu();
            WhileDongusu();
            DoWhileDongusu();


            //Dongu örnek
            //BasicOrnek();
            GameManagerTarziOrnek();
        }
        private static void GameManagerTarziOrnek()
        {
            Player p = new Player("ArcherHero", 100, WeaponType.Bow, CharacterClass.Archer);
            Gamemager gm = new Gamemager(p);
            gm.StartGame();
        }

        private static void BasicOrnek()
        {
          /*   GameState gameState = GameState.Playing;
            Player player = new Player { Name = "Hero", Health = 40, weaponType = WeaponType.Sword };

            System.Console.WriteLine($"Player: {player.Name}, Weappon: {player.weaponType}, Health: {player.Health}");
            while (gameState == GameState.Playing)
            {
                System.Console.WriteLine("Enemmy Attacks!");
                player.Health -= 10;

                //if -> sağlık kontrolü
                if (player.Health <= 0)
                {
                    gameState = GameState.GameOver;
                    System.Console.WriteLine("Game Over!");
                }
                else if (player.Health < 30)
                {
                    System.Console.WriteLine("low health! Use medkit");
                    player.Health += 20;
                }

                //for -> 3 saldırı yap
                for (int i = 0; i < 3; i++)
                {
                    System.Console.WriteLine($"Attack {i + 1} with {player.weaponType}");
                }

                //do-while -> en az 1 kez deneme

                int bonus = 0;
                do
                {
                    bonus++;
                    System.Console.WriteLine($"Bonus attempt {bonus}");
                } while (bonus < 2);

                string[] inventory = { "Potion", "Sheld", "Key" };
                foreach (var item in inventory)
                {
                    System.Console.WriteLine($"Inventory item: {item}");
                }
                gameState = GameState.Paused;
                System.Console.WriteLine("Game Paused");
            } */
        }

        private static void ForDongusu()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Enemy {i + 1} spawned");
            }
        }

        private static void ForeachDongusu()
        {
            string[] inventory = { "sword", "bow", "staff" };
            foreach (string item in inventory)
            {
                System.Console.WriteLine($"Envanterde: {item}");
            }
        }

        private static void WhileDongusu()
        {
            int healt = 10;
            int medkits = 10;

            while (healt < 50)
            {
                medkits--;
                healt += 10;
                System.Console.WriteLine($"Medkit {medkits} kullanıldı. Health: {healt}");
            }
        }
        private static void DoWhileDongusu()
        {
            int attacks = 0;
            int maxAttacks = 3;
            do
            {
                attacks++;
                System.Console.WriteLine($"Attack {attacks} done");
            } while (attacks < maxAttacks);
        }



    }


}