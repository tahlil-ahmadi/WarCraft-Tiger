using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues;
using Xunit;

namespace ProductManagment.Domain.Tests.Unit
{
    public class NumericRangeConstraintValueTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var constraintId = 20;
            var min = 10;
            var max = 100;

            var numericConstraint = new NumericRangeConstraintValue(constraintId, min, max);

            numericConstraint.Range.Max.Should().Be(max);
            numericConstraint.Range.Min.Should().Be(min);
            numericConstraint.ConstraintId.Should().Be(constraintId);
        }

        [Theory]
        [InlineData(10,100,50)]
        [InlineData(10,100,10)]
        [InlineData(10,100,100)]
        [InlineData(null,100,50)]
        [InlineData(10, null,50)]
        public void Validate_should_return_true_when_characteristic_value_is_valid(int? min, int? max, int value)
        {
            var constraintId = 20;

            var numericConstraint = new NumericRangeConstraintValue(constraintId, min, max);

            var isValid = numericConstraint.Validate(value);

            isValid.Should().Be(true);
        }


        [Theory]
        [InlineData(10, 100, 9)]
        [InlineData(10, 100, 101)]
        [InlineData(null, 100, 101)]
        [InlineData(10, null, 9)]
        public void Validate_should_return_false_when_characteristic_value_is_not_valid(int? min, int? max, int value)
        {
            var constraintId = 20;

            var numericConstraint = new NumericRangeConstraintValue(constraintId, min, max);

            var isValid = numericConstraint.Validate(value);

            isValid.Should().Be(false);
        }
    }
}
