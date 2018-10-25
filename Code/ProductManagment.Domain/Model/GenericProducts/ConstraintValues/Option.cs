namespace ProductManagment.Domain.Model.GenericProducts.ConstraintValues
{
    public class Option
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