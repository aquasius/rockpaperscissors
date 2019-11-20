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
        //public string player1Name;
        //public string player2Name;
        //public int players;
        //public string aiName;
        //public string rules;
        //public string winner;
        //public string loser;
        public int numberOfPlayers;
         Player player1;
         Player player2;




        // contructor

        


        //member methods ( can do )
        public void runGame()
        {
            displayRules();
            chooseNumberOfPlayers();
            createPlayers(numberOfPlayers);
            player1.chooseName();
            player2.chooseName();
            player1.chooseGesture();
            player2.chooseGesture();
            determineGestureWin();


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

        public void determineGestureWin()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("The result is a tie!");
                Console.ReadLine();
            }

            else if ((player1.choice == "rock") && (player2.choice == "scissors") || (player2.choice == "lizard")) 
            {
                player1.score++;
                Console.WriteLine("Rock beats " + player2.choice + "!");
                Console.WriteLine(player1.name + " score is: " + player1.score + "\n" + player2.name + " score is: " + player2.score);
            }

        }
        
    
        
    
    
    
    }

}
