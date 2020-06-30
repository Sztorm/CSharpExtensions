# CSharpExtensions
Set of C# extensions designed for performance and usability.
 * [API Documentation](./Documentation/API/index.md)
 * [License](./LICENSE)

## Features:
## EnumExtensions
Methods extending any enum type for more intuitive use of bit flags. They are pure and fluent that means they can be easily combined, which is important for working with such basic types. They are also performant as they do not use reflection nor create garbage.

## Examples
<details>
<summary>EnumExtensions</summary>

Remember to import namespace:
``using Sztorm.Extensions.Enum;`` 

Enum for example purposes.
```csharp
[Flags]
enum FilePermissions
{
    None = 0,
    Write = 1,
    Read = 2,
    Execute = 4
}
```

Flags manipulation
```csharp
FilePermissions writeAndRead = FilePermissions.Write
    .WithFlags(FilePermissions.Read);

FilePermissions readAndExec = writeAndRead
    .WithoutFlags(FilePermissions.Write)
    .WithFlags(FilePermissions.Execute);

Console.WriteLine(writeAndRead);
Console.WriteLine(readAndExec);
```  

Output
```
Write, Read
Read, Execute
```

Checking whether file is executable
```csharp
FilePermissions allPermissions = FilePermissions.Write
    .WithFlags(FilePermissions.Read)
    .WithFlags(FilePermissions.Execute);

bool isExecutable = allPermissions.HasAllFlags(FilePermissions.Execute);

Console.WriteLine(isExecutable ? "File is executable." : "File is not executable.");
```

Output
```
File is executable.
```

</details>

## Dependencies
Main project:
 * .NET Standard 2.0 (C# 7.3)
 * System.Runtime.CompilerServices.Unsafe 4.7.1
 * DefaultDocumentation 0.6.7
 
Tests project:
 * .NET Core 2.2
 * Microsoft.NET.Test.Sdk 16.6.1
 * NUnit 3.12.0
 * NUnit3TestAdapter 3.16.1

## License
CSharpExtensions is licensed under the MIT license. CSharpExtensions is free for commercial and non-commercial use.

[More about license.](./LICENSE)
