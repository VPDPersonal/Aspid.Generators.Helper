using System;

// ReSharper disable once CheckNamespace
namespace Aspid.Generators.Helper.CodeWriters;

public static partial class CodeWriterExtensions
{
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag)
    {
        if (flag) code.AppendLine();
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, bool value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, bool value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, char value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, char value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, char[] buffer)
    {
        if (flag) code.AppendLine(buffer);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, char[] buffer)
    {
        if (condition.Invoke()) code.AppendLine(buffer);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, char[] buffer, int index, int count)
    {
        if (flag) code.AppendLine(buffer, index, count);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, char[] buffer, int index, int count)
    {
        if (condition.Invoke()) code.AppendLine(buffer, index, count);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, int value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, int value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, uint value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, uint value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, long value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, long value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, ulong value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, ulong value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, float value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, float value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, double value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, double value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, decimal value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, decimal value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, object value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, object value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, string value)
    {
        if (flag) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, string value)
    {
        if (condition.Invoke()) code.AppendLine(value);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, string format, object arg0)
    {
        if (flag) code.AppendLine(format, arg0);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, string format, object arg0)
    {
        if (condition.Invoke()) code.AppendLine(format, arg0);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, string format, object arg0, object arg1)
    {
        if (flag) code.AppendLine(format, arg0, arg1);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, string format, object arg0, object arg1)
    {
        if (condition.Invoke()) code.AppendLine(format, arg0, arg1);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, string format, object arg0, object arg1, object arg2)
    {
        if (flag) code.AppendLine(format, arg0, arg1, arg2);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, string format, object arg0, object arg1, object arg2)
    {
        if (condition.Invoke()) code.AppendLine(format, arg0, arg1, arg2);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, bool flag, string format, params object[] arg)
    {
        if (flag) code.AppendLine(format, arg);
        return code;
    }
    
    public static CodeWriter AppendLineIf(this CodeWriter code, Func<bool> condition, string format, params object[] arg)
    {
        if (condition.Invoke()) code.AppendLine(format, arg);
        return code;
    }
}