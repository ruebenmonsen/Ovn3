using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Dog : Animal
    {
        private int humanFriends;
        private bool excited = true;

        public int HumanFriends
        {
            get { return humanFriends; }
            set { humanFriends = value; }
        }

        internal override void DoSound()
        {
            Console.WriteLine("Woof!");
        }
        internal override string Stats()
        {
            return base.Stats() + $" {humanFriends} human friends.";
        }
        internal string WaggleTail()
        {
            if (excited)
                return $"{Name} waggles his tail!";
            else
                return $"{Name}s tail isn't wagging.";
        }
    }
}