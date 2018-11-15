using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UOM.Application.Contracts;
using NSubstitute;
using UOM.Domain.Model.MeasurementDimensions;
using Xunit;
using FluentAssertions;
using AutoFixture;

namespace UOM.Application.Tests.Unit
{
    public class MeasurementDimensionCommandHandlerTests
    {
        [Fact]
        public void should_create_measurement_dimension()
        {
            var command = new Fixture().Create<CreateMeasurementDimensionCommand>();
            var repository = Substitute.For<IMeasurementDimensionRepository>();
            var commandHandler = new MeasurementDimensionCommandHandlers(repository);
            
            commandHandler.Handle(command);

            repository.Received(1).Add(Verify.That<MeasurementDimension>(a=>a.Should().BeEquivalentTo(command)));
        }
    }
}
