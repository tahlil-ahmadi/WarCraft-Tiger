using UOM.Domain.Model.Dimensions.Exceptions;

namespace UOM.Domain.Model.Dimensions
{
    public class Dimension
    {
        public string Title { get; private set; }
        public string AlternateTitle { get;private  set; }
        public string Symbol { get;private  set; }
        public Dimension(string title, string alternateTitle, string symbol)
        {
            GaurdAgainstEmptyTitle(title);

            this.Title = title;
            this.AlternateTitle = alternateTitle;
            this.Symbol = symbol;
        }

        private static void GaurdAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidTitleException("Title should not be empty");
            }
        }
    }
}