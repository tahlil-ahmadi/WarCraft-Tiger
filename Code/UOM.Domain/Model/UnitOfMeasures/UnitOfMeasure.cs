namespace UOM.Domain.Model.UnitOfMeasures
{
    public abstract class UnitOfMeasure
    {
        public string IsoCode { get;private set; }
        public string Title { get; private set; }
        public string AlternateTitle { get; private set; }
        protected UnitOfMeasure(string isoCode, string title, string altTitle)
        {
            this.IsoCode = isoCode;
            this.Title = title;
            this.AlternateTitle = altTitle;
        }
    }

}