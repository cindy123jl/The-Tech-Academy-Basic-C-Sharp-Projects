using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();//any class inhert this class must implemetn this method 

        public virtual void ListPlayers()//virtual means that this method gets inhert from an inherit class but can be overwritten
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
