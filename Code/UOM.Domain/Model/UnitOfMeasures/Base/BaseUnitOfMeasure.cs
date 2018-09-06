namespace UOM.Domain.Model.UnitOfMeasures.Base
{
    public class BaseUnitOfMeasure : UnitOfMeasure
    {
        public string DimensionSymbol { get; private set; }
        public BaseUnitOfMeasure(string isoCode, string title, string alternateTitle, string dimensionSymbol) 
            : base(isoCode, title,alternateTitle)
        {
            this.DimensionSymbol = dimensionSymbol;
        }
    }
}