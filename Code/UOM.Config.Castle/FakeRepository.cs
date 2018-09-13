using System;
using System.Collections.Generic;
using System.Linq;
using UOM.Domain.Model.MeasurementDimensions;

namespace UOM.Config.Castle
{
    public class FakeRepository : IMeasurementDimensionRepository
    {
        private static List<MeasurementDimension> _dimensions = new List<MeasurementDimension>();
        public MeasurementDimension GetById(long id)
        {
            return null;
        }

        public void Add(MeasurementDimension dimension)
        {
        }
    }
}