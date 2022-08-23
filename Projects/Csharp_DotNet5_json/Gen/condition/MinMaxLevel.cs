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



namespace cfg.condition
{

public sealed partial class MinMaxLevel :  condition.BoolRoleCondition 
{
    public MinMaxLevel(JsonElement _json)  : base(_json) 
    {
        MinLevel = _json.GetProperty("min_level").GetInt32();
        MaxLevel = _json.GetProperty("max_level").GetInt32();
        PostInit();
    }

    public MinMaxLevel(int min_level, int max_level )  : base() 
    {
        this.MinLevel = min_level;
        this.MaxLevel = max_level;
        PostInit();
    }

    public static MinMaxLevel DeserializeMinMaxLevel(JsonElement _json)
    {
        return new condition.MinMaxLevel(_json);
    }

    public int MinLevel { get; private set; }
    public int MaxLevel { get; private set; }

    public const int __ID__ = 907499647;
    public override int GetTypeId() => __ID__;

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
        + "MinLevel:" + MinLevel + ","
        + "MaxLevel:" + MaxLevel + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
