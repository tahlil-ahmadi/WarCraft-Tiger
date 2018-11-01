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
    public class SelectiveConstraintValueTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var constraintId = 10;
            var options = new List<Option>()
            {
                new Option(1,"Red"),
                new Option(2,"Blue"),
            };

            var selectiveConstraint = new SelectiveConstraintValue(constraintId, options);

            selectiveConstraint.ConstraintId.Should().Be(constraintId);
            selectiveConstraint.Options.Should().BeEquivalentTo(options);
        }

        [Fact]
        public void Should_throw_when_option_is_duplicated()
        {
            var constraintId = 10;
            var options = new List<Option>()
            {
                new Option(1,"Red"),
                new Option(2,"Yellow"),
                new Option(1,"Blue"),
            };

            Action constructor = () => new SelectiveConstraintValue(constraintId, options);

            constructor.Should().Throw<DuplicateOptionException>();
        }
    }
}
