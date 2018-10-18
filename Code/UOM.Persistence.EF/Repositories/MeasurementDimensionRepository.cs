using System;
using UOM.Domain.Model.MeasurementDimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class MeasurementDimensionRepository : IMeasurementDimensionRepository
    {
        private readonly UomContext _context;
        public MeasurementDimensionRepository(UomContext context)
        {
            _context = context;
        }
        public MeasurementDimension GetById(long id)
        {
            return this._context.MeasurementDimensions.Find(id);
        }

        public void Add(MeasurementDimension dimension)
        {
            //TODO: remove save changes from here
            this._context.MeasurementDimensions.Add(dimension);
            this._context.SaveChanges();
        }
    }
}
