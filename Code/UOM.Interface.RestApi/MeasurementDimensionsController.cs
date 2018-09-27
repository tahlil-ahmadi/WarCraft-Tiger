using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TigerFramework.Application;
using UOM.Application.Contracts;

namespace UOM.Interface.RestApi
{
    public class MeasurementDimensionsController : ApiController
    {
        private readonly ICommandBus _bus;
        public MeasurementDimensionsController(ICommandBus bus)
        {
            _bus = bus;
        }

        public void Post(CreateMeasurementDimensionCommand command)
        {
            _bus.Dispatch(command);
        }
    }
}
