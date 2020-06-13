**Project Description**
Anolis is the underlying project for the XPize and Vize resource switchers for Windows XP and Vista respectivly. The codebase allows for the easy swapping around of resources within Win32 executables and other files.

### Project Links
[http://www.anol.is](http://www.anol.is) - Anolis main website (under construction). Thanks to Arni Gunnar for helping me with getting into the Icelandic DNS
[http://www.xpize.net](http://www.xpize.net) - xpize website
[http://www.vizeos.net](http://www.vizeos.net) - Vize website

# Roadmap and Timeline
**2008-07** - I took over XPize and Vize from XPero (who's a great sport!)
**2008-08** - Work starts on Anolis to replace ResHacker-based deployments
**2008-12** - Alpha releases of Resourcer made on New Years' Eve
**2009-01** - A second alpha release of Resourcer
**2009-02** - Stable Beta release of Resourcer and Anolis.Gui, which resulted in a beta of xpize 5
**2009-05** - xpize 5 Beta 2 was the first public beta of xpize 5, well received.
**2009-07** - xpize 5 Release 3 released, Vize 2 beta released, work begins on Sevenize
**2009-08** - xpize 5 Release 6 done, Resourcer 0.9 done. Things are going to be on hold for a while.
**2011-01** - Resourcer 0.95 should be released in January. 

# Project Arrangement
The software is split up into several projects

## Libraries

### Anolis.Core
A reusable library that manages everything to do with Anolis outside the GUIs. It contains the programming that patches files, recognises resource types, and handles Package processing. Anyone is free to develop software that recognises more resource data types (in fact, they're actively encouraged), since Anolis.Core can load software from other assemblies.

### W3b.Wizards
A library that brings basic wizard functionality to .NET

### W3b.TarLzma
A hacked together melding of the LzmaAlone library (by Igor Pavlov) and SharpZipLib's Tarball library with some modifications. Extraction performance is good, but compression is really slow and bad. In future I'll make a first-class C# port of 7z's entire codebase. This library is used for extracting and creating *.anop packages which are currently LZMA-compressed Tarballs.

## Main Projects
These are high-quality pieces of software for use by end-users

### Anolis.Resourcer
A ResHacker clone developed as a testbed for Anolis.Core and to replace ResHacker (because ResHacker doesn't support x64, XN Resource Editor (ResHacker's spiritual sequel) doesn't support multiple-language resources and crashes a lot, and other utilities rest cost actual money. It has a powerful yet simplified UI that doesn't duplicate commands or confuse the users with special-case handlers (which ResHacker and XN have in spades).

### Anolis.Installer
This is the main program that most of the users will see. It is a frontend for Anolis.Core's package handler. It uses a Wizards library which I haven't yet put up on Codeplex.

### Anolis.Packager
A program used to create packages to be installed by Anolis.Installer

## Utilities

### Anolis.Tools.UxTheme
Presently a little program that doesn't do anything particularly special when it comes to patching the uxtheme.dll file in Windows. Later versions will use an intelligent and heuristic patching method.

# Misc
Apparently on 2008-12-31 Anolis was ranked the 187th most popular project on Codeplex by weekly pageviews.
...but by 2009-02-36 it dropped down to 223rd place.
In March 2009 it hovered in the early-200s

# Links and Friends

[http://www.istartedsomething.com](http://www.istartedsomething.com) - Long Zheng
[http://www.withinwindows.com/](http://www.withinwindows.com/) - Rafael Rivera
[http://deepxw.blogspot.com/](http://deepxw.blogspot.com/) - deepxw
[http://www.w3bbo.com](http://www.w3bbo.com) - Me