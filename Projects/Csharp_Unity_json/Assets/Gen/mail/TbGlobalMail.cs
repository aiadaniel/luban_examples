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



namespace cfg.mail
{

public sealed partial class TbGlobalMail
{
    private readonly Dictionary<int, mail.GlobalMail> _dataMap;
    private readonly List<mail.GlobalMail> _dataList;
    
    public TbGlobalMail(JSONNode _json)
    {
        _dataMap = new Dictionary<int, mail.GlobalMail>();
        _dataList = new List<mail.GlobalMail>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = mail.GlobalMail.DeserializeGlobalMail(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, mail.GlobalMail> DataMap => _dataMap;
    public List<mail.GlobalMail> DataList => _dataList;

    public mail.GlobalMail GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public mail.GlobalMail Get(int key) => _dataMap[key];
    public mail.GlobalMail this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}