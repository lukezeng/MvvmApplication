using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MvvmApplication.Repositories;
using MvvmApplication.Services;
using MvvmApplication.SqlPersistances;
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

            // e.g. container.RegisterType<ITestService, TestService>();            


            //User
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserSqlPersistence, UserSqlPersistence>();

            //Brand
            container.RegisterType<IBrandService, BrandService>();
            container.RegisterType<IBrandRepository, BrandRepository>();
            container.RegisterType<IBrandSqlPersistence, BrandSqlPersistence>();

            //Relation
            container.RegisterType<IRelationService, RelationService>();
            container.RegisterType<IRelationRepository, RelationRepository>();
            container.RegisterType<IRelationSqlPersistence, RelationSqlPersistence>();

            //Count
            container.RegisterType<ICountService, CountService>();
            container.RegisterType<ICountRepository, CountRepository>();
            container.RegisterType<ICountSqlPersistence, CountSqlPersistence>();

            //Company example
            container.RegisterType<ICompanyService, CompanyService>();
            container.RegisterType<ICompanyRepository, CompanyRepository>();
            container.RegisterType<ICompanySqlPersistence, CompanySqlPersistence>();

            return container;
        }
    }
}