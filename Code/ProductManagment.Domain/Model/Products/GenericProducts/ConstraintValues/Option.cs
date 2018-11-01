using TigerFramework.Core.EqualityHelpers;
using TigerFramework.Domain;

namespace ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues
{
    public class Option : ValueObject
    {
        public int Key { get; private set; }
        public string Value { get;private  set; }
        public Option(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}