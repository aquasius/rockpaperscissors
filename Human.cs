using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    class Human : Player
    {
        //member variables ( has a )




        // constructor




        // member methods ( can do )

        public override void chooseGesture()
        {
            Console.WriteLine("Please choose rock, paper, scissors, lizard, spock");
            choice = Console.ReadLine();
        }

        

    }
}
