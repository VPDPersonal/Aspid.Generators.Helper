namespace Aspid.Generators.Helper.Text;

public sealed class NamespaceText(string namespaceName, NamespaceText? parent = null)
{
    private readonly string _namespace = (parent is not null ?  $"{parent}." : "") + namespaceName;
    
    private bool Equals(NamespaceText other) =>
        _namespace == other._namespace;

    public override bool Equals(object? obj) =>
        ReferenceEquals(this, obj) || obj is NamespaceText other && Equals(other);

    public override int GetHashCode() => _namespace.GetHashCode();
    
    public override string ToString() => _namespace;

    public static bool operator ==(NamespaceText left, string right) =>
        left._namespace == right;
    
    public static bool operator !=(NamespaceText left, string right) => !(left == right);
    
    public static bool operator ==(string left, NamespaceText right) => right == left;
    
    public static bool operator !=(string left, NamespaceText right) => right != left;
    
    public static bool operator ==(NamespaceText left, NamespaceText right) =>
        left._namespace == right._namespace;
    
    public static bool operator !=(NamespaceText left, NamespaceText right) => !(left == right);

    public static implicit operator string?(NamespaceText? namespaceText) => namespaceText?.ToString();
    
    public static implicit operator NamespaceText?(string? namespaceName) =>
        string.IsNullOrWhiteSpace(namespaceName) ? null : new NamespaceText(namespaceName!);
}