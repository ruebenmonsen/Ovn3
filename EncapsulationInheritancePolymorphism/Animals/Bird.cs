using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Bird : Animal
    {

        private int wingSpan;

        public int WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        internal override void DoSound()
        {
            Console.WriteLine("Chirp chirp");
        }
        internal override string Stats()
        {
            return base.Stats() + $" Has a wingspan of {WingSpan} units of lenght.";
        }
    }
}
