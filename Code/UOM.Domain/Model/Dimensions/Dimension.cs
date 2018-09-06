namespace UOM.Domain.Model.Dimensions
{
    public class Dimension
    {
        public string Title { get; private set; }
        public string AlternateTitle { get;private  set; }
        public string Symbol { get;private  set; }
        public Dimension(string title, string alternateTitle, string symbol)
        {
            this.Title = title;
            this.AlternateTitle = alternateTitle;
            this.Symbol = symbol;
        }
    }
}