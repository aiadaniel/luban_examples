
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{

public sealed class DemoD2 :  test.DemoDynamic 
{
    public DemoD2(JsonElement _json)  : base(_json) 
    {
        X2 = _json.GetProperty("x2").GetInt32();
    }

    public DemoD2(int x1, int x2 )  : base(x1) 
    {
        this.X2 = x2;
    }

    public static DemoD2 DeserializeDemoD2(JsonElement _json)
    {
        return new test.DemoD2(_json);
    }

    public int X2 { get; private set; }

    public const int __ID__ = -2138341747;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "}";
    }
    }
}
