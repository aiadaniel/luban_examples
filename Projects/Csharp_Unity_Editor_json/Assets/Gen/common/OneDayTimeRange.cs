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



namespace editor.cfg.common
{

public sealed partial class OneDayTimeRange :  Bright.Config.EditorBeanBase 
{
    public OneDayTimeRange()
    {
            StartTime = new common.TimeOfDay();
            EndTime = new common.TimeOfDay();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["start_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  StartTime = common.TimeOfDay.LoadJsonTimeOfDay(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["end_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  EndTime = common.TimeOfDay.LoadJsonTimeOfDay(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "common.OneDayTimeRange";
        {

            if (StartTime == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  common.TimeOfDay.SaveJsonTimeOfDay(StartTime, __bjson); _json["start_time"] = __bjson; }
        }
        {

            if (EndTime == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  common.TimeOfDay.SaveJsonTimeOfDay(EndTime, __bjson); _json["end_time"] = __bjson; }
        }
    }

    public static OneDayTimeRange LoadJsonOneDayTimeRange(SimpleJSON.JSONNode _json)
    {
        OneDayTimeRange obj = new common.OneDayTimeRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonOneDayTimeRange(OneDayTimeRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public common.TimeOfDay StartTime { get; set; }

    public common.TimeOfDay EndTime { get; set; }

}
}
