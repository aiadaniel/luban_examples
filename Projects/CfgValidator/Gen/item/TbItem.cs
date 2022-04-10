
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



namespace cfg.item
{

/// <summary>
/// 道具表
/// </summary>
public sealed class TbItem
{
    private readonly Dictionary<int, item.Item> _dataMap;
    private readonly List<item.Item> _dataList;
    
    public TbItem(JsonElement _json)
    {
        _dataMap = new Dictionary<int, item.Item>();
        _dataList = new List<item.Item>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = item.Item.DeserializeItem(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, item.Item> DataMap => _dataMap;
    public List<item.Item> DataList => _dataList;

    public item.Item GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public item.Item Get(int key) => _dataMap[key];
    public item.Item this[int key] => _dataMap[key];

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