Description
===========
If you haven't heard of the Onion Architecture, you wouldn't be alone. However, 
it's been around for a while under the name of Hexagonal Architecture, due 
solely to a graphic created when Alistair Cockburn first described it. It's 
also known as the Ports & Adapters Pattern. The Onion Architecture version of 
this pattern described by Jeffrey Palermo was the most understandable to me. I 
dug around for a while until I could find someone who implemented a sample 
project using the Onion Architecture and came across Matt Hidinger's 
presentation he did for the Chicago Code Camp last year. I destructed his 
sample project, documented it, and rebuilt it in a shape I felt I could teach 
and support. I then Templified it.

Usage
=====
The project, sans the .pkg file in the root, can be used as-is with one 
configuration note; you'll need to enable NuGet package restore in Visual 
Studio as follows:

Tools -> Options -> Package Manager -> General -> Package Restore
Check "Allow NuGet to download missing packages during build.

Readme files are provided for each layer of the onion. However, it is highly 
recommended that you download Templify and move the provided template, the 
.pkg file, to the templates folder. Templify is available here:

http://opensource.endjin.com/templify/

The location of that folder, as of this writing, is as follows:

%UserProfile%\AppData\Roaming\Endjin\Templify\repo

Once you copy the template .pkg file into that location, you can right-click 
on any folder and choose Templify Here to create a new solution in that folder 
using the Onion Architecture. 

This package includes an MVC 4 project for the UI. If you don't currently have 
MVC 4 installed, you will get an error that the project cannot be loaded. Feel 
free to delete it and create an MVC 3 project or any other web project of your 
choosing.

Due to popular demand, I have also included an implementation of the IoC 
container. I chose to use SimpleInjector as it is extremely lightweight DI 
API and easily replaced if/when you decide to use a more robust API such as 
Unity or Ninject.

I will keep the template without SimpleInjector for those who feel confident 
implementing the pattern with another DI API.

Useful Links
============
Below are links to the inspirations and tools used in this project.

http://jeffreypalermo.com/blog/the-onion-architecture-part-1/
http://www.matthidinger.com/archive/2011/05/17/Onion-Architecture-code-and-slides-from-Chicago-Code-Camp.aspx
http://onionarch.codeplex.com/
http://opensource.endjin.com/templify/