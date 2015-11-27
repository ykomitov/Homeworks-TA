namespace TeleimotBg.Web.Api
{
    using System;
    using System.Web;
    using Common.Constants;
    using Common.Providers;
    using Data;
    using Data.Repositories;
    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;

    public class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
            kernel.Bind<ITeleimotBgDbContext>().To<TeleimotBgDbContext>().InRequestScope();

            kernel.Bind<IRandomProvider>().To<RandomProvider>();

            kernel.Bind(b => b
            .From(Assemblies.DataServices)
            .SelectAllClasses()
            .BindDefaultInterface());

            ////kernel.Bind(k => k
            ////    .From(
            ////        ServerConstants.InfrastructureAssembly,
            ////        ServerConstants.DataServicesAssembly,
            ////        ServerConstants.LogicServicesAssembly)
            ////    .SelectAllClasses()
            ////    .InheritedFrom<IService>()
            ////    .BindDefaultInterface());
        }
    }
}