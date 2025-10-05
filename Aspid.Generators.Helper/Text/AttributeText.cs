namespace Aspid.Generators.Helper.Text;

public class AttributeText(string name, NamespaceText? namespaceText = null) 
    : TypeText(name, namespaceText)
{
    public string ShortestName = GetShortestName(name);
    public readonly string FullShortestName = GetFullName(GetShortestName(name), namespaceText);
    public readonly string GlobalShortestName = GetGlobalName(GetShortestName(name), namespaceText);
    
    protected static string GetShortestName(string name) =>
        name.Replace("Attribute", "");
}