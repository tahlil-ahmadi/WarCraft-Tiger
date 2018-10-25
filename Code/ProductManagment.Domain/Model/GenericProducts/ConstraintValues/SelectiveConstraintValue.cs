using System.Collections.Generic;
using System.Linq;

namespace ProductManagment.Domain.Model.GenericProducts.ConstraintValues
{
    public class SelectiveConstraintValue

    {
        public int ConstraintId { get; }
        public List<Option> Options { get; }

        public SelectiveConstraintValue(int constraintId, List<Option> options)
        {
            var isDuplicateKey = options.GroupBy(a => a.Key, (key, value) => new {key, Count = value.Count()})
                .Any(a => a.Count > 1);
            if (isDuplicateKey) throw new DuplicateOptionException();

            ConstraintId = constraintId;
            Options = options;
        }
    }
}