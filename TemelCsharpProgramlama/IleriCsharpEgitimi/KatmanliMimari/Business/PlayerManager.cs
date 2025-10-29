using System;
using DataAccess;
using Entities;

namespace Business
{
    public class PlayerManager
    {
        private readonly PlayerDal _playerDal = new PlayerDal();

        public void AddPlayer(Player player)
        {
            if (player.Coin >= 0)
            {
                _playerDal.Add(player);
            }
        }

        public List<Player> GetPlayers() => _playerDal.GetAll();
    }
}