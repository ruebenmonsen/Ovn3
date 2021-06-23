using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Worm : Animal
    {
        private int bodyLength;

        public int BodyLength
        {
            get { return bodyLength; }
            set { bodyLength = value; }
        }

        internal override void DoSound()
        {
            Console.WriteLine("Swibble swibble.");
        }
        internal override string Stats()
        {
            return base.Stats() + $" Bodylength: {BodyLength}.";
        }
    }
}
