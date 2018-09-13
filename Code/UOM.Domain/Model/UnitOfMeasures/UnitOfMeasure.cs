namespace UOM.Domain.Model.UnitOfMeasures
{
    public abstract class UnitOfMeasure
    {

        public string IsoCode { get;private set; }
        public string Title { get; private set; }
        public string AlternateTitle { get; private set; }
        protected UnitOfMeasure(string isoCode, string title, string altTitle)
        {
            GuardAgainstEmptyIsoCode(isoCode);
            GuardAgainstEmptyTitle(title);

            this.IsoCode = isoCode;
            this.Title = title;
            this.AlternateTitle = altTitle;
        }

        private void GuardAgainstEmptyIsoCode(string isoCode)
        {
            if (string.IsNullOrEmpty(isoCode) || string.IsNullOrWhiteSpace(isoCode))
            {
                throw new InvalidInputException("کد ایزو");
            }
        }
        private void GuardAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title))
            {
                throw new InvalidInputException("نماد واحد مبدا");
            }
        }
    }

}