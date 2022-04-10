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

public sealed partial class Clothes :  item.ItemExtra 
{
    public Clothes(JsonElement _json)  : base(_json) 
    {
        Attack = _json.GetProperty("attack").GetInt32();
        Hp = _json.GetProperty("hp").GetInt64();
        EnergyLimit = _json.GetProperty("energy_limit").GetInt32();
        EnergyResume = _json.GetProperty("energy_resume").GetInt32();
        PostInit();
    }

    public Clothes(int id, int attack, long hp, int energy_limit, int energy_resume )  : base(id) 
    {
        this.Attack = attack;
        this.Hp = hp;
        this.EnergyLimit = energy_limit;
        this.EnergyResume = energy_resume;
        PostInit();
    }

    public static Clothes DeserializeClothes(JsonElement _json)
    {
        return new item.Clothes(_json);
    }

    public int Attack { get; private set; }
    public long Hp { get; private set; }
    public int EnergyLimit { get; private set; }
    public int EnergyResume { get; private set; }

    public const int __ID__ = 1659907149;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Attack:" + Attack + ","
        + "Hp:" + Hp + ","
        + "EnergyLimit:" + EnergyLimit + ","
        + "EnergyResume:" + EnergyResume + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
