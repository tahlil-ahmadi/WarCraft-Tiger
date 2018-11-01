using FluentAssertions;
using ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues;
using Xunit;

namespace ProductManagment.Domain.Tests.Unit
{
    public class StringConstraintValueTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var constraintId = 10;
            var maxLength = 50;

            var stringConstraintValue = new StringConstraintValue(constraintId, maxLength);

            stringConstraintValue.ConstraintId.Should().Be(constraintId);
            stringConstraintValue.MaxLength.Should().Be(maxLength);
        }

        [Theory]
        [InlineData(3, "A", true)]
        [InlineData(3, "AAA", true)]
        [InlineData(3, "AAAA", false)]
        [InlineData(3, null, false)]
        public void Validate_should_validated_characteristic_value_based_on_max_length(int maxLength, string charactristicValue, bool expectedResult)
        {
            var constraintId = 10;
            var stringConstraintValue = new StringConstraintValue(constraintId, maxLength);

            var result = stringConstraintValue.Validate(charactristicValue);

            result.Should().Be(expectedResult);
        }
    }
}