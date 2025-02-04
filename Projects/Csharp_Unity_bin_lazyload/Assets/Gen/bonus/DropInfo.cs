//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public sealed partial class DropInfo :  Bright.Config.BeanBase 
{
    public DropInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Desc = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);ClientShowItems = new System.Collections.Generic.List<bonus.ShowItemInfo>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { bonus.ShowItemInfo _e0;  _e0 = bonus.ShowItemInfo.DeserializeShowItemInfo(_buf); ClientShowItems.Add(_e0);}}
        Bonus = bonus.Bonus.DeserializeBonus(_buf);
        PostInit();
    }

    public static DropInfo DeserializeDropInfo(ByteBuf _buf)
    {
        return new bonus.DropInfo(_buf);
    }

    public int Id { get; private set; }
    public string Desc { get; private set; }
    public System.Collections.Generic.List<bonus.ShowItemInfo> ClientShowItems { get; private set; }
    public bonus.Bonus Bonus { get; private set; }

    public const int __ID__ = -2014781108;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in ClientShowItems) { _e?.Resolve(_tables); }
        Bonus?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in ClientShowItems) { _e?.TranslateText(translator); }
        Bonus?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Desc:" + Desc + ","
        + "ClientShowItems:" + Bright.Common.StringUtil.CollectionToString(ClientShowItems) + ","
        + "Bonus:" + Bonus + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
