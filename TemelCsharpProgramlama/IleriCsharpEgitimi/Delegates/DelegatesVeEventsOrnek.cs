using System;
using System.Runtime.CompilerServices;
using DelegateOrnek2;

namespace DelegatesVeEventsOrnek
{
    class DelegatesVeEventsOrnekClass
    {
        public static void DelegatesVeEventsOrnekRunMethod()
        {
            Player player = new Player();

            UIManager ui = new UIManager(player);


            player.Skor += 10;
            player.Skor += 5;

        }


    }



    class Player
    {
        // Delegate ve Event tanımı
        public delegate void PlayerEventHandler(int skor);
        public event PlayerEventHandler? OnScoreChanged;

        private int _score;
        public int Skor
        {
            get => _score;
            set
            {
                _score = value;
                OnScoreChanged?.Invoke(_score);
            }
        }
    }

    class UIManager
    {
        public UIManager(Player player)
        {
            player.OnScoreChanged += SkorGuncelle;
        }

        private void SkorGuncelle(int skor)
        {
            System.Console.WriteLine("Skor: " + skor);
        }
    }



    #region Tanım
    /*
    Mantık:
        Delegate -> Bir veya birden fazla metodu temsil eder.
        Event -> Delegate'i güvenli bir şekilde dış dünyaya açar, sadece ekleme/çıkarma yapılabilir, doğrudan çağrı yapılamaz.
    */

    #endregion



}


