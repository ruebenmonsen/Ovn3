using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Horse : Animal
    {
        private string horseshoeMaterial;

        public string HorseshoeMaterial
        {
            get { return horseshoeMaterial; }
            set { horseshoeMaterial = value; }
        }

        internal override void DoSound()
        {
            Console.WriteLine("Neigh.");
        }
        internal override string Stats()
        {
            return base.Stats() + $" Horseshoe material: {HorseshoeMaterial}.";
        }
    }
}
