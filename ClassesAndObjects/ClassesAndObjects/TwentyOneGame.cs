using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class TwentyOneGame : Game
    {
        public override void Play()// should overide for the abstract method in Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            base.ListPlayers();
            {
                Console.WriteLine("21 Players: ");
                base.ListPlayers();
            }
        }
    }
}
