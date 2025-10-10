using System;

// ReSharper disable CheckNamespace
namespace Aspid.Generators.Helper;

public static partial class CodeWriterExtensions
{
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, bool value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, bool value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, char value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, char value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, char[] buffer)
    {
        if (flag) code.Append(buffer);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, char[] buffer)
    {
        if (condition.Invoke()) code.Append(buffer);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, char[] buffer, int index, int count)
    {
        if (flag) code.Append(buffer, index, count);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, char[] buffer, int index, int count)
    {
        if (condition.Invoke()) code.Append(buffer, index, count);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, int value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, int value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, uint value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, uint value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, long value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, long value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, ulong value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, ulong value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, float value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, float value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, double value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, double value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, decimal value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, decimal value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, object value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, object value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, string value)
    {
        if (flag) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, string value)
    {
        if (condition.Invoke()) code.Append(value);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, string format, object arg0)
    {
        if (flag) code.Append(format, arg0);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, string format, object arg0)
    {
        if (condition.Invoke()) code.Append(format, arg0);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, string format, object arg0, object arg1)
    {
        if (flag) code.Append(format, arg0, arg1);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, string format, object arg0, object arg1)
    {
        if (condition.Invoke()) code.Append(format, arg0, arg1);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, string format, object arg0, object arg1, object arg2)
    {
        if (flag) code.Append(format, arg0, arg1, arg2);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, string format, object arg0, object arg1, object arg2)
    {
        if (condition.Invoke()) code.Append(format, arg0, arg1, arg2);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, bool flag, string format, params object[] arg)
    {
        if (flag) code.Append(format, arg);
        return code;
    }
    
    public static CodeWriter AppendIf(this CodeWriter code, Func<bool> condition, string format, params object[] arg)
    {
        if (condition.Invoke()) code.Append(format, arg);
        return code;
    }
}