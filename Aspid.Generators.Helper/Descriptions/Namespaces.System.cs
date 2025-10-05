using Aspid.Generators.Helper.Text;

// ReSharper disable InconsistentNaming
namespace Aspid.Generators.Helper.Descriptions;

public static partial class Namespaces
{
    public static readonly NamespaceText System = new("System");
    
    public static readonly NamespaceText System_ComponentModel = new("ComponentModel", System);
    
    public static readonly NamespaceText System_Collections = new("Collections", System);
    public static readonly NamespaceText System_Collections_Generic = new("Generic", System_Collections);
    
    public static readonly NamespaceText System_Runtime = new("Runtime", System);
    public static readonly NamespaceText System_Runtime_CompilerServices = new("CompilerServices", System_Runtime);
    
    public static readonly NamespaceText System_CodeDom = new("CodeDom", System);
    public static readonly NamespaceText System_CodeDom_Compiler = new("Compiler", System_CodeDom);
}