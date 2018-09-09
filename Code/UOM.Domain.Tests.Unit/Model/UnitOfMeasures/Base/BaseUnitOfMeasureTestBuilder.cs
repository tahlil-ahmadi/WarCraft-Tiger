using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Model.UnitOfMeasures.Base;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures.Base
{
    public class BaseUnitOfMeasureTestBuilder
    {
        public string IsoCode { get; private set; }
        public string Title { get; private set; }
        public string AlternateTitle { get; private set; }
        public string DimensionSymbol { get; private set; }

        public BaseUnitOfMeasureTestBuilder()
        {
            Title = "Gram";
            AlternateTitle = "گرم";
            IsoCode = "GR";
            DimensionSymbol = "M";
        }

        public BaseUnitOfMeasureTestBuilder WithTitle(string title)
        {
            this.Title = title;
            return this;
        }

        public BaseUnitOfMeasureTestBuilder WithAlternateTitle(string alternateTitle)
        {
            this.AlternateTitle = alternateTitle;
            return this;
        }
        public BaseUnitOfMeasureTestBuilder WithIsoCode(string isoCode)
        {
            this.IsoCode = isoCode;
            return this;
        }

        public BaseUnitOfMeasureTestBuilder WithDimensionSymbol(string dimensionSymbol)
        {
            this.DimensionSymbol = dimensionSymbol;
            return this;
        }

        public BaseUnitOfMeasure Build()
        {
            return new BaseUnitOfMeasure(this.IsoCode, this.Title, this.AlternateTitle, this.DimensionSymbol);
        }
    }
}
