WpfHelper
=============

A library that introduces developers to the wonders of Model-View-ViewModel (MVVM) architecture in the Windows Presentation Foundation (WPF) application format. Complete with base classes for instantiating closeable window and workspace objects too! :D

Summary
-------

This library slowly evolved into something useable through iteration after iteration of the MVVM pattern in a couple dozen WPF applications and experiments. This iteration (20-something, a couple of months old) has been designed as both a utility for extending basic MVVM functionality to MVVM-architected application classes and a tutorial for helping developers understand how MVVM "ticks" when implemented in WPF applications. Eventually its components were isolated, generalized, and thoroughly tested to include closeable workspace components and event-driven object collections at the developer's option. The goal is to implement a base framework that allows developers to understand and painlessly implement MVVM architecture in their Windows applications in less [lines of] code.

This (like many others) library is based almost entirely around the notion that a developer can focus on making awesome software when another (hopefully not boring) developer worries about the details for them. It only has a few methods for now, but will grow with the needs of my personal and university projects. I don't understand why Microsoft has been trying to do away intuitive design patterns (MVVM in WPF) with the introduction of Windows 8, but hopefully Microsoft engineers come to their senses and realize how good and useful this paradigm turned out to be in the [relatively] few years it has been officially in use.

Notes
-----

All code in this library has been composed in a self-documenting fashion and styled for readability where possible. All public members, methods, and constructors have complete XML documentation for use with VS Intellisense.

This solution, including unit tests and architectural models, was created, debugged, and deployed using [Visual Studio 2012 Ultimate with MSDN](http://en.wikipedia.org/wiki/Microsoft_Visual_Studio#Visual_Studio_2012) (link contains addtional references). The solution may not open properly if you try using an earlier or less feature-saturated version of Visual Studio. If a later version is used, be sure to check the cloned solution against original source code to ensure that compatiblity changes haven't significantly altered existing functionality.

Instructions
------------

To get your machine ready for development with this repository:

1. Clone the repository to your machine.
2. Navigate to the directory you cloned your repository to.
3. Locate the Visual Studio 2012 solution file.
3. Open the solution in Visual Studio (2012 or later)

Viola! You're good to go!
