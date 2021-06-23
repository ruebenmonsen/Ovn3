using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    public class Wolf : Animal
    {
        private bool isPackLeader;

        public bool IsPackLeader
        {
            get { return isPackLeader; }
            set { isPackLeader = value; }
        }

        internal override void DoSound()
        {
            Console.WriteLine("Howl!");
        }
        internal override string Stats()
        {
            return base.Stats() + $" Is the pack leader: {IsPackLeader}.";
        }
    }
}
