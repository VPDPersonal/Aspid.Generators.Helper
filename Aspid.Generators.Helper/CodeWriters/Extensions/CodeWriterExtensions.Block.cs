using System;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.CodeWriters;

public static partial class CodeWriterExtensions
{
    public static BlockScope BeginBlockScope(this CodeWriter code) => new(code);
    
    public static CodeWriter BeginBlock(this CodeWriter code)
    {
        code.AppendLine('{');
        code.Indent++;
        
        return code;
    }
    
    public static CodeWriter BeginBlockIf(this CodeWriter code, bool flag) =>
        flag ? code.BeginBlock() : code;
    
    public static CodeWriter BeginBlockIf(this CodeWriter code, Func<bool> condition) =>
        condition.Invoke() ? code.BeginBlock() : code;
    
    public static CodeWriter EndBlock(this CodeWriter code)
    {
        code.Indent--;
        code.AppendLine('}');
        
        return code;
    }
    
    public static CodeWriter EndBlockIf(this CodeWriter code, bool flag) =>
        flag ? code.EndBlock() : code;
    
    public static CodeWriter EndBlockIf(this CodeWriter code, Func<bool> condition) =>
        condition.Invoke() ? code.EndBlock() : code;
    
    public readonly ref struct BlockScope : IDisposable
    {
        private readonly CodeWriter _source;
        
        public BlockScope(CodeWriter source)
        {
            _source = source;
            source.BeginBlock();
        }
        
        public void Dispose() =>
            _source.EndBlock();
    }
}