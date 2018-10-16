using TigerFramework.Application;
using UOM.Application.Contracts;
using UOM.Domain.Model.MeasurementDimensions;

namespace UOM.Application
{
    public class MeasurementDimensionCommandHandlers : ICommandHandler<CreateMeasurementDimensionCommand>
    {
        private readonly IMeasurementDimensionRepository _repository;
        public MeasurementDimensionCommandHandlers(IMeasurementDimensionRepository repository)
        {
            _repository = repository;
        }

        public void Handle(CreateMeasurementDimensionCommand command)
        {
            //start transaction
            var measurementDimension = new MeasurementDimension(command.Title,command.AlternateTitle, command.Symbol);
            _repository.Add(measurementDimension);
            //commit transaction
        }
    }
}
