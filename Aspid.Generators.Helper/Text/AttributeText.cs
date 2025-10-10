using System;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public class AttributeText: TypeText
{
    public string ShortestName;
    public readonly string FullShortestName;
    public readonly string GlobalShortestName;

    public AttributeText(Type type)
        : base(type)
    {
        ShortestName = GetShortestName(Name);
        FullShortestName = GetFullName(GetShortestName(Name), Namespace);
        GlobalShortestName = GetGlobalName(GetShortestName(Name), Namespace);
    }

    public AttributeText(string name, NamespaceText? namespaceText = null)
        : base(name, namespaceText)
    {
        ShortestName = GetShortestName(Name);
        FullShortestName = GetFullName(GetShortestName(Name), Namespace);
        GlobalShortestName = GetGlobalName(GetShortestName(Name), Namespace);
    }

    protected static string GetShortestName(string name) =>
        name.Replace("Attribute", "");
}