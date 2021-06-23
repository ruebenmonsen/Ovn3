using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Pelican : Bird
    {
        private int uniquePelicanProperty;

        public int UniquePelicanProperty
        {
            get { return uniquePelicanProperty; }
            set { uniquePelicanProperty = value; }
        }
    }
}