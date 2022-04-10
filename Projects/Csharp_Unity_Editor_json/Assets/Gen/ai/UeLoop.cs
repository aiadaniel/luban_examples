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

public sealed partial class UeLoop :  ai.Decorator 
{
    public UeLoop()
    {
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
            var _fieldJson = _json["flow_abort_mode"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { FlowAbortMode = (ai.EFlowAbortMode)System.Enum.Parse(typeof(ai.EFlowAbortMode), _fieldJson); } else if(_fieldJson.IsNumber) { FlowAbortMode = (ai.EFlowAbortMode)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["num_loops"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  NumLoops = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["infinite_loop"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  InfiniteLoop = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["infinite_loop_timeout_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  InfiniteLoopTimeoutTime = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "ai.UeLoop";
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (NodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(NodeName);
        }
        {
            _json["flow_abort_mode"] = new JSONNumber((int)FlowAbortMode);
        }
        {
            _json["num_loops"] = new JSONNumber(NumLoops);
        }
        {
            _json["infinite_loop"] = new JSONBool(InfiniteLoop);
        }
        {
            _json["infinite_loop_timeout_time"] = new JSONNumber(InfiniteLoopTimeoutTime);
        }
    }

    public static UeLoop LoadJsonUeLoop(SimpleJSON.JSONNode _json)
    {
        UeLoop obj = new ai.UeLoop();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUeLoop(UeLoop _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int NumLoops { get; set; }

    public bool InfiniteLoop { get; set; }

    public float InfiniteLoopTimeoutTime { get; set; }

}
}
