using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MvvmApplication.Repositories;
using MvvmApplication.Services;
using MvvmApplication.SqlPersistance;
using Unity.Mvc3;

namespace MvvmApplication
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ICompanyService, CompanyService>();
            container.RegisterType<ICompanyRepository, CompanyRepository>();
            container.RegisterType<ICompanySqlPersistence, CompanySqlPersistence>();


            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}