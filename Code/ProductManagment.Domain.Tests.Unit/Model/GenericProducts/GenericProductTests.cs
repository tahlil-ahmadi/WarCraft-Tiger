using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ProductManagment.Domain.Model.Products.GenericProducts;
using ProductManagment.Domain.Tests.Unit.Utils;
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
            var constraintValues = ConstraintValueTestFactory.SomeValidConstraintValues();

            var genericProduct = new GenericProduct(id, title, constraintValues);

            genericProduct.Id.Should().Be(id);
            genericProduct.Title.Should().Be(title);
            genericProduct.ConstraintValues.Should().BeEquivalentTo(constraintValues);
        }

        [Fact]
        public void Should_throw_exception_when_constraint_is_duplicated()
        {
            var id = 10;
            var title = "Mobile Phone";
            var constraintValues = ConstraintValueTestFactory.SomeDuplicateConstraintValues();

            Action constructor = ()=> new GenericProduct(id, title, constraintValues);

            constructor.Should().Throw<DuplicateConstraintException>();
        }
    }
}
