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



namespace cfg.test
{

public sealed partial class TbNotIndexList
{
    private readonly List<test.NotIndexList> _dataList;

    
    public TbNotIndexList(JsonElement _json)
    {
        _dataList = new List<test.NotIndexList>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.NotIndexList.DeserializeNotIndexList(_row);
            _dataList.Add(_v);
        }
        PostInit();
    }

    public List<test.NotIndexList> DataList => _dataList;


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