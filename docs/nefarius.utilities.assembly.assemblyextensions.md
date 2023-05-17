# AssemblyExtensions

Namespace: Nefarius.Utilities.Assembly

Extension methods for  class.

```csharp
public static class AssemblyExtensions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AssemblyExtensions](./nefarius.utilities.assembly.assemblyextensions.md)

## Methods

### **GetProductVersion(Assembly)**

Gets the assembly product version from the Win32 VERSIONINFO resource.

```csharp
public static Version GetProductVersion(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly)<br>
The Assembly to read.

#### Returns

[Version](https://docs.microsoft.com/en-us/dotnet/api/system.version)<br>
The product version.

### **GetFileVersion(Assembly)**

Gets the assembly file version from the Win32 VERSIONINFO resource.

```csharp
public static Version GetFileVersion(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly)<br>
The Assembly to read.

#### Returns

[Version](https://docs.microsoft.com/en-us/dotnet/api/system.version)<br>
The product version.
