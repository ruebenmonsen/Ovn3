using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("I am a howlf!");
        }
    }
}