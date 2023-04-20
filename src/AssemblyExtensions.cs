﻿#nullable enable

using System.Diagnostics.CodeAnalysis;

using PeNet;
using PeNet.Header.Resource;

namespace Nefarius.Utilities.Assembly;

/// <summary>
///     Extension methods for <see cref="Assembly"/> class.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static class AssemblyExtensions
{
    /// <summary>
    ///     Gets the assembly product version from the Win32 VERSIONINFO resource.
    /// </summary>
    /// <example>string productVersion = Assembly.GetEntryAssembly()!.GetProductVersion().ToString()</example>
    /// <param name="assembly">The Assembly to read.</param>
    /// <returns>The product version.</returns>
    public static Version GetProductVersion(this System.Reflection.Assembly assembly)
    {
        Version fallback = assembly.GetName().Version;

        PeFile peFile = new(assembly.Location);

        if (peFile.Resources is null)
        {
            return fallback;
        }

        if (peFile.Resources.VsVersionInfo is null)
        {
            return fallback;
        }

        if (!peFile.Resources.VsVersionInfo.StringFileInfo.StringTable.Any())
        {
            return fallback;
        }

        StringTable stringTable = peFile.Resources.VsVersionInfo.StringFileInfo.StringTable.First();

        string? productVersion = stringTable.ProductVersion;

        return productVersion is null ? fallback : Version.Parse(productVersion);
    }

    /// <summary>
    ///     Gets the assembly file version from the Win32 VERSIONINFO resource.
    /// </summary>
    /// <example>string fileVersion = Assembly.GetEntryAssembly()!.GetFileVersion().ToString()</example>
    /// <param name="assembly">The Assembly to read.</param>
    /// <returns>The product version.</returns>
    public static Version GetFileVersion(this System.Reflection.Assembly assembly)
    {
        Version fallback = assembly.GetName().Version;

        PeFile peFile = new(assembly.Location);

        if (peFile.Resources is null)
        {
            return fallback;
        }

        if (peFile.Resources.VsVersionInfo is null)
        {
            return fallback;
        }

        if (!peFile.Resources.VsVersionInfo.StringFileInfo.StringTable.Any())
        {
            return fallback;
        }

        StringTable stringTable = peFile.Resources.VsVersionInfo.StringFileInfo.StringTable.First();

        string? fileVersion = stringTable.FileVersion;

        return fileVersion is null ? fallback : Version.Parse(fileVersion);
    }
}