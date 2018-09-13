using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Application.Contracts;
using UOM.Domain.Model.MeasurementDimensions;

namespace UOM.Application
{
    public class MeasurementDimensionService : IMeasurementDimensionService
    {
        private readonly IMeasurementDimensionRepository _repository;
        public MeasurementDimensionService(IMeasurementDimensionRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateMeasurementDimensionDTO dto)
        {
            var measurementDimension = new MeasurementDimension(dto.Title,dto.AlternateTitle, dto.Symbol);
            _repository.Add(measurementDimension);
        }
    }
}
