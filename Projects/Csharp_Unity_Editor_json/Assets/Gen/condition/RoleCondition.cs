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



namespace editor.cfg.condition
{

public abstract partial class RoleCondition :  condition.Condition 
{
    public RoleCondition()
    {
    }


    public static RoleCondition LoadJsonRoleCondition(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        RoleCondition obj;
        switch (type)
        {
            case "condition.MultiRoleCondition":   
            case "MultiRoleCondition":obj = new condition.MultiRoleCondition(); break;
            case "condition.GenderLimit":   
            case "GenderLimit":obj = new condition.GenderLimit(); break;
            case "condition.MinLevel":   
            case "MinLevel":obj = new condition.MinLevel(); break;
            case "condition.MaxLevel":   
            case "MaxLevel":obj = new condition.MaxLevel(); break;
            case "condition.MinMaxLevel":   
            case "MinMaxLevel":obj = new condition.MinMaxLevel(); break;
            case "condition.ClothesPropertyScoreGreaterThan":   
            case "ClothesPropertyScoreGreaterThan":obj = new condition.ClothesPropertyScoreGreaterThan(); break;
            case "condition.ContainsItem":   
            case "ContainsItem":obj = new condition.ContainsItem(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonRoleCondition(RoleCondition _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

}
}
