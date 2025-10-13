using System;

namespace Programlama.Tekrars1
{


    #region Game Manager Tarzı örnek
    public enum GameState { Playing, Paused, GameOver }
    public enum WeaponType { Sword, Bow,Dagger, Staff }
    public enum CharacterClass { Archer, Mage, Assasin }

    public struct Player
    {
        public string Name;
        public int Health;
        public WeaponType weaponType;
        public CharacterClass characterClass;


        public Player(string name, int healthValue, WeaponType wt, CharacterClass cc)
        {
            this.Name = name;
            this.Health = healthValue;
            this.weaponType = wt;
            this.characterClass = cc;
        }
    }
    
    public class Gamemager
    {
        private GameState _state;
        private Player _player;

        public Gamemager(Player player)
        {
            this._player = player;
            this._state = GameState.Playing;
        }

        public void StartGame()
        {
            System.Console.WriteLine($"Game Started - Player: {_player.Name}, Class {_player.characterClass}, Weappon: {_player.weaponType}, Health: {_player.Health} ");
            GameLoop();
        }

        private void GameLoop()
        {
            while (_state == GameState.Playing)
            {
                EnemmyAttack();
                PlayerActions();
                InventoryCheck();
                PauseGame();

            }
        }

        private void EnemmyAttack()
        {
            System.Console.WriteLine("Enemmy Attack1");
            _player.Health -= 10;
            if (_player.Health < 0)
            {
                _state = GameState.GameOver;
                System.Console.WriteLine("Game Over!");
            }
            else if (_player.Health < 30)
            {
                System.Console.WriteLine("Low Health! Using Medkit..");
                _player.Health += 20;
                System.Console.WriteLine($"Health restored to {_player.Health}");
            }
        }

        private void PlayerActions()
        {
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"Attack {i + 1} with {_player.weaponType}");

            }

            int bonus = 0;
            do
            {
                bonus++;
                System.Console.WriteLine($"Bonus attemp {bonus}");
            } while (bonus < 2);
        }
        
        private void InventoryCheck()
        {
            string[] inventory = { "Potion", "Sheild", "Key" };
            foreach (var item in inventory)
            {
                System.Console.WriteLine($"Inventory item: {item}");
            }
        }

        private void PauseGame()
        {
            _state = GameState.Paused;
            System.Console.WriteLine("Game Paused");
        }


    }

    #endregion



#region Basit Ornek
    
    
    
/*     public enum GameState { Playing, Paused, GameOver }
    public enum WeaponType { Sword, Bow }
   
   public struct Player
    {
        public string Name;
        public int Health;
        public WeaponType weaponType;
    } */
   
#endregion
}