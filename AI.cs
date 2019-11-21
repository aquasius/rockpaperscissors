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
        
        
        public int gesturesCount;
        public int nameCount;
        private List<string> randNames;
        private Random rand;

        // constructor
        public AI(Random random)
        {
            randNames = new List<string>() { "Wally", "Dorf", "Grub", "Loppy" };
            rand = random;
            nameCount = randNames.Count;

        }



        // member methods
        public override void chooseGesture()
        {
            int cpuGesture = rand.Next(gestures.Count - 1);
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
