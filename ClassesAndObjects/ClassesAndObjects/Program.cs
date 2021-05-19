using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Game> games = new List<Game>();

            //Game game = new TwentyOneGame();//polymorphism TwentyOneGame inherits from game 
            //good for many different game objects^

            // games.Add(game);

            //TwentyOneGame game = new TwentyOneGame();
            // game.Players = new List<string>() { "jess", "bill", "jo" };
            //game.ListPlayers();
            //game.Play();
            // Console.ReadLine();



            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jess";
            //game = game + player;

            //game = game - player;


            //List<string>


            Card card = new Card();
            card.Suit = Suit.Clubs;
            int underlyingValue = Convert.ToInt32(Suit.Diamonds);

            Deck deck = new Deck();
            deck.Shuffle(3);
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
          
            Console.ReadLine();

        }
        public enum days
        {

            monday,
            tuesday,
            wednesday
        }
    }
}       //public static Deck Shuffle(Deck deck, int times)
        //{
        //  for (int i = 0; i < times; i++)
        //  {
        //     deck = Shuffle(deck);
        //  }
        //   return deck;


