using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using TigerFramework.Core;

namespace TigerFramework.Castle
{
    public class WindsorServiceLocatorAdapter : IServiceLocator
    {
        private readonly IWindsorContainer _container;
        public WindsorServiceLocatorAdapter(IWindsorContainer container)
        {
            this._container = container;
        }

        public T GetInstance<T>()
        {
            return _container.Resolve<T>();
        }

        public void Release(object obj)
        {
            _container.Release(obj);
        }
    }
}
