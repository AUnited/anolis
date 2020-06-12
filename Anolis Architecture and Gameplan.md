# What is Anolis?

Anolis is the internal name for the software product that will make up the XPize and Vize products.

XPize and Vize themselves will be mere distributions of the Anolis product combined with a predefined collection of sets; read-on for the definition of a "set".

# Architecture

The Anolis project is defined as a Solution comprised of three projects:

## Anolis.dll

This is a library which does all the work and where various classes are defined. It includes classes which swap out resources in Win32/PE executable images, insert new items into Windows, and various other utilities.

## Anolis.Desktop.exe

This is the binary that the user will execute that presents a nice GUI for the patcher and feature installer codebase.

## Anolis.Setup

Unlike the original XPize where the installer was also the patcher, for now the two programs will be separate. This makes development, debugging, and making backups easier. I doubt _xpize 5_ will use the combined installer/patcher, maybe _xpize 6_ (if we need to go that far; maybe a 5.5 version)

# Sets

An Anolis distribution is comprised of pre-built versions of the three projects described above, along with some packaged "Sets", or rather: Collections of Collections of Sets. Drawing inspiration from the inheritance cascade of CSS (Cascading Style Sheets, a key web technology) multiple sets can be combined to form a resultant set which is then applied to the operating system.

A Set is a collection of resources and details on what files to patch the resources in. E.g. "MCE Blue Wizard Background Images": a set of all the MCE-blue styled wizard background images. Or "Base XPize Icons": a set comprised of only the new or improved icons in XPize.

A Set Collection is a predefined collection of sets that form a visually consistent suite. For example packaging the _MCE Blue Wizard Background Images_ set with the _Base XPize Icons_ set to form the current XPize distributions we see today.

A Collection of Set Collections (for want of a better name) is simply a bunch of different visually consistent sets packaged together. This is so that users of the program can choose a Blue MCE or Black MCE or Royale Energy Blue theme without needing to download a separate distribution.
