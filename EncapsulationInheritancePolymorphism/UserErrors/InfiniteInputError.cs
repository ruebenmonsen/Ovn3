using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class InfiniteInputError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to use an infinite input in a finite input only field. This fired an error!";
        }
    }
}
