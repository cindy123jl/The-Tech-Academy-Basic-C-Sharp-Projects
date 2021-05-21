﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();//any class inhert this class must implemetn this method 

        public virtual void ListPlayers()//virtual means that this method gets inhert from an inherit class but can be overwritten
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
