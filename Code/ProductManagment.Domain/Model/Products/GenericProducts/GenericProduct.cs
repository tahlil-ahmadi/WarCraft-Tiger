using System.Collections.Generic;
using System.Linq;
using ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues;
using TigerFramework.Domain;

namespace ProductManagment.Domain.Model.Products.GenericProducts
{
    public class GenericProduct : AggregateRoot<int>
    {
        private readonly List<ConstraintValue> _constraintValues;
        public string Title { get; }
        public IReadOnlyCollection<ConstraintValue> ConstraintValues => this._constraintValues.AsReadOnly();
        public GenericProduct(int id, string title, List<ConstraintValue> constraintValues)
        {
            GuardAgainstDuplicateKey(constraintValues);

            Id = id;
            Title = title;
            _constraintValues = constraintValues;
        }
        private static void GuardAgainstDuplicateKey(List<ConstraintValue> constraintValues)
        {
            var isDuplicateKey = constraintValues.GroupBy(a => a.ConstraintId, 
                    (key, value) => new { key, Count = value.Count() })
                .Any(a => a.Count > 1);
            if (isDuplicateKey) throw new DuplicateConstraintException();
        }
    }
}
