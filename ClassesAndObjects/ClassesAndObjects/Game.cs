﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public Dictionary<Player, int> Bets { get; set; }
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
