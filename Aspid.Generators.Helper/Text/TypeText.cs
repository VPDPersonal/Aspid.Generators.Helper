using System;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public class TypeText
{
    public readonly string Name;
    public readonly NamespaceText? Namespace;
    
    public readonly string FullName;
    public readonly string GlobalName;

    public TypeText(Type type)
    {
        var name = type.Name;
        Name = name.Substring(0,name.IndexOf('`'));
        
        Namespace = type.ToNamespaceText();
        
        FullName = GetFullName(Name, Namespace);
        GlobalName = GetGlobalName(Name, Namespace);
    }
    
    public TypeText(string name, NamespaceText? namespaceText = null)
    {
        Name = name;
        Namespace =  namespaceText;
        
        FullName = GetFullName(name, namespaceText);
        GlobalName = GetGlobalName(name, namespaceText);
    }
    
    protected bool Equals(TypeText other) =>
        FullName == other.FullName;

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((TypeText)obj);
    }

    public override int GetHashCode() =>
        FullName.GetHashCode();
    
    public override string ToString() => GlobalName;

    public static bool operator ==(TypeText? left, string? right)
    {
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;
        
        if (right.Length > 8 && right.Substring(0, 8) == "global::")
            return left.GlobalName == right;
        
        return left.FullName == right;
    }

    public static bool operator !=(TypeText? left, string? right) => !(left == right);
    
    public static bool operator ==(string? left, TypeText? right) => right == left;
    
    public static bool operator !=(string? left, TypeText? right) => right != left;

    public static bool operator ==(TypeText? left, TypeText? right) =>
        left?.FullName == right?.FullName;

    public static bool operator !=(TypeText? left, TypeText? right) => !(left == right);
    
    public static implicit operator string(TypeText typeText) => typeText.ToString();
    
    public static implicit operator TypeText(string typeText)
    {
        typeText = typeText.Replace("global::", "");
        
        var lastDot = typeText.LastIndexOf('.');
        NamespaceText? namespaceText = lastDot < 0
            ? null
            : typeText.Substring(0, lastDot);
        
        return new TypeText(typeText.Substring(lastDot + 1), namespaceText);
    }

    protected static string GetFullName(string name, NamespaceText? namespaceText) =>
        (namespaceText is not null ? $"{namespaceText}." : string.Empty) + name;
    
    protected static string GetGlobalName(string name, NamespaceText? namespaceText) =>
        "global::" + GetFullName(name, namespaceText);
}