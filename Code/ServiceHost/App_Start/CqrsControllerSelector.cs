using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace ServiceHost.App_Start
{
    public class CqrsControllerSelector : DefaultHttpControllerSelector
    {
        public CqrsControllerSelector(HttpConfiguration configuration) : base(configuration)
        {
        }


        public override string GetControllerName(HttpRequestMessage request)
        {
            var controllerName = base.GetControllerName(request);
            if (request.Method == HttpMethod.Get)
                controllerName += "Query";
            return controllerName;
        }
    }
}