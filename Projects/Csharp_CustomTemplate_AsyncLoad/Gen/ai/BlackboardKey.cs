
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



namespace cfg.ai
{

public sealed class BlackboardKey :  Bright.Config.BeanBase 
{
    public BlackboardKey(JsonElement _json) 
    {
        Name = _json.GetProperty("name").GetString();
        Desc = _json.GetProperty("desc").GetString();
        IsStatic = _json.GetProperty("is_static").GetBoolean();
        Type = (ai.EKeyType)_json.GetProperty("type").GetInt32();
        TypeClassName = _json.GetProperty("type_class_name").GetString();
    }

    public BlackboardKey(string name, string desc, bool is_static, ai.EKeyType type, string type_class_name ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.IsStatic = is_static;
        this.Type = type;
        this.TypeClassName = type_class_name;
    }

    public static BlackboardKey DeserializeBlackboardKey(JsonElement _json)
    {
        return new ai.BlackboardKey(_json);
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public bool IsStatic { get; private set; }
    public ai.EKeyType Type { get; private set; }
    public string TypeClassName { get; private set; }

    public const int __ID__ = -511559886;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "Type:" + Type + ","
        + "TypeClassName:" + TypeClassName + ","
        + "}";
    }
    }
}
