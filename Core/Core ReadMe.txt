Projects in this folder are where the business is modeled. Entities and 
business logic live here. Business logic may include services provided which 
are specific to the business domain, i.e. order processing. Such services 
should have an interface for consumption which are defined and implemented in 
this project. 

It is common for this project to have external dependencies. However, these 
dependencies should be handled through interfaces created here but implemented 
in other projects. Examples of such dependencies include:
    * Entity persistence
    * Logging
    * Web Services

All dependencies are then resolved in another project.  There should be no 
references to other projects. To handle dependency resolution, this project 
should contain a ServiceLocator class used by the UI's IoCControllerFactory for 
dependency resolution. It should also contain the definition of the 
IServiceLocator interface for the IoC container used by the 
DependencyResolution project.

Be sure to change the project's build target to the UI project's bin folder.