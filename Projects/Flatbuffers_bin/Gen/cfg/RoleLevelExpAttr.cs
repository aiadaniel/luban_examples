// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct RoleLevelExpAttr : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static RoleLevelExpAttr GetRootAsRoleLevelExpAttr(ByteBuffer _bb) { return GetRootAsRoleLevelExpAttr(_bb, new RoleLevelExpAttr()); }
  public static RoleLevelExpAttr GetRootAsRoleLevelExpAttr(ByteBuffer _bb, RoleLevelExpAttr obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RoleLevelExpAttr __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long NeedExp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ClothesAttrs(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ClothesAttrsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetClothesAttrsBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetClothesAttrsBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetClothesAttrsArray() { return __p.__vector_as_array<int>(8); }

  public static Offset<cfg.RoleLevelExpAttr> CreateRoleLevelExpAttr(FlatBufferBuilder builder,
      int level = 0,
      long need_exp = 0,
      VectorOffset clothes_attrsOffset = default(VectorOffset)) {
    builder.StartTable(3);
    RoleLevelExpAttr.AddNeedExp(builder, need_exp);
    RoleLevelExpAttr.AddClothesAttrs(builder, clothes_attrsOffset);
    RoleLevelExpAttr.AddLevel(builder, level);
    return RoleLevelExpAttr.EndRoleLevelExpAttr(builder);
  }

  public static void StartRoleLevelExpAttr(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(0, level, 0); }
  public static void AddNeedExp(FlatBufferBuilder builder, long needExp) { builder.AddLong(1, needExp, 0); }
  public static void AddClothesAttrs(FlatBufferBuilder builder, VectorOffset clothesAttrsOffset) { builder.AddOffset(2, clothesAttrsOffset.Value, 0); }
  public static VectorOffset CreateClothesAttrsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClothesAttrsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartClothesAttrsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.RoleLevelExpAttr> EndRoleLevelExpAttr(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 8);  // clothes_attrs
    return new Offset<cfg.RoleLevelExpAttr>(o);
  }
};


}
