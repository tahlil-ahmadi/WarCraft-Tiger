using FluentAssertions;
using ProductManagment.Domain.Model.GenericProducts.ConstraintValues;
using Xunit;

namespace ProductManagment.Domain.Tests.Unit
{
    public class BooleanConstraintValueTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var constraintId = 10;

            var booleanConstraint = new BooleanConstraintValue(constraintId);

            booleanConstraint.ConstraintId.Should().Be(constraintId);
        }
    }
}