using System.Linq;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using Aspid.Generators.Helper.Text;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.Symbols;

public static partial class TypeSymbolExtensions
{
    public static bool HasAttributeInBases(this ITypeSymbol typeSymbol, TypeText attributeName) =>
        typeSymbol.TryGetAttributeInBases(out _, attributeName);
    
    public static bool HasAttributeInSelfAndBases(this ITypeSymbol typeSymbol, TypeText attributeName) =>
        typeSymbol.TryGetAttributeInSelfAndBases(out _, attributeName);
    
    public static bool HasAnyAttributeInBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInBases(out _, attributeNames);
    
    public static bool HasAnyAttributeInBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInBases(out _, attributeNames);
    
    public static bool HasAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInSelfAndBases(out _, attributeNames);
    
    public static bool HasAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.TryGetAnyAttributeInSelfAndBases(out _, attributeNames);
    
    public static bool TryGetAttributeInBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, TypeText attributeName) =>
        typeSymbol.TryGetAnyAttributeInBases(out outAttribute, attributeName);
    
    public static bool TryGetAttributeInSelfAndBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, TypeText attributeName) =>
        typeSymbol.TryGetAnyAttributeInSelfAndBases(out outAttribute, attributeName);

    public static bool TryGetAnyAttributeInBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, params IReadOnlyCollection<string> attributeNames)
    {
        outAttribute = typeSymbol.GetAttributesInBases(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }

    public static bool TryGetAnyAttributeInBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, params IReadOnlyCollection<TypeText> attributeNames)
    {
        outAttribute = typeSymbol.GetAttributesInBases(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }
    
    public static bool TryGetAnyAttributeInSelfAndBases(this ITypeSymbol typeSymbol, out AttributeData? outAttribute, params IReadOnlyCollection<string> attributeNames)
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
    
    public static IEnumerable<AttributeData> GetAttributesInBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.GetAllBaseTypes().SelectMany(type => type.GetAttributesInSelf(attributeNames));
    
    public static IEnumerable<AttributeData> GetAttributesInBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.GetAllBaseTypes().SelectMany(type => type.GetAttributesInSelf(attributeNames));
    
    public static IEnumerable<AttributeData> GetAttributesInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<string> attributeNames) =>
        typeSymbol.GetAllBaseTypesAndSelf().SelectMany(type => type.GetAttributesInSelf(attributeNames));
    
    public static IEnumerable<AttributeData> GetAttributesInSelfAndBases(this ITypeSymbol typeSymbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        typeSymbol.GetAllBaseTypesAndSelf().SelectMany(type => type.GetAttributesInSelf(attributeNames));
}