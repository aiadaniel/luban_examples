//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.cost
{

public sealed partial class CostItems :  cost.Cost 
{
    public CostItems(ByteBuf _buf)  : base(_buf) 
    {
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);ItemList = new cost.CostItem[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { cost.CostItem __e0;__e0 = cost.CostItem.DeserializeCostItem(_buf); ItemList[__index0] = __e0;}}
        PostInit();
    }

    public static CostItems DeserializeCostItems(ByteBuf _buf)
    {
        return new cost.CostItems(_buf);
    }

    public cost.CostItem[] ItemList { get; private set; }

    public const int __ID__ = -77945102;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in ItemList) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in ItemList) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "ItemList:" + Bright.Common.StringUtil.CollectionToString(ItemList) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
