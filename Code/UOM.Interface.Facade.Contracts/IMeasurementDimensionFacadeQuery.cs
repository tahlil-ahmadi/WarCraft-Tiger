using UOM.QueryModel.Model;

namespace UOM.Interface.Facade.Contracts
{
    public interface IMeasurementDimensionFacadeQuery
    {
        MeasurementDimensionQuery GetBySymbol(string symbol);
    }
}