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
        public string name;
        private Random rand;
        public int gesturesCount;


        // constructor



        // member methods
        private void randomizeGestures()
        {
            int cpuGesture = rand.Next(gesturesCount);
            choice = gestures[cpuGesture];
            Console.WriteLine(choice);
        }

        

        public override void chooseGesture()
        {
            
       
        }

        public override void chooseName()
        {
            Console.WriteLine("My name is Grub");
            Console.ReadLine();

        }

    }
}
