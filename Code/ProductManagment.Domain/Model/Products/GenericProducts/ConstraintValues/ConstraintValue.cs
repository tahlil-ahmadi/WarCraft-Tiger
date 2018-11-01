namespace ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues
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
