using System.Linq;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using Aspid.Generators.Helper.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Aspid.Generators.Helper.Syntaxes;

public static class MemberDeclarationSyntaxExtensions
{
    public static bool HasAnyAttributeInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, IReadOnlyCollection<string> attributeNames) =>
        TryGetAnyAttributeInSelf(declaration, semanticModel, out _, attributeNames);
    
    public static bool HasAnyAttributeInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, params IReadOnlyCollection<TypeText> attributeNames) =>
        TryGetAnyAttributeInSelf(declaration, semanticModel, out _, attributeNames);

    public static bool TryGetAttributeInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, out IMethodSymbol? outAttribute, TypeText attributeName) =>
        TryGetAnyAttributeInSelf(declaration, semanticModel, out outAttribute, attributeName);

    public static bool TryGetAnyAttributeInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, out IMethodSymbol? outAttribute, IReadOnlyCollection<string> attributeNames)
    {
        outAttribute = declaration.GetAttributesInSelf(semanticModel, attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }

    public static bool TryGetAnyAttributeInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, out IMethodSymbol? outAttribute, params IReadOnlyCollection<TypeText> attributeNames)
    {
        outAttribute = declaration.GetAttributesInSelf(semanticModel, attributeNames).FirstOrDefault();;
        return outAttribute is not null;
    }

    public static IMethodSymbol? GetAttributeInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, TypeText attributeName) => 
        declaration.GetAttributesInSelf(semanticModel, attributeName).FirstOrDefault();
    
    public static IEnumerable<IMethodSymbol> GetAttributesInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, IReadOnlyCollection<string> attributeNames)
    {
        foreach (var attribute in declaration.AttributeLists.SelectMany(attributeList => attributeList.Attributes))
        {
            if (semanticModel.GetSymbolInfo(attribute).Symbol is not IMethodSymbol attributeSymbol) continue;
            if (attributeNames.All(attributeName => attributeSymbol.ContainingType?.ToDisplayString() != attributeName)) continue;

            yield return attributeSymbol;
        }
    }

    public static IEnumerable<IMethodSymbol> GetAttributesInSelf(this MemberDeclarationSyntax declaration, SemanticModel semanticModel, params IReadOnlyCollection<TypeText> attributeNames)
    {
        foreach (var attribute in declaration.AttributeLists.SelectMany(attributeList => attributeList.Attributes))
        {
            if (semanticModel.GetSymbolInfo(attribute).Symbol is not IMethodSymbol attributeSymbol) continue;
            if (attributeNames.All(attributeName => attributeSymbol.ContainingType?.ToDisplayString() != attributeName)) continue;

            yield return attributeSymbol;
        }
    }
}