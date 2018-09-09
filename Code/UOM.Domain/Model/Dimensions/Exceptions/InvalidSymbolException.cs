using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOM.Domain.Model.Dimensions.Exceptions
{
   public class InvalidSymbolException : Exception
    {
        public InvalidSymbolException(String message):base(message)
        {

        }
    }
}
