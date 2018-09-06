namespace UOM.Domain.Model.UnitOfMeasures.Scaled
{
    public class ScaledUnitOfMeasure : UnitOfMeasure
    {
        public string BaseUnitOfMeasureIsoCode { get;private set; }
        public decimal ConversionFactor { get; private set; }

        public ScaledUnitOfMeasure(string isoCode, string title, string alternateTitle, string baseIsoCode, decimal conversionFactor)
            :base(isoCode, title, alternateTitle)
        {
            this.BaseUnitOfMeasureIsoCode = baseIsoCode;
            this.ConversionFactor = conversionFactor;
        }

        public Measurement ConvertToBase(Measurement measurement)
        {
            var value = measurement.Amount * this.ConversionFactor;
            return new Measurement(value, this.BaseUnitOfMeasureIsoCode);
        }

        public Measurement ConvertTo(Measurement measurement, ScaledUnitOfMeasure destinationUom)
        {
            var valueInBaseScale = measurement.Amount * this.ConversionFactor;
            var valueInDestinationScale = valueInBaseScale / destinationUom.ConversionFactor;
            return new Measurement(valueInDestinationScale, destinationUom.IsoCode);
        }
    }
}