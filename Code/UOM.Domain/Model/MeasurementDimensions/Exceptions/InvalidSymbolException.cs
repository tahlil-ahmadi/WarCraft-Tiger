using System;

namespace UOM.Domain.Model.MeasurementDimensions.Exceptions
{
   public class InvalidSymbolException : Exception
    {
        public InvalidSymbolException(String message):base(message)
        {

        }
    }
}
