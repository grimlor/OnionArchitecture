Projects in this folder tie the interfaces used throughout the application to
implementations. This is done using an Inversion of Control (IoC) container 
such as SimpleInjector, Unity, Castle Windsor, or Ninject. There should be no 
logic unrelated to this functionality in this project.

Whatever IoC container is used, it needs to implement the IServiceLocator
interface defined in Core.

This project will have references to any of the other projects in the 
application implementing interfaces in the Core. Oftentimes, this will 
mean that this project references all of the other projects except the UI.

Be sure to change the project's build target to the UI layer's bin folder.