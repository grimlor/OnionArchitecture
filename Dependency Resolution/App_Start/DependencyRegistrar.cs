using System;
using System.Web;
using OnionArchitecture.DependencyResolution.App_Start;
using SimpleInjector;

[assembly: PreApplicationStartMethod(typeof(DependencyRegistrar), "RegisterAllDependencies")]

namespace OnionArchitecture.DependencyResolution.App_Start
{
    using Core.Entities;
    using Core.Interfaces;

    public static class DependencyRegistrar
    {
        #region Private Fields

        static Container _container;

        #endregion

        #region Public Methods

        /// <summary>
        /// Registers all dependencies.
        /// </summary>
        public static void RegisterAllDependencies()
        {
            _container = new Container();

            //Register<Interface, Concretion>();

            _container.Verify();

            ServiceLocator.SetServiceLocator(() => new SimpleInjectorServiceLocator(_container));
        }

        /// <summary>
        /// Registers the specified service.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="implementation">The implementation.</param>
        public static void Register(Type service, Type implementation)
        {
            _container.Register(service, implementation);
        }

        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <typeparam name="TService">The service.</typeparam>
        /// <typeparam name="TImplementation">The implementation.</typeparam>
        public static void Register<TService, TImplementation>()
        {
            Register(typeof(TService), typeof(TImplementation));
        }

        /// <summary>
        /// Registers as singleton.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="implementation">The implementation.</param>
        public static void RegisterSingle(Type service, Type implementation)
        {
            _container.RegisterSingle(service, implementation);
        }

        /// <summary>
        /// Registers as singleton.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation.</typeparam>
        public static void RegisterSingle<TService, TImplementation>()
        {
            RegisterSingle(typeof(TService), typeof(TImplementation));
        }

        #endregion
    }
}
