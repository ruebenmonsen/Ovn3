using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Flamingo : Bird
    {
        private int uniqueFlamingoProperty;

        public int UniqueFlamingoProperty
        {
            get { return uniqueFlamingoProperty; }
            set { uniqueFlamingoProperty = value; }
        }

    }
}
