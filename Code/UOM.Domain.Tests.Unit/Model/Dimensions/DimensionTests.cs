using FluentAssertions;
using UOM.Domain.Model.Dimensions;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.Dimensions
{
    public class DimensionTests
    {
        [Fact]
        public void Constructor_should_construct_dimension_properly()
        {
            var title = "Length";
            var altTitle = "طول";
            var symbol = "L";

            var dimension = new Dimension(title, altTitle, symbol);

            dimension.Symbol.Should().Be(symbol);
            dimension.Title.Should().Be(title);
            dimension.AlternateTitle.Should().Be(altTitle);
        }
    }
}
