UI projects, i.e. WinForms, WebForms, MVC, should be stored in this folder. 

No business logic should exist in these projects. Keep things "skinny" and 
decoupled. To achieve these two goals, reference Core to access the business
entities and the interfaces you'll program against for services. An 
IoCControllerFactory is required to inject the implementations for any 
interfaces which the controllers rely upon.

The only reference projects in this folder should have is to Core.