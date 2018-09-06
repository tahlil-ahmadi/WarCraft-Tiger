using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using UOM.Domain.Model.UnitOfMeasures;
using UOM.Domain.Model.UnitOfMeasures.Scaled;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures.Scaled
{
    public class ScaledUnitOfMeasureTests
    {
        [Fact]
        public void Constructor_should_construct_scaledUnitOfMeasure_properly()
        {
            //TODO: remove duplication (use creational patterns)
            var title = "Kilogram";
            var alternateTitle = "کیلوگرم";
            var isoCode = "KG";
            var baseIsoCode = "GR";
            var conversionFactor = 1000M;

            var scaledUnitOfMeasure = new ScaledUnitOfMeasure(isoCode, title, alternateTitle, baseIsoCode, conversionFactor);

            scaledUnitOfMeasure.Title.Should().Be(title);
            scaledUnitOfMeasure.AlternateTitle.Should().Be(alternateTitle);
            scaledUnitOfMeasure.IsoCode.Should().Be(isoCode);
            scaledUnitOfMeasure.BaseUnitOfMeasureIsoCode.Should().Be(baseIsoCode);
            scaledUnitOfMeasure.ConversionFactor.Should().Be(conversionFactor);
        }

        [Fact]
        public void Convert_should_convert_measurement_to_baseUnitOfMeasure()
        {
            var title = "Kilogram";
            var alternateTitle = "کیلوگرم";
            var isoCode = "KG";
            var baseIsoCode = "GR";
            var conversionFactor = 1000M;
            var scaledUnitOfMeasure = new ScaledUnitOfMeasure(isoCode, title, alternateTitle, baseIsoCode, conversionFactor);
            var measurement = new Measurement(100,"KG");

            var result = scaledUnitOfMeasure.ConvertToBase(measurement);

            result.Amount.Should().Be(100000);
            result.UnitOfMeasure.Should().Be(baseIsoCode);
        }

        [Fact]
        public void Convert_should_convert_measurement_to_scaledUnitOfMeasure()
        {
            var title = "Kilogram";
            var alternateTitle = "کیلوگرم";
            var isoCode = "KG";
            var baseIsoCode = "GR";
            var conversionFactor = 1000M;
            var kiloGram = new ScaledUnitOfMeasure(isoCode, title, alternateTitle, baseIsoCode, conversionFactor);
            var hundredKilogram = new ScaledUnitOfMeasure("HK","Hundred Kilogram","صد کیلوگرم", baseIsoCode, 100000);

            var measurement = new Measurement(700,"KG");

            var result = kiloGram.ConvertTo(measurement, hundredKilogram);

            result.Amount.Should().Be(7);
            result.UnitOfMeasure.Should().Be("HK");
        }

        [Fact]
        public void Convert_should_convert_measurement_to_scaledUnitOfMeasureXX()
        {
            var title = "Kilometer";
            var alternateTitle = "کیلومتر";
            var isoCode = "KM";
            var baseIsoCode = "M";
            var conversionFactor = 1000M;
            var kilometer = new ScaledUnitOfMeasure(isoCode, title, alternateTitle, baseIsoCode, conversionFactor);
            var centimeter = new ScaledUnitOfMeasure("CM", "Centimeter", "سانتی متر", baseIsoCode, 0.01M);

            var measurement = new Measurement(1, "KM");

            var result = kilometer.ConvertTo(measurement, centimeter);

            result.Amount.Should().Be(100000);
            result.UnitOfMeasure.Should().Be("CM");
        }
    }
}
