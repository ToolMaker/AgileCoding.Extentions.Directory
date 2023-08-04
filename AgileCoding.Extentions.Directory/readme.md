AgileCoding.Extensions.Directory
================================

Overview
--------

The AgileCoding.Extensions.Directory is a .NET library that provides extension methods for the `System.IO.DirectoryInfo` class. It aims to enhance Directory behavior by adding more convenient methods for handling directory-based operations.

Installation
------------

This library is available as a NuGet package. You can install it using the NuGet package manager console:

bashCopy code

`Install-Package AgileCoding.Extensions.Directory -Version 2.0.5`

Features
--------

The library introduces the following methods for `DirectoryInfo`:

1.  GetDriveInfo: Returns the `DriveInfo` object associated with the root directory of the `DirectoryInfo` object.

2.  GetFilesByFilterPattern: Returns an array of `FileInfo` objects that meet a specified search pattern in the current directory.

Usage
-----

Here's a brief example of how to use these features in your code:

```csharp
using AgileCoding.Extentions.Directories;
using System.IO;

// Suppose 'myDirectory' is a DirectoryInfo object.

// Get drive information
DriveInfo driveInfo = myDirectory.GetDriveInfo();

// Get files by filter pattern
FileInfo[] filteredFiles = myDirectory.GetFilesByFilterPattern(".txt");
```

In the above example, replace `myDirectory` with your actual `DirectoryInfo` instance.

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.Directory/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.Directory/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.Directory/blob/main/CONTRIBUTING.md) for more details.