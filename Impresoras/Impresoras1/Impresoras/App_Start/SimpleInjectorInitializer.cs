[assembly: WebActivator.PostApplicationStartMethod(typeof(Impresoras.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace Impresoras.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using Repositorio.Clases;
    using Repositorio.Interfaces;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
            container.Register<IImpresorasRepositorio, ImpresorasRepositorio>(Lifestyle.Scoped);
            container.Register<ITonnersRepositorio, TonnersRepositorio>(Lifestyle.Scoped);
            container.Register<IInventarioRepositorio, InventarioRepositorio>(Lifestyle.Scoped);
            container.Register<IUbicacionRepositorio, UbicacionRepositorio>(Lifestyle.Scoped);
        }
    }
}