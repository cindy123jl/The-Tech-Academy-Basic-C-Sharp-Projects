using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
   class Card
        
        {
           public Card()
        {
            Suit = "Spades";//constructor these are the default settings
            Face = "Two";
        }
           public string Suit { get; set; }
           public string Face { get; set; }
        }
}

