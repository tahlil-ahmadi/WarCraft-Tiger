using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOM.Domain.Model.MeasurementDimensions
{
    public interface IMeasurementDimensionRepository
    {
        MeasurementDimension GetById(long id);
        void Add(MeasurementDimension dimension);
    }
}
