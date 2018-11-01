using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.ModelBinding.Binders;
using ProductManagment.Application.Contracts;

namespace ProductManagement.Interface.RestApi.ModelBinders
{
    public class ProductModelBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(CreateGenericProductCommand))
            {
                return false;
            }
            

            //TODO: fill the object from the request json body 
            var dto = new CreateGenericProductCommand();
            dto.Title = "X";
            dto.ConstraintValues = new List<ConstraintValueDto>()
            {
                new NumericConstraintValueDto(){ ConstraintId = 1, Max = 10, Min = 0},
                new StringConstraintValueDto() { ConstraintId = 2, MaxLength = 255}
            };
            //var provider = new CompositeModelBinderProvider(actionContext.ControllerContext.Configuration.Services.GetModelBinderProviders());
            //var binder = provider.GetBinder(actionContext.ControllerContext.Configuration, typeof(CreateGenericProductCommand));

            bindingContext.Model = dto;
            return true;

        }
    }
}
