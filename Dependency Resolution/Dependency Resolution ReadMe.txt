Projects in this folder tie the interfaces used throughout the application to
implementations. This is done using an Inversion of Control (IoC) container 
such as SimpleInjector, Unity, Castle Windsor, or Ninject. There should be no 
logic unrelated to this functionality in this project.

Whatever IoC container is used, it needs to implement the IServiceLocator 
interface defined in Core and initialize this concrete implementation. 
Reference the documentation for your IoC container for how to resolve 
your dependencies at application startup.

This project will have references to all of the other projects in the 
application implementing interfaces in the Core. Oftentimes, this will mean 
that this project references all of the other projects. 

It is strongly recommended that this exclude the UI or Tests as these projects 
may need to initialize the IoC container. IIS does this for web technologies 
via an Assembly-level attribute called PreApplicationStartMethod but it is 
still an anti-pattern to have interfaces in the UI or Test projects requiring 
external resolution. Rather, implement a factory for such events or simply 
instantiate the object fulfilling the contract in the interface. If the 
interface is anticipated to be needed in other projects, promote it to Core.

Be sure to change the project's build target to the UI project's bin folder.