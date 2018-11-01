using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues;

namespace ProductManagment.Domain.Tests.Unit.Utils
{
    public static class ConstraintValueTestFactory
    {
        public static List<ConstraintValue> SomeValidConstraintValues()
        {
            return new List<ConstraintValue>()
            {
                new BooleanConstraintValue(1),
                new NumericRangeConstraintValue(2,20,30)
            };
        }

        public static List<ConstraintValue> SomeDuplicateConstraintValues()
        {
            return new List<ConstraintValue>()
            {
                new BooleanConstraintValue(1),
                new BooleanConstraintValue(1),
                new NumericRangeConstraintValue(2,20,30)
            };
        }
    }
}
