namespace ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues
{
    public class StringConstraintValue : ConstraintValue
    {
        public int MaxLength { get; private set; }
        public StringConstraintValue(long constraintId, int maxLength) : base(constraintId)
        {
            MaxLength = maxLength;
        }

        public bool Validate(string characteristicValue)
        {
            return characteristicValue?.Length <= this.MaxLength;
        }
    }
}