// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Aspid.Generators.Helper.Unity;

public static class UnityNamespaces
{
    public static readonly NamespaceText Unity = new(nameof(Unity));
    public static readonly NamespaceText Unity_Profiling = new("Profiling", Unity);
    
    public static readonly NamespaceText UnityEditor = new(nameof(UnityEditor));
    
    public static readonly NamespaceText UnityEngine = new(nameof(UnityEngine));
    public static readonly NamespaceText UnityEngine_UI = new("UI", UnityEngine);
}