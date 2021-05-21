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

            Console.WriteLine("Welcome to the Grand Hotel and Casino!! Let's start by telling me your name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today? ");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now? ", playerName);
            string answer = Console.ReadLine().ToLower();//tolower lowercases input for us to run through only lowercase options

            if (answer == "yes" || answer == "ye" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);//this is a constructor
                Game game = new TwentyOneGame();//game is created polymorphism happening here
                game += player; //adding player to the game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino, bye for now");
            Console.ReadLine();
        }
    }
}











































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

            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1Face);

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            // int underlyingValue = Convert.ToInt32(Suit.Diamonds);

           // Deck deck = new Deck();

           // int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //List<int> numberList = new List<int>() { 2, 3, 6, 7 };
            //int sum = numberList.Sum(x => x + 5);
            //Console.WriteLine(sum);

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //deck.Shuffle(3);

           // foreach (Card card in deck.Cards)
           // {
                //Console.WriteLine(card.Face + " of " + card.Suit);
            //}
           // Console.WriteLine(deck.Cards.Count);

           // Console.ReadLine();

       // }
       // public enum days
        //{

           // monday,
           // tuesday,
           // wednesday
        //}
   // }
//}       //public static Deck Shuffle(Deck deck, int times)
        //{
        //  for (int i = 0; i < times; i++)
        //  {
        //     deck = Shuffle(deck);
        //  }
        //   return deck;
