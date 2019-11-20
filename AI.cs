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
            Random rnd = new Random();
            rnd.Next(0, 5);
        }

        public void createCPUName()
        {
            Random compName = new Random();
            compName.Next()
        }

        public override void chooseGesture()
        {
            
        }
    }
}
