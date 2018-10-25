using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagment.Domain.Model.GenericProducts.ConstraintValues
{
    public abstract class ConstraintValue
    {
        public long ConstraintId { get; }
        protected ConstraintValue(long constraintId)
        {
            ConstraintId = constraintId;
        }
    }
}
