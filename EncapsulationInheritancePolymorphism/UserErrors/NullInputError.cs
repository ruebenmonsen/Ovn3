using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class NullInputError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to use a null input in an input field requiring something. This fired an error!";
        }
    }
}