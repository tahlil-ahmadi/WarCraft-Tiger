using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Newtonsoft.Json.Linq;
using ProductManagement.Interface.RestApi.ModelBinders;
using ProductManagment.Application.Contracts;
using TigerFramework.Application;

namespace ProductManagement.Interface.RestApi
{
    public class ProductsController : ApiController
    {
        private readonly ICommandBus _commandBus;
        public ProductsController(ICommandBus commandBus)
        {
            this._commandBus = commandBus;
        }

        public void Post([ModelBinder(typeof(ProductModelBinder))]CreateGenericProductCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
