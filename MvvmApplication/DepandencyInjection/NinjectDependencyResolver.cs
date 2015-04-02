using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MvvmApplication.Services;
using Ninject;

namespace MvvmApplication.DepandencyInjection
{
    public class NinjectDependencyResolver
        : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            _kernel.Bind<ICompanyService>()
                .To<CompanyService>();
        }

        public object GetService(Type serviceType)
        {
            return this._kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this._kernel.GetAll(serviceType);
        }
    }
}