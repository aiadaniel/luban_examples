//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.role
{
   
public partial class TbRoleLevelBonusCoefficient
{
    private readonly Dictionary<int, role.LevelBonus> _dataMap;
    private readonly List<role.LevelBonus> _dataList;
    
    public TbRoleLevelBonusCoefficient(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, role.LevelBonus>();
        _dataList = new List<role.LevelBonus>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            role.LevelBonus _v;
            _v = role.LevelBonus.DeserializeLevelBonus(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, role.LevelBonus> DataMap => _dataMap;
    public List<role.LevelBonus> DataList => _dataList;

    public role.LevelBonus GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public role.LevelBonus Get(int key) => _dataMap[key];
    public role.LevelBonus this[int key] => _dataMap[key];

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