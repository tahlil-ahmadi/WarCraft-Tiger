using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using UOM.Domain.Model;
using UOM.Domain.Model.UnitOfMeasures;
using Xunit;

namespace UOM.Domain.Tests.Unit.Model.UnitOfMeasures
{
    public class UnitOfMeasureTests
    {
        #region HelperClasses
        private class DummyUnitOfMeasure : UnitOfMeasure
        {
            public DummyUnitOfMeasure(string isoCode, string title, string alternateTitle) 
                : base(isoCode, title, alternateTitle)
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

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Constructor_should_throw_exception_when_title_is_null(string invalidTitle)
        {
            var expectedMessage = string.Format(InvalidInputException.InvalidInputExceptionMessageFormatString, "نماد واحد مبدا");

            var title = invalidTitle;
            var alternateTitle = "گرم";
            var isoCode = "GR";


            var exception = Assert.Throws<InvalidInputException>(() => {
                var unitOfMeasure = new DummyUnitOfMeasure(isoCode, title, alternateTitle);
            });

            exception.Message.Should().Be(expectedMessage);
        }


        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Constructor_should_throw_exception_when_isoCode_is_null(string invalidIsoCode)
        {
            var expectedMessage = string.Format(InvalidInputException.InvalidInputExceptionMessageFormatString, "کد ایزو");

            var title = "Gram";
            var alternateTitle = "گرم";
            var isoCode = invalidIsoCode;

            var exception = Assert.Throws<InvalidInputException>(() => {
                var unitOfMeasure = new DummyUnitOfMeasure(isoCode, title, alternateTitle);
            });

            exception.Message.Should().Be(expectedMessage);
        }


    }
}
