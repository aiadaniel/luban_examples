// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ConditionMaxLevel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static ConditionMaxLevel GetRootAsConditionMaxLevel(ByteBuffer _bb) { return GetRootAsConditionMaxLevel(_bb, new ConditionMaxLevel()); }
  public static ConditionMaxLevel GetRootAsConditionMaxLevel(ByteBuffer _bb, ConditionMaxLevel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConditionMaxLevel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<cfg.ConditionMaxLevel> CreateConditionMaxLevel(FlatBufferBuilder builder,
      int level = 0) {
    builder.StartTable(1);
    ConditionMaxLevel.AddLevel(builder, level);
    return ConditionMaxLevel.EndConditionMaxLevel(builder);
  }

  public static void StartConditionMaxLevel(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(0, level, 0); }
  public static Offset<cfg.ConditionMaxLevel> EndConditionMaxLevel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.ConditionMaxLevel>(o);
  }
};


}
