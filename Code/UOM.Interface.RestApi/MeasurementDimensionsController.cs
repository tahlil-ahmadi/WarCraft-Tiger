using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using UOM.Application.Contracts;

namespace UOM.Interface.RestApi
{
    public class MeasurementDimensionsController : ApiController
    {
        private readonly IMeasurementDimensionService _service;
        public MeasurementDimensionsController(IMeasurementDimensionService service)
        {
            _service = service;
        }

        public void Post(CreateMeasurementDimensionDTO dto)
        {
            _service.Create(dto);
        }
    }
}
