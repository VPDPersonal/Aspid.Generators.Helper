using System;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.CodeWriters;

public static partial class CodeWriterExtensions
{
    public static IndentScope BeginIndentScope(this CodeWriter code) => new(code);
    
    public static CodeWriter IncreaseIndent(this CodeWriter code)
    {
        code.Indent++;
        return code;
    }
    
    public static CodeWriter IncreaseIndentIf(this CodeWriter code, bool flag) =>
        flag ? code.IncreaseIndent() : code;
    
    public static CodeWriter IncreaseIndentIf(this CodeWriter code, Func<bool> condition) =>
        condition.Invoke() ? code.IncreaseIndent() : code;
    
    public static CodeWriter DecreaseIndent(this CodeWriter code)
    {
        code.Indent--;
        return code;
    }
    
    public static CodeWriter DecreaseIndentIf(this CodeWriter code, bool flag) =>
        flag ? code.DecreaseIndent() : code;
    
    public static CodeWriter DecreaseIndentIf(this CodeWriter code, Func<bool> condition) =>
        condition.Invoke() ? code.DecreaseIndent() : code;
    
    public readonly ref struct IndentScope : IDisposable
    {
        private readonly  CodeWriter _source;
        
        public IndentScope(CodeWriter source)
        {
            _source = source;
            source.IncreaseIndent();
        }
        
        public void Dispose() =>
            _source.DecreaseIndent();
    }
}