using System;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IServiceLocator
    {
        T GetInstance<T>() where T : class;
        object GetInstance(Type type);
    }
}