//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class Color :  Bright.Config.BeanBase 
{
    public Color(ByteBuf _buf) 
    {
        R = _buf.ReadFloat();
        G = _buf.ReadFloat();
        B = _buf.ReadFloat();
        A = _buf.ReadFloat();
        PostInit();
    }

    public static Color DeserializeColor(ByteBuf _buf)
    {
        return new test.Color(_buf);
    }

    public float R { get; private set; }
    public float G { get; private set; }
    public float B { get; private set; }
    public float A { get; private set; }

    public const int __ID__ = 623131367;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "R:" + R + ","
        + "G:" + G + ","
        + "B:" + B + ","
        + "A:" + A + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
