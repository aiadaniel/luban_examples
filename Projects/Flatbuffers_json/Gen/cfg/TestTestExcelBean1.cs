// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TestTestExcelBean1 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static TestTestExcelBean1 GetRootAsTestTestExcelBean1(ByteBuffer _bb) { return GetRootAsTestTestExcelBean1(_bb, new TestTestExcelBean1()); }
  public static TestTestExcelBean1 GetRootAsTestTestExcelBean1(ByteBuffer _bb, TestTestExcelBean1 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestTestExcelBean1 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X1 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string X2 { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetX2Bytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetX2Bytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetX2Array() { return __p.__vector_as_array<byte>(6); }
  public int X3 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float X4 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<cfg.TestTestExcelBean1> CreateTestTestExcelBean1(FlatBufferBuilder builder,
      int x1 = 0,
      StringOffset x2Offset = default(StringOffset),
      int x3 = 0,
      float x4 = 0.0f) {
    builder.StartTable(4);
    TestTestExcelBean1.AddX4(builder, x4);
    TestTestExcelBean1.AddX3(builder, x3);
    TestTestExcelBean1.AddX2(builder, x2Offset);
    TestTestExcelBean1.AddX1(builder, x1);
    return TestTestExcelBean1.EndTestTestExcelBean1(builder);
  }

  public static void StartTestTestExcelBean1(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddX1(FlatBufferBuilder builder, int x1) { builder.AddInt(0, x1, 0); }
  public static void AddX2(FlatBufferBuilder builder, StringOffset x2Offset) { builder.AddOffset(1, x2Offset.Value, 0); }
  public static void AddX3(FlatBufferBuilder builder, int x3) { builder.AddInt(2, x3, 0); }
  public static void AddX4(FlatBufferBuilder builder, float x4) { builder.AddFloat(3, x4, 0.0f); }
  public static Offset<cfg.TestTestExcelBean1> EndTestTestExcelBean1(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestTestExcelBean1>(o);
  }
};


}
