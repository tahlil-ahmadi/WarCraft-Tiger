using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Model.MeasurementDimensions;

namespace UOM.Domain.Tests.Unit.Model.Dimensions
{
    public class DimensionTestBuilder
    {
        public string Title { get; private set; }
        public string AlternateTitle { get; private set; }
        public string Symbol { get; private set; }

        public DimensionTestBuilder()
        {
            Title = "Length";
            AlternateTitle = "طول";
            Symbol = "L";
        }


        public DimensionTestBuilder WithTitle(string title)
        {
            this.Title = title;
            return this;
        }


        public DimensionTestBuilder WithAlternativeTitle(string alternativeTitle)
        {
            this.AlternateTitle = alternativeTitle;
            return this;
        }

        public DimensionTestBuilder WithSymbol(string symbol)
        {
            this.Symbol = symbol;
            return this;
        }


        public MeasurementDimension Build()
        {
            return new MeasurementDimension(this.Title, this.AlternateTitle, this.Symbol);
        }


    }
}
