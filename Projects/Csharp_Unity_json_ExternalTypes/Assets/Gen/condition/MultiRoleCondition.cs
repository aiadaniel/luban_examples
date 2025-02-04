//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.condition
{

public sealed partial class MultiRoleCondition :  condition.RoleCondition 
{
    public MultiRoleCondition(JSONNode _json)  : base(_json) 
    {
        { var __json0 = _json["conditions"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; Conditions = new condition.RoleCondition[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { condition.RoleCondition __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = condition.RoleCondition.DeserializeRoleCondition(__e0);  }  Conditions[__index0++] = __v0; }   }
        PostInit();
    }

    public MultiRoleCondition(condition.RoleCondition[] conditions )  : base() 
    {
        this.Conditions = conditions;
        PostInit();
    }

    public static MultiRoleCondition DeserializeMultiRoleCondition(JSONNode _json)
    {
        return new condition.MultiRoleCondition(_json);
    }

    public condition.RoleCondition[] Conditions { get; private set; }

    public const int __ID__ = 934079583;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Conditions) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Conditions) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Conditions:" + Bright.Common.StringUtil.CollectionToString(Conditions) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
