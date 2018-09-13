using UOM.Domain.Model.MeasurementDimensions.Exceptions;

namespace UOM.Domain.Model.MeasurementDimensions
{
    public class MeasurementDimension
    {
        public string Title { get; private set; }
        public string AlternateTitle { get;private  set; }
        public string Symbol { get;private  set; }
        public MeasurementDimension(string title, string alternateTitle, string symbol)
        {
            GaurdAgainstEmptyTitle(title);
            GuardAgainstEmptySymbol(symbol);

            this.Title = title;
            this.AlternateTitle = alternateTitle;
            this.Symbol = symbol;
        }

        private void GuardAgainstEmptySymbol(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol) || string.IsNullOrWhiteSpace(symbol))
            {
                throw new InvalidSymbolException("نماد مربوطه را وارد نمایید");
            }
        }

        private static void GaurdAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title))
            {
                throw new InvalidTitleException("Title should not be empty");
            }
        }
    }
}