using FluentAssertions;
using System;
using UOM.Domain.Model.Dimensions;
using UOM.Domain.Model.Dimensions.Exceptions;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.Dimensions
{
    public class DimensionTests
    {
        private readonly DimensionTestBuilder dimensionTestBuilder;
        public DimensionTests()
        {
            dimensionTestBuilder = new DimensionTestBuilder();
        }

        [Fact]
        public void Constructor_should_construct_dimension_properly()
        {
            var title = "Length";
            var altTitle = "طول";
            var symbol = "L";

            var dimension = dimensionTestBuilder.WithTitle(title)
                                            .WithSymbol(symbol)
                                            .WithAlternativeTitle(altTitle).Build();

            dimension.Title.Should().Be(dimensionTestBuilder.Title);
            dimension.AlternateTitle.Should().Be(dimensionTestBuilder.AlternateTitle);
            dimension.Symbol.Should().Be(dimensionTestBuilder.Symbol);

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Constructor_should_throw_exception_when_title_is_null(string invalidTitle)
        {
            var title = invalidTitle;
            var altTitle = "طول";
            var symbol = "L";

            Action action = () => dimensionTestBuilder.WithTitle(title)
                                                      .WithAlternativeTitle(altTitle)
                                                      .WithSymbol(symbol)
                                                      .Build(); 

            Assert.Throws<InvalidTitleException>(action);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Constructor_should_throw_exception_when_symbol_is_null(string invalidSymbol)
        {
            var title = "Length";
            var altTitle = "طول";
            var symbol = invalidSymbol;

            Action action = () => dimensionTestBuilder.WithTitle(title)
                .WithAlternativeTitle(altTitle)
                .WithSymbol(symbol)
                .Build();

            Assert.Throws<InvalidSymbolException>(action);
        }

    }
}
