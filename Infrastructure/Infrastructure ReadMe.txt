This folder is for infrastructure concerns such as file I/O, data persistence,
and web services. Interfaces for these services will have been defined in Core.
The projects in this folder should have no business logic. Such code should be
in Core which, if the business logic needs to persist the data, will end up
using an interface to utilize an infrastructure concern.

Infrastructure projects are also where implementation of helper classes, such 
as mappers for UI models to Core entities, should exist. Interfaces for these
will exist in the appropriate project. Most interfaces will be in Core. 
However, if services need to be provided for objects that are clearly specific 
to another project's needs, then the interface may be created in that project.
Mappers, for example, may have interfaces in the UI project.

This design pattern allows for ease of application maintenance as these
components, which are more likely to change over time than business logic, are 
decoupled from the rest of the application.

The only references projects in this folder should have to other projects is to 
Core and UI.

Be sure to change the project's build target to the UI layer's bin folder.