using System;
using Entities;

namespace DataAccess
{
    public class PlayerDal
    {
        private List<Player> _player = new List<Player>();

        public void Add(Player player)
        {
            _player.Add(player);
        }
        public List<Player> GetAll()
        {
            return _player;
        }
    }
}