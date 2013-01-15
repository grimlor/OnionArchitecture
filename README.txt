Description
===========
This solution contains an implementation and Templify template of Jeffrey 
Palermo's Onion Architecture. The implementation closely reflects work done by 
Matt Hidinger on the topic.

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
on any folder and choose Templify Here to create a new project using the Onion 
Architecture.

Useful Links
============
Below are links to the inspirations and tools used in this project.

http://jeffreypalermo.com/blog/the-onion-architecture-part-1/
http://www.matthidinger.com/archive/2011/05/17/Onion-Architecture-code-and-slides-from-Chicago-Code-Camp.aspx
http://onionarch.codeplex.com/
http://opensource.endjin.com/templify/