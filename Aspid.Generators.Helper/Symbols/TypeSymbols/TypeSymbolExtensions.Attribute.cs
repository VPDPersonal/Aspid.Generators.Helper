using System.Linq;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public static partial class TypeSymbolExtensions
{
    public static bool HasAnyAttributeInBases(this ITypeSymbol typeSymbol, IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInBases(out _, attributeNames);
    
    public static bool HasAnyAttributeInBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInBases(out _, attributeNames);
    
    public static bool HasAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInSelfAndBases(out _, attributeNames);
    
    public static bool HasAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInSelfAndBases(out _, attributeNames);

    public static bool TryGetAnyAttributeInBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, IReadOnlyCollection<string> attributeNames)
    {
        outAttribute = typeSymbol.GetAttributesInBases(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }

    public static bool TryGetAnyAttributeInBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, params IReadOnlyCollection<TypeText> attributeNames)
    {
        outAttribute = typeSymbol.GetAttributesInBases(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }
    
    public static bool TryGetAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, IReadOnlyCollection<string> attributeNames)
    {
        outAttribute = typeSymbol.GetAttributesInSelfAndBases(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }
    
    public static bool TryGetAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, params IReadOnlyCollection<TypeText> attributeNames)
    {
        outAttribute = typeSymbol.GetAttributesInSelfAndBases(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }
    
    public static AttributeData? GetAttributeInBases(this ITypeSymbol typeSymbol, TypeText attributeName) =>
        typeSymbol.GetAttributesInBases(attributeName).FirstOrDefault();
    
    public static AttributeData? GetAttributeInSelfAndBases(this ITypeSymbol typeSymbol, TypeText attributeName) =>
        typeSymbol.GetAttributesInSelfAndBases(attributeName).FirstOrDefault();
    
    public static IEnumerable<AttributeData> GetAttributesInBases(this ITypeSymbol typeSymbol, IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.GetAllBaseTypes().SelectMany(type => type.GetAttributesInSelf(attributeNames));
    
    public static IEnumerable<AttributeData> GetAttributesInBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.GetAllBaseTypes().SelectMany(type => type.GetAttributesInSelf(attributeNames));
    
    public static IEnumerable<AttributeData> GetAttributesInSelfAndBases(this ITypeSymbol typeSymbol, IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.GetAllBaseTypesAndSelf().SelectMany(type => type.GetAttributesInSelf(attributeNames));
    
    public static IEnumerable<AttributeData> GetAttributesInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.GetAllBaseTypesAndSelf().SelectMany(type => type.GetAttributesInSelf(attributeNames));
}