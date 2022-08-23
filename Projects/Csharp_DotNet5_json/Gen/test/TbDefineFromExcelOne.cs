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

public sealed partial class TbDefineFromExcelOne
{

     private readonly test.DefineFromExcelOne _data;

    public TbDefineFromExcelOne(JsonElement _json)
    {
        int n = _json.GetArrayLength();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = test.DefineFromExcelOne.DeserializeDefineFromExcelOne(_json[0]);
        PostInit();
    }

    /// <summary>
    /// 装备解锁等级
    /// </summary>
     public int UnlockEquip => _data.UnlockEquip;
    /// <summary>
    /// 英雄解锁等级
    /// </summary>
     public int UnlockHero => _data.UnlockHero;
     public string DefaultAvatar => _data.DefaultAvatar;
     public string DefaultItem => _data.DefaultItem;
     public test.DemoE2 E2 => _data.E2;
     public System.Collections.Generic.List<string> Icons => _data.Icons;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        _data.TranslateText(translator);
    }


    partial void PostInit();
    partial void PostResolve();
}

}