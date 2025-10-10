using UnityEngine;
using Unity.Profiling;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Aspid.Generators.Helper.Unity;

public static class UnityClasses
{
    public static readonly TypeText ProfilerMarker = typeof(ProfilerMarker).ToTypeText();
    public static readonly TypeText ProfilerMarker_AutoScope = typeof(ProfilerMarker.AutoScope).ToTypeText();
    
    public static readonly TypeText Object = typeof(Object).ToTypeText();
    public static readonly TypeText Component = typeof(Component).ToTypeText();
    public static readonly TypeText MonoBehaviour = typeof(MonoBehaviour).ToTypeText();
    public static readonly TypeText ScriptableObject = typeof(ScriptableObject).ToTypeText();
    public static readonly AttributeText SerializeField = typeof(SerializeField).ToAttributeText();
    
    public static readonly TypeText MenuItem = new("MenuItem", UnityNamespaces.UnityEditor);
    public static readonly TypeText MenuCommand = new("MenuCommand", UnityNamespaces.UnityEditor);
    
    public static readonly TypeText Button = new("Button", UnityNamespaces.UnityEngine_UI);
    public static readonly TypeText Toggle = new("Toggle", UnityNamespaces.UnityEngine_UI);
    public static readonly TypeText Slider = new("Slider", UnityNamespaces.UnityEngine_UI);
    public static readonly TypeText ScrollRect = new("ScrollRect", UnityNamespaces.UnityEngine_UI);
}