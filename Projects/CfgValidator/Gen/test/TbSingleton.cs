
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

public sealed class TbSingleton
{

     private readonly test.DemoSingletonType _data;

    public TbSingleton(JsonElement _json)
    {
        int n = _json.GetArrayLength();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = test.DemoSingletonType.DeserializeDemoSingletonType(_json[0]);
    }

     public int Id => _data.Id;
     public string Name => _data.Name;
     public test.DemoDynamic Date => _data.Date;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        _data.TranslateText(translator);
    }

}

}