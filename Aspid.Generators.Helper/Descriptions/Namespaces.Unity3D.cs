using Aspid.Generators.Helper.Text;

// ReSharper disable InconsistentNaming
namespace Aspid.Generators.Helper.Descriptions;

public static partial class Namespaces
{
    public static readonly NamespaceText Unity = new("Unity");
    public static readonly NamespaceText Unity_Profiling = new("Profiling", Unity);
    
    public static readonly NamespaceText UnityEngine = new("UnityEngine");
    public static readonly NamespaceText UnityEngine_UI = new("UI", UnityEngine);
    
    public static readonly NamespaceText UnityEditor = new("UnityEditor");
}