using FluentAssertions;
using UOM.Domain.Model.UnitOfMeasures.Base;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures.Base
{
    public class BaseUnitOfMeasureTests
    {
        [Fact]
        public void Constructor_should_construct_baseUnitOfMeasure_properly()
        {
            //TODO: remove duplication (use creational patterns)
            var title = "Gram";
            var alternateTitle = "گرم";
            var isoCode = "GR";
            var dimensionSymbol = "M";

            var unitOfMeasure = new BaseUnitOfMeasure(isoCode, title, alternateTitle, dimensionSymbol);

            unitOfMeasure.Title.Should().Be(title);
            unitOfMeasure.AlternateTitle.Should().Be(alternateTitle);
            unitOfMeasure.IsoCode.Should().Be(isoCode);
            unitOfMeasure.DimensionSymbol.Should().Be(dimensionSymbol);
        }
    }
}
