This folder is for infrastructure concerns such as file I/O, data persistence,
and web services. Interfaces for these services will have been defined in Core.
The projects in this folder should have no business logic. Such code should be
in Core which, if the business logic needs to persist the data, will end up
using an interface to utilize an infrastructure concern.

Infrastructure projects are also where implementation of cross-cuttomg helper 
classes, such as logging, should exist. Interfaces for these should also be in 
Core. 

This design pattern allows for ease of application maintenance as these
components, which are more likely to change over time than business logic, are 
decoupled from the rest of the application.

The only references projects in this folder should have to other projects is to 
Core.

Be sure to change the project's build target to the UI project's bin folder.