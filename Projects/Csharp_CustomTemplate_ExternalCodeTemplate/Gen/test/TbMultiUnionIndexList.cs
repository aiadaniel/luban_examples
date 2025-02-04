
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

public sealed class TbMultiUnionIndexList
{
    private readonly List<test.MultiUnionIndexList> _dataList;
    
    public TbMultiUnionIndexList(JsonElement _json)
    {
        _dataList = new List<test.MultiUnionIndexList>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.MultiUnionIndexList.DeserializeMultiUnionIndexList(_row);
            _dataList.Add(_v);
        }
    }

    public List<test.MultiUnionIndexList> DataList => _dataList;

    public test.MultiUnionIndexList Get(int index) => _dataList[index];
    public test.MultiUnionIndexList this[int index] => _dataList[index];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
}

}