using System;
using SimpleInjector;

namespace OnionArchitecture.DependencyResolution
{
    using Core.Interfaces;

    class SimpleInjectorServiceLocator : IServiceLocator
    {
        #region Private Fields

        private readonly Container _container;

        #endregion

        #region Constructors/Destructors

        public SimpleInjectorServiceLocator(Container container)
        {
            _container = container;
        }

        #endregion

        #region Public Methods

        public T GetInstance<T>() where T : class
        {
            return _container.GetInstance<T>();
        }

        public object GetInstance(Type type)
        {
            return _container.GetInstance(type);
        }

        #endregion
    }
}
