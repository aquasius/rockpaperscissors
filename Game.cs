using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    class Game
    {
    
        //member variables ( has a ) 
        public string player1Name;
        public string player2Name;
        public int players;
        public string aiName;
        public string rules;
        public string winner;
        public string loser;
        public int numberOfPlayers;
         Player player1;
         Player player2;




        // contructor




        //member methods ( can do )
        public void runGame()
        {
            displayRules();
            chooseNumberOfPlayers();
            promptAskName();
            createPlayers(numberOfPlayers);

        }
    
        public void displayRules()
        {
            Console.WriteLine("Game description: Out-smart your opponent by choosing the winning gesture! \n Rock crushes Scissors.\n Scissors cuts Paper.\n Paper covers Rock.\n Rock crushes Lizard.\n Lizard poisons Spock.\n Spock smashes Scissors.\n Scissors decapitates Lizard.\n Lizard eats Paper");
        }

        public void chooseNumberOfPlayers()
        {
            Console.WriteLine("How many players are playing? 1 or 2?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
        }

        public void promptAskName()
        {
            if(numberOfPlayers == 1)
            {
                Console.WriteLine("Please enter your name");
                player1Name = Console.ReadLine();
            }
            else if (numberOfPlayers == 2)
            {
                Console.WriteLine("Player 1 please enter your name");
                player1Name = Console.ReadLine();
                Console.WriteLine("Player 2 please enter your name");
                player2Name = Console.ReadLine();
            }
        }
        
        public void createPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new AI();
            }
        
            else if(numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
        }

        public void roundOne()
        {
            Player player = new Player();
            player.chooseGesture();
        }
    }
}
