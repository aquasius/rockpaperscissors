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
            Console.WriteLine("How many players are playing? 0, 1 or 2?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
        }

        
        public void createPlayers(int numberOfPlayers)
        {
           if(numberOfPlayers == 0)
           {
                player1 = new AI();
                player2 = new AI();
           }
            
           else if(numberOfPlayers == 1)
           {
                player1 = new Human();
                player2 = new AI();
           }
        
           else if (numberOfPlayers == 2)
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

            else if ((player1.choice == "paper") && (player2.choice == "rock"))
            {
                player1.score++;
                Console.WriteLine("Paper covers " + player2.choice + "!");
            }

            else if ((player1.choice == "scissors") && (player2.choice == "paper") || (player2.choice == "lizard"))
            {
                player1.score++;
                Console.WriteLine("Scissors cuts " + player2.choice + "!");
            }

            else if ((player1.choice == "lizard") && (player2.choice == "spock") || (player2.choice == "paper"))
            {
                player1.score++;
                Console.WriteLine("Lizard beats " + player2.choice + "!");
            }

            else if ((player1.choice == "spock") && (player2.choice == "scissors"))
            {
                player1.score++;
                Console.WriteLine("Spock smashes " + player2.choice + "!");
            }

            else player2.score++;
        }
        
    
        public void determineRoundWinner()
        {
            if(player1.score == 1)
            {
                Console.WriteLine(player1.name + " Wins the round!");
                Console.WriteLine(player1.name + " score is: " + player1.score);
                Console.WriteLine(player2.name + " score is: " + player2.score);
            }
            else if(player2.score == 1)
            {
                Console.WriteLine(player2.name + " Wins the round")
            }
            
        }
        
    
    
    
    }

}
