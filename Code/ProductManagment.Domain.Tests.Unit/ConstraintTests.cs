using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ProductManagment.Domain.Model.Constraints;
using Xunit;

namespace ProductManagment.Domain.Tests.Unit
{
    public class ConstraintTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var id = 1;
            var title = "Weight";

            var constraint = new Constraint(id, title);

            constraint.Id.Should().Be(id);
            constraint.Title.Should().Be(title);
        }
    }
}
