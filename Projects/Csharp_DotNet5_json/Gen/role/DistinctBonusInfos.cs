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



namespace cfg.role
{

public sealed partial class DistinctBonusInfos :  Bright.Config.BeanBase 
{
    public DistinctBonusInfos(JsonElement _json) 
    {
        EffectiveLevel = _json.GetProperty("effective_level").GetInt32();
        { var __json0 = _json.GetProperty("bonus_info"); BonusInfo = new System.Collections.Generic.List<role.BonusInfo>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { role.BonusInfo __v0;  __v0 = role.BonusInfo.DeserializeBonusInfo(__e0);  BonusInfo.Add(__v0); }   }
        PostInit();
    }

    public DistinctBonusInfos(int effective_level, System.Collections.Generic.List<role.BonusInfo> bonus_info ) 
    {
        this.EffectiveLevel = effective_level;
        this.BonusInfo = bonus_info;
        PostInit();
    }

    public static DistinctBonusInfos DeserializeDistinctBonusInfos(JsonElement _json)
    {
        return new role.DistinctBonusInfos(_json);
    }

    public int EffectiveLevel { get; private set; }
    public System.Collections.Generic.List<role.BonusInfo> BonusInfo { get; private set; }

    public const int __ID__ = -854361766;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in BonusInfo) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in BonusInfo) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "EffectiveLevel:" + EffectiveLevel + ","
        + "BonusInfo:" + Bright.Common.StringUtil.CollectionToString(BonusInfo) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
