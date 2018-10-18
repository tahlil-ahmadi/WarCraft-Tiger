using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using UOM.Specs.Model;

namespace UOM.Specs.Tasks
{
   internal class MeasurementDimensionTasks
    {
        internal void DefineDimension(DimensionTestModel model)
        {
            var client = new RestClient("http://localhost:29210/");
            var request = new RestRequest("api/MeasurementDimensions",Method.POST);
            request.AddJsonBody(model);
            var response = client.Execute(request);
            if (!response.IsSuccessful)
                throw new Exception(response.ErrorMessage);
        }

        internal DimensionTestModel GetDimension(string symbol)
        {
            var client = new RestClient("http://localhost:29210/");
            var request = new RestRequest("api/MeasurementDimensions");
            request.AddParameter("symbol", symbol);
            var response =  client.Execute<DimensionTestModel>(request);
            return response.Data;
        }
    }
}
