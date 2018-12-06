using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TigerFramework.Application;
using UOM.Application.Contracts;
using UOM.Interface.Facade.Contracts;
using UOM.QueryModel.Model;

namespace UOM.Interface.RestApi
{
    public class MeasurementDimensionsQueryController : ApiController
    {
        private IMeasurementDimensionFacadeQuery _query;
        public MeasurementDimensionsQueryController(IMeasurementDimensionFacadeQuery query)
        {
            this._query = query;
        }
        public async Task<MeasurementDimensionQuery> Get(string symbol)
        {
            return await _query.GetBySymbol(symbol);
        }

        public async Task<IEnumerable<MeasurementDimensionQuery>> GetAll()
        {
            return await _query.GetAll();
        }
    }
}
