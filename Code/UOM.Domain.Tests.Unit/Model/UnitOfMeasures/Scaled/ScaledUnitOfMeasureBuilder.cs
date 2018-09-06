using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Model.UnitOfMeasures.Scaled;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures.Scaled
{
    public class ScaledUnitOfMeasureBuilder
    {
        private string IsoCode { get; set; }

        private string Title { get; set; }

        public string AlternateTitle { get; set; }

        private string BaseIsoCode { get; set; }

        private decimal ConversionFactor { get; set; }

        public ScaledUnitOfMeasureBuilder WithIsoCode(string isoCode)
        {
            this.IsoCode = isoCode;
            return this;
        }

        public ScaledUnitOfMeasureBuilder WithTitle(string title)
        {
            this.Title = title;
            return this;
        }

        public ScaledUnitOfMeasureBuilder WithAlternateTitle(string alternateTitle)
        {
            this.AlternateTitle = alternateTitle;
            return this;
        }

        public ScaledUnitOfMeasureBuilder WithBaseIsoCode(string baseIsoCode)
        {
            this.BaseIsoCode = baseIsoCode;
            return this;
        }

        public ScaledUnitOfMeasureBuilder WithConversionFactor(decimal conversionFactor)
        {
            this.ConversionFactor = conversionFactor;
            return this;
        }


        public ScaledUnitOfMeasure Build()
        {
            return new ScaledUnitOfMeasure(IsoCode, Title, AlternateTitle, BaseIsoCode, ConversionFactor);
        }
    }
}
