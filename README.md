# Aspid.Generators.Helper

A set of utilities for simplifying Source Generators development:

Code generation helper `CodeWriter`
Extensions for symbols and syntax nodes
Text "builders" for delegates/attributes/namespaces

**Status: prerelease (alpha). Interfaces and API may change.**

## Installation
The package is available on NuGet (prerelease):

```
Install-Package Aspid.Generators.Helper -Version 0.0.1-alpha.1
```

or via .csproj:

```xml
<ItemGroup>
  <PackageReference Include="Aspid.Generators.Helper" Version="0.0.1-alpha.1" />
</ItemGroup>
```

For the package to work correctly, we also recommend installing [SourceGenerator.Foundations](https://www.nuget.org/packages/SourceGenerator.Foundations/2.0.13)

```
Install-Package SourceGenerator.Foundations -Version 2.0.13
```

or via .csproj:

```xml
<ItemGroup>
  <PackageReference Include="SourceGenerator.Foundations" Version="2.0.13" />
</ItemGroup>
```

Target framework: .NET Standard 2.0. Compatible with generators for .NET Standard 2.0/+.

## Examples

```csharp
using Aspid.Generators.Helper;
using static Aspid.Generators.Helper.Classes;

private static void GenerateCode(SourceProductionContext context)
{
    var hasNamespace = true;
    var namespaceName = "MyNamespace";
    
    var code = new CodeWrite()
        .Append("// ")
        .AppendLine("<auto generated \>")
        .AppendLine()
        .AppendLineIf(hasNamespace, $"namespace {namespaceName}");
        .BeginBlockIf(hasNamespace)
        .AppendMultiLine(
            $$"""
            public static class MyExtensions
            {
                public staic void DoSomthing()
                {
                    throw new {{Exception}}();
                }
            }
            """
        ) 
        .EndBlockIf(hasNamespace);
        
        context.AddSource(hintName, code.GetSourceText());
        
        // Generated Code:
        // // <auto generated \>
        // namespace MyNamespace
        // {
        //     public static class MyExtensions
        //     {
        //         public static void DoSomthing()
        //         {
        //             throw new global::System.Exception();
        //         }
        //     }
        // }
}
```

```csharp
using Aspid.Generators.Helper;

public static void DoSomething(
    SemanticModel semanticModel,
    CSharpSyntaxNode cSharpSyntaxNode,
    MemberDeclarationSyntax memberDeclarationSyntax,
    PropertyDeclarationSyntax propertyDeclarationSyntax)
{
    var namespaceName = cSharpSyntaxNode.GetNamespaceName();
    bool value1 = memberDeclarationSyntax.HasAnyAttributeInSelf(semanticModel, "FullNameAttribute", "OtherFullNameAttribute");
    bool value3 = memberDeclarationSyntax.TryGetAnyAttributeInSelf(semanticModel, out IMethodSymbol? outAttribute2, "FullNameAttribute", "OtherFullNameAttribute");
    IMethodSymbol attribute = memberDeclarationSyntax.GetAttributeInSelf(semanticModel, "FullNameAttribute");
    IEnumerable<IMethodSymbol> attributes = memberDeclarationSyntax.GetAttributesInSelf(semanticModel, "FullNameAttribute", "OtherFullNameAttribute");
    
    var hasGet = propertyDeclarationSyntax.HasGetAccessor();
    var hasSet = propertyDeclarationSyntax.HasSetAccessor();
    var hasInit = propertyDeclarationSyntax.HasInitAccessor();
}
```

```csharp
using Aspid.Generators.Helper;

public static void DoSomething(
    ISymbol symbol,
    IMethodSymbol methodSymbol1,
    IMethodSymbol methodSymbol2)
{
    ITypeSymbol typeSymbol = symbol.GetSymbolType();
    string globalName = symbol.ToDisplayStringGlobal();
    bool value2 = symbol.HasAnyAttributeInSelf("FullNameAttribute", "OtherFullNameAttribute");
    bool value3 = symbol.TryGetAnyAttributeInSelf(out AttributeData? outAttribute2, "FullNameAttribute", "OtherFullNameAttribute");
    AttributeData? attributeData1 = symbol.GetAttributeInSelf("FullNameAttribute");
    IEnumerable<AttributeData> attributesData1 = symbol.GetAttributesInSelf("FullNameAttribute", "OtherFullNameAttribute");
    
    bool equalsMethods = methodSymbol.EqualsSignature(methodSymbol2);
    string nameFromExplicitImplementation = methodSymbol.NameFromExplicitImplementation();
    
    bool value4 = typeSymbol.HasAnyAttributeInBases("FullNameAttribute");
    bool value5 = typeSymbol.HasAnyAttributeInSelfAndBases("FullNameAttribute", "OtherFullNameAttribute");
    bool value6 = typeSymbol.TryGetAnyAttributeInBases(out AttributeData? outAttribute2, "FullNameAttribute", "OtherFullNameAttribute");
    bool value7 = typeSymbol.TryGetAnyAttributeInSelfAndBases(out AttributeData? outAttribute2, "FullNameAttribute", "OtherFullNameAttribute");
    AttributeData? attributeData2 = symbol.GetAttributeInBases("FullNameAttribute");
    AttributeData? attributeData3 = symbol.GetAttributeInSelfAndBases("FullNameAttribute");
    IEnumerable<AttributeData> attributesData2 = symbol.GetAttributesInBases("FullNameAttribute", "OtherFullNameAttribute");
    IEnumerable<AttributeData> attributesData3 = symbol.GetAttributesInSelfAndBases("FullNameAttribute", "OtherFullNameAttribute");

    bool value8 = typeSymbol.HasAnyBaseType("FullBaseTypeName", "OtherFullBaseTypeName");
    bool value9 = typeSymbol.TryGetAnyBaseType(out out ITypeSymbol? outBaseType1, "FullBaseTypeName", "OtherFullBaseTypeName");
    ITypeSymbol? baseType = typeSymbol.GetBaseType("FullBaseTypeName");
    IEnumerable<ITypeSymbol> baseTypes = typeSymbol.GetBaseType("FullBaseTypeName", "OtherFullBaseTypeName");
    IEnumerable<ITypeSymbol> allBaseTypes1 = typeSymbol.GetAllBaseTypes();
    IEnumerable<ITypeSymbol> allBaseTypes2 = typeSymbol.GetAllBaseTypesAndSelf();
    
    bool value10 = typeSymbol.HasAnyInterfaceInSelf("FullInterfaceName", "OtherFullInterfaceName");
    bool value11 = typeSymbol.HasAnyInterfaceInSelfAndBases("FullInterfaceName", "OtherInterfaceName");
    bool value12 = typeSymbol.TryGetAnyInterfaceInSelf(out INamedTypeSymbol? outInterface1, "FullInterfaceName", "OtherFullInterfaceName");
    bool value13 = typeSymbol.TryGetAnyInterfaceInSelfAndBases(out INamedTypeSymbol? outInterface2, "FullInterfaceName", "OtherInterfaceName");
    INamedTypeSymbol? interface1 = typeSymbol.GetInterfaceInSelf("FullInterfaceName");
    INamedTypeSymbol? interface2 = typeSymbol.GetInterfaceInSelfAndBases("FullInterfaceName");
    IEnumerable<INamedTypeSymbol> interfaces1 = typeSymbol.GetInterfacesInSelf("FullInterfaceName", "OtherInterfaceName");
    IEnumerable<INamedTypeSymbol> interfaces2 = typeSymbol.GetInterfacesInSelfAndBases("FullInterfaceName", "OtherInterfaceName");
}
```
