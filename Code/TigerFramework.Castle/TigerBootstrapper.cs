using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using TigerFramework.Application;
using TigerFramework.Core;
using TigerFramework.EF;

namespace TigerFramework.Castle
{
    public static class TigerBootstrapper
    {
        public static void WireUp(IWindsorContainer container, string connectionStringKey)
        {
            container.Register(Component.For<IServiceLocator>()
                .UsingFactoryMethod(a=> new WindsorServiceLocatorAdapter(container)));

            container.Register(Component.For<ICommandBus>()
                .ImplementedBy<CommandBus>());

            container.Register(Component.For<IUnitOfWork>()
                .ImplementedBy<EfUnitOfWork>()
                .LifestylePerWebRequest());

            container.Register(Component.For<IDbConnection>()
                .Forward<DbConnection>().Forward<SqlConnection>()
                .UsingFactoryMethod(a =>
                {
                    var connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    return connection;
                })
                .LifestylePerWebRequest()
                .OnDestroy(a => a.Close()));

            container.Register(Component.For(typeof(TransactionalCommandHandlerDecorator<>))
                .LifestyleTransient());
        }
    }
}
