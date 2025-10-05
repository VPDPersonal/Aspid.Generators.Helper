using System;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.CodeWriters;

public static partial class CodeWriterExtensions
{
    public static CodeWriter AppendMultilineIf(this CodeWriter code, bool flag, string value)
    {
        if (!flag) return code;
        
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
    
    public static CodeWriter AppendMultilineIf(this CodeWriter code, Func<bool> condition, string value)
    {
        if (!condition.Invoke()) return code;
        
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