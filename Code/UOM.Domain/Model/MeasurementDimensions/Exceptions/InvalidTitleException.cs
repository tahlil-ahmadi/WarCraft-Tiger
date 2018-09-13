using System;

namespace UOM.Domain.Model.MeasurementDimensions.Exceptions
{
    public class InvalidTitleException : Exception
    {
        public InvalidTitleException(string message) : base(message)
        {

        }
    }
}
