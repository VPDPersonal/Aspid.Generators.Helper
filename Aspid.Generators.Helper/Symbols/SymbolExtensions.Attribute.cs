using System.Linq;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using Aspid.Generators.Helper.Text;

namespace Aspid.Generators.Helper.Symbols;

public static partial class SymbolExtensions
{
    public static bool HasAttributeInSelf(this ISymbol symbol, TypeText attributeName) =>
        symbol.TryGetAttributeInSelf(out _, attributeName);
    
    public static bool HasAnyAttributeInSelf(this ISymbol symbol, IReadOnlyCollection<string> attributeNames) =>
        symbol.TryGetAnyAttributeInSelf(out _, attributeNames);
    
    public static bool HasAnyAttributeInSelf(this ISymbol symbol, params IReadOnlyCollection<TypeText> attributeNames) =>
        symbol.TryGetAnyAttributeInSelf(out _, attributeNames);

    public static bool TryGetAttributeInSelf(this ISymbol symbol, out AttributeData? outAttribute, TypeText attributeName) =>
        symbol.TryGetAnyAttributeInSelf(out outAttribute, attributeName);

    public static bool TryGetAnyAttributeInSelf(this ISymbol symbol, out AttributeData? outAttribute, IReadOnlyCollection<string> attributeNames)
    {
        outAttribute = symbol.GetAttributesInSelf(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }

    public static bool TryGetAnyAttributeInSelf(this ISymbol symbol, out AttributeData? outAttribute, params IReadOnlyCollection<TypeText> attributeNames)
    {
        outAttribute = symbol.GetAttributesInSelf(attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }
    
    public static AttributeData? GetAttributeInSelf(this ISymbol symbol, TypeText attributeName) =>
        symbol.GetAttributesInSelf(attributeName).FirstOrDefault();

    public static IEnumerable<AttributeData> GetAttributesInSelf(this ISymbol symbol, IReadOnlyCollection<string> attributeNames)
    {
        foreach (var attribute in symbol.GetAttributes())
        {
            if (attribute.AttributeClass is null) continue;
            if (attributeNames.All(attributeName => attribute.AttributeClass.ToDisplayString() != attributeName)) continue;
            
            yield return attribute;
        }
    }
    
    public static IEnumerable<AttributeData> GetAttributesInSelf(this ISymbol symbol, params IReadOnlyCollection<TypeText> attributeNames)
    {
        foreach (var attribute in symbol.GetAttributes())
        {
            if (attribute?.AttributeClass is null) continue;
            if (attributeNames.All(attributeName => attribute.AttributeClass.ToDisplayString() != attributeName)) continue;
            
            yield return attribute;
        }
    }
}