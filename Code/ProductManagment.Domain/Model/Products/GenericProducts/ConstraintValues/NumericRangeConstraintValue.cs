namespace ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues
{
    public class NumericRangeConstraintValue : ConstraintValue
    {
        public Range Range { get; private set; }
        public NumericRangeConstraintValue(int constraintId, int? min, int? max)
                :base(constraintId)
        {
            this.Range = new Range(min,max);
        }

        public bool Validate(int value)
        {
            return this.Range.IsValid(value);
        }
    }
}