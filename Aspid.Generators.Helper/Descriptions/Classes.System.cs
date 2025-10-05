using Aspid.Generators.Helper.Text;

namespace Aspid.Generators.Helper.Descriptions;

public static partial class Classes
{
    // Collections
    public static readonly TypeText SpanT1 = new("Span", Namespaces.System);
    public static readonly TypeText ReadOnlySpanT1 = new("ReadOnlySpan", Namespaces.System);
    public static readonly TypeText ListT1 = new("List", Namespaces.System_Collections_Generic);
    public static readonly TypeText IListT1 = new("IList", Namespaces.System_Collections_Generic);
    public static readonly TypeText DictionaryT2 = new("Dictionary", Namespaces.System_Collections_Generic);
    
    public static readonly TypeText IEnumerable = new("IEnumerable", Namespaces.System_Collections);
    public static readonly TypeText IEnumerableT1 = new("IEnumerable", Namespaces.System_Collections_Generic);
    
    // Delegates
    public static readonly TypeText FuncT = new("Func", Namespaces.System);
    public static readonly TypeText ActionT = new("Action", Namespaces.System);
    public static readonly TypeText DelegateT = new("Delegate", Namespaces.System);
    
    // Exceptions
    public static readonly TypeText Exception = new("Exception", Namespaces.System);
    public static readonly TypeText ArgumentNullException = new("ArgumentNullException", Namespaces.System);
    public static readonly TypeText InvalidOperationException = new("InvalidOperationException", Namespaces.System);
    
    // EditorBrowsableState
    public static readonly TypeText EditorBrowsableState = new("EditorBrowsableState", Namespaces.System_ComponentModel);
    public static readonly AttributeText EditorBrowsableAttribute = new("EditorBrowsable", Namespaces.System_ComponentModel);
    
    // MethodImpl
    public static readonly TypeText MethodImplOptions = new("MethodImplOptions", Namespaces.System_Runtime_CompilerServices);
    public static readonly AttributeText MethodImplAttribute = new("MethodImplAttribute", Namespaces.System_Runtime_CompilerServices);
    
    // Others
    public static readonly TypeText EqualityComparerT1 = new("EqualityComparer", Namespaces.System_Collections_Generic);
    public static readonly AttributeText GeneratedCodeAttribute = new("GeneratedCodeAttribute", Namespaces.System_CodeDom_Compiler);
}