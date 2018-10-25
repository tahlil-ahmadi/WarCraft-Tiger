using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagment.Domain.Model.GenericProducts.ConstraintValues;

namespace ProductManagment.Domain.Model.GenericProducts
{
    public class GenericProduct
    {
        private readonly List<ConstraintValue> _constraintValues;

        public int Id { get; }
        public string Title { get; }
        public IReadOnlyCollection<ConstraintValue> ConstraintValues => this._constraintValues.AsReadOnly();
        public GenericProduct(int id, string title, List<ConstraintValue> constraintValues)
        {
            Id = id;
            Title = title;
            _constraintValues = constraintValues;
        }
    }
}
