namespace UOM.Domain.Model.UnitOfMeasures.Base
{
    public class BaseUnitOfMeasure : UnitOfMeasure
    {
        public string DimensionSymbol { get; private set; }
        public BaseUnitOfMeasure(string isoCode, string title, string alternateTitle, string dimensionSymbol) 
            : base(isoCode, title,alternateTitle)
        {
           
            GuardAgainstEmptyDimensionSymbol(dimensionSymbol);
            this.DimensionSymbol = dimensionSymbol;
        }

        private void GuardAgainstEmptyDimensionSymbol(string dimensionSymbol)
        {
            if (string.IsNullOrWhiteSpace(dimensionSymbol) || string.IsNullOrEmpty(dimensionSymbol))
            {
                throw new InvalidInputException("نماد واحد مقصد");
            }
        }

      
    }
}