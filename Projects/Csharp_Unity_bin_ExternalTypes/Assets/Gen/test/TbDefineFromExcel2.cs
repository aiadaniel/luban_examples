//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.test
{
   
public partial class TbDefineFromExcel2
{
    private readonly Dictionary<int, test.DefineFromExcel2> _dataMap;
    private readonly List<test.DefineFromExcel2> _dataList;
    
    public TbDefineFromExcel2(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.DefineFromExcel2>();
        _dataList = new List<test.DefineFromExcel2>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.DefineFromExcel2 _v;
            _v = test.DefineFromExcel2.DeserializeDefineFromExcel2(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.DefineFromExcel2> DataMap => _dataMap;
    public List<test.DefineFromExcel2> DataList => _dataList;

    public test.DefineFromExcel2 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DefineFromExcel2 Get(int key) => _dataMap[key];
    public test.DefineFromExcel2 this[int key] => _dataMap[key];

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