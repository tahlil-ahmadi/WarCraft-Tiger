namespace ProductManagment.Domain.Model.GenericProducts.ConstraintValues
{
    public class NumericRangeConstraintValue
    {
        public int ConstraintId { get; }
        public Range Range { get; private set; }
        public NumericRangeConstraintValue(int constraintId, int? min, int? max)
        {
            ConstraintId = constraintId;
            this.Range = new Range(min,max);
        }

        public bool Validate(int value)
        {
            return this.Range.IsValid(value);
        }
    }
}