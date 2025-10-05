// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.CodeWriters;

public static partial class CodeWriterExtensions
{
    public static CodeWriter AppendMultiline(this CodeWriter code, string value)
    {
        var indent = code.Indent;
        code.Indent = 0;

        if (indent is not 0)
        {
            var tab = new string('\t', indent);
            
            value = $"{tab}{value}";
            value = value.Replace("\n", $"\n{tab}");
        }
        
        code.AppendLine(value);
        code.Indent = indent;
        
        return code;
    }
}