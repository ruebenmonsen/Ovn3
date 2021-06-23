using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class IrrationalInputError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to use an irrational number in a rational number only field. This fired an error!";
        }
    }
}
