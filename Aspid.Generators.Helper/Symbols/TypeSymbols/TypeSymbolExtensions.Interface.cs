using System.Linq;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using Aspid.Generators.Helper.Text;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.Symbols;

public static partial class TypeSymbolExtensions
{
    public static bool HasGetInterfaceInSelf(this ITypeSymbol typeSymbol, TypeText interfaceName) =>
        typeSymbol.TryGetInterfaceInSelfAndBases(out _, interfaceName);
    
    public static bool HasGetInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, TypeText interfaceName) =>
        typeSymbol.TryGetInterfaceInSelfAndBases(out _, interfaceName);
    
    public static bool HasGetAnyInterfaceInSelf(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> interfaceNames) =>
        typeSymbol.TryGetAnyInterfaceInSelf(out _, interfaceNames);
    
    public static bool HasGetAnyInterfaceInSelf(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> interfaceNames) =>
        typeSymbol.TryGetAnyInterfaceInSelf(out _, interfaceNames);

    public static bool HasGetAnyInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> interfaceNames) =>
        typeSymbol.TryGetAnyInterfaceInSelfAndBases(out _, interfaceNames);

    public static bool HasGetAnyInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> interfaceNames) =>
        typeSymbol.TryGetAnyInterfaceInSelfAndBases(out _, interfaceNames);
    
    public static bool TryGetInterfaceInSelf(this ITypeSymbol typeSymbol, out INamedTypeSymbol? outInterface, TypeText interfaceName) =>
        typeSymbol.TryGetAnyInterfaceInSelf(out outInterface, interfaceName);
    
    public static bool TryGetInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, out INamedTypeSymbol? outInterface, TypeText interfaceName) =>
        typeSymbol.TryGetAnyInterfaceInSelfAndBases(out outInterface, interfaceName);
    
    public static bool TryGetAnyInterfaceInSelf(this ITypeSymbol typeSymbol, out INamedTypeSymbol? outInterface, params IReadOnlyCollection<string> interfaceNames)
    {
        outInterface = typeSymbol.GetInterfacesInSelf(interfaceNames).FirstOrDefault();
        return outInterface is not null;
    }
    
    public static bool TryGetAnyInterfaceInSelf(this ITypeSymbol typeSymbol, out INamedTypeSymbol? outInterface, params IReadOnlyCollection<TypeText> interfaceNames)
    {
        outInterface = typeSymbol.GetInterfacesInSelf(interfaceNames).FirstOrDefault();
        return outInterface is not null;
    }
    
    public static bool TryGetAnyInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, out INamedTypeSymbol? outInterface, params IReadOnlyCollection<string> interfaceNames)
    {
        outInterface = typeSymbol.GetInterfacesInSelfAndBases(interfaceNames).FirstOrDefault();
        return outInterface is not null;
    }

    public static bool TryGetAnyInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, out INamedTypeSymbol? outInterface, params IReadOnlyCollection<TypeText> interfaceNames)
    {
        outInterface = typeSymbol.GetInterfacesInSelfAndBases(interfaceNames).FirstOrDefault();
        return outInterface is not null;
    }

    public static INamedTypeSymbol? GetInterfaceInSelf(this ITypeSymbol typeSymbol, TypeText interfaceName) =>
        typeSymbol.GetInterfacesInSelf(interfaceName).FirstOrDefault();
    
    public static INamedTypeSymbol? GetInterfaceInSelfAndBases(this ITypeSymbol typeSymbol, TypeText interfaceName) =>
        typeSymbol.GetInterfacesInSelfAndBases(interfaceName).FirstOrDefault();
    
    public static IEnumerable<INamedTypeSymbol> GetInterfacesInSelf(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> interfaceNames) =>
        typeSymbol.Interfaces.Where(@interface => interfaceNames.Any(interfaceName => @interface.ToDisplayString() == interfaceName));

    public static IEnumerable<INamedTypeSymbol> GetInterfacesInSelf(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> interfaceNames) =>
        typeSymbol.Interfaces.Where(@interface => interfaceNames.Any(interfaceName => @interface.ToDisplayString() == interfaceName));
    
    public static IEnumerable<INamedTypeSymbol> GetInterfacesInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> interfaceNames) =>
        typeSymbol.AllInterfaces.Where(@interface => interfaceNames.Any(interfaceName => @interface.ToDisplayString() == interfaceName));

    public static IEnumerable<INamedTypeSymbol> GetInterfacesInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> interfaceNames) =>
        typeSymbol.AllInterfaces.Where(@interface => interfaceNames.Any(interfaceName => @interface.ToDisplayString() == interfaceName));
}