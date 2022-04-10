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

public abstract partial class DemoD3 :  test.DemoDynamic 
{
    public DemoD3(JsonElement _json)  : base(_json) 
    {
        X3 = _json.GetProperty("x3").GetInt32();
        PostInit();
    }

    public DemoD3(int x1, int x3 )  : base(x1) 
    {
        this.X3 = x3;
        PostInit();
    }

    public static DemoD3 DeserializeDemoD3(JsonElement _json)
    {
        switch (_json.GetProperty("$type").GetString())
        {
            case "DemoE1": return new test.DemoE1(_json);
            case "test.login.RoleInfo": return new test.login.RoleInfo(_json);
            default: throw new SerializationException();
        }
    }

    public int X3 { get; private set; }


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X3:" + X3 + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
