// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BonusWeightBonus : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static BonusWeightBonus GetRootAsBonusWeightBonus(ByteBuffer _bb) { return GetRootAsBonusWeightBonus(_bb, new BonusWeightBonus()); }
  public static BonusWeightBonus GetRootAsBonusWeightBonus(ByteBuffer _bb, BonusWeightBonus obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BonusWeightBonus __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.BonusWeightBonusInfo? Bonuses(int j) { int o = __p.__offset(4); return o != 0 ? (cfg.BonusWeightBonusInfo?)(new cfg.BonusWeightBonusInfo()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int BonusesLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<cfg.BonusWeightBonus> CreateBonusWeightBonus(FlatBufferBuilder builder,
      VectorOffset bonusesOffset = default(VectorOffset)) {
    builder.StartTable(1);
    BonusWeightBonus.AddBonuses(builder, bonusesOffset);
    return BonusWeightBonus.EndBonusWeightBonus(builder);
  }

  public static void StartBonusWeightBonus(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddBonuses(FlatBufferBuilder builder, VectorOffset bonusesOffset) { builder.AddOffset(0, bonusesOffset.Value, 0); }
  public static VectorOffset CreateBonusesVector(FlatBufferBuilder builder, Offset<cfg.BonusWeightBonusInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBonusesVectorBlock(FlatBufferBuilder builder, Offset<cfg.BonusWeightBonusInfo>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartBonusesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.BonusWeightBonus> EndBonusWeightBonus(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // bonuses
    return new Offset<cfg.BonusWeightBonus>(o);
  }
};


}
