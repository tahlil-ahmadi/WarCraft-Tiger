using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ProductManagment.Domain.Model.GenericProducts;
using ProductManagment.Domain.Model.GenericProducts.ConstraintValues;
using Xunit;

namespace ProductManagment.Domain.Tests.Unit.Model.GenericProducts
{
    public class GenericProductTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var id = 10;
            var title = "Mobile Phone";
            var constraintValues = SomeConstraintValues();

            var genericProduct = new GenericProduct(id, title, constraintValues);

            genericProduct.Id.Should().Be(id);
            genericProduct.Title.Should().Be(title);
            genericProduct.ConstraintValues.Should().BeEquivalentTo(constraintValues);
        }

        //Anonymous Creation Method
        private List<ConstraintValue> SomeConstraintValues()
        {
            //TODO: move to a test util
            return new List<ConstraintValue>()
            {
                new BooleanConstraintValue(1),
                new NumericRangeConstraintValue(2,20,30)
            };
        }
    }
}
