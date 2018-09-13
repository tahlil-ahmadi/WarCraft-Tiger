using FluentAssertions;
using UOM.Domain.Model;
using UOM.Domain.Model.UnitOfMeasures.Base;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures.Base
{

    public class BaseUnitOfMeasureTests
    {
        private readonly BaseUnitOfMeasureTestBuilder baseUomBuilder;
        public BaseUnitOfMeasureTests()
        {
            baseUomBuilder = new BaseUnitOfMeasureTestBuilder();
        }

        [Fact]
        public void Constructor_should_construct_baseUnitOfMeasure_properly()
        {
            var title = "Gram";
            var alternateTitle = "گرم";
            var isoCode = "GR";
            var dimensionSymbol = "M";

            var unitOfMeasure = baseUomBuilder.WithTitle(title)
                                            .WithAlternateTitle(alternateTitle)
                                            .WithIsoCode(isoCode)
                                            .WithDimensionSymbol(dimensionSymbol).Build();

            unitOfMeasure.Title.Should().Be(baseUomBuilder.Title);
            unitOfMeasure.AlternateTitle.Should().Be(baseUomBuilder.AlternateTitle);
            unitOfMeasure.IsoCode.Should().Be(baseUomBuilder.IsoCode);
            unitOfMeasure.DimensionSymbol.Should().Be(baseUomBuilder.DimensionSymbol);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Constructor_should_throw_exception_when_dimensionSymbol_is_null(string invalidDimensionSymbol)
        {
            var expectedMessage = string.Format(InvalidInputException.InvalidInputExceptionMessageFormatString, "نماد واحد مقصد");

            var title = "Gram";
            var alternateTitle = "گرم";
            var isoCode = "GR";
            var dimensionSymbol = invalidDimensionSymbol;

            var exception = Assert.Throws<InvalidInputException>(() => {
                baseUomBuilder.WithTitle(title)
                    .WithAlternateTitle(alternateTitle)
                    .WithIsoCode(isoCode)
                    .WithDimensionSymbol(dimensionSymbol).Build();
            });

            exception.Message.Should().Be(expectedMessage);
        }
    }
}
