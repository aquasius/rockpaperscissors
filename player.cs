using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    public abstract class Player
    {
        //member variables ( has a ) 
        public int score;
        public string choice;
        public List<string> gestures;
        public string name;





        //constructor
        public Player()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            score = 0;
        }



        //member methods ( can do )
        

        public abstract void chooseGesture();
        
           

        

    }
}
