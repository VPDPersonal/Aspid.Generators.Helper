using System.Linq;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using Aspid.Generators.Helper.Text;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.Symbols;

public static partial class TypeSymbolExtensions
{
    public static bool HasAnyBaseType(this ITypeSymbol typeSymbol, IReadOnlyCollection<string> baseTypeNames) =>
        typeSymbol.TryGetAnyBaseType(out _, baseTypeNames);
    
    public static bool HasAnyBaseType(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> baseTypeNames) =>
        typeSymbol.TryGetAnyBaseType(out _, baseTypeNames);

    public static bool TryGetAnyBaseType(this ITypeSymbol typeSymbol, out ITypeSymbol? outBaseType, IReadOnlyCollection<string> baseTypeNames)
    {
        outBaseType = typeSymbol.GetBaseTypes(baseTypeNames).FirstOrDefault();;
        return outBaseType is not null;
    }

    public static bool TryGetAnyBaseType(this ITypeSymbol typeSymbol, out ITypeSymbol? outBaseType, params IReadOnlyCollection<TypeText> baseTypeNames)
    {
        outBaseType = typeSymbol.GetBaseTypes(baseTypeNames).FirstOrDefault();;
        return outBaseType is not null;
    }
    
    public static ITypeSymbol? GetBaseType(this ITypeSymbol typeSymbol, TypeText baseTypeName) =>
        typeSymbol.GetBaseTypes(baseTypeName).FirstOrDefault();
    
    public static IEnumerable<ITypeSymbol> GetBaseTypes(this ITypeSymbol typeSymbol, IReadOnlyCollection<string> baseTypeNames) =>
        typeSymbol.GetAllBaseTypes().Where(type => baseTypeNames.Any(baseTypeName => type.ToDisplayString() == baseTypeName));

    public static IEnumerable<ITypeSymbol> GetBaseTypes(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> baseTypeNames) =>
        typeSymbol.GetAllBaseTypes().Where(type => baseTypeNames.Any(baseTypeName => type.ToDisplayString() == baseTypeName));

    public static IEnumerable<ITypeSymbol> GetAllBaseTypes(this ITypeSymbol typeSymbol)
    {
        for (var type = typeSymbol.BaseType; type is not null; type = type.BaseType)
        {
            yield return type;
        }
    }
    
    public static IEnumerable<ITypeSymbol> GetAllBaseTypesAndSelf(this ITypeSymbol typeSymbol)
    {
        for (var type = typeSymbol; type is not null; type = type.BaseType)
        {
            yield return type;
        }
    }
}