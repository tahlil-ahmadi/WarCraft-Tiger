using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using UOM.Domain.Model.UnitOfMeasures;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures
{
    public class UnitOfMeasureTests
    {
        #region HelperClasses
        private class DummyUnitOfMeasure : UnitOfMeasure
        {
            public DummyUnitOfMeasure(string isoCode, string title, string title2) 
                : base(isoCode, title, title2)
            {
            }
        }
        #endregion

        [Fact]
        public void X()
        {
            var title = "Gram";
            var alternateTitle = "گرم";
            var isoCode = "GR";

            var unitOfMeasure = new DummyUnitOfMeasure(isoCode, title, alternateTitle);

            unitOfMeasure.IsoCode.Should().Be(isoCode);
            unitOfMeasure.Title.Should().Be(title);
            unitOfMeasure.AlternateTitle.Should().Be(alternateTitle);
        }
    }
}
