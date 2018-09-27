using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using TigerFramework.Application;
using UOM.Application;
using UOM.Application.Contracts;
using UOM.Domain.Model.MeasurementDimensions;
using UOM.Interface.RestApi;

namespace UOM.Config.Castle
{
    public static class UomBootstrapper
    {
        public static void WireUp(IWindsorContainer container)
        {
            container.Register(Classes.FromAssemblyContaining<MeasurementDimensionCommandHandlers>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceAllInterfaces()
                .LifestylePerWebRequest());

            container.Register(Component.For<IMeasurementDimensionRepository>()
                .ImplementedBy<FakeRepository>());

            container.Register(Component.For<MeasurementDimensionsController>()
                .LifestylePerWebRequest());
        }
    }
}
