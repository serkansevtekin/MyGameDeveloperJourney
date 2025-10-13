using System;

namespace Programlama.Tekrars1
{
    public class MiniGame
    {
        //Enum oyun durumu
        public enum GameState { Playing, Paused, GameOver }

        //Struct : player bilgileri
        public struct Playerss
        {
            public string Name{ get; private set; }
            public int Health{ get; private set; }
            public int Score{ get; private set; }

            public Playerss(string name, int health, int score)
            {
                Name = name;
                Health = health;
                Score = score;
            }

            public void AddHealth(int healtValue)
            {
                Health += healtValue;
                if (Health > 100) Health = 100;
              
            }

            public void Print()
            {
                Console.WriteLine($"Player: {Name}, Health: {Health}, Score: {Score}");
            }

        }

        public static void CheckerGameState(GameState gameState, Playerss player)
        {
            switch (gameState)
            {
                case GameState.Playing:
                    System.Console.WriteLine("Oyun devam ediyor");
                    player.AddHealth(10);
                    break;
                case GameState.Paused:
                    System.Console.WriteLine("Oun duraklatıldı");
                    break;

                case GameState.GameOver:
                    System.Console.WriteLine("Oyun Bitti");
                    break;
            }

            player.Print();
            System.Console.WriteLine("*---------------------*");
        }

    }
}