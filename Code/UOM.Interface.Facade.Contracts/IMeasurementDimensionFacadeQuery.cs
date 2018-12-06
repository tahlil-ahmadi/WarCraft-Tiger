using System.Collections.Generic;
using System.Threading.Tasks;
using UOM.QueryModel.Model;

namespace UOM.Interface.Facade.Contracts
{
    public interface IMeasurementDimensionFacadeQuery
    {
        Task<MeasurementDimensionQuery> GetBySymbol(string symbol);
        Task<IEnumerable<MeasurementDimensionQuery>> GetAll();
    }
}