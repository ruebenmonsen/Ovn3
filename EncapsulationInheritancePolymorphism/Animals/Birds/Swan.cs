using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Swan : Bird
    {
        private bool hasLifetimePartner;

        public bool HasLifetimePartner
        {
            get { return hasLifetimePartner; }
            set { hasLifetimePartner = value; }
        }
        internal override void DoSound()
        {
            Console.WriteLine("oh-OH!"); // Enligt google
        }
        internal override string Stats()
        {
            return base.Stats() + $" Has a lifetime partner: {HasLifetimePartner}.";
        }
    }
}