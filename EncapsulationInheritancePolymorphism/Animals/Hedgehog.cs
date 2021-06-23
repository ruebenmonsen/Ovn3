using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Hedgehog : Animal
    {
        private int numberOfSpikes;

        public int NumberOfSpikes
        {
            get { return numberOfSpikes; }
            set { numberOfSpikes = value; }
        }

        internal override void DoSound()
        {
            Console.WriteLine("Squeak!");
        }
        internal override string Stats()
        {
            return base.Stats() + $" Number of spikes: {NumberOfSpikes}.";
        }
    }
}
