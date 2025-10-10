using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public sealed class DeclarationText
{
    private readonly string _modifiers;
    private readonly string _type;
    private readonly string _name;
    private readonly string? _genericArguments;
    
    public DeclarationText(TypeDeclarationSyntax declaration)
    {
        _modifiers = GetModifiers(declaration);
        _type = declaration is ClassDeclarationSyntax ? "class" : "struct";
        _name = declaration.Identifier.Text;
        _genericArguments = GetGenericArguments(declaration);
    }
    
    public DeclarationText(string modifiers, string type, string name, string? genericArguments)
    {
        _modifiers = modifiers;
        _type = type;
        _name = name;
        _genericArguments = genericArguments;
    }

    public string GetFileName(NamespaceText? namespaceText, string? postfix)
    {
        postfix ??= string.Empty;
        postfix = postfix!.Length > 0 && postfix[0] is not '.' ? $".{postfix}" : postfix;

        namespaceText ??= string.Empty;
        return namespaceText + (_genericArguments is null
            ? $"{_name}{postfix}.g.cs" 
            : $"{_name}`{_genericArguments!.Count(arg => arg == ',') + 1}{postfix}.g.cs");
    }

    public override string ToString()
    {
        var modifiers = !string.IsNullOrWhiteSpace(_modifiers) ?  $"{_modifiers} " : "";
        var arguments = !string.IsNullOrWhiteSpace(_genericArguments) ? $"<{_genericArguments}>" : "";

        return $"{modifiers}{_type} {_name}{arguments}";
    }

    public static implicit operator DeclarationText?(TypeDeclarationSyntax? declaration) => declaration is not null
        ? new DeclarationText(declaration)
        : null;

    private static string GetModifiers(TypeDeclarationSyntax declaration)
    {
        var modifiers = new StringBuilder();
        foreach (var modifier in declaration.Modifiers)
            modifiers.Append(modifier + " ");

        modifiers.Length--;
        return modifiers.ToString();
    }

    private static string? GetGenericArguments(TypeDeclarationSyntax declaration)
    {
        var types = declaration.TypeParameterList;
        if (types is null || types.Parameters.Count is 0) return null;
        
        var genericTypes = new StringBuilder();
        foreach (var type in types.Parameters)
        {
            if (genericTypes.Length > 0)
                genericTypes.Append(", ");
            
            genericTypes.Append(type.Identifier.Text);
        }
        
        return genericTypes.ToString();
    }
}