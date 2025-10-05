using System.IO;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CodeAnalysis.Text;

namespace Aspid.Generators.Helper.CodeWriters;

public sealed class CodeWriter
{
    private readonly MemoryStream _sourceStream;
    private readonly IndentedTextWriter _textWriter;
    
    public CodeWriter()
    {
        _sourceStream = new MemoryStream();
        var sourceStreamWriter = new StreamWriter(_sourceStream, Encoding.UTF8);
        _textWriter = new IndentedTextWriter(sourceStreamWriter);
    }
    
    public int Indent
    {
        get => _textWriter.Indent;
        set => _textWriter.Indent = value;
    }
    
        public CodeWriter Append(bool value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(char value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(char[] buffer)
    {
        _textWriter.Write(buffer);
        return this;
    }
    
    public CodeWriter Append(char[] buffer, int index, int count)
    {
        _textWriter.Write(buffer, index, count);
        return this;
    }
    
    public CodeWriter Append(int value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(uint value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(long value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(ulong value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(float value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(double value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(decimal value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(object value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(string value)
    {
        _textWriter.Write(value);
        return this;
    }
    
    public CodeWriter Append(string format, object arg0)
    {
        _textWriter.Write(format, arg0);
        return this;
    }
    
    public CodeWriter Append(string format, object arg0, object arg1)
    {
        _textWriter.Write(format, arg0, arg1);
        return this;
    }
    
    public CodeWriter Append(string format, object arg0, object arg1, object arg2)
    {
        _textWriter.Write(format, arg0, arg1, arg2);
        return this;
    }
    
    public CodeWriter Append(string format, params object[] arg)
    {
        _textWriter.Write(format, arg);
        return this;
    }
    
    public CodeWriter AppendLine()
    {
        _textWriter.WriteLine();
        return this;
    }
    
    public CodeWriter AppendLine(bool value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(char value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(char[] buffer)
    {
        _textWriter.WriteLine(buffer);
        return this;
    }
    
    public CodeWriter AppendLine(char[] buffer, int index, int count)
    {
        _textWriter.WriteLine(buffer, index, count);
        return this;
    }
    
    public CodeWriter AppendLine(int value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(uint value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(long value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(ulong value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(float value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(double value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(decimal value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(object value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(string value)
    {
        _textWriter.WriteLine(value);
        return this;
    }
    
    public CodeWriter AppendLine(string format, object arg0)
    {
        _textWriter.WriteLine(format, arg0);
        return this;
    }
    
    public CodeWriter AppendLine(string format, object arg0, object arg1)
    {
        _textWriter.WriteLine(format, arg0, arg1);
        return this;
    }
    
    public CodeWriter AppendLine(string format, object arg0, object arg1, object arg2)
    {
        _textWriter.WriteLine(format, arg0, arg1, arg2);
        return this;
    }
    
    public CodeWriter AppendLine(string format, params object[] arg)
    {
        _textWriter.WriteLine(format, arg);
        return this;
    }
    
    public SourceText GetSourceText()
    {
        _textWriter.Flush();
        return SourceText.From(_sourceStream, Encoding.UTF8, canBeEmbedded: true);
    }
}