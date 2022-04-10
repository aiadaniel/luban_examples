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



namespace cfg.error
{

public sealed partial class CodeInfo :  Bright.Config.BeanBase 
{
    public CodeInfo(JSONNode _json) 
    {
        { if(!_json["code"].IsNumber) { throw new SerializationException(); }  Code = (error.EErrorCode)_json["code"].AsInt; }
        { if(!_json["key"].IsString) { throw new SerializationException(); }  Key = _json["key"]; }
        PostInit();
    }

    public CodeInfo(error.EErrorCode code, string key ) 
    {
        this.Code = code;
        this.Key = key;
        PostInit();
    }

    public static CodeInfo DeserializeCodeInfo(JSONNode _json)
    {
        return new error.CodeInfo(_json);
    }

    public error.EErrorCode Code { get; private set; }
    public string Key { get; private set; }

    public const int __ID__ = -1942481535;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Code:" + Code + ","
        + "Key:" + Key + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
