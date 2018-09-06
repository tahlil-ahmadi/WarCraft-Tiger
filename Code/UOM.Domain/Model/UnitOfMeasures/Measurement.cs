using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOM.Domain.Model.UnitOfMeasures
{
    public class Measurement
    {
        public decimal Amount { get; private set; }
        public string UnitOfMeasure { get; private set; }
        public Measurement(decimal amount, string unitOfMeasure)
        {
            Amount = amount;
            UnitOfMeasure = unitOfMeasure;
        }
    }
}
