using System;
using System.Collections;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Aspid.Generators.Helper;

public static class Classes
{
    // Collections
    public static readonly TypeText Array = typeof(Array).ToTypeText();
    public static readonly TypeText Span_1 = typeof(Span<>).ToTypeText();
    public static readonly TypeText ReadOnlySpan_1 = typeof(ReadOnlySpan<>).ToTypeText();
    
    public static readonly TypeText List_1 = typeof(List<>).ToTypeText();
    public static readonly TypeText IList_1 = typeof(IList<>).ToTypeText();
    
    public static readonly TypeText Dictionary_2 = typeof(Dictionary<,>).ToTypeText();
    
    public static readonly TypeText IEnumerable = typeof(IEnumerable).ToTypeText();
    public static readonly TypeText IEnumerable_1 = typeof(IEnumerable<>).ToTypeText();
    
    // Delegates
    public static readonly TypeText Func = typeof(Func<>).ToTypeText();
    public static readonly TypeText Action = typeof(Action).ToTypeText();
    public static readonly TypeText Delegate = typeof(Delegate).ToTypeText();
    public static readonly TypeText Predicate = typeof(Predicate<>).ToTypeText();
    
    // Exceptions
    public static readonly TypeText Exception = typeof(Exception).ToTypeText();
    public static readonly TypeText ArgumentException = typeof(ArgumentException).ToTypeText();
    public static readonly TypeText InvalidCastException = typeof(InvalidCastException).ToTypeText();
    public static readonly TypeText KeyNotFoundException = typeof(KeyNotFoundException).ToTypeText();
    public static readonly TypeText ArgumentNullException = typeof(ArgumentNullException).ToTypeText();
    public static readonly TypeText NotImplementedException = typeof(NotImplementedException).ToTypeText();
    public static readonly TypeText IndexOutOfRangeException = typeof(IndexOutOfRangeException).ToTypeText();
    public static readonly TypeText InvalidOperationException = typeof(InvalidOperationException).ToTypeText();
    public static readonly TypeText ArgumentOutOfRangeException = typeof(ArgumentOutOfRangeException).ToTypeText();

    // EditorBrowsableState
    public static readonly TypeText EditorBrowsableState = typeof(EditorBrowsableState).ToTypeText();
    public static readonly AttributeText EditorBrowsableAttribute = typeof(EditorBrowsableAttribute).ToAttributeText();
    
    // MethodImpl
    public static readonly TypeText MethodImplOptions = typeof(MethodImplOptions).ToTypeText();
    public static readonly AttributeText MethodImplAttribute = typeof(MethodImplAttribute).ToAttributeText();
    
    // Others
    public static readonly TypeText EqualityComparer_1 = typeof(EqualityComparer<>).ToTypeText();
    public static readonly AttributeText GeneratedCodeAttribute = typeof(GeneratedCodeAttribute).ToAttributeText();
}