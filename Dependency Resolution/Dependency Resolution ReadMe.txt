Projects in this folder tie the interfaces used throughout the application to
implementations. This is done using an Inversion of Control (IoC) container 
such as SimpleInjector, Unity, Castle Windsor, or Ninject. There should be no 
logic unrelated to this functionality in these projects.

Whatever IoC container is used, it needs to implement the IServiceLocator
interface defined in Core.

This project will have references to all of the other layers in the 
application.

Be sure to change the project's build target to the UI layer's bin folder.