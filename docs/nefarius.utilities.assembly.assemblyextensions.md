# AssemblyExtensions

Namespace: Nefarius.Utilities.Assembly

Extension methods for  class.

```csharp
public static class AssemblyExtensions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AssemblyExtensions](./nefarius.utilities.assembly.assemblyextensions.md)

## Methods

### <a id="methods-getfileversion"/>**GetFileVersion(Assembly)**

Gets the assembly file version from the Win32 VERSIONINFO resource.

```csharp
public static Version GetFileVersion(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly)<br>
The Assembly to read.

#### Returns

The file version.

### <a id="methods-getfileversionstring"/>**GetFileVersionString(Assembly)**

Gets the assembly file version from the Win32 VERSIONINFO resource.

```csharp
public static string GetFileVersionString(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly)<br>
The Assembly to read.

#### Returns

The file version string directly taken from the PE resource.

### <a id="methods-getproductversion"/>**GetProductVersion(Assembly)**

Gets the assembly product version from the Win32 VERSIONINFO resource.

```csharp
public static Version GetProductVersion(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly)<br>
The Assembly to read.

#### Returns

The product version.

### <a id="methods-getproductversionstring"/>**GetProductVersionString(Assembly)**

Gets the assembly product version from the Win32 VERSIONINFO resource.

```csharp
public static string GetProductVersionString(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly)<br>
The Assembly to read.

#### Returns

The file version string directly taken from the PE resource.
