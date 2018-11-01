using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ProductManagement.Interface.RestApi;
using ProductManagment.Application;
using ProductManagment.Domain.Model.Products;
using ProductManagment.Domain.Model.Products.GenericProducts;
using TigerFramework.Application;

namespace ProductManagment.Config.Castle
{
    public static class ProductManagementBootstrapper
    {
        public static void WireUp(IWindsorContainer container)
        {
            container.Register(Classes.FromAssemblyContaining<ProductCommandHandlers>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceAllInterfaces()
                .LifestylePerWebRequest());

            container.Register(Component.For<IProductRepository>()
                .ImplementedBy<FakeProductRepository>());

            container.Register(Component.For<ProductsController>()
                .LifestylePerWebRequest());
        }
    }

    public class FakeProductRepository : IProductRepository
    {
        public void Add(GenericProduct product)
        {
            
        }
    }
}
