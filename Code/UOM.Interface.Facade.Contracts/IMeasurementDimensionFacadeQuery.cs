using System.Threading.Tasks;
using UOM.QueryModel.Model;

namespace UOM.Interface.Facade.Contracts
{
    public interface IMeasurementDimensionFacadeQuery
    {
        Task<MeasurementDimensionQuery> GetBySymbol(string symbol);
    }
}