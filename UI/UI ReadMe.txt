UI projects, i.e. WinForms, WebForms, MVC, should be stored in this folder. 

No business logic should exist in these projects. Keep things "skinny" and 
decoupled. To achieve these two goals, reference Core to access the business
entities and the interfaces you'll program against for services. An 
IoCControllerFactory, set in Global.asax.cs, is required to inject the 
implementations for any interfaces which the controllers rely upon.

If you intend on using Web Deploy or Build Deployment Package, you will need 
to refer to the following article about how to include the libraries from the 
other projects into the deployment package.

http://sedodream.com/2010/05/01/WebDeploymentToolMSDeployBuildPackageIncludingExtraFilesOrExcludingSpecificFiles.aspx

You will also need to do a Build Solution before creating the deployment 
package.

The only reference projects in this folder should have is to Core and, if 
necessary, to Dependency Resolution so that the IoC container may be 
initialized. This is unnecessary for web technologies used in IIS. See the 
readme in Dependency Resolution for further information.