// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Aspid.Generators.Helper.Unity;

public static class UnityClasses
{
    public static readonly TypeText ProfilerMarker = new(nameof(ProfilerMarker), UnityNamespaces.Unity_Profiling);
    public static readonly TypeText ProfilerMarker_AutoScope = new("ProfilerMarker.AutoScope", UnityNamespaces.Unity_Profiling);

    public static readonly TypeText Object = new(nameof(Object), UnityNamespaces.UnityEngine);
    public static readonly TypeText Component = new(nameof(Component), UnityNamespaces.UnityEngine);
    public static readonly TypeText MonoBehaviour = new(nameof(MonoBehaviour), UnityNamespaces.UnityEngine);
    public static readonly TypeText ScriptableObject = new(nameof(ScriptableObject), UnityNamespaces.UnityEngine);
    public static readonly AttributeText SerializeField = new(nameof(SerializeField), UnityNamespaces.UnityEngine);
    
    public static readonly TypeText MenuItem = new(nameof(MenuItem), UnityNamespaces.UnityEditor);
    public static readonly TypeText MenuCommand = new(nameof(MenuCommand), UnityNamespaces.UnityEditor);
    
    public static readonly TypeText Button = new(nameof(Button), UnityNamespaces.UnityEngine_UI);
    public static readonly TypeText Toggle = new(nameof(Toggle), UnityNamespaces.UnityEngine_UI);
    public static readonly TypeText Slider = new(nameof(Slider), UnityNamespaces.UnityEngine_UI);
    public static readonly TypeText ScrollRect = new(nameof(ScrollRect), UnityNamespaces.UnityEngine_UI);
}