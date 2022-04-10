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



namespace editor.cfg.ai
{

public sealed partial class MoveToTarget :  ai.Task 
{
    public MoveToTarget()
    {
            TargetActorKey = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  NodeName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["decorators"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } Decorators = new System.Collections.Generic.List<ai.Decorator>(); foreach(JSONNode __e in _fieldJson.Children) { ai.Decorator __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = ai.Decorator.LoadJsonDecorator(__e);  Decorators.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["services"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } Services = new System.Collections.Generic.List<ai.Service>(); foreach(JSONNode __e in _fieldJson.Children) { ai.Service __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = ai.Service.LoadJsonService(__e);  Services.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["ignore_restart_self"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  IgnoreRestartSelf = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["target_actor_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  TargetActorKey = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["acceptable_radius"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  AcceptableRadius = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "ai.MoveToTarget";
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (NodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(NodeName);
        }
        {

            if (Decorators == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in Decorators) { { var __bjson = new JSONObject();  ai.Decorator.SaveJsonDecorator(_e, __bjson); __cjson["null"] = __bjson; } } _json["decorators"] = __cjson; }
        }
        {

            if (Services == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in Services) { { var __bjson = new JSONObject();  ai.Service.SaveJsonService(_e, __bjson); __cjson["null"] = __bjson; } } _json["services"] = __cjson; }
        }
        {
            _json["ignore_restart_self"] = new JSONBool(IgnoreRestartSelf);
        }
        {

            if (TargetActorKey == null) { throw new System.ArgumentNullException(); }
            _json["target_actor_key"] = new JSONString(TargetActorKey);
        }
        {
            _json["acceptable_radius"] = new JSONNumber(AcceptableRadius);
        }
    }

    public static MoveToTarget LoadJsonMoveToTarget(SimpleJSON.JSONNode _json)
    {
        MoveToTarget obj = new ai.MoveToTarget();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMoveToTarget(MoveToTarget _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string TargetActorKey { get; set; }

    public float AcceptableRadius { get; set; }

}
}
