using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    class AI : Player
    {
        // member vairables 
        
        private Random rand;
        public int gesturesCount;
        public int nameCount;
        private List<string> randNames;

        // constructor
        public AI()
        {
            randNames = new List<string>() { "Wally", "Dorf", "Grub", "Loppy" };
        }



        // member methods
        public override void chooseGesture()
        {
            int cpuGesture = rand.Next(gesturesCount);
            choice = gestures[cpuGesture];
            Console.WriteLine(choice);

        }

        public override void chooseName()
        {
            int cpuNames = rand.Next(nameCount);
            name = randNames[cpuNames];
            Console.WriteLine(name);

        }

    }
}
