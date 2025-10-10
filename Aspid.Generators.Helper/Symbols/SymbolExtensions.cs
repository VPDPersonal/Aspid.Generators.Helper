using Microsoft.CodeAnalysis;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public static partial class SymbolExtensions
{
    public static string ToDisplayStringGlobal(this ISymbol symbol) =>
        symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
    
    public static ITypeSymbol? GetSymbolType(this ISymbol symbol) => symbol switch
    {
        ITypeSymbol type => type,
        IFieldSymbol field => field.Type,
        ILocalSymbol local => local.Type,
        IEventSymbol @event => @event.Type,
        IDiscardSymbol discard => discard.Type,
        IPropertySymbol property => property.Type,
        IParameterSymbol parameter => parameter.Type,
        _ => null
    };
}