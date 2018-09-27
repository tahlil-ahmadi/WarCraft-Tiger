namespace UOM.Application.Contracts
{
    public class CreateMeasurementDimensionCommand
    {
        public string Title { get; set; }
        public string AlternateTitle { get; set; }
        public string Symbol { get; set; }
    }
}