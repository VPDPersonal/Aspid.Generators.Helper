using System;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public static class TypeExtensions
{
    public static TypeText ToTypeText(this Type type) => new(type);
    
    public static AttributeText ToAttributeText(this Type type) => new AttributeText(type);

    public static NamespaceText? ToNamespaceText(this Type type) =>
        type.Namespace is not null ? new NamespaceText(type.Namespace) : null;
}