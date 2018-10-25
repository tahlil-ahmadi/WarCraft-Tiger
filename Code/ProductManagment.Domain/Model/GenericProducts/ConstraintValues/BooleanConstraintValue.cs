namespace ProductManagment.Domain.Model.GenericProducts.ConstraintValues
{
    public class BooleanConstraintValue
    {
        public int ConstraintId { get; }
        public BooleanConstraintValue(int constraintId)
        {
            ConstraintId = constraintId;
        }
    }
}