Create your test projects in this folder. Test projects should be named to 
reflect the primary testing framework. Examples:
    * MSTest: Solution.Tests.MSTest
    * NUnit: Solution.UnitTests.NUnit
    * MSpec: Solution.UITests.MSpec

The goal with testing is to prove that the application or unit of code behaves
as desired, not to test how it works. Thus all tests need to conform to the 
Arrange/Act/Assert pattern. Details can be found at the link below:

    http://c2.com/cgi/wiki?ArrangeActAssert

This project may reference any project necessary for testing. The best practice 
is to reference as few projects as necessary, preferring interfaces over 
implementation, and allowing the IoC container to perform resolution. This 
allows for proper testing of the implementations of the interfaces. 

One example of a project reference that does not conform to the testing of 
interface over implementation best practice is the UI. For this reason, you may 
wish to split UI testing into its own project.

To test specific components, decoupling one interface's implementation from 
others, you may want to use a mocking framework such as FakeItEasy or Rhino
Mocks.